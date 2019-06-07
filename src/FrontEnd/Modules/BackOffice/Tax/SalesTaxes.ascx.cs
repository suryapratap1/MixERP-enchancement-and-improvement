using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;
using System.Collections.Generic;

namespace MixERP.Net.Core.Modules.BackOffice.Tax
{
    public partial class SalesTaxes : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
        }

        private static string GetDisplayFields()
        {
            List<string> displayFields = new List<string>();
            ScrudHelper.AddDisplayField(displayFields, "core.tax_master.tax_master_id",
                DbConfig.GetDbParameter(AppUsers.GetCurrentUserDB(), "TaxMasterDisplayField"));
            ScrudHelper.AddDisplayField(displayFields, "office.offices.office_id",
                DbConfig.GetDbParameter(AppUsers.GetCurrentUserDB(), "OfficeDisplayField"));
            ScrudHelper.AddDisplayField(displayFields, "core.tax_base_amount_types.tax_base_amount_type_code",
                DbConfig.GetDbParameter(AppUsers.GetCurrentUserDB(), "TaxBaseAmountTypeDisplayField"));
            return string.Join(",", displayFields);
        }

        private static string GetDisplayViews()
        {
            List<string> displayViews = new List<string>();
            ScrudHelper.AddDisplayView(displayViews, "core.tax_master.tax_master_id", "core.tax_master_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "office.offices.office_id", "office.office_scrud_view");
            ScrudHelper.AddDisplayView(displayViews, "core.tax_base_amount_types.tax_base_amount_type_code",
                "core.tax_base_amount_type_selector_view");
            return string.Join(",", displayViews);
        }
    }
}