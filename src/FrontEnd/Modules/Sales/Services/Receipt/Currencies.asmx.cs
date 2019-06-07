using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities.Core;
using System.Web.Script.Services;
using System.Web.Services;


namespace MixERP.Net.Core.Modules.Sales.Services.Receipt
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public class Currencies : WebService
    {
        [WebMethod]
        public System.Collections.ObjectModel.Collection<System.Web.UI.WebControls.ListItem> GetCurrencies()
        {
            System.Collections.ObjectModel.Collection<System.Web.UI.WebControls.ListItem> values = new System.Collections.ObjectModel.Collection<System.Web.UI.WebControls.ListItem>();

            foreach (Currency currency in Data.Helpers.Currencies.GetCurrencies(AppUsers.GetCurrentUserDB()))
            {
                values.Add(new System.Web.UI.WebControls.ListItem(currency.CurrencyCode, currency.CurrencyCode));
            }

            return values;
        }

        [WebMethod]
        public decimal GetExchangeRate(string sourceCurrencyCode, string destinationCurrencyCode)
        {
            if (string.IsNullOrWhiteSpace(sourceCurrencyCode))
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(destinationCurrencyCode))
            {
                return 0;
            }

            if (sourceCurrencyCode.Equals(destinationCurrencyCode))
            {
                return 1;
            }

            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            decimal exchangeRate = Data.Helpers.Transaction.GetExchangeRate(AppUsers.GetCurrentUserDB(), officeId, sourceCurrencyCode, destinationCurrencyCode);

            return exchangeRate;
        }

        [WebMethod]
        public string GetHomeCurrency()
        {
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            return Data.Helpers.Currencies.GetHomeCurrency(AppUsers.GetCurrentUserDB(), officeId);
        }
    }
}