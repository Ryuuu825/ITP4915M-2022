namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class DefectItemController 
    {
        protected readonly Data.DataContext db;
        private Data.Repositories.Repository<Data.Entity.DefectItemRecord> repository;
        private Data.Repositories.UserInfoRepository userInfo;
        public DefectItemController(Data.DataContext db) 
        {
            this.db = db;
            repository = new Data.Repositories.Repository<Data.Entity.DefectItemRecord>(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
        }

        public void AddRefectItemRecord(string user , Data.Dto.DefectItemDto record)
        {
            try 
            {
                repository.Add(
                    new Data.Entity.DefectItemRecord
                    {
                        ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.DefectItemRecord>(db),
                        _supplierGoodsStockId = record._supplierGoodsStockId,
                        _salesOrderId = record._salesOrderId,
                        _creatorId = userInfo.GetStaffFromUserName(user).Id,
                        _operatorId = userInfo.GetStaffFromUserName(user).Id,
                        Status = Data.Entity.DefectItemRecordStatus.Pending,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now,
                        Remark = record.Remark
                    }
                );
            }
            catch(MySqlConnector.MySqlException e)
            {
                throw new Exceptions.BadForeignKeyException("The foreign key is not valid.");
            }
            catch(Microsoft.EntityFrameworkCore.DbUpdateException e)
            {
                throw new Exceptions.BadForeignKeyException("The foreign key is not valid.");
            }catch(Exception e)
            {
                throw new BadArgException(e.Message);
            }
        }

        
    }
}