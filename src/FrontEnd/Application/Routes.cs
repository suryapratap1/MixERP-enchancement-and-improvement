using System.Web.Routing;
using Serilog;

namespace MixERP.Net.FrontEnd.Application
{
    internal static class Routes
    {
        internal static void RegisterRoutes(RouteCollection routes)
        {
            if (routes != null)
            {
                Log.Information("Registering routes.");
                routes.Ignore("{resource}.axd");
				routes.Ignore("{*url}", new { url = @".*\.asmx(/.*)?" });
                routes.MapPageRoute("DefaultRoute", "", "~/SignIn.aspx");
                routes.MapPageRoute("Reporting", "Reports/{path}", "~/Reports/ReportMaster.aspx");
                routes.MapPageRoute("Modules", "Modules/{*path}", "~/Modules/Default.aspx");
            }
        }
    }
}