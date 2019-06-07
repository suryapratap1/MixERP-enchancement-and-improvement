using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MixERP.Net.Core.Modules.Sales.Reports
{
    public partial class SalesReturnReport : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            list.Add(new KeyValuePair<string, object>("@transaction_master_id", this.Page.Request["TranId"]));
            list.Add(new KeyValuePair<string, object>("@transaction_master_id", this.Page.Request["TranId"]));

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(list);
                report.AddParameterToCollection(list);
                report.AutoInitialize = true;
                report.Path = "~/Modules/Sales/Reports/Source/Sales.Return.xml";

                this.Controls.Add(report);
            }
        }
    }
}