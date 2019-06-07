// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("attribute_id", autoIncrement = true)]
    [TableName("core.attributes")]
    [ExplicitColumns]
    public sealed class Attribute : PetaPocoDB.Record<Attribute>, IPoco
    {
        [Column("attribute_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.attributes_attribute_id_seq'::regclass)")]
        public int AttributeId { get; set; }

        [Column("attribute_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string AttributeCode { get; set; }

        [Column("attribute_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string AttributeName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}