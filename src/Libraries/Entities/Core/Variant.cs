// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("variant_id", autoIncrement = true)]
    [TableName("core.variants")]
    [ExplicitColumns]
    public sealed class Variant : PetaPocoDB.Record<Variant>, IPoco
    {
        [Column("variant_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.variants_variant_id_seq'::regclass)")]
        public int VariantId { get; set; }

        [Column("variant_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string VariantCode { get; set; }

        [Column("variant_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string VariantName { get; set; }

        [Column("attribute_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int AttributeId { get; set; }

        [Column("attribute_value")]
        [ColumnDbType("varchar", 200, false, "")]
        public string AttributeValue { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}