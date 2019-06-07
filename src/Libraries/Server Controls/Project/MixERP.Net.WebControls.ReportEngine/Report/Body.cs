using MixERP.Net.Common.Helpers;
using System.IO;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        private void AddReportBody(Panel container)
        {
            this.reportBody = new Panel();
            this.reportBody.ID = "report";

            if (!this.NoHeader)
            {
                this.header = new ReportHeader();
                this.header.Path = ConfigurationHelper.GetReportParameter("HeaderPath");
                this.reportBody.Controls.Add(this.header);
            }

            this.reportTitleLiteral = new Literal();
            this.reportBody.Controls.Add(this.reportTitleLiteral);

            this.topSectionLiteral = new Literal();
            this.reportBody.Controls.Add(this.topSectionLiteral);

            this.bodyContentsLiteral = new Literal();
            this.reportBody.Controls.Add(this.bodyContentsLiteral);

            this.gridPlaceHolder = new PlaceHolder();
            this.reportBody.Controls.Add(this.gridPlaceHolder);

            this.bottomSectionLiteral = new Literal();
            this.reportBody.Controls.Add(this.bottomSectionLiteral);

            container.Controls.Add(this.reportBody);
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(this.Path))
            {
                return false;
            }

            this.reportPath = this.Page.Server.MapPath(this.Path);

            if (!File.Exists(this.reportPath))
            {
                return false;
            }

            return true;
        }
    }
}