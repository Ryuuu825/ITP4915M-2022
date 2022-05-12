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

    public List<AccountDto> GetAllUsers()
    {
        var list = _UserTable.Entities.ToList();
        var res = new List<AccountDto>();
        foreach (var item in list)
        {
            res.Add(item.CopyAs<AccountDto>());
        }
        return res;
    }
    
    public List<Account> GetUsers(int limit)
    {
        try
        {
            return _UserTable.Entities.ToList().GetRange(0,limit);
        }catch (System.ArgumentException e)
        {
            throw new BadArgException("Limit is invalid.");
        }
    }

    public async Task<List<AccountDto>> GetUsersBySql(string sql)
    {
        var AccountList = await _UserTable.GetBySQLAsync(sql);
        if (AccountList.Count == 0)
        {
            throw new HasNoElementException("Not Found");
        }
        var res = new List<AccountDto>();


        foreach (var item in AccountList)
        {
            res.Add(item.CopyAs<AccountDto>());
        }
        

        return res;
    }

    public async Task<List<AccountDto>> GetUsersByConditionString(string condString)
    {
        string queryStr = Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(condString, "accounts");
    
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

    public async Task<AccountDto> UpdateUserAsync(string id , List<UpdateObjectModel> updateContent,  bool saveNow = true)
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
            return record.CopyAs<AccountDto>();
        else
            throw new OperationFailException("Update failed");
    }

    public async Task<List<AccountDto>> UpdateRangeUserAsync( string condString , List<UpdateObjectModel> updateContent, bool saveNow = true)
    {
        List<Account> records = await _UserTable.GetBySQLAsync(Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>(condString , "accounts"));
        foreach (var record in records)
        {
            await UpdateUserAsync(record.Id , updateContent, saveNow);
        }
        return records.CopyAs<List<AccountDto>>();
    }
    
    public async Task LockUserAsync(string id , int lockDay)
    {
        var acc = await _UserTable.GetByIdAsync(id);
        if (acc is null)
            throw new BadArgException("No such user");
        

        // add lock day on unlock date

        await UpdateUserAsync(id , new List<UpdateObjectModel>(1) { new UpdateObjectModel() { Attribute = "unlockDate" , Value = DateTime.Now.AddDays(lockDay) } }, true);
    }

     public async Task UnlockUserAsync(string id)
     {
         var acc = await _UserTable.GetByIdAsync(id);
        if (acc is null)
            throw new BadArgException("No such user");

        await UpdateUserAsync(id , new List<UpdateObjectModel>(1) { new UpdateObjectModel() { Attribute = "unlockDate" , Value = DateTime.Now } }, true);
     }


}