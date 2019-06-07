// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("non_gl_stock_detail_id", autoIncrement = true)]
    [TableName("transactions.non_gl_stock_details")]
    [ExplicitColumns]
    public sealed class NonGlStockDetail : PetaPocoDB.Record<NonGlStockDetail>, IPoco
    {
        [Column("non_gl_stock_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.non_gl_stock_details_non_gl_stock_detail_id_seq'::regclass)")]
        public long NonGlStockDetailId { get; set; }

        [Column("non_gl_stock_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long NonGlStockMasterId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("item_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int ItemId { get; set; }

        [Column("quantity")]
        [ColumnDbType("int4", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int UnitId { get; set; }

        [Column("base_quantity")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal BaseQuantity { get; set; }

        [Column("base_unit_id")]
        [ColumnDbType("int4", 0, false, "")]
        public int BaseUnitId { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal Discount { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal ShippingCharge { get; set; }

        [Column("sales_tax_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? SalesTaxId { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal Tax { get; set; }

        [Column("audit_user_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? AuditUserId { get; set; }

        [Column("audit_ts")]
        [ColumnDbType("timestamptz", 0, true, "")]
        public DateTime? AuditTs { get; set; }
    }
}