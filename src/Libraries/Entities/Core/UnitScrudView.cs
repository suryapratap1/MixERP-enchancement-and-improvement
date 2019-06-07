// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.unit_scrud_view")]
    [ExplicitColumns]
    public sealed class UnitScrudView : PetaPocoDB.Record<UnitScrudView>, IPoco
    {
        [Column("unit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? UnitId { get; set; }

        [Column("unit_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string UnitCode { get; set; }

        [Column("unit_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string UnitName { get; set; }
    }
}