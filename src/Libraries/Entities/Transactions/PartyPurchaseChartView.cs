// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.party_purchase_chart_view")]
    [ExplicitColumns]
    public sealed class PartyPurchaseChartView : PetaPocoDB.Record<PartyPurchaseChartView>, IPoco
    {
        [Column("row_number")]
        [ColumnDbType("int8", 0, true, "")]
        public long? RowNumber { get; set; }

        [Column("transaction_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TransactionMasterId { get; set; }

        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("book")]
        [ColumnDbType("varchar", 50, true, "")]
        public string Book { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("amount")]
        [ColumnDbType("numeric", 1572868, true, "")]
        public decimal? Amount { get; set; }
    }
}