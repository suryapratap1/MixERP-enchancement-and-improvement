// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.ageing_slab_scrud_view")]
    [ExplicitColumns]
    public sealed class AgeingSlabScrudView : PetaPocoDB.Record<AgeingSlabScrudView>, IPoco
    {
        [Column("ageing_slab_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AgeingSlabId { get; set; }

        [Column("ageing_slab_name")]
        [ColumnDbType("varchar", 24, true, "")]
        public string AgeingSlabName { get; set; }

        [Column("from_days")]
        [ColumnDbType("int4", 0, true, "")]
        public int? FromDays { get; set; }

        [Column("to_days")]
        [ColumnDbType("integer_strict2", 0, true, "")]
        public int? ToDays { get; set; }
    }
}