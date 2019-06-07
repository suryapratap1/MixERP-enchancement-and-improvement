// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_journal_view")]
    [ExplicitColumns]
    public sealed class DbGetJournalViewResult : PetaPocoDB.Record<DbGetJournalViewResult>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("transaction_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TransactionCode { get; set; }

        [Column("book")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Book { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("reference_number")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ReferenceNumber { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("posted_by")]
        [ColumnDbType("text", 0, false, "")]
        public string PostedBy { get; set; }

        [Column("office")]
        [ColumnDbType("text", 0, false, "")]
        public string Office { get; set; }

        [Column("status")]
        [ColumnDbType("text", 0, false, "")]
        public string Status { get; set; }

        [Column("verified_by")]
        [ColumnDbType("text", 0, false, "")]
        public string VerifiedBy { get; set; }

        [Column("verified_on")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime VerifiedOn { get; set; }

        [Column("reason")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Reason { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime TransactionTs { get; set; }
    }
}