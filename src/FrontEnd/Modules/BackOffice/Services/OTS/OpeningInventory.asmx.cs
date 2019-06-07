using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Entities.Transactions;
using Serilog;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace MixERP.Net.Core.Modules.BackOffice.Services.OTS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class OpeningInventory : WebService
    {
        [WebMethod]
        public long Save(DateTime valueDate, string referenceNumber, string statementReference, string jsonDetails)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(jsonDetails))
                {
                    return 0;
                }

                int userId = AppUsers.GetCurrent().View.UserId.ToInt();
                int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
                long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

                Collection<OpeningStockType> details = this.GetStockDetails(jsonDetails);

                return Data.OneTimeSetup.OpeningInventory.Save(AppUsers.GetCurrentUserDB(), officeId, userId, loginId, valueDate, referenceNumber, statementReference, details);
            }
            catch (Exception ex)
            {
                Log.Warning("Could not save opening inventory entry. {Exception}", ex);
                throw;
            }
        }

        private Collection<OpeningStockType> GetStockDetails(string json)
        {
            Collection<OpeningStockType> details = new Collection<OpeningStockType>();
            JavaScriptSerializer jss = new JavaScriptSerializer();

            dynamic result = jss.Deserialize<dynamic>(json);

            if (result != null)
            {
                foreach (dynamic item in result)
                {
                    OpeningStockType detail = new OpeningStockType();
                    detail.ItemCode = item[0];
                    detail.StoreName = item[2];
                    detail.Quantity = Conversion.TryCastInteger(item[3]);
                    detail.UnitName = item[4];
                    detail.Amount = Conversion.TryCastDecimal(item[5]);

                    details.Add(detail);
                }
            }

            return details;
        }


    }
}