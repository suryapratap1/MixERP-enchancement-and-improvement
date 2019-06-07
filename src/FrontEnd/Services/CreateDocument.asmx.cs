using System.ComponentModel;
using System.IO;
using System.Web;
using System.Web.Hosting;
using System.Web.Script.Services;
using System.Web.Services;
using MixERP.Net.Common.Helpers;
using MixERP.Net.FrontEnd.Base;

namespace MixERP.Net.FrontEnd.Services
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    [ScriptService]
    public class CreateDocument : MixERPWebService
    {
       private readonly string basePath = HostingEnvironment.MapPath("/");

        [WebMethod]
        public string CreatePdf(string html, string documentName)
        {
            if (!this.IsValid(html, documentName))
            {
                return string.Empty;
            }

            string destination = HostingEnvironment.MapPath("/Resource/Documents/" + documentName);

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

             ExportHelper.CreatePDF(html, destination);

            return "/" + destination.Replace(this.basePath, string.Empty).Replace(@"\", "/");
        }

        private bool IsValid(string html, string documentName)
        {
            if (!this.Context.User.Identity.IsAuthenticated)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(html) || string.IsNullOrWhiteSpace(documentName))
            {
                return false;
            }

            return true;
        }

        [WebMethod]
        public string CreateDoc(string html, string documentName)
        {
            if (!this.IsValid(html, documentName))
            {
                return string.Empty;
            }

            string destination = ExportHelper.CreateWord(html, documentName);
            return "/" + destination.Replace(this.basePath, string.Empty).Replace(@"\", "/");
        }

        [WebMethod]
        public string CreateXls(string html, string documentName)
        {
            if (!this.IsValid(html, documentName))
            {
                return string.Empty;
            }

            string destination = ExportHelper.CreateExcel(html, documentName);
            return "/" + destination.Replace(this.basePath, string.Empty).Replace(@"\", "/");
        }

    }
}