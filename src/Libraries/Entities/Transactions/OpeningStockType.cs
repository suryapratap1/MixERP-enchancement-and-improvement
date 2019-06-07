using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.opening_stock_type")]
    [ExplicitColumns]
    public sealed class OpeningStockType : PetaPocoDB.Record<OpeningStockType>, IPoco
    {
        [Column("store_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string StoreName { get; set; }

        [Column("item_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer_strict", 0, false, "")]
        public int Quantity { get; set; }

        [Column("unit_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string UnitName { get; set; }

        [Column("amount")]
        [ColumnDbType("money_strict", 0, false, "")]
        public decimal Amount { get; set; }
    }
}