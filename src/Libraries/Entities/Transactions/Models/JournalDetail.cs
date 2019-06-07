namespace MixERP.Net.Entities.Transactions.Models
{
    public sealed class JournalDetail
    {
        public string Account { get; set; }
        public string AccountNumber { get; set; }
        public string CashRepositoryCode { get; set; }
        public decimal Credit { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Debit { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal LocalCurrencyCredit { get; set; }
        public decimal LocalCurrencyDebit { get; set; }
        public string StatementReference { get; set; }
    }
}