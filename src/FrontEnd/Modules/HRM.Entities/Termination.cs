// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("termination_id", autoIncrement = true)]
    [TableName("hrm.terminations")]
    [ExplicitColumns]
    public sealed class Termination : PetaPocoDB.Record<Termination>, IPoco
    {
        [Column("termination_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.terminations_termination_id_seq'::regclass)")]
        public int TerminationId { get; set; }

        [Column("notice_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime NoticeDate { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("forward_to")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ForwardTo { get; set; }

        [Column("change_status_to")]
        [ColumnDbType("int4", 0, false, "")]
        public int ChangeStatusTo { get; set; }

        [Column("reason")]
        [ColumnDbType("varchar", 128, false, "")]
        public string Reason { get; set; }

        [Column("details")]
        [ColumnDbType("text", 0, true, "")]
        public string Details { get; set; }

        [Column("service_end_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ServiceEndDate { get; set; }

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