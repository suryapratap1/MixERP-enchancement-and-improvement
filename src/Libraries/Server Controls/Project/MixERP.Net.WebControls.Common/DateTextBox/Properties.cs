using MixERP.Net.Entities;
using System;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.Common
{
    public partial class DateTextBox
    {
        private bool enableValidation;

        private FrequencyType mode;

        public override string CssClass
        {
            get
            {
                this.EnsureChildControls();
                return this.textBox.CssClass;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.CssClass = value;
            }
        }

        public bool Disabled
        {
            get
            {
                this.EnsureChildControls();
                return !this.textBox.Enabled;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.Enabled = !value;
            }
        }

        public bool EnableValidation
        {
            get
            {
                this.EnsureChildControls();
                return this.enableValidation;
            }
            set
            {
                this.EnsureChildControls();
                this.enableValidation = value;
            }
        }

        public override string ID { get; set; }

        public DateTime? MaxDate { get; set; }

        public DateTime? MinDate { get; set; }

        public FrequencyType Mode
        {
            get
            {
                this.EnsureChildControls();
                return this.mode;
            }
            set
            {
                this.EnsureChildControls();
                this.mode = value;
                this.InitializeDate();
            }
        }

        private int officeId;

        public int OfficeId
        {
            get
            {
                this.EnsureChildControls();
                return this.officeId;
            }
            set
            {
                this.EnsureChildControls();
                this.officeId = value;
                this.InitializeDate();
            }
        }


        private string catalog;

        public string Catalog
        {
            get
            {
                this.EnsureChildControls();
                return this.catalog;
            }
            set
            {
                this.EnsureChildControls();
                this.catalog = value;
            }
        }

        public bool Required { get; set; }

        public string Text
        {
            get
            {
                this.EnsureChildControls();
                return this.textBox.Text;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.Text = value;
            }
        }

        public string ValidatorCssClass { get; set; }

        public override Unit Width
        {
            get
            {
                this.EnsureChildControls();
                return this.textBox.Width;
            }
            set
            {
                this.EnsureChildControls();
                this.textBox.Width = value;
            }
        }
    }
}