using System.IO;
using MixERP.Net.Common;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.ReportEngine
{
    [ToolboxData("<{0}:Report runat=server></{0}:Report>")]
    public partial class Report : CompositeControl
    {
        protected override void CreateChildControls()
        {
            this.reportContainer = new Panel();
            this.AddHiddenControls(this.reportContainer);
            this.AddCommandPanel(this.reportContainer);
            this.AddReportBody(this.reportContainer);
            this.Controls.Add(this.reportContainer);
            this.ValidateRequestMode = ValidateRequestMode.Disabled;

            PageUtility.AddMeta(this.Page, "generator", Assembly.GetAssembly(typeof (Report)).GetName().Name);

            if (this.AutoInitialize)
            {
                this.InitializeReport();
            }
        }


        protected override void RecreateChildControls()
        {
            this.EnsureChildControls();
        }

        protected override void Render(HtmlTextWriter w)
        {
            // setup a TextWriter to capture the markup
            TextWriter tw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(tw);

            // render the markup into our surrogate TextWriter
            base.Render(htw);

            // get the captured markup as a string
            string pageSource = tw.ToString(); 
            this.Html = pageSource;
            this.reportContainer.RenderControl(w);
        }
    }
}