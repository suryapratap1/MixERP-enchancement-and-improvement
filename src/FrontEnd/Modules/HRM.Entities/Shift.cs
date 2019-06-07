// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("shift_id", autoIncrement = true)]
    [TableName("hrm.shifts")]
    [ExplicitColumns]
    public sealed class Shift : PetaPocoDB.Record<Shift>, IPoco
    {
        [Column("shift_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.shifts_shift_id_seq'::regclass)")]
        public int ShiftId { get; set; }

        [Column("shift_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string ShiftCode { get; set; }

        [Column("shift_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string ShiftName { get; set; }

        [Column("begins_from")]
        [ColumnDbType("time", 0, false, "")]
        public DateTime BeginsFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("time", 0, false, "")]
        public DateTime EndsOn { get; set; }

        [Column("description")]
        [ColumnDbType("text", 0, true, "")]
        public string Description { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}