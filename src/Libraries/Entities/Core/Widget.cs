// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("widget_name", autoIncrement = false)]
    [TableName("core.widgets")]
    [ExplicitColumns]
    public sealed class Widget : PetaPocoDB.Record<Widget>, IPoco
    {
        [Column("widget_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.widgets_widget_id_seq'::regclass)")]
        public int WidgetId { get; set; }

        [Column("widget_name")]
        [ColumnDbType("text", 0, false, "")]
        public string WidgetName { get; set; }

        [Column("widget_source")]
        [ColumnDbType("text", 0, false, "")]
        public string WidgetSource { get; set; }
    }
}