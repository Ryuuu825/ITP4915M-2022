using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Helpers.LogHelper;

using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers.Entity;
using Newtonsoft.Json.Linq;
using TheBetterLimited_Server.AppLogic.Models;
namespace TheBetterLimited_Server.AppLogic.Controllers;

public class UserController
{
    private readonly Data.Repositories.AccountRepository _UserTable;

    public UserController(DataContext dataContext)
    {
        _UserTable = new Data.Repositories.AccountRepository(dataContext);
    }

    public async Task CreateUser(AccountDto acc, bool saveNow = true)
    {
        var newObj = acc.CopyAs<Account>();
        newObj.Password = Helpers.Secure.Hasher.Hash(newObj.Password);
        newObj.unlockDate = DateTime.Now;
        newObj.unlockDate = DateTime.Now;
        newObj.LoginFailedCount = 0;

        _UserTable.CreateUser(ref newObj);
    }

    public async Task<Account?> GetUserByIDAsync(string id)
    {
        var acc = await _UserTable.GetByIdAsync(id);
        if (acc is null)
            throw new HasNoElementException($"Account with id {id} is not exist");
        return acc;
    }

    public List<AccountOutDto> GetAllUsers()
    {
        var list = _UserTable.Entities.ToList();
        List<AccountOutDto> res = AccountToDto(in list);
        return res;
    }
    
    public List<AccountOutDto> GetUsers(int limit)
    {
        try
        {
            var list =  _UserTable.Entities.ToList().GetRange(0,limit);
            List<AccountOutDto> res = AccountToDto(in list);
            return res;
        }catch (System.ArgumentException e)
        {
            throw new BadArgException("Limit is invalid.");
        }
    }

    public List<AccountOutDto> AccountToDto(in List<Account> list)
    {
        List<AccountOutDto> res = new List<AccountOutDto>();
        foreach(var entry in list)
        {
            var o = entry.CopyAs<AccountOutDto>();
            o.StaffName = entry.Staff.FirstName + " " + entry.Staff.LastName;
            res.Add(o);
        }
        return res;
    }

    public async Task<List<AccountOutDto>> GetUsersBySql(string sql)
    {
        var AccountList = await _UserTable.GetBySQLAsync(sql);
        if (AccountList.Count == 0)
        {
            throw new HasNoElementException("Not Found");
        }
        return AccountToDto(in AccountList);
    }

    public async Task<List<AccountOutDto>> GetUsersByConditionString(string condString)
    {
        string queryStr = Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(condString);
    
        return await GetUsersBySql(queryStr);
    }

    public  bool CheckIsExist(string id)
    {
        return _UserTable.IsRecordExist(id);
    }

    public async Task DeleteUserAsync(string id)
    {
        var acc = await _UserTable.GetByIdAsync(id);
        if (acc is null )
            throw new BadArgException("No such user");
        await _UserTable.DeleteAsync( acc );
    }

    public async Task<AccountOutDto> UpdateUserAsync(string id , List<UpdateObjectModel> updateContent,  bool saveNow = true)
    {
        Account record = await GetUserByIDAsync(id);
        if (record is null)
            throw new BadArgException("No such user");
        
        Helpers.Entity.EntityUpdater.Update( ref record , updateContent);
    
        string res;
        if (! Helpers.Entity.EntityValidator.Validate<Account>(record , out res))
        {
            ConsoleLogger.Debug("UpdateUserAsync : Validation failed");
            throw new BadArgException("Invalid value: "+ res);
        }


        if(await _UserTable.UpdateAsync(record , saveNow))
            return record.CopyAs<AccountOutDto>();
        else
            throw new OperationFailException("Update failed");
    }

    public async Task<List<AccountOutDto>> UpdateRangeUserAsync( string condString , List<UpdateObjectModel> updateContent, bool saveNow = true)
    {
        List<Account> records = await _UserTable.GetBySQLAsync(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(condString ));
        foreach (var record in records)
        {
            await UpdateUserAsync(record.Id , updateContent, saveNow);
        }
        return records.CopyAs<List<AccountOutDto>>();
    }
    
    public async Task LockUserAsync(string id , int lockDay)
    {
        var acc = await _UserTable.GetByIdAsync(id);
        if (acc is null)
            throw new BadArgException("No such user");
        

        // add lock day on unlock date

        await UpdateUserAsync(id , 
        new List<UpdateObjectModel>(2) { 
            new UpdateObjectModel() { 
                Attribute = "unlockDate" , 
                Value = DateTime.Now.AddDays(lockDay) 
            },
            new UpdateObjectModel() {
                Attribute = "Status" ,
                Value = 'L'
            }
        }, 
        true);
    }

     public async Task UnlockUserAsync(string id)
     {
         var acc = await _UserTable.GetByIdAsync(id);
        if (acc is null)
            throw new BadArgException("No such user");

        await UpdateUserAsync(id , new List<UpdateObjectModel>(2) { 
            new UpdateObjectModel() { Attribute = "unlockDate" , Value = DateTime.Now },
            new UpdateObjectModel() {Attribute = "Status" , Value = "N"} 
        }, true);
     }

     public Tuple<byte[], string> GetUserIcon(string username )
     {
         Account? acc = _UserTable.GetBySQL(
                $"SELECT * FROM Account WHERE username = '{username}'"
         ).FirstOrDefault();

         if (acc is null)
             throw new BadArgException("No such user");
         

        if (acc.Icon is null)
        {
            return new Tuple<byte[], string>(System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "resources/usericons/default.png"), "png");
        }
        else
        {
            return new Tuple<byte[], string>(acc.Icon, "png");
        }
     }

     public async Task UpdateUserIcon(string username , string base64Image)
     {
         Account? acc = (await _UserTable.GetBySQLAsync(
                $"SELECT * FROM Account WHERE username = '{username}'"
         )).FirstOrDefault();

        if (acc is null)
            throw new BadArgException("No such user");

        acc.Icon = Convert.FromBase64String(base64Image);
        await _UserTable.UpdateAsync(acc , true);
     }


}