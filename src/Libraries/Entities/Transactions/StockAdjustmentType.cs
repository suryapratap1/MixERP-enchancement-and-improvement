using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.stock_adjustment_type")]
    [ExplicitColumns]
    public sealed class StockAdjustmentType : PetaPocoDB.Record<StockAdjustmentType>, IPoco
    {
        [Column("tran_type")]
        [ColumnDbType("transaction_type", 0, false, "")]
        public string TranType { get; set; }

        [Column("store_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string StoreName { get; set; }

        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("unit_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string UnitName { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Quantity { get; set; }
    }
}