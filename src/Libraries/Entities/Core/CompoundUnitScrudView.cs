// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.compound_unit_scrud_view")]
    [ExplicitColumns]
    public sealed class CompoundUnitScrudView : PetaPocoDB.Record<CompoundUnitScrudView>, IPoco
    {
        [Column("compound_unit_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CompoundUnitId { get; set; }

        [Column("base_unit_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string BaseUnitName { get; set; }

        [Column("value")]
        [ColumnDbType("int2", 0, true, "")]
        public short? Value { get; set; }

        [Column("compare_unit_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string CompareUnitName { get; set; }
    }
}