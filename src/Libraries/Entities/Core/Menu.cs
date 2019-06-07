// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("menu_id", autoIncrement = true)]
    [TableName("core.menus")]
    [ExplicitColumns]
    public sealed class Menu : PetaPocoDB.Record<Menu>, IPoco
    {
        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.menus_menu_id_seq'::regclass)")]
        public int MenuId { get; set; }

        [Column("menu_text")]
        [ColumnDbType("varchar", 250, false, "")]
        public string MenuText { get; set; }

        [Column("url")]
        [ColumnDbType("varchar", 250, true, "")]
        public string Url { get; set; }

        [Column("menu_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string MenuCode { get; set; }

        [Column("level")]
        [ColumnDbType("int2", 0, false, "")]
        public short Level { get; set; }

        [Column("parent_menu_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? ParentMenuId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }

        [Column("sort")]
        [ColumnDbType("int4", 0, false, "0")]
        public int Sort { get; set; }

        [Column("icon")]
        [ColumnDbType("varchar", 48, false, "")]
        public string Icon { get; set; }
    }
}