using System;
using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.Common.Extensions;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.Finance.DayOperation
{
    public partial class EOY : MixERPUserControl
    {
        public override AccessLevel AccessLevel
        {
            get { return AccessLevel.AdminOnly; }
        }

        public override void OnControlLoad(object sender, EventArgs e)
        {
            string catalog = AppUsers.GetCurrentUserDB();
            int officeId = AppUsers.GetCurrent().View.OfficeId.ToInt();

            int inStack = TransactionGovernor.Verification.Stack.CountItemsInVerificationStack(catalog, officeId);
            this.EOYPanel.Visible = inStack == 0;
            this.MessagePanel.Visible = !this.EOYPanel.Visible;

            this.SetOverrideUrl();
        }

        private void SetOverrideUrl()
        {
            this.OverridePath = "/Modules/Finance/EODOperation.mix";        
        }
    }
}