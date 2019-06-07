namespace MixERP.Net.Entities.Transactions.Models
{
    public sealed class ProductDetail
    {
        public decimal Amount { get; set; }
        public decimal Discount { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal ShippingCharge { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public string TaxCode { get; set; }
        public decimal Total { get; set; }
        public string Unit { get; set; }
    }
}