using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Inventory.Data.Helpers;
using MixERP.Net.Entities;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions;
using Serilog;
using MixERP.Net.ApplicationState.Cache;
using PetaPoco;

namespace MixERP.Net.Core.Modules.Inventory.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    public class PartyData : WebService
    {
        [WebMethod]
        public Collection<ListItem> GetAddressByPartyCode(string partyCode)
        {
            Collection<ListItem> values = new Collection<ListItem>();

            foreach (ShippingAddressView view in ShippingAddresses.GetShippingAddressView(AppUsers.GetCurrentUserDB(), partyCode))
            {
                string address = string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}{1}{3}{4}{5}{1}{6}{4}{7}", view.AddressLine1, Environment.NewLine, view.AddressLine2, view.Street, ", ", view.City, view.StateName, view.CountryName);

                values.Add(new ListItem(view.ShippingAddressCode, address));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetParties()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            foreach (Party party in Parties.GetParties(AppUsers.GetCurrentUserDB()))
            {
                values.Add(new ListItem(party.PartyName, party.PartyCode));
            }
            return values;
        }

        [WebMethod]
        public string GetPartyCodeByPartyId(int partyId)
        {
            return Parties.GetPartyCodeByPartyId(AppUsers.GetCurrentUserDB(), partyId);
        }

        [WebMethod]
        public DbGetPartyTransactionSummaryResult GetPartyDue(string partyCode)
        {
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            return Parties.GetPartyDue(AppUsers.GetCurrentUserDB(), officeId, partyCode);
        }

        [WebMethod]
        public PartyView GetPartyView(string partyCode)
        {
            return Parties.GetPartyView(AppUsers.GetCurrentUserDB(), partyCode);
        }

        [WebMethod]
        public IEnumerable<ShippingAddress> GetShippingAddresses(string partyCode)
        {
            return Parties.GetShippingAddresses(AppUsers.GetCurrentUserDB(), partyCode);
        }

        [WebMethod]
        public Collection<ListItem> GetPartyTypes()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            IEnumerable<PartyType> partyTypes = PartyTypes.GetPartyTypes(AppUsers.GetCurrentUserDB());

            foreach (PartyType partyType in partyTypes)
            {
                values.Add(new ListItem(partyType.PartyTypeName, partyType.PartyTypeId.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetEntities()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            IEnumerable<Entity> entities = Data.Helpers.Entities.GetEntities(AppUsers.GetCurrentUserDB());

            foreach (Entity entity in entities)
            {
                values.Add(new ListItem(entity.EntityName, entity.EntityId.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetIndustries()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            IEnumerable<Industry> industries = Data.Helpers.Industries.GetIndustries(AppUsers.GetCurrentUserDB());

            foreach (Industry industry in industries)
            {
                values.Add(new ListItem(industry.IndustryName, industry.IndustryId.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetCountries()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            IEnumerable<Country> countries = Data.Helpers.Countries.GetCountries(AppUsers.GetCurrentUserDB());

            foreach (Country country in countries)
            {
                values.Add(new ListItem(country.CountryName, country.CountryId.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetStates(int countryId)
            {
            Collection<ListItem> values = new Collection<ListItem>();

            IEnumerable<State> states = States.GetStates(AppUsers.GetCurrentUserDB(), countryId);

            foreach (State state in states)
            {
                values.Add(new ListItem(state.StateName, state.StateId.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetCurrencyCodes()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            IEnumerable<Currency> currencies = Data.Helpers.Currencies.GetCurrencyCodes(AppUsers.GetCurrentUserDB());

            foreach (Currency currency in currencies)
            {
                values.Add(new ListItem(currency.CurrencySymbol + "(" + currency.CurrencyCode + "/" + currency.CurrencyName + ")", currency.CurrencyCode.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }


        [WebMethod]
        public long SaveOrUpdate(Party party)
        {
            try
            {
                string catalog = AppUsers.GetCurrentUserDB();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();

                if (string.IsNullOrWhiteSpace(party.PartyName))
                {
                    party.PartyName = party.LastName + ", " + party.FirstName;
                }

                party.AuditUserId = userId;
                party.AuditTs = DateTime.UtcNow;

                if (party.PartyId > 0)
                {
                    Factory.Update(catalog, party, party.PartyId);
                    return party.PartyId;
                }

                //Party code will be created on server side.
                party.PartyCode = null;
                long id = Conversion.TryCastLong(Factory.Insert(catalog, party));
                return id;
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save items. {Exception}", ex);
                throw;
            }
        }

        [WebMethod]
        public Party GetPartyData(string partyId)
        {
            return Parties.GetParty(AppUsers.GetCurrentUserDB(), Conversion.TryCastLong(partyId)).First();
        }
    }
}