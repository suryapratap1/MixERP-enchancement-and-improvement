// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("policy.auto_verification_policy_scrud_view")]
    [ExplicitColumns]
    public sealed class AutoVerificationPolicyScrudView : PetaPocoDB.Record<AutoVerificationPolicyScrudView>, IPoco
    {
        [Column("policy_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? PolicyId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("user_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string UserName { get; set; }

        [Column("office_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string OfficeName { get; set; }

        [Column("verify_sales_transactions")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? VerifySalesTransactions { get; set; }

        [Column("sales_verification_limit")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? SalesVerificationLimit { get; set; }

        [Column("verify_purchase_transactions")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? VerifyPurchaseTransactions { get; set; }

        [Column("purchase_verification_limit")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? PurchaseVerificationLimit { get; set; }

        [Column("verify_gl_transactions")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? VerifyGlTransactions { get; set; }

        [Column("gl_verification_limit")]
        [ColumnDbType("money_strict2", 0, true, "")]
        public decimal? GlVerificationLimit { get; set; }

        [Column("effective_from")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndsOn { get; set; }

        [Column("is_active")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsActive { get; set; }
    }
}