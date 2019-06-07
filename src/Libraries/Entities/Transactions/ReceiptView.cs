// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.receipt_view")]
    [ExplicitColumns]
    public sealed class ReceiptView : PetaPocoDB.Record<ReceiptView>, IPoco
    {
        [Column("tran_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TranId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? OfficeId { get; set; }

        [Column("office_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string OfficeCode { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionMasterId { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("varchar", 50, true, "")]
        public string TransactionCode { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("entered_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EnteredBy { get; set; }

        [Column("reference_number")]
        [ColumnDbType("varchar", 24, true, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("status")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Status { get; set; }

        [Column("verification_reason")]
        [ColumnDbType("varchar", 128, true, "")]
        public string VerificationReason { get; set; }

        [Column("verified_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string VerifiedBy { get; set; }

        [Column("customer_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? CustomerId { get; set; }

        [Column("customer_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CustomerCode { get; set; }

        [Column("customer_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string CustomerName { get; set; }

        [Column("address")]
        [ColumnDbType("text", 0, true, "")]
        public string Address { get; set; }

        [Column("pan_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PanNumber { get; set; }

        [Column("sst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string SstNumber { get; set; }

        [Column("cst_number")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CstNumber { get; set; }

        [Column("email")]
        [ColumnDbType("varchar", 128, true, "")]
        public string Email { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CurrencyCode { get; set; }

        [Column("amount")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? Amount { get; set; }

        [Column("er_debit")]
        [ColumnDbType("decimal_strict", 0, true, "")]
        public decimal? ErDebit { get; set; }

        [Column("home_currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string HomeCurrencyCode { get; set; }

        [Column("amount_in_home_currency")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? AmountInHomeCurrency { get; set; }

        [Column("er_credit")]
        [ColumnDbType("decimal_strict", 0, true, "")]
        public decimal? ErCredit { get; set; }

        [Column("base_currency_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string BaseCurrencyCode { get; set; }

        [Column("amount_in_base_currency")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? AmountInBaseCurrency { get; set; }
    }
}