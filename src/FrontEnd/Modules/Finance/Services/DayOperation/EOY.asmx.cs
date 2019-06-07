using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI.WebControls;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Finance.Data.Helpers;
using MixERP.Net.Entities.Core;
using MixERP.Net.Entities.Transactions.Models;
using MixERP.Net.Entities.Transactions;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.Common.Helpers;

namespace MixERP.Net.Core.Modules.Finance.Services.DayOperation
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class EOY : WebService
    {
        [WebMethod]
        public List<DbGetPlAppropriationDataResult> GetAppropriationData()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            bool isAdmin = AppUsers.GetCurrent().View.IsAdmin.ToBool();

            if (!isAdmin)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            return Data.DayOperation.EOY.GetPlAppropriationData(catalog, officeId).ToList();
        }

        [WebMethod]
        public bool PostPLAppropriation(string referenceNumber, int costCenterId, string accountNumber,
            string statementReference)
        {
            bool isAdmin = AppUsers.GetCurrent().View.IsAdmin.ToBool();

            if (!isAdmin)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            if (string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new MixERPException(Warnings.InvalidAccount);
            }

            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            int userId = AppUsers.GetCurrent().View.UserId.ToInt();
            long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            string currencyCode = AppUsers.GetCurrent().View.CurrencyCode;

            DateTime valueDate = DatePersister.GetFrequencyDates(catalog, officeId).Today;
            DateTime eoyDate = DatePersister.GetFrequencyDates(catalog, officeId).FiscalYearEndDate;

            if (valueDate != eoyDate)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            DateTime bookDate = valueDate;

            Collection<JournalDetail> details = new Collection<JournalDetail>();

            foreach (var item in this.GetAppropriationData())
            {
                details.Add(new JournalDetail
                {
                    Account = item.AccountName,
                    AccountNumber = item.AccountNumber,
                    Credit = item.Credit,
                    Debit = item.Debit,
                    CashRepositoryCode = string.Empty,
                    CurrencyCode = currencyCode,
                    ExchangeRate = 1,
                    LocalCurrencyCredit = item.Credit,
                    LocalCurrencyDebit = item.Debit,
                    StatementReference = statementReference
                });

                //Reverse side to balance the journal
                decimal debit = item.Credit;
                decimal credit = item.Debit;


                details.Add(new JournalDetail
                {
                    Account = string.Empty,
                    AccountNumber = accountNumber,
                    Credit = credit,
                    Debit = debit,
                    CashRepositoryCode = string.Empty,
                    CurrencyCode = currencyCode,
                    ExchangeRate = 1,
                    LocalCurrencyCredit = credit,
                    LocalCurrencyDebit = debit,
                    StatementReference = statementReference + " (" + item.AccountName + ")"
                });
            }

            Transaction.Add(catalog, valueDate, bookDate, officeId, userId, loginId, costCenterId,
                referenceNumber, details, new Collection<Attachment>());

            return true;
        }

        [WebMethod]
        public DbGetEoyProfitSummaryResult GetEoyProfitSummary()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            return Data.DayOperation.EOY.GetEoyProfitSummary(catalog, officeId);
        }

        [WebMethod]
        public bool PostIncomeTax(string taxOfficeAccountNumber, string taxExpensesAccountNumber, int costCenterId,
            string referenceNumber, string statementReference)
        {
            bool isAdmin = AppUsers.GetCurrent().View.IsAdmin.ToBool();

            if (!isAdmin)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            if (string.IsNullOrWhiteSpace(taxOfficeAccountNumber) || string.IsNullOrWhiteSpace(taxExpensesAccountNumber))
            {
                throw new MixERPException(Warnings.InvalidAccount);
            }

            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            int userId = AppUsers.GetCurrent().View.UserId.ToInt();
            long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();
            string currencyCode = AppUsers.GetCurrent().View.CurrencyCode;

            decimal tax = this.GetEoyProfitSummary().Tax;

            if (tax <= 0)
            {
                return true;
            }

            DateTime valueDate = DatePersister.GetFrequencyDates(catalog, officeId).Today;
            DateTime eoyDate = DatePersister.GetFrequencyDates(catalog, officeId).FiscalYearEndDate;

            if (valueDate != eoyDate)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            DateTime bookDate = valueDate;

            Collection<JournalDetail> details = new Collection<JournalDetail>();

            JournalDetail liability = new JournalDetail
            {
                Account = string.Empty,
                AccountNumber = taxOfficeAccountNumber,
                Credit = tax,
                Debit = 0,
                CashRepositoryCode = string.Empty,
                CurrencyCode = currencyCode,
                ExchangeRate = 1,
                LocalCurrencyCredit = tax,
                LocalCurrencyDebit = 0,
                StatementReference = statementReference
            };

            JournalDetail expenses = new JournalDetail
            {
                Account = string.Empty,
                AccountNumber = taxExpensesAccountNumber,
                Credit = 0,
                Debit = tax,
                CashRepositoryCode = string.Empty,
                CurrencyCode = currencyCode,
                ExchangeRate = 1,
                LocalCurrencyCredit = 0,
                LocalCurrencyDebit = tax,
                StatementReference = statementReference
            };

            details.Add(liability);
            details.Add(expenses);

            Transaction.Add(catalog, valueDate, bookDate, officeId, userId, loginId, costCenterId,
                referenceNumber, details, new Collection<Attachment>());

            return true;
        }

        [WebMethod]
        public void CreateNewFiscalYear(string fiscalYearCode, string fiscalYearName)

        {
            bool isAdmin = AppUsers.GetCurrent().View.IsAdmin.ToBool();

            if (!isAdmin)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            if (string.IsNullOrWhiteSpace(fiscalYearCode) || string.IsNullOrWhiteSpace(fiscalYearName))
            {
                throw new MixERPException(Labels.AllFieldsRequired);
            }

            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            int userId = AppUsers.GetCurrent().View.UserId.ToInt();


            DateTime valueDate = DatePersister.GetFrequencyDates(catalog, officeId).Today;
            DateTime eoyDate = DatePersister.GetFrequencyDates(catalog, officeId).FiscalYearEndDate;

            if (valueDate != eoyDate)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }


            Data.DayOperation.EOY.CreateNewFiscalYear(catalog, officeId, userId, fiscalYearCode, fiscalYearName);
        }

        [WebMethod]
        public bool IsNewFiscalYearCreated()
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            return Data.DayOperation.EOY.IsNewFiscalYearCreated(catalog, officeId);
        }

        #region Accounts

        [WebMethod]
        public Collection<ListItem> GetLiabilityAccounts()
        {
            if (AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return GetValues(AccountHelper.GetLiabilityAccounts(AppUsers.GetCurrentUserDB()));
            }

            return null;
        }

        [WebMethod]
        public Collection<ListItem> GetIncomeTaxExpenseAccounts()
        {
            if (AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return GetValues(AccountHelper.GetIncomeTaxExpenseAccounts(AppUsers.GetCurrentUserDB()));
            }

            return null;
        }

        [WebMethod]
        public Collection<ListItem> GetPLAppropriationAccounts()
        {
            if (AppUsers.GetCurrent().View.IsAdmin.ToBool())
            {
                return GetValues(AccountHelper.GetPLAppropriationAccounts(AppUsers.GetCurrentUserDB()));
            }

            return null;
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

        #endregion
    }
}