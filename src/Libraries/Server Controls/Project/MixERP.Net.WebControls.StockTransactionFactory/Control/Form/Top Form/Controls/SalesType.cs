using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void AddSalesTypeField(HtmlGenericControl container)
        {
            using (HtmlGenericControl salesTypeDiv = HtmlControlHelper.GetField())
            {
                salesTypeDiv.ID = "SalesTypeDiv";
                salesTypeDiv.Attributes.Add("style", "width:200px");

                using (HtmlGenericControl field = HtmlControlHelper.GetField())
                {
                    using (HtmlGenericControl label = HtmlControlHelper.GetLabel(Titles.SalesType, "SalesTypeSelect"))
                    {
                        field.Controls.Add(label);
                    }

                    using (HtmlSelect salesTypeSelect = new HtmlSelect())
                    {
                        salesTypeSelect.ID = "SalesTypeSelect";
                        salesTypeSelect.DataSource = this.GetSalesTypes();
                        salesTypeSelect.DataTextField = "Text";
                        salesTypeSelect.DataValueField = "Value";
                        salesTypeSelect.DataBind();

                        field.Controls.Add(salesTypeSelect);
                    }

                    salesTypeDiv.Controls.Add(field);
                }

                container.Controls.Add(salesTypeDiv);
            }
        }

        private IEnumerable<ListItem> GetSalesTypes()
        {
            Collection<ListItem> items = new Collection<ListItem>();

            items.Add(new ListItem(Titles.TaxableSales, "1"));
            items.Add(new ListItem(Titles.NonTaxableSales, "0"));

            return items;
        }
    }
}