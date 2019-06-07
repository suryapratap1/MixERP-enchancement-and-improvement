// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_trial_balance")]
    [ExplicitColumns]
    public sealed class DbGetTrialBalanceResult : PetaPocoDB.Record<DbGetTrialBalanceResult>, IPoco
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

        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Debit { get; set; }

        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Credit { get; set; }

        [Column("closing_debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal ClosingDebit { get; set; }

        [Column("closing_credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal ClosingCredit { get; set; }
    }
}