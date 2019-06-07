// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_pl_appropriation_data")]
    [ExplicitColumns]
    public sealed class DbGetPlAppropriationDataResult : PetaPocoDB.Record<DbGetPlAppropriationDataResult>, IPoco
    {
        [Column("account_id")]
        [ColumnDbType("bigint", 0, false, "")]
        public long AccountId { get; set; }

        [Column("account_number")]
        [ColumnDbType("text", 0, false, "")]
        public string AccountNumber { get; set; }

        [Column("account_name")]
        [ColumnDbType("text", 0, false, "")]
        public string AccountName { get; set; }

        [Column("debit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Debit { get; set; }

        [Column("credit")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Credit { get; set; }
    }
}