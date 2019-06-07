// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [FunctionName("transactions.get_eoy_profit_summary")]
    [ExplicitColumns]
    public sealed class DbGetEoyProfitSummaryResult : PetaPocoDB.Record<DbGetEoyProfitSummaryResult>, IPoco
    {
        [Column("profit_before_tax")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal ProfitBeforeTax { get; set; }

        [Column("tax_rate")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal TaxRate { get; set; }

        [Column("tax")]
        [ColumnDbType("numeric", 0, false, "")]
        public decimal Tax { get; set; }
    }
}