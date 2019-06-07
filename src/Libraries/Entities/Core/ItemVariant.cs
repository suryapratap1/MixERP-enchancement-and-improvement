// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("item_variant_id", autoIncrement = true)]
    [TableName("core.item_variants")]
    [ExplicitColumns]
    public sealed class ItemVariant : PetaPocoDB.Record<ItemVariant>, IPoco
    {
        [Column("item_variant_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.item_variants_item_variant_id_seq'::regclass)")]
        public int ItemVariantId { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemId { get; set; }

        [Column("variant_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int VariantId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}