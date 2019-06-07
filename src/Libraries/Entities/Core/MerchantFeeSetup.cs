// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("merchant_fee_setup_id", autoIncrement = true)]
    [TableName("core.merchant_fee_setup")]
    [ExplicitColumns]
    public sealed class MerchantFeeSetup : PetaPocoDB.Record<MerchantFeeSetup>, IPoco
    {
        [Column("merchant_fee_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.merchant_fee_setup_merchant_fee_setup_id_seq'::regclass)")]
        public int MerchantFeeSetupId { get; set; }

        [Column("merchant_account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long MerchantAccountId { get; set; }

        [Column("payment_card_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int PaymentCardId { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal Rate { get; set; }

        [Column("customer_pays_fee")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool CustomerPaysFee { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("varchar", 128, false, "")]
        public string StatementReference { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}