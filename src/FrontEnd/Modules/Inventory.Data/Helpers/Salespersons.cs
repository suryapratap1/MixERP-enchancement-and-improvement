using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Salespersons
    {
        public static IEnumerable<Salesperson> GetSalespersons(string catalog)
        {
            const string sql = "SELECT * FROM core.salespersons ORDER BY salesperson_id;";
            return Factory.Get<Salesperson>(catalog, sql);
        }
    }
}