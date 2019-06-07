namespace MixERP.Net.Entities.Transactions.Models
{
    public sealed class StockAdjustmentDetail
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string StoreName { get; set; }
        public TransactionTypeEnum TransferTypeEnum { get; set; }
        public string UnitName { get; set; }
    }
}