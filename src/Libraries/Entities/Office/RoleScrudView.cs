// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.role_scrud_view")]
    [ExplicitColumns]
    public sealed class RoleScrudView : PetaPocoDB.Record<RoleScrudView>, IPoco
    {
        [Column("role_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? RoleId { get; set; }

        [Column("role_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string RoleCode { get; set; }

        [Column("role_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RoleName { get; set; }

        [Column("is_admin")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsAdmin { get; set; }

        [Column("is_system")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSystem { get; set; }
    }
}