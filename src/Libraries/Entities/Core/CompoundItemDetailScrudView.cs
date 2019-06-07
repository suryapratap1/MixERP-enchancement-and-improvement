// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.compound_item_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class CompoundItemDetailScrudView : PetaPocoDB.Record<CompoundItemDetailScrudView>, IPoco
    {
        [Column("compound_item_detail_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CompoundItemDetailId { get; set; }

        [Column("compound_item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CompoundItemId { get; set; }

        [Column("compound_item_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CompoundItemCode { get; set; }

        [Column("compound_item_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string CompoundItemName { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemId { get; set; }

        [Column("item")]
        [ColumnDbType("text", 0, true, "")]
        public string Item { get; set; }

        [Column("unit")]
        [ColumnDbType("text", 0, true, "")]
        public string Unit { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, true, "")]
        public int? Quantity { get; set; }
    }
}