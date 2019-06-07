// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("store_policy_detail_id", autoIncrement = true)]
    [TableName("policy.store_policy_details")]
    [ExplicitColumns]
    public sealed class StorePolicyDetail : PetaPocoDB.Record<StorePolicyDetail>, IPoco
    {
        [Column("store_policy_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.store_policy_details_store_policy_detail_id_seq'::regclass)")]
        public long StorePolicyDetailId { get; set; }

        [Column("store_policy_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long StorePolicyId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int StoreId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}