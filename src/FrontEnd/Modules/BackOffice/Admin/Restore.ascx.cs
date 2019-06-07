using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;
using System;

namespace MixERP.Net.Core.Modules.BackOffice.Admin
{
    public partial class Restore : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
        }

        public override AccessLevel AccessLevel
        {
            get
            {
                return AccessLevel.AdminOnly;
            }
        }

    }
}