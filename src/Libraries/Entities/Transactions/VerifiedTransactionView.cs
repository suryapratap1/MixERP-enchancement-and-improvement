// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.verified_transaction_view")]
    [ExplicitColumns]
    public sealed class VerifiedTransactionView : PetaPocoDB.Record<VerifiedTransactionView>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionMasterId { get; set; }

        [Column("transaction_counter")]
        [ColumnDbType("int4", 0, true, "")]
        public int? TransactionCounter { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TransactionCode { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Book { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("login_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("sys_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SysUserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("cost_center_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CostCenterId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? VerifiedByUserId { get; set; }

        [Column("verification_status_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? VerificationStatusId { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionDetailId { get; set; }

        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, true, "")]
        public string TranType { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("varchar", 12, true, "")]
        public string AccountNumber { get; set; }

        [Column("account_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string AccountName { get; set; }

        [Column("normally_debit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? NormallyDebit { get; set; }

        [Column("account_master_code")]
        [ColumnDbType("varchar", 3, true, "")]
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")]
        [ColumnDbType("varchar", 40, true, "")]
        public string AccountMasterName { get; set; }

        [Column("account_master_id")]
        [ColumnDbType("int2", 0, true, "")]
        public short? AccountMasterId { get; set; }

        [Column("confidential")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? Confidential { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashRepositoryId { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? AmountInCurrency { get; set; }

        [Column("local_currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? AmountInLocalCurrency { get; set; }
    }
}