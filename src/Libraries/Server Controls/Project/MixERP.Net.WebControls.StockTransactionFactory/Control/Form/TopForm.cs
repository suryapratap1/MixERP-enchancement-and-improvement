using MixERP.Net.Common.Helpers;
using MixERP.Net.Entities;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private readonly string[] numbers = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

        private void CreateTopFormPanel(Control container)
        {
            using (HtmlGenericControl segment = HtmlControlHelper.GetSegment())
            {
                using (HtmlGenericControl form = new HtmlGenericControl("div"))
                {
                    form.Attributes.Add("class", "ui stackable form");

                    var totalFields = this.CountTopFormControls();

                    using (HtmlGenericControl fields = HtmlControlHelper.GetFields(this.numbers[totalFields] + " fields"))
                    {
                        this.AddTopFormControls(fields);

                        form.Controls.Add(fields);
                    }

                    segment.Controls.Add(form);

                }

                container.Controls.Add(segment);
            }


            using (HtmlGenericControl form = HtmlControlHelper.GetForm())
            {
                using (HtmlGenericControl fields = HtmlControlHelper.GetFields("two fields"))
                {
                    if (this.ShowShippingInformation)
                    {
                        AddShippingAddressCompositeField(fields);
                    }

                    if (this.Book == TranBook.Sales && this.ShowSalesType)
                    {
                        this.AddSalesTypeField(fields);
                    }

                    form.Controls.Add(fields);
                }

                container.Controls.Add(form);
            }
        }
    }
}