// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("counter_id", autoIncrement = true)]
    [TableName("office.counters")]
    [ExplicitColumns]
    public sealed class Counter : PetaPocoDB.Record<Counter>, IPoco
    {
        [Column("counter_id")]
        [ColumnDbType("int4", 0, false, "nextval('office.counters_counter_id_seq'::regclass)")]
        public int CounterId { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StoreId { get; set; }

        [Column("cash_repository_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CashRepositoryId { get; set; }

        [Column("counter_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CounterCode { get; set; }

        [Column("counter_name")]
        [ColumnDbType("varchar", 50, false, "")]
        public string CounterName { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}