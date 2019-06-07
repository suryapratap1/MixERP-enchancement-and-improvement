using System.Configuration;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Serilog;

namespace MixERP.Net.FrontEnd.Application
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            string assemblyResolverType = ConfigurationManager.AppSettings["WebAPIAssemblyResolverType"];

            Log.Information("Registering Web API.");
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("VersionedApi", "api/v1.5/{schema}/{controller}/{action}/{id}",
                new {id = RouteParameter.Optional});
            config.Routes.MapHttpRoute("DefaultApi", "api/{schema}/{controller}/{action}/{id}",
                new {id = RouteParameter.Optional});

            if (assemblyResolverType == "Classic")
            {
                Log.Information("Registering Classic Web API Resolver.");
                config.Services.Replace(typeof (IAssembliesResolver), new ClassicAssemblyResolver());
            }
            else
            {
                Log.Information("Registering Default Web API Resolver.");
                config.Services.Replace(typeof (IAssembliesResolver), new MixERPAssemblyResolver());
            }

            config.EnsureInitialized();
        }
    }
}