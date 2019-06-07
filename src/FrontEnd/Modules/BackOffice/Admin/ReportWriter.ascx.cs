using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;
using System;

namespace MixERP.Net.Core.Modules.BackOffice.Admin
{
    public partial class ReportWriter : MixERPUserControl
    {
        public override AccessLevel AccessLevel
        {
            get { return AccessLevel.AdminOnly; }
        }

        public override void OnControlLoad(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}