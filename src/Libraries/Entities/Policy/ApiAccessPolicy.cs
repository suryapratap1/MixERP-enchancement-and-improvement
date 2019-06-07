// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("api_access_policy_id", autoIncrement = true)]
    [TableName("policy.api_access_policy")]
    [ExplicitColumns]
    public sealed class ApiAccessPolicy : PetaPocoDB.Record<ApiAccessPolicy>, IPoco
    {
        [Column("api_access_policy_id")]
        [ColumnDbType("int8", 0, false, "nextval('policy.api_access_policy_api_access_policy_id_seq'::regclass)")]
        public long ApiAccessPolicyId { get; set; }

        [Column("user_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UserId { get; set; }

        [Column("office_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("poco_type_name")]
        [ColumnDbType("text", 0, false, "")]
        public string PocoTypeName { get; set; }

        [Column("http_action_code")]
        [ColumnDbType("text", 0, false, "")]
        public string HttpActionCode { get; set; }

        [Column("valid_till")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValidTill { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}