// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("cashier_id", autoIncrement = true)]
    [TableName("office.cashiers")]
    [ExplicitColumns]
    public sealed class Cashier : PetaPocoDB.Record<Cashier>, IPoco
    {
        [Column("cashier_id")]
        [ColumnDbType("int8", 0, false, "nextval('office.cashiers_cashier_id_seq'::regclass)")]
        public long CashierId { get; set; }

        [Column("counter_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CounterId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("assigned_by_user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int AssignedByUserId { get; set; }

        [Column("transaction_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime TransactionDate { get; set; }

        [Column("closed")]
        [ColumnDbType("bool", 0, false, "")]
        public bool Closed { get; set; }
    }
}