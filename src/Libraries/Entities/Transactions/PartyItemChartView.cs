// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.party_item_chart_view")]
    [ExplicitColumns]
    public sealed class PartyItemChartView : PetaPocoDB.Record<PartyItemChartView>, IPoco
    {
        [Column("party_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? PartyId { get; set; }

        [Column("item_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string ItemName { get; set; }

        [Column("total")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Total { get; set; }
    }
}