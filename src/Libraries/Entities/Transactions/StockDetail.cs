// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("stock_detail_id", autoIncrement = true)]
    [TableName("transactions.stock_details")]
    [ExplicitColumns]
    public sealed class StockDetail : PetaPocoDB.Record<StockDetail>, IPoco
    {
        [Column("stock_detail_id")]
        [ColumnDbType("int8", 0, false, "nextval('transactions.stock_details_stock_detail_id_seq'::regclass)")]
        public long StockDetailId { get; set; }

        [Column("value_date")]
        [ColumnDbType("date", 0, false, "")]
        public DateTime ValueDate { get; set; }

        [Column("stock_master_id")]
        [ColumnDbType("int8", 0, false, "")]
        public long StockMasterId { get; set; }

        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, false, "")]
        public string TranType { get; set; }

        [Column("store_id")]
        [ColumnDbType("int4", 0, true, "")]
        public int? StoreId { get; set; }

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

        [Column("cost_of_goods_sold")]
        [ColumnDbType("money_strict2", 0, false, "0")]
        public decimal CostOfGoodsSold { get; set; }

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