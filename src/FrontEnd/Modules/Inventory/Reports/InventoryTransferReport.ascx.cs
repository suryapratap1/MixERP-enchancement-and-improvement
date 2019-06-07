using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;

namespace MixERP.Net.Core.Modules.Inventory.Reports
{
    public partial class InventoryTransferReport : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            list.Add(new KeyValuePair<string, object>("@transaction_master_id", this.Page.Request["TranId"]));

            using (WebReport report = new WebReport())
            {
                report.AddParameterToCollection(list);
                report.AddParameterToCollection(list);
                report.AutoInitialize = true;
                report.Path = "~/Modules/Inventory/Reports/Source/Inventory.Transfer.xml";

                this.Controls.Add(report);
            }
        }
    }
}