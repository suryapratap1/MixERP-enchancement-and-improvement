using System.Collections.Generic;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Sales.Data.Helpers
{
    public static class Currencies
    {
        public static IEnumerable<Currency> GetCurrencies(string catalog)
        {
            const string sql = "SELECT * FROM core.currencies ORDER BY currency_code;";
            return Factory.Get<Currency>(catalog, sql);
        }

        public static string GetHomeCurrency(string catalog, int officeId)
        {
            const string sql = "SELECT core.get_currency_code_by_office_id(@0);";
            return Factory.Scalar<string>(catalog, sql, officeId);
        }
    }
}