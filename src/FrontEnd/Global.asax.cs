using System;
using System.Configuration;
using System.Web;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;
using MixERP.Net.Entities.Office;
using MixERP.Net.Entities.Public.Meta;
using MixERP.Net.FrontEnd.Application;
using MixERP.Net.ReportManager;

namespace MixERP.Net.FrontEnd
{
    public class Global : HttpApplication
    {
        protected void Application_BeginRequest()
        {
            if (HttpContext.Current.Request.IsSecureConnection)
            {
                return;
            }

            var enforceSSL = ConfigurationManager.AppSettings["EnforceSSL"].ToLowerInvariant().Equals("true");

            if (!enforceSSL)
            {
                return;
            }

            switch (this.Request.Url.Scheme)
            {
                case "https":
                    this.Response.AddHeader("Strict-Transport-Security", "max-age=31536000");
                    break;
                case "http":
                    var path = "https://" + this.Request.Url.Host + this.Request.Url.PathAndQuery;
                    this.Response.Status = "301 Moved Permanently";
                    this.Response.AddHeader("Location", path);
                    break;
            }
        }

        private void Application_Error(object sender, EventArgs e)
        {
            ApplicationError.Handle(this.Server.GetLastError());
        }

        private void Application_Start(object sender, EventArgs e)
        {
            LogManager.IntializeLogger();
            WebJobManager.Register();
            UpdateManager.CheckForUpdates(this.Application);
            Routes.RegisterRoutes(RouteTable.Routes);

            GlobalLogin.CreateTable();
            SalesQuotationValidation.CreateTable();
            Repository.DownloadAndInstallReports();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}