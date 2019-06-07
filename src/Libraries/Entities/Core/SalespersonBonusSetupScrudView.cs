// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.salesperson_bonus_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class SalespersonBonusSetupScrudView : PetaPocoDB.Record<SalespersonBonusSetupScrudView>, IPoco
    {
        [Column("salesperson_bonus_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalespersonBonusSetupId { get; set; }

        [Column("salesperson")]
        [ColumnDbType("text", 0, true, "")]
        public string Salesperson { get; set; }

        [Column("bonus_slab")]
        [ColumnDbType("text", 0, true, "")]
        public string BonusSlab { get; set; }
    }
}