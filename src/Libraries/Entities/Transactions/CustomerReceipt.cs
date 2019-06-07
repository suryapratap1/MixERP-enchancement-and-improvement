// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("receipt_id", autoIncrement = true)]
    [TableName("transactions.customer_receipts")]
    [ExplicitColumns]
    public sealed class CustomerReceipt : PetaPocoDB.Record<CustomerReceipt>, IPoco
    {
        [Column("receipt_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.customer_receipts_receipt_id_seq'::regclass)")]
        public long ReceiptId { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PartyId { get; set; }

        [Column("currency_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CurrencyCode { get; set; }

        [Column("amount")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Amount { get; set; }

        [Column("er_debit")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal ErDebit { get; set; }

        [Column("er_credit")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal ErCredit { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashRepositoryId { get; set; }

        [Column("posted_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? PostedDate { get; set; }

        [Column("bank_account_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? BankAccountId { get; set; }

        [Column("bank_instrument_code")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankInstrumentCode { get; set; }

        [Column("bank_tran_code")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BankTranCode { get; set; }
    }
}