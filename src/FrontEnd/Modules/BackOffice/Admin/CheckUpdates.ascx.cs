using System;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.BackOffice.Admin
{
    public partial class CheckUpdates : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.Page.Server.Transfer("/Modules/Update.aspx");
        }
    }
}