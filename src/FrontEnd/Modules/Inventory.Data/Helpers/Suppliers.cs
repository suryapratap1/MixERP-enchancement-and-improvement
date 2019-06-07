using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Suppliers
    {
        public static IEnumerable<Party> GetPreferredSuppliers(string catalog)
        {
            const string sql = "SELECT * FROM core.parties WHERE party_type_id=4;";
            return Factory.Get<Party>(catalog, sql);
        }
    }
}