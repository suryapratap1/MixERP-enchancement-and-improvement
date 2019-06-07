using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Sales.Widgets
{
    public partial class TopSellingProductOfAllTimeWidget : MixERPWidget
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.TopSellingProductsLiteral.Text = Titles.TopSellingProductsOfAllTime;

            this.TopSellingProductsGridView.Attributes.Add("style", "display:none;");
            this.TopSellingProductsGridView.DataSource = Data.Reports.TopSellingProducts.GetTopSellingProductsOfAllTimeByOffice(AppUsers.GetCurrentUserDB());
            this.TopSellingProductsGridView.DataBind();
        }
    }
}