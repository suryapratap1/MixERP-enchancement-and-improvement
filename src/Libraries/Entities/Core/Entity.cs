// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("entity_id", autoIncrement = true)]
    [TableName("core.entities")]
    [ExplicitColumns]
    public sealed class Entity : PetaPocoDB.Record<Entity>, IPoco
    {
        [Column("entity_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.entities_entity_id_seq'::regclass)")]
        public int EntityId { get; set; }

        [Column("entity_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string EntityName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}