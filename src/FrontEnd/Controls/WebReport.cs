using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.WebControls.ReportEngine;

namespace MixERP.Net.FrontEnd.Controls
{
    public sealed class WebReport : Report
    {
        public WebReport()
        {
            this.Catalog = AppUsers.GetCurrentUserDB();
        }
    }
}