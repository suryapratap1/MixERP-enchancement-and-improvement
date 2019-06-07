// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("store_policy_id", autoIncrement = true)]
    [TableName("policy.store_policies")]
    [ExplicitColumns]
    public sealed class StorePolicy : PetaPocoDB.Record<StorePolicy>, IPoco
    {
        [Column("store_policy_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.store_policies_store_policy_id_seq'::regclass)")]
        public long StorePolicyId { get; set; }

        [Column("written_by_user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int WrittenByUserId { get; set; }

        [Column("status")]
        [ColumnDbType("bool", 0, false, "")]
        public bool Status { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}