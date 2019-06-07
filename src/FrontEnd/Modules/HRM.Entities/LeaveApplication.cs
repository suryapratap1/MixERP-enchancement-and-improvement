// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("leave_application_id", autoIncrement = true)]
    [TableName("hrm.leave_applications")]
    [ExplicitColumns]
    public sealed class LeaveApplication : PetaPocoDB.Record<LeaveApplication>, IPoco
    {
        [Column("leave_application_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.leave_applications_leave_application_id_seq'::regclass)")]
        public long LeaveApplicationId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("leave_type_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int LeaveTypeId { get; set; }

        [Column("entered_by")]
        [ColumnDbType("int4", 0, false, "")]
        public int EnteredBy { get; set; }

        [Column("applied_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? AppliedOn { get; set; }

        [Column("reason")]
        [ColumnDbType("text", 0, true, "")]
        public string Reason { get; set; }

        [Column("start_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartDate { get; set; }

        [Column("end_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndDate { get; set; }

        [Column("verification_status_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int VerificationStatusId { get; set; }

        [Column("verified_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? VerifiedByUserId { get; set; }

        [Column("verified_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? VerifiedOn { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string VerificationReason { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}