namespace TheBetterLimited_Server.Data.Repositories;

   

public interface IRepository<TEntity>
{
    abstract Task<TEntity?> GetByIdAsync(params object[] ids);
    abstract Task<TEntity?> GetBySQLAsync(string sql);
    abstract Task<bool> AddAsync(TEntity entity, bool saveNow = true);
    abstract Task<bool> UpdateAsync(TEntity entity, bool saveNow = true);
    abstract Task<bool> DeleteAsync(TEntity entity, bool saveNow = true);
    
    abstract TEntity GetById(params object[] ids);
    abstract TEntity GetBySQL(string sql);

    abstract bool Add(TEntity entity, bool saveNow = true);
    abstract bool Update(TEntity entity, bool saveNow = true);
    abstract bool Delete(TEntity entity, bool saveNow = true);

    abstract void Dispose();
}