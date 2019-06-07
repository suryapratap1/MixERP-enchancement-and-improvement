using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Entities.Core;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace MixERP.Net.FrontEnd.Dashboard
{
    public partial class Index : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.IsLandingPage = true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var widgets = Data.Core.Widget.GetDefaultWidgets(AppUsers.GetCurrentUserDB());
            this.LoadWidgets(widgets, this.WidgetPlaceholder, this.Page);
        }

        public void LoadWidgets(IEnumerable<DefaultWidgetSetupView> widgetModels, Control placeholder, TemplateControl page)
        {
            if (placeholder == null)
            {
                return;
            }

            if (page == null)
            {
                return;
            }

            if (widgetModels == null)
            {
                return;
            }

            foreach (DefaultWidgetSetupView item in widgetModels.OrderBy(x => x.WidgetOrder))
            {
                using (MixERPWidget widget = page.LoadControl(item.WidgetSource) as MixERPWidget)
                {
                    if (widget != null)
                    {
                        placeholder.Controls.Add(widget);
                        widget.OnControlLoad(widget, new EventArgs());
                    }
                }
            }
        }

    }
}