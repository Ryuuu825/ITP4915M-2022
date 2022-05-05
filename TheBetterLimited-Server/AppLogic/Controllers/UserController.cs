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
    private readonly Data.Repositories.Repository<Data.Entity.Account> _UserTable;

    public UserController(DataContext dataContext)
    {
        _UserTable = new Data.Repositories.Repository<Data.Entity.Account>(dataContext, dataContext.accounts);
    }

    public void CreateUser(Data.Entity.Account acc, bool saveNow = true)
    {
        _UserTable.Add(acc ,saveNow);
    }

    public Account GetUserByID(string id)
    {
        return _UserTable.GetById(id);
    }

    public List<Account> GetAllUsers()
    {
        return _UserTable.Entities.ToList();
    }
    
    public List<Account> GetUsers(int limit)
    {
        return _UserTable.Entities.ToList().GetRange(0,limit);
    }

    public Account GetUserBySql(string sql)
    {
        try
        {
            return _UserTable.GetBySQL(sql);
        }
        catch (Exception e)
        {
            throw new HasNoElementException();
        }
        
    }
}