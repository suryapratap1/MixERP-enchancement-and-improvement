// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.counter_scrud_view")]
    [ExplicitColumns]
    public sealed class CounterScrudView : PetaPocoDB.Record<CounterScrudView>, IPoco
    {
        [Column("counter_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CounterId { get; set; }

        [Column("store")]
        [ColumnDbType("text", 0, true, "")]
        public string Store { get; set; }

        [Column("cash_repository")]
        [ColumnDbType("text", 0, true, "")]
        public string CashRepository { get; set; }

        [Column("counter_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CounterCode { get; set; }

        [Column("counter_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CounterName { get; set; }
    }
}