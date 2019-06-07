using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Sales.Widgets
{
    public partial class CurrentOfficeSalesByMonthWidget : MixERPWidget
    {
        public override AccessLevel AccessLevel
        {
            get { return AccessLevel.PolicyBased; }
        }

        public override void OnControlLoad(object sender, EventArgs e)
        {
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();
            string catalog = AppUsers.GetCurrentUserDB();

            this.TitleLiteral.Text = Titles.SalesByMonthInThousands;

            this.SalesByMonthGridView.Attributes.Add("style", "display:none;");
            this.SalesByMonthGridView.DataSource = Data.Reports.SalesByMonth.GetSalesByOffice(catalog, officeId);
            this.SalesByMonthGridView.DataBind();
        }
    }
}