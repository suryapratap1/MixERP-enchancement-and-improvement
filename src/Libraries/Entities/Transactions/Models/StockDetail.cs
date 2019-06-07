namespace MixERP.Net.Entities.Transactions.Models
{
    public sealed class StockDetail
    {
        public decimal Discount { get; set; }
        public string ItemCode { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal ShippingCharge { get; set; }
        public int StoreId { get; set; }
        public decimal Tax { get; set; }
        public string TaxForm { get; set; }
        public string UnitName { get; set; }
    }
}