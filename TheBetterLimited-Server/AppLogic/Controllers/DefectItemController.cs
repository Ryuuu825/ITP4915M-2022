using TheBetterLimited_Server.Helpers.Extension;
namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class DefectItemController 
    {
        protected readonly Data.DataContext db;
        private Data.Repositories.Repository<Data.Entity.DefectItemRecord> repository;
        private Data.Repositories.Repository<Data.Entity.Customer> _CustomerTable;
        private Data.Repositories.UserInfoRepository userInfo;
        public DefectItemController(Data.DataContext db) 
        {
            this.db = db;
            repository = new Data.Repositories.Repository<Data.Entity.DefectItemRecord>(db);
            _CustomerTable = new Data.Repositories.Repository<Data.Entity.Customer>(db);
            userInfo = new Data.Repositories.UserInfoRepository(db);
        }

        public void AddRefectItemRecord(string user , Data.Dto.DefectItemDto record)
        {
            try 
            {
                string CollectAddress = String.Empty;
                string CustomerId = null;
                if (record.Customer is null)
                {
                    CollectAddress = userInfo.GetStaffFromUserName(user).store.Location.Loc;
                }
                else
                {
                    CollectAddress = record.Customer.Address;
                    Data.Entity.Customer cust = new Data.Entity.Customer
                                                {
                                                    ID = Helpers.Sql.PrimaryKeyGenerator.Get<Data.Entity.Customer>(db),
                                                    Name = record.Customer.Name,
                                                    Phone = record.Customer.Phone,
                                                    Address = record.Customer.Address
                                                };
                    _CustomerTable.Add(cust);
                    CustomerId = cust.ID;
                }
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
                        Remark = record.Remark,
                        HandleStatus = record.HandleStatus,
                        _customerId = CustomerId,
                        CollectAddress = CollectAddress
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
                throw new BadArgException("The entry already exists.");
            }
        }


        public List<Hashtable> GetAll(string username , string lang)
        {
            List<Hashtable> res = new List<Hashtable>();
            List<Data.Entity.DefectItemRecord> records = repository.GetAll();

            foreach (var record in records)
            {
                Data.Entity.Goods goods = record.SupplierGoodsStock.Supplier_Goods.Goods;
                var localizeGoods = Helpers.Localizer.TryLocalize<Data.Entity.Goods>(lang , goods);

                res.Add(
                    new Data.Dto.DefectItemOutDto
                    {
                        Id = record.ID.ToString(),
                        _creatorId = record._creatorId,
                        _operatorId = record._operatorId,
                        _supplierGoodsStockId = record._supplierGoodsStockId,
                        _salesOrderId = record._salesOrderId,
                        Status = record.Status.ToString(),
                        GoodsName = localizeGoods.Name,
                        CollectAddress = record.CollectAddress,
                        SupplierAddress = record.SupplierGoodsStock.Supplier_Goods.Supplier.Address,
                        CreateAt = record.createdAt,
                        OperatedAt = record.updatedAt
                    }.MapToDto()
                );
            }

            return res;
        }

        
    }
}