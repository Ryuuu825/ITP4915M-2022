namespace TheBetterLimited_Server.Data.Dto
{
    public class TransactionDto 
    {
        public string _salesOrderId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
    }

    public class CreditCardTransactionDto : TransactionDto
    {
        public string CreditCardNumber { get; set; }
    }

    public class TransactionResDto {}
    public class TransactionOkDto : TransactionResDto
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string PaymentMethod { get; set; }

    }

    public class TransactionErrorDto : TransactionResDto
    {
        public string ErrorMessage { get; set; }
    }

    public class CreditCardTransactionOkDto : TransactionOkDto
    {
        public string ReferenceNumber { get; set; }
    }

    public class CreditCardTransactionErrorDto : TransactionErrorDto
    {
        public string ReferenceNumber { get; set; }
    }

}