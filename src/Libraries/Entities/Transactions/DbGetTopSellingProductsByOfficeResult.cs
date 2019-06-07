// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_top_selling_products_by_office")]
    [ExplicitColumns]
    public sealed class DbGetTopSellingProductsByOfficeResult : PetaPocoDB.Record<DbGetTopSellingProductsByOfficeResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("office_code")]
        [ColumnDbType("text", 0, false, "")]
        public string OfficeCode { get; set; }

        [Column("office_name")]
        [ColumnDbType("text", 0, false, "")]
        public string OfficeName { get; set; }

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