// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("cash_flow_setup_id", autoIncrement = true)]
    [TableName("core.cash_flow_setup")]
    [ExplicitColumns]
    public sealed class CashFlowSetup : PetaPocoDB.Record<CashFlowSetup>, IPoco
    {
        [Column("cash_flow_setup_id")]
        [ColumnDbType("int4", 0, false, "nextval('core.cash_flow_setup_cash_flow_setup_id_seq'::regclass)")]
        public int CashFlowSetupId { get; set; }

        [Column("cash_flow_heading_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CashFlowHeadingId { get; set; }

        [Column("account_master_id")]
        [ColumnDbType("int2", 0, false, "")]
        public short AccountMasterId { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}