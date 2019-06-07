namespace MixERP.Net.Core.Modules.Purchase.Data.Models
{
    public class Reorder
    {
        public int ItemId { get; set; }

        public int OrderQuantity { get; set; }

        public decimal Price { get; set; }

        public string SupplierCode { get; set; }

        public string Tax { get; set; }

        public int UnitId { get; set; }
    }
}