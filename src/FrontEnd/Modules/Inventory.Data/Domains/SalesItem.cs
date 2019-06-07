namespace MixERP.Net.Core.Modules.Inventory.Data.Domains
{
    public class SalesItem
    {
        public int ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public bool IsCompoundItem { get; set; }
    }
}

