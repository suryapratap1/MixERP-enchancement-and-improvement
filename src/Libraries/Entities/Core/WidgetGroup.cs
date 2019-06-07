// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("widget_group_name", autoIncrement = false)]
    [TableName("core.widget_groups")]
    [ExplicitColumns]
    public sealed class WidgetGroup : PetaPocoDB.Record<WidgetGroup>, IPoco
    {
        [Column("widget_group_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string WidgetGroupName { get; set; }

        [Column("is_default")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsDefault { get; set; }
    }
}