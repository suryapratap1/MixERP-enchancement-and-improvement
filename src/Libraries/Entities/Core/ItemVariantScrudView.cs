// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.item_variant_scrud_view")]
    [ExplicitColumns]
    public sealed class ItemVariantScrudView : PetaPocoDB.Record<ItemVariantScrudView>, IPoco
    {
        [Column("item_variant_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ItemVariantId { get; set; }

        [Column("item")]
        [ColumnDbType("text", 0, true, "")]
        public string Item { get; set; }

        [Column("variant")]
        [ColumnDbType("text", 0, true, "")]
        public string Variant { get; set; }
    }
}