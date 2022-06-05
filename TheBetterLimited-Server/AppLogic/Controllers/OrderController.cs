using TheBetterLimited_Server.Data.Dto;
using TheBetterLimited_Server.Data.Entity;

namespace TheBetterLimited_Server.AppLogic.Controllers
{
    public class OrderController : AppControllerBase<Data.Entity.SalesOrder>
    {
        private readonly Data.Repositories.Repository<SalesOrderItem> _SalesOrderItemTable;

        private readonly Data.Repositories.Repository<Appointment> _AppointmentTable; 
        private readonly Data.Repositories.Repository<BookingOrder> _BookingOrderTable;
        private readonly Data.Repositories.Repository<Supplier_Goods_Stock> _Supplier_Goods_StockTable;
        private readonly Data.Repositories.Repository<Staff> _StaffTable;
        private readonly Data.Repositories.Repository<Transaction> _TransactionTable;
        private readonly Data.Repositories.Repository<Store> _StoreTable;
        private readonly Data.Repositories.Repository<Account> _AccountTable;
        private readonly AppLogic.Controllers.MessageController _MessageController;

        public OrderController(Data.DataContext db) : base(db)
        {
            _SalesOrderItemTable = new Data.Repositories.Repository<SalesOrderItem>(db);
            _AppointmentTable = new Data.Repositories.Repository<Appointment>(db);
            _BookingOrderTable = new Data.Repositories.Repository<BookingOrder>(db);
            _Supplier_Goods_StockTable = new Data.Repositories.Repository<Supplier_Goods_Stock>(db);
            _MessageController = new AppLogic.Controllers.MessageController(db);
            _StaffTable = new Data.Repositories.Repository<Staff>(db);
            _TransactionTable = new Data.Repositories.Repository<Transaction>(db);
            _StoreTable = new Data.Repositories.Repository<Store>(db);
            _AccountTable = new Data.Repositories.Repository<Account>(db);
        }

        private async Task<List<Hashtable>> ToDto(List<SalesOrder> salesOrders ,  string lang = "en")
        {
            List<Hashtable> res = new List<Hashtable>();

            // all the sales record in the system
            for (var i = 0; i < salesOrders.Count; i++)
            {
                // localize the sales record
                salesOrders[i] = Helpers.Localizer.TryLocalize<SalesOrder>(lang, salesOrders[i]);
               
                // get the sales record items
                var salesOrderItemList = await _SalesOrderItemTable.GetBySQLAsync(
                    "SELECT * FROM SalesOrderItem WHERE _salesOrderId = " + salesOrders[i].ID
                );

                // tmp list to convert the sales order item to dto
                List<SalesOrderItemOutDto> tmp = new List<SalesOrderItemOutDto>();

                // convert the sales order item to dto
                foreach(var salesOrderItem in salesOrderItemList)
                {
                    var salesOrderItemDto = salesOrderItem.CopyAs<SalesOrderItemOutDto>();
                    salesOrderItemDto.SupplierGoodsStockId = salesOrderItem._supplierGoodsStockId;

                    Goods goods = Helpers.Localizer.TryLocalize<Goods>(lang, salesOrderItem.SupplierGoodsStock.Supplier_Goods.Goods);
                    salesOrderItemDto.Name = goods.Name;
                    tmp.Add(salesOrderItemDto);
                }

                // get the store name
                Store store = (await _StaffTable.GetByIdAsync(salesOrders[i]._creatorId)).store;

                // get the amount paid
                decimal paid = 0;
                var transactionRecords = await _TransactionTable.GetBySQLAsync(
                    "SELECT * FROM Transaction WHERE _salesOrderId = " + salesOrders[i].ID
                );
                foreach(var record in transactionRecords)
                {
                    paid += record.Amount;
                }

                decimal total = 0;
                // get the price from the supplier goods stock record
                // get the qty from the sales order item record
                foreach(var salesOrderItem in salesOrderItemList)
                {
                    total += salesOrderItem.Price * salesOrderItem.Quantity;
                }
                

                res.Add(
                    new OrderOutDto
                    {
                        orderItems = tmp,
                        _creatorId = salesOrders[i]._creatorId,
                        _operatorId = salesOrders[i]._operatorId,
                        store = store,
                        createAt = salesOrders[i].createdAt,
                        updateAt = salesOrders[i].updatedAt,
                        status = salesOrders[i].Status.ToString(),
                        total = total,
                        paid = paid,
                        Id = salesOrders[i].ID
                    }.MapToDto()
                );
            }

            return res;
        }

        public override async Task<List<Hashtable>> GetAll(string lang = "en")
        {
            var salesOrders = (await repository.GetAllAsync());
            return await ToDto(salesOrders, lang);
        }

        public override async Task<List<Hashtable>> GetByQueryString(string sql, string lang = "en")
        {
            var salesOrders = (await repository.GetBySQLAsync(sql));
            return await ToDto(salesOrders, lang);
        }

        public override async Task<Hashtable> GetById(string id, string lang = "en")
        {
            var salesOrder = (await repository.GetByIdAsync(id));
            return (await ToDto(new List<SalesOrder> { salesOrder }, lang))[0];
        }

