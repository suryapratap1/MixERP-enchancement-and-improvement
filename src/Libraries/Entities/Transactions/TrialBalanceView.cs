using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.trial_balance_view")]
    [ExplicitColumns]
    public sealed class TrialBalanceView : PetaPocoDB.Record<TrialBalanceView>, IPoco
    {
        [Column("get_account_name")]
        [ColumnDbType("text", 0, false, "")]
        public string GetAccountName { get; set; }

        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Debit { get; set; }

        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Credit { get; set; }
    }
}