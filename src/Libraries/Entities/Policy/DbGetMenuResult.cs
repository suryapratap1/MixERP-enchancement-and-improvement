// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("policy.get_menu")]
    [ExplicitColumns]
    public sealed class DbGetMenuResult : PetaPocoDB.Record<DbGetMenuResult>, IPoco
    {
        [Column("menu_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int MenuId { get; set; }

        [Column("menu_text")]
        [ColumnDbType("character varying", 0, false, "")]
        public string MenuText { get; set; }

        [Column("url")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Url { get; set; }

        [Column("menu_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string MenuCode { get; set; }

        [Column("sort")]
        [ColumnDbType("integer", 0, false, "")]
        public int Sort { get; set; }

        [Column("icon")]
        [ColumnDbType("character varying", 0, false, "")]
        public string Icon { get; set; }

        [Column("level")]
        [ColumnDbType("smallint", 0, false, "")]
        public short Level { get; set; }

        [Column("parent_menu_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ParentMenuId { get; set; }
    }
}