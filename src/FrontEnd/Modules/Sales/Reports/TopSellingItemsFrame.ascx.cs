using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using System;

namespace MixERP.Net.Core.Modules.Sales.Reports
{
    public partial class TopSellingItemsFrame : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (WebReport report = new WebReport())
            {
                report.AutoInitialize = true;
                report.NoHeader = true;
                report.Path = "~/Modules/Sales/Reports/Source/TopSellingProductsOfAllTime.xml";
                this.Controls.Add(report);
            }
        }
    }
}