using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Entities.Core;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class WidgetManager : WebService
    {
        [WebMethod]
        public void RemoveWidget(string group, string widget)
        {
            Data.Core.Widget.RemoveWidget(AppUsers.GetCurrentUserDB(), group, widget);
        }

        [WebMethod]
        public void AddWidget(int order, string group, string widget)
        {
            Data.Core.Widget.AddWidget(AppUsers.GetCurrentUserDB(), order, group, widget);
        }

        [WebMethod]
        public void OrderWidgets(List<WidgetSetup> widgets)
        {
            Data.Core.Widget.OrderWidgets(AppUsers.GetCurrentUserDB(), widgets);
        }

    }
}