using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Industries
    {
        public static IEnumerable<Industry> GetIndustries(string catalog)
        {
            const string sql = "SELECT * FROM core.industries;";
            return Factory.Get<Industry>(catalog, sql);
        }
    }
}