using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        private void AddHiddenControls(Panel p)
        {
            this.reportHidden = new HiddenField();
            this.reportHidden.ID = "ReportHidden";
            p.Controls.Add(this.reportHidden);

            this.reportTitleHidden = new HiddenField();
            this.reportTitleHidden.ID = "ReportTitleHidden";
            p.Controls.Add(this.reportTitleHidden);
        }
    }
}