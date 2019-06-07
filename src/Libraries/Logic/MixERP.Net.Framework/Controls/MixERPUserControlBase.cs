using System;
using System.Web.UI;

namespace MixERP.Net.Framework.Controls
{
    public abstract class MixERPUserControlBase : UserControl, IControl
    {
        private ValidateRequestMode validDateRequest = ValidateRequestMode.Inherit;
        public abstract AccessLevel AccessLevel { get; }

        public ValidateRequestMode ValidDateRequest
        {
            get { return this.validDateRequest; }
            set { this.validDateRequest = value; }
        }

        public string MasterPageId { get; set; }
        public bool RemoveTheme { get; set; }
        public string OverridePath { get; set; }
        public abstract void OnControlLoad(object sender, EventArgs e);
    }
}