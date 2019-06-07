using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.stock_detail_type")]
    [ExplicitColumns]
    public sealed class StockDetailType : PetaPocoDB.Record<StockDetailType>, IPoco
    {
        [Column("store_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int StoreId { get; set; }

        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string UnitName { get; set; }

        [Column("price")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Price { get; set; }

        [Column("discount")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Discount { get; set; }

        [Column("shipping_charge")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal ShippingCharge { get; set; }

        [Column("tax_form")]
        [ColumnDbType("character varying", 0, false, "")]
        public string TaxForm { get; set; }

        [Column("tax")]
        [ColumnDbType("money_strict2", 0, false, "")]
        public decimal Tax { get; set; }
    }
}