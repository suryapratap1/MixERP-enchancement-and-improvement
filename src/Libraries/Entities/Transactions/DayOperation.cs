// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("day_id", autoIncrement = true)]
    [TableName("transactions.day_operation")]
    [ExplicitColumns]
    public sealed class DayOperation : PetaPocoDB.Record<DayOperation>, IPoco
    {
        [Column("day_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.day_operation_day_id_seq'::regclass)")]
        public long DayId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("started_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime StartedOn { get; set; }

        [Column("started_by")]
        [ColumnDbType("int4", 0, false, "")]
        public int StartedBy { get; set; }

        [Column("completed_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? CompletedOn { get; set; }

        [Column("completed_by")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CompletedBy { get; set; }

        [Column("completed")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool Completed { get; set; }
    }
}