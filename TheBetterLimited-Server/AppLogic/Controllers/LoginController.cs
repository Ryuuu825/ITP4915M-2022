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

#if DEBUG
    public async Task UpdateUserPasswordAsHashedPassword(string userName)
    {
        Account potentialUser = (await _UserTable.GetBySQLAsync(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{userName}" , "accounts"))).Single();
        List<UpdateObjectModel> content = new List<UpdateObjectModel>();
        content.Add(new UpdateObjectModel() { Attribute = "Password", Value = Helpers.Secure.Hasher.Hash(potentialUser.Password) });
        Helpers.Entity.EntityUpdater.Update(ref potentialUser, content);
        ConsoleLogger.Debug(potentialUser.Debug());
        await _UserTable.UpdateAsync(potentialUser);
    }

#endif
    public bool Login(string name, string password, out LoginOkModel res)
    {
        res = new LoginOkModel();
        
        var potentialUser = _UserTable.GetBySQL(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{name}" , "accounts")).FirstOrDefault();
        if (potentialUser is null)
        {
            throw new HasNoElementException($"UserName: {name} not found" , HttpStatusCode.BadRequest);
        }

        if (potentialUser.unlockDate >= DateTime.Now)
        {
            potentialUser.Status = "L";
            potentialUser.LoginFailedCount++;
            potentialUser.LoginFailedAt = DateTime.Now;
            _UserTable.Update(potentialUser);
            throw new LoginFailException($"The account is locked until {potentialUser.unlockDate}");
        }
        else if (! password.Verify(potentialUser.Password))
        {
            potentialUser.LoginFailedCount++;
            potentialUser.LoginFailedAt = DateTime.Now;
            _UserTable.Update(potentialUser);

            if (potentialUser.LoginFailedCount >= 3)
            {
                potentialUser.unlockDate = DateTime.Now.AddHours(1);
                _UserTable.Update(potentialUser);
                throw new LoginFailException($"The password is incorrect. The account is lock until {potentialUser.unlockDate}");
            }
        }
        else //  if password is correct and user not locked
        {
            potentialUser.LastLogin = DateTime.Now;
            potentialUser.LoginFailedCount = 0;
            potentialUser.Status = "N";

            res.Token = JwtToken.Issue(potentialUser);
            res.Account = potentialUser.CopyAs<AccountDto>();
            res.Status = "Authenticated";
            res.ExpireAt = DateTime.Now.AddHours(10);

            _UserTable.Update(potentialUser);

            return true;
        }

        return false;
    }

    public void RequestForgetPW(ForgetPwModel model, string lang)
    {
        var potentialUser = _UserTable.GetBySQL(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{model.UserName};EmailAddress:{model.EmailAddress}" , "accounts")).FirstOrDefault();

        if (potentialUser is null)
            throw new HasNoElementException("UserName or EmailAddress not found", HttpStatusCode.BadRequest);
        
        var token = Helpers.File.TempFileManager.Create();
        token.WriteAllText(Helpers.Secure.JwtToken.IssueResetPasswordToken(model.UserName , model.EmailAddress, lang));

        // prepare email content
        List<UpdateObjectModel> content = new List<UpdateObjectModel>(5);
        content.Add(new UpdateObjectModel() { Attribute = "redirect_url", Value = "http://localhost:5233/api/login/resetpwd/page" });
        content.Add(new UpdateObjectModel() { Attribute = "expire_time", Value = Int32.Parse(_Secret["reset_password_expire_time"]) });
        content.Add(new UpdateObjectModel() { Attribute = "lang", Value = lang });
        content.Add(new UpdateObjectModel() { Attribute = "name", Value = potentialUser.UserName });
        content.Add(new UpdateObjectModel() { Attribute = "token", Value = token.GetFileName() });
        
        string email = Helpers.File.DynamicFile.UpdatePlaceHolder(
                $"email/reset_password.{lang}.html",
                content
            );

        ConsoleLogger.Debug(email);

        // send email to user with link to reset password
        // Helpers.EmailSender.SendEmail(
        //     potentialUser.UserName,
        //     potentialUser.EmailAddress,
        //     "Reset Password",
        //     in email
        // );


    }

    public void ResetPW( HttpRequest req , string password)
    {
        var bearerToken = req.Headers["Authorization"].ToString().Split(' ')[1];
        var accessToken = Helpers.File.TempFileManager.GetFilePath(bearerToken);
        ConsoleLogger.Debug("Access token : " + accessToken);

        if (accessToken.Equals(""))
            throw new System.UnauthorizedAccessException("Invalid token");
        

        var claims = Helpers.HttpReader.GetClaims(req); 
        var userName = claims["name"];
        var emailAddress = claims["emailaddress"];
        
        var potentialUser = _UserTable.GetBySQL(
            Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(
                $"UserName:{userName};EmailAddress:{emailAddress}" , "accounts"
            )
        ).FirstOrDefault();

        potentialUser.Password = Helpers.Secure.Hasher.Hash(password);

        Helpers.File.TempFileManager.CloseTempFile(accessToken);
        _UserTable.Update(potentialUser);
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
    public void ChangePW(string usernmae, string oldPW, string newPW)
    {
    }
    
}