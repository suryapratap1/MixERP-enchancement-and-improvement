using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Entities
    {
        public static IEnumerable<Entity> GetEntities(string catalog)
        {
            const string sql = "SELECT * FROM core.entities;";
            return Factory.Get<Entity>(catalog, sql);
        }
    }
}