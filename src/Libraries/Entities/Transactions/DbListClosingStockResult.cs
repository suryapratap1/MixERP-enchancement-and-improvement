// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.list_closing_stock")]
    [ExplicitColumns]
    public sealed class DbListClosingStockResult : PetaPocoDB.Record<DbListClosingStockResult>, IPoco
    {
        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemName { get; set; }

        [Column("unit_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int UnitId { get; set; }

        [Column("unit_name")]
        [ColumnDbType("text", 0, false, "")]
        public string UnitName { get; set; }

        [Column("quantity")]
        [ColumnDbType("integer", 0, false, "")]
        public int Quantity { get; set; }
    }
}