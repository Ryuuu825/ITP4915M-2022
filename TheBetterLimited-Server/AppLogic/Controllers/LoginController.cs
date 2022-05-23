using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Helpers.Secure;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.AppLogic.Models;
using TheBetterLimited_Server.Helpers.LogHelper;
using TheBetterLimited_Server.Data.Dto;
namespace TheBetterLimited_Server.AppLogic.Controllers;

public class LoginController
{
    private readonly Data.Repositories.AccountRepository _UserTable;
    private static string _resetPwdToken;


    public LoginController(DataContext dataContext)
    {
        _UserTable = new Data.Repositories.AccountRepository(dataContext);

    }

    public bool Login(string name, string password, out LoginOkModel res , in HttpRequest request)
    {
        res = new LoginOkModel();
        
        // get the user from the database
        var potentialUser = _UserTable.GetBySQL(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{name}")).FirstOrDefault();
        if (potentialUser is null)
        {
            throw new HasNoElementException($"UserName: {name} not found" , HttpStatusCode.BadRequest);
        }

        // the user is found and is currently locked.
        if (potentialUser.unlockDate >= DateTime.Now)
        {
            throw new LoginFailException($"The account is locked until {potentialUser.unlockDate}");
        }
        // the user is found and the password is incorrect
        else if (! password.Verify(potentialUser.Password))
        {
            potentialUser.LoginFailedCount++;
            potentialUser.LoginFailedAt = DateTime.Now;
            _UserTable.Update( in potentialUser);

            if (potentialUser.LoginFailedCount >= 10)
            {
                ConsoleLogger.Debug($"The account {potentialUser.UserName} is locked");
                potentialUser.Status = "L";
                potentialUser.unlockDate = DateTime.Now.AddYears(1);
                _UserTable.Update( in potentialUser);
                throw new LoginFailException($"The password is incorrect. The account is lock until {potentialUser.unlockDate}");
            }
            else if (potentialUser.LoginFailedCount >= 5)
            {
                potentialUser.Status = "L";
                potentialUser.unlockDate = DateTime.Now.AddMinutes(5);
                _UserTable.Update( in potentialUser);
                throw new LoginFailException($"The password is incorrect. The account is lock until {potentialUser.unlockDate}");
            }

            throw new LoginFailException($"The password is incorrect. You have {5 - potentialUser.LoginFailedCount} attempts left");
        }
        //  if password is correct and user not locked
        else 
        {
            potentialUser.LastLogin = DateTime.Now;
            potentialUser.LoginFailedCount = 0;
            potentialUser.Status = "N";

            res.Token = JwtToken.Issue(potentialUser);
            res.Status = "Authenticated";
            res.ExpireAt = DateTime.Now.AddHours(10);



            List<AppLogic.Models.Permission> permissions = new List<AppLogic.Models.Permission>();
            // foreach (var permission in potentialUser.Staff.position.permissions)
            // {
            //     permissions.Add(
            //         new AppLogic.Models.Permission
            //         {
            //             menu_name = permission.menu.Name,
            //             read = permission.read,
            //             write = permission.write,
            //             delete = permission.delete
            //         }
            //     );
            // }
        
            res.permissions = permissions;

            _UserTable.Update(in potentialUser);

            Helpers.LogHelper.FileLogger.AcceccLog( in potentialUser);

            return true;
        }

    }

    public void RequestForgetPW(ForgetPwModel model, string lang)
    {
        // get the user from the database
        Account potentialUser = _UserTable.GetBySQL(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{model.UserName};EmailAddress:{model.EmailAddress}" )).FirstOrDefault();

        if (potentialUser is null)
            throw new HasNoElementException("UserName or EmailAddress not found", HttpStatusCode.BadRequest);
        
        // create a tmp token and store as a filename
        var token = Helpers.File.TempFileManager.Create();
        // store the bearer token in the file
        token.WriteAllText( Helpers.Secure.JwtToken.IssueResetPasswordToken(model.UserName , model.EmailAddress, lang));

        // prepare email content
        List<UpdateObjectModel> content = new List<UpdateObjectModel>(5);
        content.Add(new UpdateObjectModel() { Attribute = "redirect_url", Value = "http://localhost:5233/api/login/resetpwd/page" });
        content.Add(new UpdateObjectModel() { Attribute = "expire_time", Value = Int32.Parse(_Secret["reset_password_expire_time"]) });
        content.Add(new UpdateObjectModel() { Attribute = "lang", Value = lang });
        content.Add(new UpdateObjectModel() { Attribute = "name", Value = potentialUser.UserName });
        content.Add(new UpdateObjectModel() { Attribute = "token", Value = token.GetFileName() });
        
        try
        {
            // use the email template and the update obj content to generate the email content
            string email = Helpers.File.DynamicFile.UpdatePlaceHolder(
                $"email/reset_password.{lang}.html",
                content
            );

            // send email to user with link to reset password
            Helpers.EmailSender.SendEmail(
                    potentialUser.UserName,
                    potentialUser.EmailAddress,
                    "Reset Password",
                    email
            );

          

        }catch(FileNotFoundException e)
        {
            throw new FileNotExistException($"Language not supprt: {lang}", HttpStatusCode.BadRequest);
        
        }catch(Exception e) 
        {
            ConsoleLogger.Debug(e.Message);
            // the email account maybe not verified, therefore there are a limited number of email can be sent within one day.
            // also the email sender class did not use oauth2 before sending the email, therefore the email maybe can not sent.
            throw new OperationFailException("Failed to send email");
        }
       
    }

    public void ResetPW( HttpRequest req , string password)
    {
        // get the bearer token from the request
        var bearerToken = req.Headers["Authorization"].ToString().Split(' ')[1];

        // get the token from compare the content of the file with the bearer token
        var accessToken = Helpers.File.TempFileManager.GetFilePath(bearerToken);

        // The token is not found
        if (accessToken.Equals(""))
            throw new System.UnauthorizedAccessException("Invalid token");
        

        // get list of claims from the bearer token
        var claims = Helpers.HttpReader.GetClaims(req); 
        var userName = claims["name"];
        var emailAddress = claims["emailaddress"];
        
        var potentialUser = _UserTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(
                $"UserName:{userName};EmailAddress:{emailAddress}"
            )
        ).FirstOrDefault();

        potentialUser.Password = Helpers.Secure.Hasher.Hash(password);

        Helpers.File.TempFileManager.CloseTempFile(accessToken);
        _UserTable.Update( in potentialUser);
 
    }

    

    public void GetResetPwPage(string accessToken , string lang, ref string html)
    {

        var bearerToken = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + $"/var/tmp/{accessToken}");
        html = Helpers.File.DynamicFile.UpdatePlaceHolder
        (
            $"pages/reset_password.{lang}.html",
            new List<UpdateObjectModel>
            {
                new UpdateObjectModel { Attribute = "url", Value = "http://localhost:5233/api/login/resetpwd" },
                new UpdateObjectModel { Attribute = "token", Value = bearerToken },
                new UpdateObjectModel { Attribute = "lan", Value = lang }
            }
        );
    }


    public void ChangePW(string username , string newPassword )
    {
        var potentialUser = _UserTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(
                $"UserName:{username}" 
            )
        ).FirstOrDefault();

        potentialUser.Password = Helpers.Secure.Hasher.Hash(newPassword);

        _UserTable.Update( in potentialUser);
    }
}