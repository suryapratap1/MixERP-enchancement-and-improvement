// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.bonus_slab_scrud_view")]
    [ExplicitColumns]
    public sealed class BonusSlabScrudView : PetaPocoDB.Record<BonusSlabScrudView>, IPoco
    {
        [Column("bonus_slab_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? BonusSlabId { get; set; }

        [Column("bonus_slab_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string BonusSlabCode { get; set; }

        [Column("bonus_slab_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string BonusSlabName { get; set; }

        [Column("effective_from")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EffectiveFrom { get; set; }

        [Column("ends_on")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? EndsOn { get; set; }

        [Column("checking_frequency")]
        [ColumnDbType("text", 0, true, "")]
        public string CheckingFrequency { get; set; }

        [Column("account")]
        [ColumnDbType("text", 0, true, "")]
        public string Account { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("varchar", 100, true, "")]
        public string StatementReference { get; set; }
    }
}