using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MixERP.Net.Common.Extensions;

namespace MixERP.Net.Core.Modules.Sales.Reports
{
    public partial class SalesByOfficeFrame : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            list.Add(new KeyValuePair<string, object>("@office_id", AppUsers.GetCurrent().View.OfficeId.ToInt() ));

            using (WebReport report = new WebReport())
            {
                report.AutoInitialize = true;
                report.NoHeader = true;
                report.AddParameterToCollection (list);
                report.Path = "~/Modules/Sales/Reports/Source/SalesByOffice.xml";
                this.Controls.Add(report);
            }
        }
    }
}