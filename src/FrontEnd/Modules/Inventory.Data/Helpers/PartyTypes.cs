using System.Collections.Generic;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class PartyTypes
    {
        public static IEnumerable<PartyType> GetPartyTypes(string catalog)
        {
            const string sql = "SELECT * FROM core.party_types;";
            return Factory.Get<PartyType>(catalog, sql);
        }
    }
}