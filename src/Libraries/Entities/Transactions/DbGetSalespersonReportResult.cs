// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_salesperson_report")]
    [ExplicitColumns]
    public sealed class DbGetSalespersonReportResult : PetaPocoDB.Record<DbGetSalespersonReportResult>, IPoco
    {
        [Column("id")]
        [ColumnDbType("integer", 0, false, "")]
        public int Id { get; set; }

        [Column("salesperson_id")]
        [ColumnDbType("integer", 0, false, "")]
        public int SalespersonId { get; set; }

        [Column("salesperson_name")]
        [ColumnDbType("text", 0, false, "")]
        public string SalespersonName { get; set; }

        [Column("total_sales")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TotalSales { get; set; }
    }
}