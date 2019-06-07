using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Data.Helpers
{
    public static class Parties
    {
        public static IEnumerable<Party> GetParties(string catalog)
        {
            const string sql = "SELECT * FROM core.parties ORDER BY party_id;";
            return Factory.Get<Party>(catalog, sql);
        }

        public static IEnumerable<Party> GetParty(string catalog, long partyId)
        {
            const string sql = "SELECT * FROM core.parties WHERE party_id=@0;";
            return Factory.Get<Party>(catalog, sql, partyId);
        }

        public static string GetPartyCodeByPartyId(string catalog, int partyId)
        {
            const string sql = "SELECT party_code FROM core.parties WHERE party_id=@0;";
            Party party = Factory.Get<Party>(catalog, sql, partyId).FirstOrDefault();

            if (party != null)
            {
                return party.PartyCode;
            }

            return string.Empty;
        }

        public static PartyView GetPartyView(string catalog, string partyCode)
        {
            const string sql = "SELECT * FROM core.party_view WHERE party_code=@0 ORDER BY party_id";
            return Factory.Get<PartyView>(catalog, sql, partyCode).FirstOrDefault();
        }

        public static PartyView GetPartyViewData(string catalog, long partyId)
        {
            const string sql = "SELECT * FROM core.party_view WHERE party_id=@0";
            return Factory.Get<PartyView>(catalog, sql, partyId).FirstOrDefault();
        }

        //public static PartyOverviewScrudView GetPartySummaryData(string catalog, long partyId)
        //{
        //    const string sql = "SELECT * FROM core.party_overview_scrud_view WHERE party_id=@0";
        //    return Factory.Get<PartyOverviewScrudView>(catalog, sql, partyId).FirstOrDefault();
        //}

        public static IEnumerable<ShippingAddress> GetShippingAddresses(string catalog, string partyCode)
        {
            const string sql =
                "SELECT * FROM core.shipping_addresses WHERE party_id=core.get_party_id_by_party_code(@0);";
            return Factory.Get<ShippingAddress>(catalog, sql, partyCode);
        }

        public static DbGetPartyTransactionSummaryResult GetPartyDue(string catalog, int officeId, string partyCode)
        {
            const string sql =
                "SELECT * FROM transactions.get_party_transaction_summary(@0::integer, core.get_party_id_by_party_code(@1)::bigint);";
            return Factory.Get<DbGetPartyTransactionSummaryResult>(catalog, sql, officeId, partyCode).FirstOrDefault();
        }

        
    }
}