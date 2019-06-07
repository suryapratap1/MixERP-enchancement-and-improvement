using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Core.Modules.Sales.Data.Reports;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.Common;
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.Core.Modules.Sales.Widgets
{
    public partial class SalesByGeographyWidget : MixERPWidget
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.CreateGridView(this.Placeholder1);
            this.CreateWidget(this.Placeholder1);
        }

        private void CreateGridView(Control container)
        {
            using (MixERPGridView grid = new MixERPGridView())
            {
                grid.ID = "SalesByGeographyGridView";
                grid.CssClass = "initially hidden";
                grid.DataSource = SalesByGeography.GetSalesByCountry(AppUsers.GetCurrentUserDB());
                grid.DataBind();

                container.Controls.Add(grid);
            }
        }

        private void CreateWidget(Control container)
        {
            using (HtmlGenericControl widget = new HtmlGenericControl("div"))
            {
                widget.ID = "SalesByGeographyWidget";
                widget.Attributes.Add("class", "sixteen wide column widget");

                using (HtmlGenericControl segment = new HtmlGenericControl("div"))
                {
                    segment.Attributes.Add("class", "ui attached segment");

                    using (HtmlGenericControl leftFloatedColumn = new HtmlGenericControl("div"))
                    {
                        leftFloatedColumn.Attributes.Add("class", "ui left floated column");

                        using (HtmlGenericControl header = new HtmlGenericControl("div"))
                        {
                            header.Attributes.Add("class", "ui header");
                            header.InnerText = Titles.WorldSalesStatistics;
                            leftFloatedColumn.Controls.Add(header);
                        }

                        segment.Controls.Add(leftFloatedColumn);
                    }

                    using (HtmlGenericControl rightFloatedColumn = new HtmlGenericControl("div"))
                    {
                        rightFloatedColumn.Attributes.Add("class", "right floated column");

                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("expand disabled icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("move icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("help icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }
                        using (HtmlGenericControl i = HtmlControlHelper.GetIcon("close icon"))
                        {
                            rightFloatedColumn.Controls.Add(i);
                        }

                        segment.Controls.Add(rightFloatedColumn);
                    }
                    widget.Controls.Add(segment);
                }

                using (HtmlGenericControl bottomAttachedSegment = new HtmlGenericControl("div"))
                {
                    bottomAttachedSegment.Attributes.Add("class", "ui attached segment");
                    using (HtmlGenericControl mapContainer = new HtmlGenericControl("div"))
                    {
                        mapContainer.ID = "map-container";
                        mapContainer.Attributes.Add("style", "height: 400px; width: 980px;");
                        bottomAttachedSegment.Controls.Add(mapContainer);
                    }

                    widget.Controls.Add(bottomAttachedSegment);
                }

                container.Controls.Add(widget);
            }
        }
    }
}