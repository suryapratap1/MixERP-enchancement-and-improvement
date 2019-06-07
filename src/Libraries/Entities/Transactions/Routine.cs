// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("routine_id", autoIncrement = true)]
    [TableName("transactions.routines")]
    [ExplicitColumns]
    public sealed class Routine : PetaPocoDB.Record<Routine>, IPoco
    {
        [Column("routine_id")]
        [ColumnDbType("int4", 0, false, "nextval('transactions.routines_routine_id_seq'::regclass)")]
        public int RoutineId { get; set; }

        [Column("order")]
        [ColumnDbType("int4", 0, false, "")]
        public int Order { get; set; }

        [Column("routine_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string RoutineCode { get; set; }

        [Column("routine_name")]
        [ColumnDbType("regproc", 0, false, "")]
        public string RoutineName { get; set; }

        [Column("status")]
        [ColumnDbType("bool", 0, false, "true")]
        public bool Status { get; set; }
    }
}