// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.bonus_slab_selector_view")]
    [ExplicitColumns]
    public sealed class BonusSlabSelectorView : PetaPocoDB.Record<BonusSlabSelectorView>, IPoco
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

        [Column("checking_frequency_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CheckingFrequencyId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}