using Microsoft.AspNetCore.Mvc;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.AppLogic.Exceptions;
using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Helpers;
using TheBetterLimited_Server.Helpers.Entity;

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

    public Task<Account?> GetUserByID(string id)
    {
        return _UserTable.GetByIdAsync(id);
    }

    public List<Account> GetAllUsers()
    {
        return _UserTable.Entities.ToList();
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

        foreach (var acc in AccountList)
        {
            res.Add(acc.CopyAs<AccountDto>());
        }
        return res;
    }


    public  bool CheckIsExist(string id)
    {
        return _UserTable.IsRecordExist(id);
    }
    
}