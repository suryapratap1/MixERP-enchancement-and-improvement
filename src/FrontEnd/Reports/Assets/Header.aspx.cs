using MixERP.Net.FrontEnd.Base;
using MixERP.Net.WebControls.ReportEngine;
using System;

namespace MixERP.Net.FrontEnd.Reports.Assets
{
    public partial class Header : MixERPWebpage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ReportHeader header = new ReportHeader())
            {
                this.Placeholder1.Controls.Add(header);
            }
        }
    }
}