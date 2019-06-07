// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.item_cost_price_scrud_view")]
    [ExplicitColumns]
    public sealed class ItemCostPriceScrudView : PetaPocoDB.Record<ItemCostPriceScrudView>, IPoco
    {
        [Column("item_cost_price_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? ItemCostPriceId { get; set; }

        [Column("item_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string ItemName { get; set; }

        [Column("party_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string PartyCode { get; set; }

        [Column("party_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string PartyName { get; set; }

        [Column("unit")]
        [ColumnDbType("text", 0, true, "")]
        public string Unit { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? Price { get; set; }
    }
}