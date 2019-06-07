using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.verified_cash_transaction_mat_view")]
    [ExplicitColumns]
    public sealed class VerifiedCashTransactionMatView : PetaPocoDB.Record<VerifiedCashTransactionMatView>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("transaction_counter")]
        [ColumnDbType("integer", 0, false, "")]
        public int TransactionCounter { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TransactionCode { get; set; }

        [Column("book")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Book { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime TransactionTs { get; set; }

        [Column("login_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long LoginId { get; set; }

        [Column("user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UserId { get; set; }

        [Column("sys_user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SysUserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("cost_center_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CostCenterId { get; set; }

        [Column("reference_number")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("master_statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string MasterStatementReference { get; set; }

        [Column("last_verified_on")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime LastVerifiedOn { get; set; }

        [Column("verified_by_user_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int VerifiedByUserId { get; set; }

        [Column("verification_status_id")]
        [ColumnDbType("smallint", 0, false, "")]
        public short VerificationStatusId { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("character varying", 0, false, "")]
        public string VerificationReason { get; set; }

        [Column("transaction_detail_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long TransactionDetailId { get; set; }

        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, false, "")]
        public string TranType { get; set; }

        [Column("account_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("character varying", 0, false, "")]
        public string AccountNumber { get; set; }

        [Column("account_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string AccountName { get; set; }

        [Column("normally_debit")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool NormallyDebit { get; set; }

        [Column("account_master_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string AccountMasterCode { get; set; }

        [Column("account_master_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string AccountMasterName { get; set; }

        [Column("account_master_id")]
        [ColumnDbType("smallint", 0, false, "")]
        public short AccountMasterId { get; set; }

        [Column("confidential")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool Confidential { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int CashRepositoryId { get; set; }

        [Column("currency_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string CurrencyCode { get; set; }

        [Column("amount_in_currency")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string LocalCurrencyCode { get; set; }

        [Column("amount_in_local_currency")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal AmountInLocalCurrency { get; set; }
    }
}