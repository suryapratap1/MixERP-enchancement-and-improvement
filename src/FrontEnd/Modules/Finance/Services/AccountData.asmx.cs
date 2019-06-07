using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Core.Modules.Finance.Data.Helpers;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Office;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace MixERP.Net.Core.Modules.Finance.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class AccountData : WebService
    {
        [WebMethod]
        public bool AccountNumberExists(string accountNumber)
        {
            if (!string.IsNullOrWhiteSpace(accountNumber))
            {
                return AccountHelper.AccountNumberExists(AppUsers.GetCurrentUserDB(), accountNumber);
            }

            return false;
        }

        [WebMethod]
        public bool CashRepositoryCodeExists(string cashRepositoryCode)
        {
            return CashRepositories.CashRepositoryCodeExists(AppUsers.GetCurrentUserDB(), cashRepositoryCode);
        }

        [WebMethod]
        public Collection<ListItem> GetAccounts()
        {
            bool allowParentAccountInGlTransaction = DbConfig.GetSwitch(AppUsers.GetCurrentUserDB(),
                "AllowParentAccountInGLTransaction");

            if (allowParentAccountInGlTransaction)
            {
                if (AppUsers.GetCurrent().View.IsAdmin.ToBool())
                {
                    return GetValues(AccountHelper.GetAccounts(AppUsers.GetCurrentUserDB()));
                }


                return GetValues(AccountHelper.GetNonConfidentialAccounts(AppUsers.GetCurrentUserDB()));
            }

            if (AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return GetValues(AccountHelper.GetChildAccounts(AppUsers.GetCurrentUserDB()));
            }

            return GetValues(AccountHelper.GetNonConfidentialChildAccounts(AppUsers.GetCurrentUserDB()));
        }

        [WebMethod]
        public Collection<ListItem> GetCashRepositories()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            foreach (
                CashRepository cashRepository in
                    CashRepositories.GetCashRepositories(AppUsers.GetCurrentUserDB(), officeId))
            {
                values.Add(new ListItem(cashRepository.CashRepositoryName,
                    cashRepository.CashRepositoryId.ToString(CultureInfo.InvariantCulture)));
            }
            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetCashRepositoriesByAccountNumber(string accountNumber)
        {
            Collection<ListItem> values = new Collection<ListItem>();

            if (AccountHelper.IsCashAccount(AppUsers.GetCurrentUserDB(), accountNumber))
            {
                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                foreach (
                    CashRepository cashRepository in
                        CashRepositories.GetCashRepositories(AppUsers.GetCurrentUserDB(), officeId))
                {
                    values.Add(new ListItem(cashRepository.CashRepositoryName, cashRepository.CashRepositoryCode));
                }
            }

            return values;
        }

        [WebMethod]
        public decimal GetCashRepositoryBalance(int cashRepositoryId, string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
            {
                return CashRepositories.GetBalance(AppUsers.GetCurrentUserDB(), cashRepositoryId);
            }

            return CashRepositories.GetBalance(AppUsers.GetCurrentUserDB(), cashRepositoryId, currencyCode);
        }

        [WebMethod]
        public Collection<ListItem> GetCostCenters()
        {
            Collection<ListItem> values = new Collection<ListItem>();


            foreach (CostCenter costCenter in CostCenters.GetCostCenters(AppUsers.GetCurrentUserDB()))
            {
                values.Add(new ListItem(costCenter.CostCenterName,
                    costCenter.CostCenterId.ToString(CultureInfo.InvariantCulture)));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetCurrencies()
        {
            Collection<ListItem> values = new Collection<ListItem>();

            foreach (Currency currency in Currencies.GetCurrencies(AppUsers.GetCurrentUserDB()))
            {
                values.Add(new ListItem(currency.CurrencyCode, currency.CurrencyCode));
            }

            return values;
        }

        [WebMethod]
        public Collection<ListItem> GetCurrenciesByAccountNumber(string accountNumber)
        {
            Collection<ListItem> values = new Collection<ListItem>();

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                return values;
            }

            string currencyCode = Currencies.GetCurrencyCode(AppUsers.GetCurrentUserDB(), accountNumber);

            values.Add(new ListItem(currencyCode, currencyCode));

            return values;
        }

        [WebMethod]
        public bool HasBalance(string cashRepositoryCode, string currencyCode, decimal credit)
        {
            if (credit.Equals(0))
            {
                return true;
            }

            if (credit < 0)
            {
                throw new MixERPException(Warnings.NegativeValueSupplied);
            }

            decimal balance = CashRepositories.GetBalance(AppUsers.GetCurrentUserDB(), cashRepositoryCode, currencyCode);

            if (balance > credit)
            {
                return true;
            }

            return false;
        }

        [WebMethod]
        public bool IsCashAccount(string accountNumber)
        {
            if (!string.IsNullOrWhiteSpace(accountNumber))
            {
                return AccountHelper.IsCashAccount(AppUsers.GetCurrentUserDB(), accountNumber);
            }

            return false;
        }

        [WebMethod]
        public Collection<ListItem> ListAccounts()
        {
            if (AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return GetValues(AccountHelper.GetAccounts(AppUsers.GetCurrentUserDB()));
            }

            return GetValues(AccountHelper.GetNonConfidentialAccounts(AppUsers.GetCurrentUserDB()));
        }

        private static Collection<ListItem> GetValues(IEnumerable<Account> accounts)
        {
            Collection<ListItem> values = new Collection<ListItem>();

            foreach (Account account in accounts)
            {
                values.Add(new ListItem(account.AccountName, account.AccountNumber));
            }

            return values;
        }
    }
}