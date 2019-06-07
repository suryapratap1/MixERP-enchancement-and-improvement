// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("default_entity_access_id", autoIncrement = true)]
    [TableName("policy.default_entity_access")]
    [ExplicitColumns]
    public sealed class DefaultEntityAccess : PetaPocoDB.Record<DefaultEntityAccess>, IPoco
    {
        [Column("default_entity_access_id")]
        [ColumnDbType("int4", 0, false, "nextval('policy.default_entity_access_default_entity_access_id_seq'::regclass)")]
        public int DefaultEntityAccessId { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string EntityName { get; set; }

        [Column("role_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int RoleId { get; set; }

        [Column("access_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AccessTypeId { get; set; }

        [Column("allow_access")]
        [ColumnDbType("bool", 0, false, "")]
        public bool AllowAccess { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}