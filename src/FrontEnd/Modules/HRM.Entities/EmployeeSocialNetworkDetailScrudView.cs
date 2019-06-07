// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.HRM
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("hrm.employee_social_network_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class EmployeeSocialNetworkDetailScrudView : PetaPocoDB.Record<EmployeeSocialNetworkDetailScrudView>, IPoco
    {
        [Column("employee_social_network_detail_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? EmployeeSocialNetworkDetailId { get; set; }

        [Column("employee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? EmployeeId { get; set; }

        [Column("employee_name")]
        [ColumnDbType("varchar", 160, true, "")]
        public string EmployeeName { get; set; }

        [Column("social_network_name")]
        [ColumnDbType("varchar", 128, true, "")]
        public string SocialNetworkName { get; set; }

        [Column("social_network_id")]
        [ColumnDbType("varchar", 128, true, "")]
        public string SocialNetworkId { get; set; }

        [Column("semantic_css_class")]
        [ColumnDbType("varchar", 128, true, "")]
        public string SemanticCssClass { get; set; }

        [Column("base_url")]
        [ColumnDbType("varchar", 128, true, "")]
        public string BaseUrl { get; set; }

        [Column("profile_url")]
        [ColumnDbType("varchar", 128, true, "")]
        public string ProfileUrl { get; set; }
    }
}