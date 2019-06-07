// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("bonus_slab_detail_id", autoIncrement = true)]
    [TableName("core.bonus_slab_details")]
    [ExplicitColumns]
    public sealed class BonusSlabDetail : PetaPocoDB.Record<BonusSlabDetail>, IPoco
    {
        [Column("bonus_slab_detail_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.bonus_slab_details_bonus_slab_detail_id_seq'::regclass)")]
        public int BonusSlabDetailId { get; set; }

        [Column("bonus_slab_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BonusSlabId { get; set; }

        [Column("amount_from")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal AmountFrom { get; set; }

        [Column("amount_to")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal AmountTo { get; set; }

        [Column("bonus_rate")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal BonusRate { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}