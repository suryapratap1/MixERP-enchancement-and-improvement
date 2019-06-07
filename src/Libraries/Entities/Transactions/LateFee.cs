// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("transaction_master_id", autoIncrement = false)]
    [TableName("transactions.late_fee")]
    [ExplicitColumns]
    public sealed class LateFee : PetaPocoDB.Record<LateFee>, IPoco
    {
        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long TransactionMasterId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long PartyId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("late_fee_tran_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long LateFeeTranId { get; set; }

        [Column("amount")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? Amount { get; set; }
    }
}