// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_income_expenditure_statement")]
    [ExplicitColumns]
    public sealed class DbGetIncomeExpenditureStatementResult : PetaPocoDB.Record<DbGetIncomeExpenditureStatementResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("account_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("text", 0, false, "")]
        public string AccountNumber { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, false, "")]
        public string Account { get; set; }

        [Column("previous_debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal PreviousDebit { get; set; }

        [Column("previous_credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal PreviousCredit { get; set; }

        [Column("previous_balance")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal PreviousBalance { get; set; }

        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Debit { get; set; }

        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Credit { get; set; }

        [Column("balance")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Balance { get; set; }

        [Column("closing_debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal ClosingDebit { get; set; }

        [Column("closing_credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal ClosingCredit { get; set; }

        [Column("closing_balance")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal ClosingBalance { get; set; }
    }
}