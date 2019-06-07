using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Entities.Core;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.FrontEnd.Modules
{
    public partial class WidgetManager : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.BindGroups();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadWidgets();
        }

        private void LoadWidgets()
        {
            string group = this.WidgetDropDownList.SelectedValue;

            this.SelectedWidgetPlaceholder.Controls.Clear();
            this.OtherWidgetPlaceholder.Controls.Clear();

            var selected = Data.Core.Widget.GetWidgetSetupView(AppUsers.GetCurrentUserDB(), group).ToList();
            this.LoadSelectedWidgets(selected, this.SelectedWidgetPlaceholder, this.Page);

            var other = Data.Core.Widget.GetNonSelectedWidgets(AppUsers.GetCurrentUserDB(), group).ToList();
            this.LoadOtherWidgets(other, this.OtherWidgetPlaceholder, this.Page);
        }

        public void BindGroups()
        {
            this.WidgetDropDownList.DataSource = Data.Core.Widget.GetGroups(AppUsers.GetCurrentUserDB());
            this.WidgetDropDownList.DataTextField = "WidgetGroupName";
            this.WidgetDropDownList.DataValueField = "WidgetGroupName";
            this.WidgetDropDownList.DataBind();

            string group = this.Request.QueryString["Group"];

            if (!string.IsNullOrWhiteSpace(group))
            {
                this.WidgetDropDownList.SelectedValue = group;
            }
        }

        public void LoadOtherWidgets(List<Widget> widgetModels, Control placeholder, TemplateControl page)
        {
            if (placeholder == null)
            {
                return;
            }

            if (page == null)
            {
                return;
            }

            if (widgetModels == null || widgetModels.Count().Equals(0))
            {
                this.AppendNotFoundMessage(placeholder);
                return;
            }

            foreach (Widget item in widgetModels.OrderBy(x => x.WidgetId))
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

        public void LoadSelectedWidgets(List<WidgetSetupView> widgetModels, Control placeholder, TemplateControl page)
        {
            if (placeholder == null)
            {
                return;
            }

            if (page == null)
            {
                return;
            }

            if (widgetModels == null || widgetModels.Count().Equals(0))
            {
                this.AppendNotFoundMessage(placeholder);
                return;
            }


            foreach (WidgetSetupView item in widgetModels.OrderBy(x => x.WidgetOrder))
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

        private void AppendNotFoundMessage(Control control)
        {
            using (HtmlGenericControl column = new HtmlGenericControl("div"))
            {
                column.Attributes.Add("class", "sixteen wide column");

                using (HtmlGenericControl message = new HtmlGenericControl("div"))
                {
                    message.Attributes.Add("class", "ui purple message");
                    message.InnerText = Labels.NoWidgetFound;

                    column.Controls.Add(message);
                    control.Controls.Add(column);
                }
            }
        }
    }
}