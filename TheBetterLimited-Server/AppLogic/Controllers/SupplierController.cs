using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Entity;
using TheBetterLimited_Server.Data.Repositories;

namespace TheBetterLimited_Server.AppLogic.Controllers

{
    public class SupplierController
    {
        private readonly DataContext db;
        private Data.Repositories.Repository<Data.Entity.Supplier> supplierRepository;
        public SupplierController(DataContext dataContext)
        {
            db = dataContext;
            supplierRepository = new Data.Repositories.Repository<Data.Entity.Supplier>(dataContext);
        }

        public async Task<List<Supplier>> GetAllSupplier()
        {
            return await supplierRepository.GetAllAsync();
        }

        public async Task<Supplier?> GetSupplierById(string id)
        {
            return await supplierRepository.GetByIdAsync(id);
        }

        public async Task<List<Supplier>> GetSupplierByQueryString(string queryString)
        {
            return await supplierRepository.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier>(queryString)
            );
        }

        public async Task AddSupplier(Supplier supplier)
        {
            var newSupplier = await supplierRepository.AddAsync(supplier);
        }

        public async Task ModifySupplier(string id , List<Models.UpdateObjectModel> content)
        {
            var potentialSupplier = await supplierRepository.GetByIdAsync(id);
            if (potentialSupplier is null)
            {
                throw new BadArgException("The supplier not found.");
            }

            TheBetterLimited_Server.Helpers.Entity.EntityUpdater.Update<Supplier>(ref potentialSupplier , content);
            await supplierRepository.UpdateAsync(potentialSupplier);
            await db.SaveChangesAsync();
        }

        public async Task DeleteSupplier(string id)
        {
            var potentialSupplier = await supplierRepository.GetByIdAsync(id);
            await supplierRepository.DeleteAsync(potentialSupplier);
            await db.SaveChangesAsync();
        }

    }
}