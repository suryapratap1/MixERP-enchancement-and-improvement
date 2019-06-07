using System;
using MixERP.Net.Common;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.Core.Modules.Inventory.Setup
{
    public partial class PartyInfo : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
        	long partyId = Conversion.TryCastLong(this.Page.Request.QueryString["PartyId"]);

        	if(partyId == 0)
            {
        		this.InfoPanel.Visible = false;
        	}
        }
    }
}