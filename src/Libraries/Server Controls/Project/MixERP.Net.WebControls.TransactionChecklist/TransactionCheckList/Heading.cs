using MixERP.Net.i18n.Resources;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        private Literal titleLiteral;
        private Label verificationLabel;
        private HtmlGenericControl subTitleHeading;

        private void AddBreak(HtmlGenericControl p)
        {
            using (HtmlGenericControl line = new HtmlGenericControl())
            {
                line.TagName = "br";
                p.Controls.Add(line);
            }
        }

        private void AddHeader(HtmlGenericControl p)
        {
            this.AddTitle(p);
            this.AddRuler(p);
            this.AddSubtitle(p);
            this.AddRuler(p);
            this.AddVerificationLabel(p);
            this.AddBreak(p);
        }

        private void AddRuler(HtmlGenericControl p)
        {
            using (HtmlGenericControl ruler = new HtmlGenericControl("hr"))
            {
                ruler.Attributes.Add("class", "ui divider");
                p.Controls.Add(ruler);
            }
        }

        private void AddSubtitle(HtmlGenericControl p)
        {
            this.subTitleHeading = new HtmlGenericControl();
            this.subTitleHeading.TagName = "h2";
            this.subTitleHeading.InnerText = Labels.TransactionPostedSuccessfully;
            p.Controls.Add(this.subTitleHeading);
        }

        private void AddTitle(HtmlGenericControl p)
        {
            using (HtmlGenericControl titleHeading = new HtmlGenericControl())
            {
                titleHeading.TagName = "h1";
                this.titleLiteral = new Literal();
                this.titleLiteral.Text = this.Text;
                titleHeading.Controls.Add(this.titleLiteral);
                p.Controls.Add(titleHeading);
            }
        }
        private void AddVerificationLabel(HtmlGenericControl p)
        {
            this.verificationLabel = new Label();
            this.ShowVerificationStatus(this.GetTranId(), this.verificationLabel);
            p.Controls.Add(this.verificationLabel);
        }
    }
}