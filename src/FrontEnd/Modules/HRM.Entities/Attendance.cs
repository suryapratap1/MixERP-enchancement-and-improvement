// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("attendance_id", autoIncrement = true)]
    [TableName("hrm.attendances")]
    [ExplicitColumns]
    public sealed class Attendance : PetaPocoDB.Record<Attendance>, IPoco
    {
        [Column("attendance_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.attendances_attendance_id_seq'::regclass)")]
        public long AttendanceId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("attendance_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime AttendanceDate { get; set; }

        [Column("was_present")]
        [ColumnDbType("bool", 0, false, "")]
        public bool WasPresent { get; set; }

        [Column("check_in_time")]
        [ColumnDbType("time", 0, true, "")]
        public DateTime? CheckInTime { get; set; }

        [Column("check_out_time")]
        [ColumnDbType("time", 0, true, "")]
        public DateTime? CheckOutTime { get; set; }

        [Column("overtime_hours")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal OvertimeHours { get; set; }

        [Column("was_absent")]
        [ColumnDbType("bool", 0, false, "")]
        public bool WasAbsent { get; set; }

        [Column("reason_for_absenteeism")]
        [ColumnDbType("text", 0, true, "")]
        public string ReasonForAbsenteeism { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}