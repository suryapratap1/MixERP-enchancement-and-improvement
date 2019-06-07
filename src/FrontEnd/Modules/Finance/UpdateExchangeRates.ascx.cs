using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.FrontEnd.Base;
using System;
using MixERP.Net.Framework.Contracts;

namespace MixERP.Net.Core.Modules.Finance
{
    public partial class UpdateExchangeRates : MixERPUserControl, ITransaction
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            this.OfficeInputText.Value = AppUsers.GetCurrent().View.OfficeName;
            this.CurrencyInputText.Value = AppUsers.GetCurrent().View.CurrencyCode;
        }
    }
}