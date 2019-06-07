// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_balance_sheet")]
    [ExplicitColumns]
    public sealed class DbGetBalanceSheetResult : PetaPocoDB.Record<DbGetBalanceSheetResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long Id { get; set; }

        [Column("item")]
        [ColumnDbType("text", 0, false, "")]
        public string Item { get; set; }

        [Column("previous_period")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal PreviousPeriod { get; set; }

        [Column("current_period")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal CurrentPeriod { get; set; }

        [Column("account_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("text", 0, false, "")]
        public string AccountNumber { get; set; }

        [Column("is_retained_earning")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool IsRetainedEarning { get; set; }
    }
}