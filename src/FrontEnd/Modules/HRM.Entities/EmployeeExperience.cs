// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employee_experience_id", autoIncrement = true)]
    [TableName("hrm.employee_experiences")]
    [ExplicitColumns]
    public sealed class EmployeeExperience : PetaPocoDB.Record<EmployeeExperience>, IPoco
    {
        [Column("employee_experience_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.employee_experiences_employee_experience_id_seq'::regclass)")]
        public long EmployeeExperienceId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("organization_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string OrganizationName { get; set; }

        [Column("title")]
        [ColumnDbType("varchar", 128, false, "")]
        public string Title { get; set; }

        [Column("started_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? StartedOn { get; set; }

        [Column("ended_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndedOn { get; set; }

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