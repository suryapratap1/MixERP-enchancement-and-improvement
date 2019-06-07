// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.flag_type_scrud_view")]
    [ExplicitColumns]
    public sealed class FlagTypeScrudView : PetaPocoDB.Record<FlagTypeScrudView>, IPoco
    {
        [Column("flag_type_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? FlagTypeId { get; set; }

        [Column("flag_type_name")]
        [ColumnDbType("varchar", 24, true, "")]
        public string FlagTypeName { get; set; }

        [Column("background_color")]
        [ColumnDbType("color", 0, true, "")]
        public string BackgroundColor { get; set; }

        [Column("foreground_color")]
        [ColumnDbType("color", 0, true, "")]
        public string ForegroundColor { get; set; }
    }
}