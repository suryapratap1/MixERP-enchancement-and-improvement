// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.cash_flow_heading_scrud_view")]
    [ExplicitColumns]
    public sealed class CashFlowHeadingScrudView : PetaPocoDB.Record<CashFlowHeadingScrudView>, IPoco
    {
        [Column("cash_flow_heading_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CashFlowHeadingId { get; set; }

        [Column("cash_flow_heading_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CashFlowHeadingCode { get; set; }

        [Column("cash_flow_heading_name")]
        [ColumnDbType("varchar", 100, true, "")]
        public string CashFlowHeadingName { get; set; }

        [Column("cash_flow_heading_type")]
        [ColumnDbType("bpchar", 1, true, "")]
        public string CashFlowHeadingType { get; set; }

        [Column("is_debit")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsDebit { get; set; }

        [Column("is_sales")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsSales { get; set; }

        [Column("is_purchase")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsPurchase { get; set; }
    }
}