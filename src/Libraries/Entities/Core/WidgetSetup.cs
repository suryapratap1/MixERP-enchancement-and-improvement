// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("widget_setup_id", autoIncrement = true)]
    [TableName("core.widget_setup")]
    [ExplicitColumns]
    public sealed class WidgetSetup : PetaPocoDB.Record<WidgetSetup>, IPoco
    {
        [Column("widget_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.widget_setup_widget_setup_id_seq'::regclass)")]
        public int WidgetSetupId { get; set; }

        [Column("widget_order")]
        [ColumnDbType("int4", 0, false, "")]
        public int WidgetOrder { get; set; }

        [Column("widget_group_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string WidgetGroupName { get; set; }

        [Column("widget_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string WidgetName { get; set; }
    }
}