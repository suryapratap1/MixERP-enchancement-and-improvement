// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Transactions
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("transactions.sales_by_country_view")]
    [ExplicitColumns]
    public sealed class SalesByCountryView : PetaPocoDB.Record<SalesByCountryView>, IPoco
    {
        [Column("country_code")]
        [ColumnDbType("varchar", 12, true, "")]
        public string CountryCode { get; set; }

        [Column("sales")]
        [ColumnDbType("numeric", 0, true, "")]
        public decimal? Sales { get; set; }
    }
}