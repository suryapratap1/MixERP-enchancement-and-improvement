// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.widget_setup_view")]
    [ExplicitColumns]
    public sealed class WidgetSetupView : PetaPocoDB.Record<WidgetSetupView>, IPoco
    {
        [Column("widget_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? WidgetSetupId { get; set; }

        [Column("widget_order")]
        [ColumnDbType("int4", 0, true, "")]
        public int? WidgetOrder { get; set; }

        [Column("widget_group_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string WidgetGroupName { get; set; }

        [Column("widget_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string WidgetName { get; set; }

        [Column("widget_source")]
        [ColumnDbType("text", 0, true, "")]
        public string WidgetSource { get; set; }
    }
}