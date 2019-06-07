using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using Serilog;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MixERP.Net.Core.Modules.Purchase.Services.Entry
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Reorder : WebService
    {
        [WebMethod]
        public bool Save(Collection<Data.Models.Reorder> details)
        {
            try
            {
                if (details == null)
                {
                    throw new ArgumentNullException("details");
                }

                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();
                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

                return Data.Transactions.Reorder.Save(AppUsers.GetCurrentUserDB(), loginId, userId, officeId, details);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save purchase reorder entry. {Exception}", ex);
                throw;
            }
        }
    }
}