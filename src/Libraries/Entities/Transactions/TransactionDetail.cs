// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("transaction_detail_id", autoIncrement = true)]
    [TableName("transactions.transaction_details")]
    [ExplicitColumns]
    public sealed class TransactionDetail : PetaPocoDB.Record<TransactionDetail>, IPoco
    {
        [Column("transaction_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.transaction_details_transaction_detail_id_seq'::regclass)")]
        public long TransactionDetailId { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, false, "")]
        public string TranType { get; set; }

        [Column("account_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long AccountId { get; set; }

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
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal AmountInCurrency { get; set; }

        [Column("local_currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string LocalCurrencyCode { get; set; }

        [Column("er")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal Er { get; set; }

        [Column("amount_in_local_currency")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal AmountInLocalCurrency { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}