        public virtual async Task<List<Hashtable>> GetWithLimit(int limit, uint offset = 0 ,string lang = "en")
        {
            var list = (await repository.GetAllAsync()).AsReadOnly().ToList();
            limit = limit > list.Count ? list.Count : limit;
            offset = offset > list.Count ? (uint) list.Count : offset;
            list = list.GetRange((int)offset, limit);
            return await ToDto(list, lang);
        }




        
        public async Task<string> CreateSalesOrder(string Username , OrderInDto order)
        {
            // first create the sales order
            // and create sales order items
            // and create appointments
            // and last add appointment to the sales order item.

            var account = (await _AccountTable.GetBySQLAsync(
                Helpers.Sql.QueryStringBuilder.GetSqlStatement<Account>($"UserName:{Username}")
            )).FirstOrDefault();

            if(account == null)
            {
                throw new Exception("Account not found");
            }

            string StaffId = account._StaffId;
            var staff = (await _StaffTable.GetByIdAsync(StaffId));
            string storeId = staff.store.ID;

            var newOrder = new SalesOrder()
            {
                ID = Helpers.Sql.PrimaryKeyGenerator.Get<SalesOrder>(db),
                _creatorId = StaffId,
                _operatorId = StaffId,
                _storeId = storeId,
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                Status =  SalesOrderStatus.Placed
            };

            try 
            {
                repository.Add(newOrder);

            }catch(Exception e)
            {
                // sales order should be created successfully first.
                throw new BadArgException("Invalid CreatorId or StoreId");
            }

            List<SalesOrderItem> salesOrderItems = new List<SalesOrderItem>();
            foreach (var item in order.SalesOrderItems)
            {
                salesOrderItems.Add(
                    new SalesOrderItem()
                    {
                        _salesOrderId = newOrder.ID,
                        _supplierGoodsStockId = item.SupplierGoodsStockId,
                        Quantity = item.Quantity,
                        Price = item.Price
                    }
                );

                Supplier_Goods_Stock sgs = (await _Supplier_Goods_StockTable.GetBySQLAsync(
                    Helpers.Sql.QueryStringBuilder.GetSqlStatement<Supplier_Goods_Stock>("Id:" + item.SupplierGoodsStockId)
                )).FirstOrDefault();
                if (sgs is null)
                {
                    CleanOrder(newOrder.ID);
                    throw new BadArgException("Invalid goods stock id : " + item.SupplierGoodsStockId);
                }

                if (sgs.Quantity - item.Quantity < 0)
                {
                    throw new NotEnoughStockException();
                }

                sgs.Quantity = sgs.Quantity - item.Quantity;

                if (sgs.Quantity < sgs.MinLimit)
                {
                    List<string> receivers = new List<string>();
                    var StoreManager = (await _StaffTable.GetBySQLAsync(
                        Helpers.Sql.QueryStringBuilder.GetSqlStatement<Staff>($"_storeId:{newOrder._storeId};_positionId:202")
                    ));

                    foreach (var s in StoreManager)
                    {
                        receivers.Add(s.acc.UserName);
                    }

                    _MessageController.SendMessage("system" ,
                        new SendMessageDto
                        {
                            receiver = receivers,
                            content = $"The quantity of {sgs._supplierGoodsId} is less than the minimum limit. Please check the stock."
                        }
                    );
                    
                }

                _Supplier_Goods_StockTable.Update(sgs);
            }

            try
            {
                // await _SalesOrderItemTable.AddRangeAsync(salesOrderItems);
                foreach(var item in salesOrderItems)
                {
                    _SalesOrderItemTable.Add(item);
                }
                await db.SaveChangesAsync();
            }catch(Exception e)
            {
                // TODO: it does not work here.
                CleanOrder(newOrder.ID);
                throw new BadArgException("Invalid SalesOrderItem ");
            }

            return newOrder.ID;

        }

        public void CleanOrder(string id)
        {
            // delete the sales order and the sales order items
            // delete the appointments
            // delete the booking order
            db.SaveChanges();

            // get the sales order
            var salesOrder = repository.GetById(id);

            // get the sales order items
            var salesOrderItems = _SalesOrderItemTable.GetBySQL(
                "SELECT * FROM SalesOrderItem WHERE _salesOrderId = " + salesOrder.ID
            );
            foreach (var soi in salesOrderItems)
            {
                _SalesOrderItemTable.Delete(soi);
            }
            // TODO: delete the appointments
            // TODO: delete the booking order

            repository.Delete(salesOrder);
            db.SaveChanges();
        }

        public string HoldOrder(OrderInDto TmpOrder)
        {
            string json = JObject.FromObject(TmpOrder).ToString();
            Helpers.File.TempFile tmp =  Helpers.File.TempFileManager.Create();
            tmp.WriteAllText(json);
            return tmp.GetFileName();
        }

        public void DeleteHoldedOrder(string HoldedOrderFileName)
        {
            Helpers.File.TempFileManager.CloseTempFile(HoldedOrderFileName);
        }

        public string GetHoldedOrder(string id)
        {
            try
            {
                return Helpers.File.TempFileManager.GetFileContent(id);
            }catch(FileNotFoundException e)
            {
                throw new FileNotExistException("The Id is invalid" , HttpStatusCode.BadRequest);
            }
        }
    }

    
}