// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employee_qualification_id", autoIncrement = true)]
    [TableName("hrm.employee_qualifications")]
    [ExplicitColumns]
    public sealed class EmployeeQualification : PetaPocoDB.Record<EmployeeQualification>, IPoco
    {
        [Column("employee_qualification_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.employee_qualifications_employee_qualification_id_seq'::regclass)")]
        public long EmployeeQualificationId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("education_level_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EducationLevelId { get; set; }

        [Column("institution")]
        [ColumnDbType("varchar", 128, false, "")]
        public string Institution { get; set; }

        [Column("majors")]
        [ColumnDbType("varchar", 128, false, "")]
        public string Majors { get; set; }

        [Column("total_years")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TotalYears { get; set; }

        [Column("score")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Score { get; set; }

        [Column("started_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartedOn { get; set; }

        [Column("completed_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? CompletedOn { get; set; }

        [Column("details")]
        [ColumnDbType("text", 0, true, "")]
        public string Details { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}