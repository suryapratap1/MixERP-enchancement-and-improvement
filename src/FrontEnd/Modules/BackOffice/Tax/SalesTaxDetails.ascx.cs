using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Collections.Generic;

namespace MixERP.Net.Core.Modules.BackOffice.Tax
{
    public partial class SalesTaxDetails : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
        }

        private static string GetDisplayViews()
        {
            List<string> displayViews = new List<string>();
            ScrudHelper.AddDisplayView(displayViews, "core.sales_tax_types.sales_tax_type_id",
                "core.sales_tax_type_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.sales_taxes.sales_tax_id", "core.sales_tax_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.state_sales_taxes.state_sales_tax_id",
                "core.state_sales_tax_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.county_sales_taxes.county_sales_tax_id",
                "core.county_sales_tax_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.tax_rate_types.tax_rate_type_code",
                "core.tax_rate_type_selector_view");
            ScrudHelper.AddDisplayView(displayViews, "core.tax_authorities.tax_authority_id",
                "core.tax_authority_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.accounts.account_id", "core.account_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.rounding_methods.rounding_method_code",
                "core.rounding_method_selector_view");
            return string.Join(",", displayViews);
        }
    }
}