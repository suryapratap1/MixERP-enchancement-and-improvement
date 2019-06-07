using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Countries
    {
        public static IEnumerable<Country> GetCountries(string catalog)
        {
            const string sql = "SELECT * FROM core.countries;";
            return Factory.Get<Country>(catalog, sql);
        }
    }
}