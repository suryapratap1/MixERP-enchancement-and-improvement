using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Entities.Core;
using MixERP.Net.i18n;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Services.Setup
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Parties : WebService
    {
        private const short PAGE_SIZE = 12;

        [WebMethod]
        public List<PartyScrudView> GetParties(string filter, int partyTypeId, int page)
        {
            string catalog = AppUsers.GetCurrentUserDB();
            filter = "%" + filter.ToLower(CultureManager.GetCurrent()) + "%";

            int offset = (page - 1) * PAGE_SIZE;

            const string sql = @"SELECT * FROM core.party_scrud_view
                WHERE (@0 = 0 OR party_type_id = @0) 
                AND (LOWER(party_code) LIKE @1 
                OR lower(party_name) LIKE @1
                OR lower(email) LIKE @1)
                ORDER BY party_id DESC
                LIMIT @2 OFFSET @3;";

            return Factory.Get<PartyScrudView>(catalog, sql, partyTypeId, filter, PAGE_SIZE, offset).ToList();
        }

        [WebMethod]
        public List<PartyType> GetPartyTypes()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            const string sql = "SELECT * FROM core.party_types;";

            return Factory.Get<PartyType>(catalog, sql).ToList();
        }

        [WebMethod]
        public void DeleteParty(int partyId)
        {
            if (partyId <= 0)
            {
                return;
            }

            string catalog = AppUsers.GetCurrentUserDB();
            const string sql = "DELETE FROM core.parties WHERE party_id=@0;";

            Factory.NonQuery(catalog, sql, partyId);
        }

        [WebMethod]
        public int GetCount(string filter, int partyTypeId)
        {
            string catalog = AppUsers.GetCurrentUserDB();
            filter = "%" + filter.ToLower(CultureManager.GetCurrent()) + "%";

            const string sql = @"SELECT COUNT(*) / @0 FROM core.party_scrud_view
                WHERE (@1 = 0 OR party_type_id = @1) 
                AND (LOWER(party_code) LIKE @2 
                OR lower(party_name) LIKE @2
                OR lower(email) LIKE @2);";

            return Factory.Scalar<int>(catalog, sql, PAGE_SIZE, partyTypeId, filter);
        }
    }
}