using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.FrontEnd.Models;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class Menu : WebService
    {
        [WebMethod]
        public string GetMenus()
        {
            LoginView view = AppUsers.GetCurrent().View;

            string catalog = AppUsers.GetCurrentUserDB();
            int userId = view.UserId.ToInt();
            int officeId = view.OfficeId.ToInt();
            string culture = view.Culture;

            Navigation nav = new Navigation(catalog, userId, officeId, culture);
            var menus = nav.GetMenus();
            return JsonConvert.SerializeObject(menus);
        }
    }
}