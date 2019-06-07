using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.ApplicationState;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Finance.Data.Helpers;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.Common.Helpers;
using Serilog;
using System;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MixERP.Net.Core.Modules.Finance.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Transactions : WebService
    {
        [WebMethod]
        public long Approve(long tranId, string reason)
        {
            try
            {
                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();
                const int verificationStatusId = 2;

                return Transaction.Verify(AppUsers.GetCurrentUserDB(), tranId, officeId, userId, loginId, verificationStatusId,
                    reason);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not approve transaction #{TranId} with reason {Reason}. {Exception}", tranId, reason,
                    ex);
                throw;
            }

            return 0;
        }

        [WebMethod]
        public decimal GetExchangeRate(string currencyCode)
        {
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            decimal exchangeRate = Transaction.GetExchangeRate(AppUsers.GetCurrentUserDB(), officeId, currencyCode);

            return exchangeRate;
        }

        [WebMethod]
        public long Reject(long tranId, string reason)
        {
            try
            {
                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();
                const int verificationStatusId = -3;

                return Transaction.Verify(AppUsers.GetCurrentUserDB(), tranId, officeId, userId, loginId, verificationStatusId,
                    reason);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not reject transaction #{TranId} with reason {Reason}. {Exception}", tranId, reason,
                    ex);
                throw;
            }

            return 0;
        }

        [WebMethod]
        public bool Reconcile(string tranCode, int year, int month, int day)
        {
            DateTime bookDate = new DateTime(year, month, day);
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            FrequencyDates model = DatePersister.GetFrequencyDates(catalog, officeId);


            if (bookDate > model.FiscalYearEndDate)
            {
                throw new MixERPException(Warnings.InvalidDate);
            }

            return Transaction.Reconcile(AppUsers.GetCurrentUserDB(), tranCode, bookDate);
        }
    }
}