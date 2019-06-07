using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.ReportEngine.Helpers;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        private string GetImageButtonCssClass()
        {
            string cssClass = this.ImageButtonCssClass;

            if (string.IsNullOrWhiteSpace(cssClass))
            {
                cssClass = ConfigurationHelper.GetReportParameter("ImageButtonCssClass");
            }

            return cssClass;
        }

        private void AddCommandPanel(Panel p)
        {
            this.commandPanel = new Panel();
            this.commandPanel.ID = "ReportParameterPanel";
            this.commandPanel.CssClass = "report-command hide";

            this.AddPdfLinkButton(this.commandPanel);
            this.AddWordLinkButton(this.commandPanel);
            this.AddExcelLinkButton(this.commandPanel);
            //this.AddEmailLinkButton(this.commandPanel);
            this.AddPrintAnchor(this.commandPanel);
            this.AddGoTopAnchor(this.commandPanel);
            this.AddGoBottomAnchor(this.commandPanel);
            this.AddFilterAnchor(this.commandPanel);
            this.AddCloseAnchor(this.commandPanel);

            p.Controls.Add(this.commandPanel);
        }

        private void AddEmailLinkButton(Panel p)
        {
            this.emailImageButton = new LinkButton();
            this.emailImageButton.ID = "SendEmailImageButton";
            this.emailImageButton.CssClass = this.GetImageButtonCssClass();
            this.emailImageButton.Text = "<i class='mail icon'></i>";

            this.emailImageButton.OnClientClick = "return updateReportHidden();";
            this.emailImageButton.ToolTip = Titles.Email;


            p.Controls.Add(this.emailImageButton);
        }

        private void AddWordLinkButton(Panel p)
        {
            this.wordLinkButton = new LinkButton();
            this.wordLinkButton.ID = "WordAnchor";
            this.wordLinkButton.CssClass = this.GetImageButtonCssClass();
            this.wordLinkButton.Text = "<i class='file word outline icon'></i>";

            this.wordLinkButton.OnClientClick = "return updateReportHidden();";
            this.wordLinkButton.ToolTip = Titles.ExportToDoc;
            this.wordLinkButton.Click += delegate
            {
                string html = this.reportHidden.Value;
                ExportHelper.DownloadWord(html);
            };


            p.Controls.Add(this.wordLinkButton);
        }

        private void AddExcelLinkButton(Panel p)
        {
            this.excelLinkButton = new LinkButton();
            this.excelLinkButton.ID = "ExcelAnchor";
            this.excelLinkButton.CssClass = this.GetImageButtonCssClass();
            this.excelLinkButton.Text = "<i class='file excel outline icon'></i>";

            this.excelLinkButton.OnClientClick = "return updateReportHidden();";
            this.excelLinkButton.ToolTip = Titles.ExportToExcel;
            this.excelLinkButton.Click += delegate
            {
                string html = this.reportHidden.Value;
                ExportHelper.DownloadExcel(html);
            };


            p.Controls.Add(this.excelLinkButton);
        }

        private void AddPdfLinkButton(Panel p)
        {
            this.pdfLinkButton = new LinkButton();
            this.pdfLinkButton.ID = "PdfAnchor";
            this.pdfLinkButton.CssClass = this.GetImageButtonCssClass();
            this.pdfLinkButton.Text = "<i class='file pdf outline icon'></i>";

            this.pdfLinkButton.OnClientClick = "return updateReportHiddenPdf();";
            this.pdfLinkButton.ToolTip = Titles.ExportToPDF;
            this.pdfLinkButton.Click += delegate
            {
                string html = this.reportHidden.Value;
                ExportHelper.DownloadPdf(html);
            };


            p.Controls.Add(this.pdfLinkButton);
        }

        private void AddPrintAnchor(Panel p)
        {
            this.printAnchor = new HtmlAnchor();
            this.printAnchor.ID = "PrintImageButton";
            this.printAnchor.Attributes.Add("class", this.GetImageButtonCssClass());
            this.printAnchor.Attributes.Add("onclick", "javascript:window.print();");
            this.printAnchor.Title = Titles.Print;

            using (HtmlGenericControl i = HtmlControlHelper.GetIcon("print icon"))
            {
                this.printAnchor.Controls.Add(i);
            }

            p.Controls.Add(this.printAnchor);
        }

        private void AddGoTopAnchor(Panel p)
        {
            this.goTopAnchor = new HtmlAnchor();
            this.goTopAnchor.ID = "GoTop";
            this.goTopAnchor.Attributes.Add("class", this.GetImageButtonCssClass());
            this.goTopAnchor.Attributes.Add("onclick", "window.scrollTo(0, 0);");
            this.goTopAnchor.Title = Titles.GoToTop;

            using (HtmlGenericControl i = HtmlControlHelper.GetIcon("arrow up icon"))
            {
                this.goTopAnchor.Controls.Add(i);
            }


            p.Controls.Add(this.goTopAnchor);
        }

        private void AddGoBottomAnchor(Panel p)
        {
            this.goBottomAnchor = new HtmlAnchor();
            this.goBottomAnchor.Attributes.Add("class", this.GetImageButtonCssClass());
            this.goBottomAnchor.ID = "GoBottom";
            this.goBottomAnchor.Attributes.Add("onclick", "window.scrollTo(0,document.body.scrollHeight);");
            this.goBottomAnchor.Title = Titles.GoToBottom;

            using (HtmlGenericControl i = HtmlControlHelper.GetIcon("arrow down icon"))
            {
                this.goBottomAnchor.Controls.Add(i);
            }

            p.Controls.Add(this.goBottomAnchor);
        }

        private void AddFilterAnchor(Panel p)
        {
            this.filterAnchor = new HtmlAnchor();
            this.filterAnchor.ID = "FilterImageButton";
            this.filterAnchor.Attributes.Add("class", this.GetImageButtonCssClass());
            this.filterAnchor.Attributes.Add("onclick", "$('.report-parameter').toggle(500);return false;");

            this.filterAnchor.Title = Titles.Filter;


            using (HtmlGenericControl i = HtmlControlHelper.GetIcon("filter icon"))
            {
                this.filterAnchor.Controls.Add(i);
            }

            p.Controls.Add(this.filterAnchor);
        }

        private void AddCloseAnchor(Panel p)
        {
            this.closeImageButton = new HtmlAnchor();
            this.closeImageButton.Attributes.Add("class", this.GetImageButtonCssClass());
            this.closeImageButton.ID = "CloseImageButton";
            this.closeImageButton.Attributes.Add("onclick", "closeWindow();");

            this.closeImageButton.Title = Titles.Close;


            using (HtmlGenericControl i = HtmlControlHelper.GetIcon("close icon"))
            {
                this.closeImageButton.Controls.Add(i);
            }

            p.Controls.Add(this.closeImageButton);
        }
    }
}