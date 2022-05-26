namespace TheBetterLimited_Server.AppLogic.Controllers; 
using System;
using TheBetterLimited_Server.Data;
using TheBetterLimited_Server.Data.Entity;
using QRCoder;

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

        public async Task<Transaction> MakePayment(Data.Dto.TransactionDto payment)
        {
            var salesOrder = await salesOrderRepository.GetByIdAsync(payment._salesOrderId);
            if (salesOrder == null)
            {
                throw new OperationFailException("Sales order not found");
            }
            var transaction = new Transaction
            {
                ID = Helpers.Secure.RandomId.GetID(10),
                CreatedAt = DateTime.Now,
                _salesOrderId = payment._salesOrderId,
                SalesOrder = salesOrder,
                Amount = payment.Amount
            };

            await paymentRepository.AddAsync(transaction);
            await db.SaveChangesAsync();
            return transaction;
        }

        /**
         * <summary>
         * Create a transaction record for the payment. Send a request to external payment gateway. (stub)
         * </summary>
         *
         */
        public async Task<Data.Dto.TransactionResDto> CreatePayment(Data.Dto.TransactionDto payment)
        {
            try
            {
                var transaction = await MakePayment(payment);
                return new Data.Dto.TransactionOkDto
                {
                    Id = transaction.ID,
                    Amount = transaction.Amount,
                    CreatedAt = transaction.CreatedAt,
                    Currency = payment.Currency,
                    PaymentMethod = "Cash"
                };
            }catch(ICustException e)
            {
                return new Data.Dto.TransactionErrorDto
                {
                    ErrorMessage = e.Message
                };
            }
        }
        public async Task<Data.Dto.TransactionResDto> CreateCreditCardPayment(Data.Dto.CreditCardTransactionDto payment)
        {
            Tuple<Guid,bool> res = await PaymentGatewayStub.CreateTransactionRecord(payment._salesOrderId);
            if (res.Item2)
            {
                try
                {
                    var transaction =  await MakePayment(payment);
                    return new Data.Dto.CreditCardTransactionOkDto
                    {
                        Id = transaction.ID,
                        Amount = transaction.Amount,
                        CreatedAt = transaction.CreatedAt,
                        Currency = payment.Currency,
                        ReferenceNumber = res.Item1.ToString(),
                        PaymentMethod = "Credit Card"
                    };
                }catch(ICustException e)
                {
                    return new Data.Dto.TransactionErrorDto
                    {
                        ErrorMessage = e.Message,
                    };
                }

            }
            else
            {
                return new Data.Dto.CreditCardTransactionErrorDto
                {
                    ErrorMessage = "Payment gateway error",
                    ReferenceNumber = res.Item1.ToString()
                };
            }
        }

        public async Task<byte[]> GetPaymentQRCode()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.youtube.com/watch?v=dQw4w9WgXcQ", QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            return qrCode.GetGraphic(20);
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