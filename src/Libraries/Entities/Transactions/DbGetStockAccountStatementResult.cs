// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_stock_account_statement")]
    [ExplicitColumns]
    public sealed class DbGetStockAccountStatementResult : PetaPocoDB.Record<DbGetStockAccountStatementResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("tran_code")]
        [ColumnDbType("text", 0, false, "")]
        public string TranCode { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, false, "")]
        public string StatementReference { get; set; }

        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Debit { get; set; }

        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Credit { get; set; }

        [Column("balance")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Balance { get; set; }

        [Column("book")]
        [ColumnDbType("text", 0, false, "")]
        public string Book { get; set; }

        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemName { get; set; }

        [Column("posted_on")]
        [ColumnDbType("timestamp with time zone", 0, false, "")]
        public DateTime PostedOn { get; set; }

        [Column("posted_by")]
        [ColumnDbType("text", 0, false, "")]
        public string PostedBy { get; set; }

        [Column("approved_by")]
        [ColumnDbType("text", 0, false, "")]
        public string ApprovedBy { get; set; }

        [Column("verification_status")]
        [ColumnDbType("integer", 0, false, "")]
        public int VerificationStatus { get; set; }

        [Column("flag_bg")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagBg { get; set; }

        [Column("flag_fg")]
        [ColumnDbType("text", 0, false, "")]
        public string FlagFg { get; set; }
    }
}