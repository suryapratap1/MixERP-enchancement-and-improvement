using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Sales.Widgets
{
    public partial class SalesByOfficeWidget : MixERPWidget
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.TitleLiteral.Text = Titles.SalesByOfficeInThousands;

            this.SalesByOfficeGridView.Attributes.Add("style", "display:none;");
            this.SalesByOfficeGridView.DataSource = Data.Reports.SalesByMonth.GetSalesByOffice(AppUsers.GetCurrentUserDB());
            this.SalesByOfficeGridView.DataBind();
        }
    }
}