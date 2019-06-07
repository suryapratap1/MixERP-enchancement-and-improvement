// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.sales_order_view")]
    [ExplicitColumns]
    public sealed class SalesOrderView : PetaPocoDB.Record<SalesOrderView>, IPoco
    {
        [Column("non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? NonGlStockMasterId { get; set; }

        [Column("tran_id")]
        [ColumnDbType("int8", 0, true, "")]
        public long? TranId { get; set; }

        [Column("transaction_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? TransactionTs { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, true, "")]
        public DateTime? ValueDate { get; set; }

        [Column("quotation_valid_duration")]
        [ColumnDbType("int4", 0, true, "")]
        public int? QuotationValidDuration { get; set; }

        [Column("entered_by")]
        [ColumnDbType("varchar", 50, true, "")]
        public string EnteredBy { get; set; }

        [Column("office_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string OfficeName { get; set; }

        [Column("statement_reference")]
        [ColumnDbType("text", 0, true, "")]
        public string StatementReference { get; set; }

        [Column("customer_name")]
        [ColumnDbType("varchar", 150, true, "")]
        public string CustomerName { get; set; }

        [Column("price_type_name")]
        [ColumnDbType("varchar", 50, true, "")]
        public string PriceTypeName { get; set; }
    }
}