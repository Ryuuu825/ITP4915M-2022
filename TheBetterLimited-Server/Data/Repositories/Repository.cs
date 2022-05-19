using MySqlConnector;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class
{
    protected readonly DataContext DbContext;
    public DbSet<TEntity> Entities { get; set; }
    
    protected Repository(){}
    public Repository(DataContext dbContext)
    {
        DbContext = dbContext;
        Entities = dbContext.Set<TEntity>();
    }
    

    public async Task<TEntity?> GetByIdAsync(params object[] ids)
    {
        return await Entities
                    .FindAsync(ids);
    }

    public async Task<List<TEntity>> GetBySQLAsync(string sql)
    {
        return await Entities.FromSqlRaw(sql).ToListAsync();
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
            throw new OperationFailException("Primary key duplicated!"); 
        }

    }
    

    public async Task<bool> UpdateAsync(TEntity entity, bool saveNow = true)
    {
        try
        {
            Entities.Update(entity);
            if (saveNow)
                await DbContext.SaveChangesAsync();

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new OperationFailException("Error");
        }
    }

    public async Task DeleteAsync(TEntity entity, bool saveNow = true)
    {
        try
        {
            Entities.Remove(entity);
            if (saveNow)
                await DbContext.SaveChangesAsync();
        }catch(Exception e)
        {
            throw new OperationFailException($"Delete {entity} failed!");
        }
    }

    public async Task<bool> IsRecordExistAsync(string id)
    {
        return (await Entities.FindAsync(id)) is null;
    }

    public TEntity GetById(params object[] ids)
    {
        return Entities.Find(ids);
    }

    public List<TEntity> GetBySQL(string sql)
    {
        return Entities.FromSqlRaw(sql).ToList();
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

    public bool Update(in TEntity entity, bool saveNow = true)
    {
        try
        {
            Entities.Update(entity);
            if (saveNow)
                DbContext.SaveChanges();

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new OperationFailException("Error");
        }
    }

    public void Delete(TEntity entity, bool saveNow = true)
    {
        try
        {
            Entities.Remove(entity);
            if (saveNow)
                DbContext.SaveChanges();
        }catch(Exception e)
        {
            throw new OperationFailException($"Delete {entity} failed!");
        }
    }

    public bool IsRecordExist(string id)
    {
        return ! (Entities.Find(id) is null);
    }

    public List<TEntity> GetAll()
    {
        return Entities.ToList();
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
        return await Entities.ToListAsync();
    }

    public void Dispose()
    {
        
    }
}