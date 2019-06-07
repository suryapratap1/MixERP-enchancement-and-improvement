using MixERP.Net.ApplicationState.Cache;
using MixERP.Net.WebControls.TransactionChecklist;

namespace MixERP.Net.FrontEnd.Controls
{
    public sealed class Checklist : TransactionChecklistForm
    {
        public Checklist()
        {
            this.Catalog = AppUsers.GetCurrentUserDB();
        }
    }
}