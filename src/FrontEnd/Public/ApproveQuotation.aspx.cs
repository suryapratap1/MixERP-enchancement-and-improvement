using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MixERP.Net.Entities.Public.Meta;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n;
using MixERP.Net.i18n.Resources;

namespace MixERP.Net.FrontEnd.Public
{
    public partial class ApproveQuotation : System.Web.UI.Page
    {
        private SalesQuotationValidation quotation;

        protected void Page_Init(object sender, EventArgs e)
        {
            string validationId = this.Page.Request.QueryString["ValidationId"];

            if (string.IsNullOrWhiteSpace(validationId))
            {
                this.DisplayError(Warnings.AccessIsDenied);
                return;
            }

            this.quotation = Data.Public.ApproveQuotation.GetQuotation(validationId);

            if (this.quotation == null || this.quotation.TranId <= 0)
            {
                this.DisplayError(Warnings.AccessIsDenied);
                return;
            }

            if (this.quotation.Accepted)
            {
                this.DisplayError(string.Format(Labels.SalesQuotationAlreadyAccepted, this.quotation.AcceptedOn));
                return;
            }


            string catalog = this.quotation.Catalog;

            Collection<KeyValuePair<string, object>> list = new Collection<KeyValuePair<string, object>>();
            list.Add(new KeyValuePair<string, object>("@non_gl_stock_master_id", this.quotation.TranId));

            using (WebReport report = new WebReport())
            {
                report.Catalog = catalog;
                report.NoHeader = true;
                report.AddParameterToCollection(list);
                report.AddParameterToCollection(list);
                report.AutoInitialize = true;
                report.Path = "~/Modules/Sales/Reports/Source/Sales.Quotation.xml";

                this.Placeholder1.Controls.Add(report);
            }

            this.AcceptButton.Text = Titles.Accept;
            this.AcceptButton.Visible = true;
            this.AcceptButton.Enabled = this.IsValid();
        }

        private void DisplayError(string message)
        {
            this.MessageLabel.Text = message;
            this.MessageLabel.CssClass = "ui red small message";
            this.MessageLabel.Visible = true;
        }

        private void DisplayMessage(string message)
        {
            this.MessageLabel.Text = message;
            this.MessageLabel.CssClass = "ui small positive message";
            this.MessageLabel.Visible = true;
        }

        private bool IsValid()
        {
            if (this.quotation.ValidTill < DateTime.Now)
            {
                this.DisplayError(string.Format(CultureManager.GetCurrent(), Labels.SalesQuotationExpired, this.quotation.ValidTill));
                return false;
            }

            return true;
        }

        protected void AcceptButton_OnClick(object sender, EventArgs e)
        {
            if (!this.IsValid())
            {
                return;
            }


            Data.Public.ApproveQuotation.AcceptQuote(this.quotation.ValidationId);
            this.DisplayMessage(Titles.ThankYou);
            this.AcceptButton.Visible = false;
        }
    }
}