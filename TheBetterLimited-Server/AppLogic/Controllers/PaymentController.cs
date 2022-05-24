namespace TheBetterLimited_Server.AppLogic.Controllers
{
    using System;
    using TheBetterLimited_Server.Data;
    using TheBetterLimited_Server.Data.Entity;
    public class PaymentController
    {
        private readonly DataContext db;
        private readonly Data.Repositories.Repository<Data.Entity.Transaction> paymentRepository;
        private readonly Data.Repositories.Repository<Data.Entity.SalesOrder> salesOrderRepository;
        public PaymentController(DataContext db)
        {
            this.db = db;
            paymentRepository = new Data.Repositories.Repository<Data.Entity.Transaction>(db);
            salesOrderRepository = new Data.Repositories.Repository<Data.Entity.SalesOrder>(db);
        }


        /**
         * <summary>
         * Create a transaction record for the payment. Send a request to external payment gateway. (stub)
         * </summary>
         *
         */
        public async Task<Data.Dto.TransactionResDto> CreatePayment(Data.Dto.TransactionDto payment)
        {
            // stub
            // send a request to external payment gateway
            Tuple<Guid,bool> res = await PaymentGatewayStub.CreateTransactionRecord(payment._salesOrderId);
            if (res.Item2)
            {
                var potnetialOrder = await salesOrderRepository.GetByIdAsync(payment._salesOrderId);
                foreach (var item in salesOrderRepository.GetAll())
                {
                    ConsoleLogger.Debug(item.ID);
                }
                // update the transaction record
                var transaction = new Transaction
                {
                    ID = Helpers.Secure.RandomId.GetID(10),
                    CreatedAt = DateTime.Now,
                    _salesOrderId = payment._salesOrderId,
                    SalesOrder = potnetialOrder,
                    Amount = payment.Amount
                };

               await paymentRepository.AddAsync(transaction);
               await db.SaveChangesAsync();
               return new Data.Dto.TransactionOkDto
               {
                    Id = transaction.ID,
                    Amount = transaction.Amount,
                    CreatedAt = transaction.CreatedAt,
                    ReferenceNumber = res.Item1,
                    Currency = payment.Currency
                };
 
            }
            else 
            {
               return new Data.Dto.TransactionErrorDto
               {
                     ErrorMessage = "Payment gateway error.",
                     ReferenceNumber = res.Item1
               };
            }
        }

    }

    internal static class PaymentGatewayStub
    {
        private static List<string> TransactionRecord = new List<string>();

        // async method that takes time to process the payment
        // return the transaction reference number
        public static async Task<Tuple<Guid,bool>> CreateTransactionRecord(string id)
        {
            TransactionRecord.Add(id);

            // sleep for a while to simulate the payment process
            System.Threading.Thread.Sleep(1000);

            if (TransactionRecord.Contains(id))
            {
                return Tuple.Create<Guid,bool>(Guid.NewGuid(),true);
            }
            return Tuple.Create<Guid,bool>(Guid.Empty,false);
        }
    }
}