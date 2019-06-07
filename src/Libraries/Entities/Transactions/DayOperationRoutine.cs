// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("day_operation_routine_id", autoIncrement = true)]
    [TableName("transactions.day_operation_routines")]
    [ExplicitColumns]
    public sealed class DayOperationRoutine : PetaPocoDB.Record<DayOperationRoutine>, IPoco
    {
        [Column("day_operation_routine_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.day_operation_routines_day_operation_routine_id_seq'::regclass)")]
        public long DayOperationRoutineId { get; set; }

        [Column("day_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long DayId { get; set; }

        [Column("routine_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int RoutineId { get; set; }

        [Column("started_on")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime StartedOn { get; set; }

        [Column("completed_on")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? CompletedOn { get; set; }
    }
}