// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Office
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("office.user_selector_view")]
    [ExplicitColumns]
    public sealed class UserSelectorView : PetaPocoDB.Record<UserSelectorView>, IPoco
    {
        [Column("user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UserId { get; set; }

        [Column("user_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string UserName { get; set; }

        [Column("full_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string FullName { get; set; }

        [Column("role_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string RoleName { get; set; }

        [Column("office_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string OfficeName { get; set; }
    }
}