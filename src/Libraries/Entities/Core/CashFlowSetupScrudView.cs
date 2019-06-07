// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.cash_flow_setup_scrud_view")]
    [ExplicitColumns]
    public sealed class CashFlowSetupScrudView : PetaPocoDB.Record<CashFlowSetupScrudView>, IPoco
    {
        [Column("cash_flow_setup_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashFlowSetupId { get; set; }

        [Column("cash_flow_heading")]
        [ColumnDbType("text", 0, true, "")]
        public string CashFlowHeading { get; set; }

        [Column("account_master")]
        [ColumnDbType("text", 0, true, "")]
        public string AccountMaster { get; set; }
    }
}