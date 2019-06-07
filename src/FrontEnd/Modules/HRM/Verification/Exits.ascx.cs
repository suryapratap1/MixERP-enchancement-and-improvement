using System;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.HRM.Verification
{
    public partial class Exits : MixERPUserControl
    {
        public override AccessLevel AccessLevel => AccessLevel.AdminOnly;

        public override void OnControlLoad(object sender, EventArgs e)
        {
        }
    }
}