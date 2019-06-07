using MixERP.Net.ApplicationState;
using MixERP.Net.Common.jQueryHelper;
using MixERP.Net.Entities;
using MixERP.Net.i18n.Resources;
using MixERP.Net.WebControls.Common.Helpers;
using System;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using MixERP.Net.i18n;

namespace MixERP.Net.WebControls.Common
{
    [ToolboxData("<{0}:DateTextBox runat=server></{0}:DateTextBox>")]
    public sealed partial class DateTextBox : CompositeControl
    {
        public CompareValidator compareValidator;
        public CompareValidator maxDateCompareValidator;
        public RequiredFieldValidator requiredValidator;
        public TextBox textBox;

        protected override void CreateChildControls()
        {
            this.Controls.Clear();

            this.textBox = new TextBox();
            this.textBox.ID = this.ID;
            this.textBox.CssClass = "date";

            this.AddMinDateValidator();
            this.AddMaxDateValidator();

            this.requiredValidator = new RequiredFieldValidator();
            this.requiredValidator.Display = ValidatorDisplay.Static;

            this.requiredValidator.ID = this.ID + "RequiredFieldValidator";
            this.requiredValidator.ControlToValidate = this.ID;
            this.requiredValidator.ErrorMessage = CommonResource.RequiredField;
            this.requiredValidator.EnableClientScript = true;
            this.requiredValidator.CssClass = this.ValidatorCssClass;
            this.requiredValidator.SetFocusOnError = true;

            this.Controls.Add(this.textBox);

            if (this.Required)
            {
                this.Controls.Add(this.requiredValidator);
            }

            if (this.EnableValidation)
            {
                this.Controls.Add(this.compareValidator);
            }

            jQueryUI.AddjQueryUIDatePicker(this.Page, this.textBox.ID, this.MinDate, this.MaxDate);

            base.CreateChildControls();
        }

        protected override void RecreateChildControls()
        {
            this.EnsureChildControls();
            base.RecreateChildControls();
        }

        protected override void Render(HtmlTextWriter w)
        {
            this.EnsureChildControls();
            if (this.textBox != null)
            {
                this.textBox.RenderControl(w);
            }


            if (this.EnableValidation)
            {
                if (this.requiredValidator != null)
                {
                    this.requiredValidator.RenderControl(w);
                }

                if (this.compareValidator != null)
                {
                    this.compareValidator.RenderControl(w);
                }
            }
        }

        private void AddMaxDateValidator()
        {
            if (this.MaxDate == null)
            {
                return;
            }

            this.maxDateCompareValidator = new CompareValidator();
            this.maxDateCompareValidator.Display = ValidatorDisplay.Static;

            this.maxDateCompareValidator.ID = this.ID + "MaxDateCompareValidator";
            this.maxDateCompareValidator.ControlToValidate = this.ID;
            this.maxDateCompareValidator.Type = ValidationDataType.Date;
            this.maxDateCompareValidator.Operator = ValidationCompareOperator.LessThan;

            this.maxDateCompareValidator.EnableClientScript = true;
            this.maxDateCompareValidator.CssClass = this.ValidatorCssClass;
            this.maxDateCompareValidator.SetFocusOnError = true;


            this.maxDateCompareValidator.ValueToCompare = this.MaxDate.ToString();
            this.maxDateCompareValidator.ErrorMessage = string.Format(CultureManager.GetCurrent(), CommonResource.DateMustBeLessThan, this.MinDate);
        }

        private void AddMinDateValidator()
        {
            this.compareValidator = new CompareValidator();
            this.compareValidator.Display = ValidatorDisplay.Static;

            this.compareValidator.ID = this.ID + "CompareValidator";
            this.compareValidator.ControlToValidate = this.ID;
            this.compareValidator.Type = ValidationDataType.Date;
            this.compareValidator.Operator = ValidationCompareOperator.GreaterThan;

            this.compareValidator.EnableClientScript = true;
            this.compareValidator.CssClass = this.ValidatorCssClass;
            this.compareValidator.SetFocusOnError = true;


            if (this.MinDate != null)
            {
                this.compareValidator.ValueToCompare = this.MinDate.ToString();
                this.compareValidator.ErrorMessage = string.Format(CultureManager.GetCurrent(), CommonResource.DateMustBeGreaterThan, this.MinDate);
            }
            else
            {
                this.compareValidator.ValueToCompare = "1/1/1900";
                this.compareValidator.ErrorMessage = CommonResource.InvalidDate;
            }
        }

        private void InitializeDate()
        {
            if (this.officeId.Equals(0))
            {
                return;
            }

            FrequencyDates model = DatePersister.GetFrequencyDates(this.Catalog, this.officeId);

            DateTime date = model.Today;

            switch (this.mode)
            {
                case FrequencyType.MonthStartDate:
                    date = model.MonthStartDate;
                    break;
                case FrequencyType.MonthEndDate:
                    date = model.MonthEndDate;
                    break;
                case FrequencyType.QuarterStartDate:
                    date = model.QuarterStartDate;
                    break;
                case FrequencyType.QuarterEndDate:
                    date = model.QuarterEndDate;
                    break;
                case FrequencyType.HalfStartDate:
                    date = model.FiscalHalfStartDate;
                    break;
                case FrequencyType.HalfEndDate:
                    date = model.FiscalHalfEndDate;
                    break;
                case FrequencyType.FiscalYearStartDate:
                    date = model.FiscalYearStartDate;
                    break;
                case FrequencyType.FiscalYearEndDate:
                    date = model.FiscalYearEndDate;
                    break;
            }


            if (this.textBox != null)
            {
                this.textBox.Text = date.ToShortDateString();
            }
        }
    }
}