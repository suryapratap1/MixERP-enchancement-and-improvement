// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_top_selling_products_of_all_time")]
    [ExplicitColumns]
    public sealed class DbGetTopSellingProductsOfAllTimeResult : PetaPocoDB.Record<DbGetTopSellingProductsOfAllTimeResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("item_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int ItemId { get; set; }

        [Column("item_code")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemCode { get; set; }

        [Column("item_name")]
        [ColumnDbType("text", 0, false, "")]
        public string ItemName { get; set; }

        [Column("total_sales")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TotalSales { get; set; }
    }
}