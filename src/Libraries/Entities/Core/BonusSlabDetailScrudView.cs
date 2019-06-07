// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.bonus_slab_detail_scrud_view")]
    [ExplicitColumns]
    public sealed class BonusSlabDetailScrudView : PetaPocoDB.Record<BonusSlabDetailScrudView>, IPoco
    {
        [Column("bonus_slab_detail_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? BonusSlabDetailId { get; set; }

        [Column("bonus_slab")]
        [ColumnDbType("text", 0, true, "")]
        public string BonusSlab { get; set; }

        [Column("amount_from")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? AmountFrom { get; set; }

        [Column("amount_to")]
        [ColumnDbType("money_strict", 0, true, "")]
        public decimal? AmountTo { get; set; }

        [Column("bonus_rate")]
        [ColumnDbType("decimal_strict", 0, true, "")]
        public decimal? BonusRate { get; set; }
    }
}