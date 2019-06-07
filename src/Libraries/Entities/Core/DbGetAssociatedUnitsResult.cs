// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("core.get_associated_units")]
    [ExplicitColumns]
    public sealed class DbGetAssociatedUnitsResult : PetaPocoDB.Record<DbGetAssociatedUnitsResult>, IPoco
    {
        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("unit_code")]
        [ColumnDbType("text", 0, false, "")]
        public string UnitCode { get; set; }

        [Column("unit_name")]
        [ColumnDbType("text", 0, false, "")]
        public string UnitName { get; set; }
    }
}