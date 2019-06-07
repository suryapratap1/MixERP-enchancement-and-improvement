using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;

namespace MixERP.Net.FrontEnd.Base
{
    public class MixERPWebService : WebService
    {
        public MixERPWebService()
        {
            this.Catalog = AppUsers.GetCurrentUserDB();
            this.UserId = AppUsers.GetCurrent().View.UserId.ToInt();
            this.OfficeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
        }

        public string Catalog { get; private set; }
        public int UserId { get; private set; }
        public int OfficeId { get; private set; }
    }
}