using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Sales.Widgets
{
    public partial class TopSellingProductOfAllTimeCurrentWidget : MixERPWidget
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.TopSellingProductsLiteral.Text = Titles.TopSellingProductsOfAllTime;

            this.TopSellingProductsOfAllTimeGridView.Attributes.Add("style", "display:none;");
            this.TopSellingProductsOfAllTimeGridView.DataSource = Data.Reports.TopSellingProducts.GetTopSellingProductsOfAllTime(AppUsers.GetCurrentUserDB());
            this.TopSellingProductsOfAllTimeGridView.DataBind();
        }
    }
}