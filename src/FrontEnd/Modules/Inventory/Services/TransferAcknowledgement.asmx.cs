using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Core.Modules.Inventory.Data.Transactions;
using MixERP.Net.Framework;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.Core.Modules.Inventory.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class TransferAcknowledgement : WebService
    {
        [WebMethod]
        public long Receive(long tranId)
        {
            bool isAdmin = AppUsers.GetCurrent().View.IsAdmin.ToBool();

            if (!isAdmin)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            if (tranId <= 0)
            {
                throw new MixERPException(Warnings.AccessIsDenied);
            }

            int userId = AppUsers.GetCurrent().View.UserId.ToInt();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            long loginId = AppUsers.GetCurrent().View.LoginId.ToLong();

            return StockTransferAcknowledgement.Receive(AppUsers.GetCurrentUserDB(), officeId, userId, loginId, tranId);
        }
    }
}