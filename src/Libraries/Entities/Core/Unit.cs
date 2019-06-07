// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("unit_id", autoIncrement = true)]
    [TableName("core.units")]
    [ExplicitColumns]
    public sealed class Unit : PetaPocoDB.Record<Unit>, IPoco
    {
        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.units_unit_id_seq'::regclass)")]
        public int UnitId { get; set; }

        [Column("unit_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string UnitCode { get; set; }

        [Column("unit_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string UnitName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}