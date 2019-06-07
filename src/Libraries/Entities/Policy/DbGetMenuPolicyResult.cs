// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Policy
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("policy.get_menu_policy")]
    [ExplicitColumns]
    public sealed class DbGetMenuPolicyResult : PetaPocoDB.Record<DbGetMenuPolicyResult>, IPoco
    {
        [Column("row_number")]
        [ColumnDbType("bigint", 0, false, "")]
        public long RowNumber { get; set; }

        [Column("access")]
        [ColumnDbType("boolean", 0, false, "")]
        public bool Access { get; set; }

        [Column("menu_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int MenuId { get; set; }

        [Column("menu_code")]
        [ColumnDbType("text", 0, false, "")]
        public string MenuCode { get; set; }

        [Column("menu_text")]
        [ColumnDbType("text", 0, false, "")]
        public string MenuText { get; set; }

        [Column("url")]
        [ColumnDbType("text", 0, false, "")]
        public string Url { get; set; }
    }
}