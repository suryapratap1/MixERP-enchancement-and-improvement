// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.item_group_scrud_view")]
    [ExplicitColumns]
    public sealed class ItemGroupScrudView : PetaPocoDB.Record<ItemGroupScrudView>, IPoco
    {
        [Column("item_group_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemGroupId { get; set; }

        [Column("item_group_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string ItemGroupCode { get; set; }

        [Column("item_group_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string ItemGroupName { get; set; }

        [Column("exclude_from_purchase")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? ExcludeFromPurchase { get; set; }

        [Column("exclude_from_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? ExcludeFromSales { get; set; }

        [Column("sales_tax")]
        [ColumnDbType("text", 0, true, "")]
        public string SalesTax { get; set; }

        [Column("parent")]
        [ColumnDbType("text", 0, true, "")]
        public string Parent { get; set; }
    }
}