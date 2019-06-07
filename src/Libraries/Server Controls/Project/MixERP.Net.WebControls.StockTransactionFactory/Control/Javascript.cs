using MixERP.Net.Common;
using MixERP.Net.Common.Helpers;
using MixERP.Net.Entities;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;

[assembly: WebResource("MixERP.Net.WebControls.StockTransactionFactory.Includes.Script.StockTransactionForm.js", "application/x-javascript", PerformSubstitution = true)]

namespace MixERP.Net.WebControls.StockTransactionFactory
{
    public partial class StockTransactionForm
    {
        private void RegisterJavascript()
        {
            string isSales = (this.Book.Equals(TranBook.Sales)) ? "true" : "false";
            string tranBook = this.GetTranBook();
            string verifyStock = (this.VerifyStock) ? "true" : "false";

            string js = string.Empty;
            js += JSUtility.GetVar("isSales", isSales, false);
            js += JSUtility.GetVar("tranBook", tranBook);
            js += JSUtility.GetVar("verifyStock", verifyStock, false);

            PageUtility.RegisterJavascript("StockTransactionForm_Vars", js, this.Page, true);
        }

        public string GetTranBook()
        {
            if (this.Book == TranBook.Sales)
            {
                return "Sales";
            }

            return "Purchase";
        }

        [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
        private void AddJavascript()
        {
            JSUtility.AddJSReference(this.Page, "MixERP.Net.WebControls.StockTransactionFactory.Includes.Script.StockTransactionForm.js", "StockTransactionForm", typeof(StockTransactionForm));
        }
    }
}