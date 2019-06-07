// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("salesperson_bonus_setup_id", autoIncrement = true)]
    [TableName("core.salesperson_bonus_setups")]
    [ExplicitColumns]
    public sealed class SalespersonBonusSetup : PetaPocoDB.Record<SalespersonBonusSetup>, IPoco
    {
        [Column("salesperson_bonus_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.salesperson_bonus_setups_salesperson_bonus_setup_id_seq'::regclass)")]
        public int SalespersonBonusSetupId { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalespersonId { get; set; }

        [Column("bonus_slab_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BonusSlabId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}