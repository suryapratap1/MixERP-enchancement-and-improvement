// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("office_hour_id", autoIncrement = true)]
    [TableName("hrm.office_hours")]
    [ExplicitColumns]
    public sealed class OfficeHour : PetaPocoDB.Record<OfficeHour>, IPoco
    {
        [Column("office_hour_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.office_hours_office_hour_id_seq'::regclass)")]
        public int OfficeHourId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("shift_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ShiftId { get; set; }

        [Column("week_day_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int WeekDayId { get; set; }

        [Column("begins_from")]
        [ColumnDbType("time", 0, false, "")]
        public DateTime BeginsFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("time", 0, false, "")]
        public DateTime EndsOn { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}