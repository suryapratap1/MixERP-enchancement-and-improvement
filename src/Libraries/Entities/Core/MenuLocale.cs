// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("menu_locale_id", autoIncrement = true)]
    [TableName("core.menu_locale")]
    [ExplicitColumns]
    public sealed class MenuLocale : PetaPocoDB.Record<MenuLocale>, IPoco
    {
        [Column("menu_locale_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.menu_locale_menu_locale_id_seq'::regclass)")]
        public int MenuLocaleId { get; set; }

        [Column("menu_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int MenuId { get; set; }

        [Column("culture")]
        [ColumnDbType("varchar", 12, false, "")]
        public string Culture { get; set; }

        [Column("menu_text")]
        [ColumnDbType("varchar", 250, false, "")]
        public string MenuText { get; set; }
    }
}