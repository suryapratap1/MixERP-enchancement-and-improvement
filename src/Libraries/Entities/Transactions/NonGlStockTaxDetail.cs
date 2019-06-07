// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("non_gl_stock_tax_detail_id", autoIncrement = true)]
    [TableName("transactions.non_gl_stock_tax_details")]
    [ExplicitColumns]
    public sealed class NonGlStockTaxDetail : PetaPocoDB.Record<NonGlStockTaxDetail>, IPoco
    {
        [Column("non_gl_stock_detail_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long NonGlStockDetailId { get; set; }

        [Column("sales_tax_detail_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int SalesTaxDetailId { get; set; }

        [Column("state_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StateSalesTaxId { get; set; }

        [Column("county_sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? CountySalesTaxId { get; set; }

        [Column("principal")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Principal { get; set; }

        [Column("rate")]
        [ColumnDbType("decimal_strict", 0, false, "")]
        public decimal Rate { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Tax { get; set; }

        [Column("non_gl_stock_tax_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_tax_details_non_gl_stock_tax_detail_id_seq'::regclass)")]
        public long NonGlStockTaxDetailId { get; set; }
    }
}