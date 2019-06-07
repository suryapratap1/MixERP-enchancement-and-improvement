// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_party_transaction_summary")]
    [ExplicitColumns]
    public sealed class DbGetPartyTransactionSummaryResult : PetaPocoDB.Record<DbGetPartyTransactionSummaryResult>, IPoco
    {
        [Column("currency_code")]
        [ColumnDbType("text", 0, false, "")]
        public string CurrencyCode { get; set; }

        [Column("currency_symbol")]
        [ColumnDbType("text", 0, false, "")]
        public string CurrencySymbol { get; set; }

        [Column("total_due_amount")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TotalDueAmount { get; set; }

        [Column("office_due_amount")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal OfficeDueAmount { get; set; }

        [Column("last_receipt_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime LastReceiptDate { get; set; }

        [Column("transaction_value")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TransactionValue { get; set; }
    }
}