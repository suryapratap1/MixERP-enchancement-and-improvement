// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("policy_id", autoIncrement = true)]
    [TableName("policy.auto_verification_policy")]
    [ExplicitColumns]
    public sealed class AutoVerificationPolicy : PetaPocoDB.Record<AutoVerificationPolicy>, IPoco
    {
        [Column("policy_id")]
        [ColumnDbType("int4", 0, false, "nextval('policy.auto_verification_policy_policy_id_seq'::regclass)")]
        public int PolicyId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("verify_sales_transactions")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool VerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal SalesVerificationLimit { get; set; }

        [Column("verify_purchase_transactions")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool VerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal PurchaseVerificationLimit { get; set; }

        [Column("verify_gl_transactions")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool VerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal GlVerificationLimit { get; set; }

        [Column("effective_from")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime EffectiveFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime EndsOn { get; set; }

        [Column("is_active")]
        [ColumnDbType("bool", 0, false, "")]
        public bool IsActive { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}