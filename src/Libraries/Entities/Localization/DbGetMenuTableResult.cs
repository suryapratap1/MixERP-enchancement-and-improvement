// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Localization
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("localization.get_menu_table")]
    [ExplicitColumns]
    public sealed class DbGetMenuTableResult : PetaPocoDB.Record<DbGetMenuTableResult>, IPoco
    {
        [Column("menu_code")]
        [ColumnDbType("text", 0, false, "")]
        public string MenuCode { get; set; }

        [Column("invariant")]
        [ColumnDbType("text", 0, false, "")]
        public string Invariant { get; set; }

        [Column("localized")]
        [ColumnDbType("text", 0, false, "")]
        public string Localized { get; set; }
    }
}