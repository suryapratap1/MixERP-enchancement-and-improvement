using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void CreateTitle(Control container)
        {
            this.title = new HtmlGenericControl("h1");
            this.title.InnerText = this.Text;
            container.Controls.Add(this.title);
        }
    }
}