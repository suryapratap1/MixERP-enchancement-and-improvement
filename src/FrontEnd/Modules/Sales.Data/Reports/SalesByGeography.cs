using System.Collections.Generic;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Reports
{
    public class SalesByGeography
    {
        public static IEnumerable<SalesByCountryView> GetSalesByCountry(string catalog)
        {
            const string sql = "SELECT * FROM transactions.sales_by_country_view;";
            return Factory.Get<SalesByCountryView>(catalog, sql);
        }
    }
}