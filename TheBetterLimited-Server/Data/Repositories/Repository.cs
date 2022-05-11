using MySqlConnector;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class
{
    protected readonly DataContext DbContext;
    private DbSet<TEntity> Entities { get; }
    
    public Repository(DataContext dbContext , DbSet<TEntity> entities)
    {
        DbContext = dbContext;
        Entities = entities; 
    }
    

    public async Task<TEntity?> GetByIdAsync(params object[] ids)
    {
        return await Entities.FindAsync(ids);
    }

    public async Task<TEntity?> GetBySQLAsync(string sql)
    {
        return await Entities.FromSqlRaw(sql).FirstOrDefaultAsync<TEntity>();
    }

    public async Task<bool> AddAsync(TEntity entity, bool saveNow = true)
    {
        if (!Helpers.Entity.EntityValidator.Validate<TEntity>(entity))
            return false;
        
        try
        {
            Entities.Add(entity);
            if (saveNow)
                await DbContext.SaveChangesAsync();
            return true;
        }
        catch (Exception e)
        {
            throw new DuplicateEntryException("Primary key duplicated!"); 
        }

    }
    

    public Task<bool> UpdateAsync(TEntity entity, bool saveNow = true)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(TEntity entity, bool saveNow = true)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> IsRecordExistAsync(string id)
    {
        return (await Entities.FindAsync(id)) is null;
    }

    public TEntity GetById(params object[] ids)
    {
        return Entities.Find(ids);
    }

    public TEntity GetBySQL(string sql)
    {
        return Entities.FromSqlRaw(sql).First();
    }

    public bool Add(TEntity entity, bool saveNow = true)
    {
        if (Helpers.Entity.EntityValidator.Validate<TEntity>(entity))
        {
            Entities.Add(entity);
            if (saveNow)
                DbContext.SaveChanges();
            return true;
        }
        return false;
    }

    public bool Update(TEntity entity, bool saveNow = true)
    {
        throw new NotImplementedException();
    }

    public bool Delete(TEntity entity, bool saveNow = true)
    {
        throw new NotImplementedException();
    }

    public bool IsRecordExist(string id)
    {
        return ! (Entities.Find(id) is null);
    }

    public void Dispose()
    {
        
    }
}