// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.role_view")]
    [ExplicitColumns]
    public sealed class RoleView : PetaPocoDB.Record<RoleView>, IPoco
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
    }
}