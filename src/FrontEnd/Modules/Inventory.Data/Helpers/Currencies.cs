using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Currencies
    {
        public static IEnumerable<Currency> GetCurrencyCodes(string catalog)
        {
            const string sql = "SELECT * FROM core.currencies;";
            return Factory.Get<Currency>(catalog, sql);
        }
    }
}