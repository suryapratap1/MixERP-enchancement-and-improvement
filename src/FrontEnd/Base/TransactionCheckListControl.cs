using System.Web.UI;

namespace MixERP.Net.FrontEnd.Base
{
    public abstract class TransactionCheckListControl : MixERPUserControl
    {
        protected TransactionCheckListControl()
        {
            this.ValidDateRequest = ValidateRequestMode.Disabled;
        }
    }
}