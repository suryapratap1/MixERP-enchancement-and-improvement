// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Config
{
    [PrimaryKey("key", autoIncrement = false)]
    [TableName("config.scrud_factory")]
    [ExplicitColumns]
    public sealed class ScrudFactory : PetaPocoDB.Record<ScrudFactory>, IPoco
    {
        [Column("key")]
        [ColumnDbType("text", 0, false, "")]
        public string Key { get; set; }

        [Column("value")]
        [ColumnDbType("text", 0, true, "")]
        public string Value { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}