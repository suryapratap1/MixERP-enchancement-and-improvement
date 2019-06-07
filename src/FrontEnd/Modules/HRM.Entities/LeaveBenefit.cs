// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("leave_benefit_id", autoIncrement = true)]
    [TableName("hrm.leave_benefits")]
    [ExplicitColumns]
    public sealed class LeaveBenefit : PetaPocoDB.Record<LeaveBenefit>, IPoco
    {
        [Column("leave_benefit_id")]
        [ColumnDbType("int4", 0, false, "nextval('hrm.leave_benefits_leave_benefit_id_seq'::regclass)")]
        public int LeaveBenefitId { get; set; }

        [Column("leave_benefit_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string LeaveBenefitCode { get; set; }

        [Column("leave_benefit_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string LeaveBenefitName { get; set; }

        [Column("total_days")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int TotalDays { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}