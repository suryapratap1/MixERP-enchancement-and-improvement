namespace MixERP.Net.Entities.Transactions.Models
{
    public sealed class StockMaster
    {
        public bool IsCredit { get; set; }
        public string PartyCode { get; set; }
        public int PaymentTermId { get; set; }
        public int PriceTypeId { get; set; }
        public int SalespersonId { get; set; }
        public int ShipperId { get; set; }
        public string ShippingAddressCode { get; set; }
        public decimal ShippingCharge { get; set; }
        public long StockMasterId { get; set; }
        public int StoreId { get; set; }
        public long TransactionMasterId { get; set; }
    }
}