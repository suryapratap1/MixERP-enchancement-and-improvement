// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("employee_social_network_detail_id", autoIncrement = true)]
    [TableName("hrm.employee_social_network_details")]
    [ExplicitColumns]
    public sealed class EmployeeSocialNetworkDetail : PetaPocoDB.Record<EmployeeSocialNetworkDetail>, IPoco
    {
        [Column("employee_social_network_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('hrm.employee_social_network_detai_employee_social_network_detai_seq'::regclass)")]
        public long EmployeeSocialNetworkDetailId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int EmployeeId { get; set; }

        [Column("social_network_name")]
        [ColumnDbType("varchar", 128, false, "")]
        public string SocialNetworkName { get; set; }

        [Column("social_network_id")]
        [ColumnDbType("varchar", 128, false, "")]
        public string SocialNetworkId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}