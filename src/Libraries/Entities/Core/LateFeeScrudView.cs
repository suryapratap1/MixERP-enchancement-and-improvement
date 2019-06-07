// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.late_fee_scrud_view")]
    [ExplicitColumns]
    public sealed class LateFeeScrudView : PetaPocoDB.Record<LateFeeScrudView>, IPoco
    {
        [Column("late_fee_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? LateFeeId { get; set; }

        [Column("late_fee_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string LateFeeCode { get; set; }

        [Column("late_fee_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string LateFeeName { get; set; }

        [Column("is_flat_amount")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsFlatAmount { get; set; }

        [Column("rate")]
        [ColumnDbType("numeric", 1572868, true, "")]
        public decimal? Rate { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }
    }
}