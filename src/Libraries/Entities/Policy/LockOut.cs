// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("lock_out_id", autoIncrement = true)]
    [TableName("policy.lock_outs")]
    [ExplicitColumns]
    public sealed class LockOut : PetaPocoDB.Record<LockOut>, IPoco
    {
        [Column("lock_out_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.lock_outs_lock_out_id_seq'::regclass)")]
        public long LockOutId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("lock_out_time")]
        [ColumnDbType("timestamptz", 0, false, "")]
        public DateTime LockOutTime { get; set; }

        [Column("lock_out_till")]
        [ColumnDbType("timestamptz", 0, false, "2015-11-17 09:39:33.764+00")]
        public DateTime LockOutTill { get; set; }
    }
}