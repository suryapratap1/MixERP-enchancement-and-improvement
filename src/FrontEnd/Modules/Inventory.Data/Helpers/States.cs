using System.Collections.Generic;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class States
    {
        public static IEnumerable<State> GetStates(string catalog, int countryId)
        {
            const string sql = "SELECT * FROM core.states WHERE country_id=@0;";
            return Factory.Get<State>(catalog, sql, countryId);
        }
    }
}