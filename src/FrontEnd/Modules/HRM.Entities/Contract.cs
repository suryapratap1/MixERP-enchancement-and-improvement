// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("contract_id", autoIncrement = true)]
    [TableName("hrm.contracts")]
    [ExplicitColumns]
    public sealed class Contract : PetaPocoDB.Record<Contract>, IPoco
    {
        [Column("contract_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.contracts_contract_id_seq'::regclass)")]
        public long ContractId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("department_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int DepartmentId { get; set; }

        [Column("role_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RoleId { get; set; }

        [Column("leave_benefit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? LeaveBenefitId { get; set; }

        [Column("began_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? BeganOn { get; set; }

        [Column("ended_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndedOn { get; set; }

        [Column("employment_status_code_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmploymentStatusCodeId { get; set; }

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