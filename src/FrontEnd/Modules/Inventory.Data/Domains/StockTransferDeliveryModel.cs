using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Domains
{
    public class StockTransferDeliveryModel
    {
        [Column("store_name")]
        public string StoreName { get; set; }
        [Column("item_code")]
        public string ItemCode { get; set; }
        [Column("item_name")]
        public string ItemName { get; set; }
        [Column("unit_name")]
        public string UnitName { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}