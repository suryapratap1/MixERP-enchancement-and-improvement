using System.IO;
using MixERP.Net.Common.Helpers;
using System.Security.Permissions;
using System.Web;
using System.Web.UI;
using MixERP.Net.Common;

[assembly: WebResource("MixERP.Net.WebControls.TransactionChecklist.Scripts.TransactionChecklist.js", "application/x-javascript")]
namespace MixERP.Net.WebControls.TransactionChecklist
{
    public partial class TransactionChecklistForm
    {
        [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
        private void AddScript()
        {
            string fileName = Path.GetFileName(this.AttachmentFileName);
            var script = JSUtility.GetVar("fileName", fileName);

            PageUtility.RegisterJavascript("Checklist", script, this.Page, true);
            JSUtility.AddJSReference(this.Page, "MixERP.Net.WebControls.TransactionChecklist.Scripts.TransactionChecklist.js", "TransactionChecklistForm", typeof(TransactionChecklistForm));
        }
    }
}