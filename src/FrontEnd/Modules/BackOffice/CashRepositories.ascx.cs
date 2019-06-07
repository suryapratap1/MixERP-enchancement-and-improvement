using System;
using MixERP.Net.Framework.Controls;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.BackOffice
{
    public partial class CashRepositories : MixERPUserControl
    {
        public override AccessLevel AccessLevel => AccessLevel.AdminOnly;

        public override void OnControlLoad(object sender, EventArgs e)
        {
        }
    }
}