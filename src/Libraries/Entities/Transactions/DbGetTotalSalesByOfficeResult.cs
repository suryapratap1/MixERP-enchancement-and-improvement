// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_total_sales_by_office")]
    [ExplicitColumns]
    public sealed class DbGetTotalSalesByOfficeResult : PetaPocoDB.Record<DbGetTotalSalesByOfficeResult>, IPoco
    {
        [Column("office_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int OfficeId { get; set; }

        [Column("office_code")]
        [ColumnDbType("character varying", 0, false, "")]
        public string OfficeCode { get; set; }

        [Column("office_name")]
        [ColumnDbType("character varying", 0, false, "")]
        public string OfficeName { get; set; }

        [Column("total_sales")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TotalSales { get; set; }
    }
}