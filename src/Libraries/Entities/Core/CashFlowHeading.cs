// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("cash_flow_heading_id", autoIncrement = false)]
    [TableName("core.cash_flow_headings")]
    [ExplicitColumns]
    public sealed class CashFlowHeading : PetaPocoDB.Record<CashFlowHeading>, IPoco
    {
        [Column("cash_flow_heading_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int CashFlowHeadingId { get; set; }

        [Column("cash_flow_heading_code")]
        [ColumnDbType("varchar", 12, false, "")]
        public string CashFlowHeadingCode { get; set; }

        [Column("cash_flow_heading_name")]
        [ColumnDbType("varchar", 100, false, "")]
        public string CashFlowHeadingName { get; set; }

        [Column("cash_flow_heading_type")]
        [ColumnDbType("bpchar", 1, false, "")]
        public string CashFlowHeadingType { get; set; }

        [Column("is_debit")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsDebit { get; set; }

        [Column("is_sales")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsSales { get; set; }

        [Column("is_purchase")]
        [ColumnDbType("bool", 0, false, "false")]
        public bool IsPurchase { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}