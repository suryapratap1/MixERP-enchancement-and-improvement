// ReSharper disable All
using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Xunit;

namespace MixERP.Net.Api.Audit.Tests
{
    public class LoggedActionRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/delete/{eventId}", "DELETE", typeof(LoggedActionController), "Delete")]
        [InlineData("/api/audit/logged-action/delete/{eventId}", "DELETE", typeof(LoggedActionController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/edit/{eventId}", "PUT", typeof(LoggedActionController), "Edit")]
        [InlineData("/api/audit/logged-action/edit/{eventId}", "PUT", typeof(LoggedActionController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/count-where", "POST", typeof(LoggedActionController), "CountWhere")]
        [InlineData("/api/audit/logged-action/count-where", "POST", typeof(LoggedActionController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/get-where/{pageNumber}", "POST", typeof(LoggedActionController), "GetWhere")]
        [InlineData("/api/audit/logged-action/get-where/{pageNumber}", "POST", typeof(LoggedActionController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/add-or-edit", "POST", typeof(LoggedActionController), "AddOrEdit")]
        [InlineData("/api/audit/logged-action/add-or-edit", "POST", typeof(LoggedActionController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/add/{loggedAction}", "POST", typeof(LoggedActionController), "Add")]
        [InlineData("/api/audit/logged-action/add/{loggedAction}", "POST", typeof(LoggedActionController), "Add")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/bulk-import", "POST", typeof(LoggedActionController), "BulkImport")]
        [InlineData("/api/audit/logged-action/bulk-import", "POST", typeof(LoggedActionController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/meta", "GET", typeof(LoggedActionController), "GetEntityView")]
        [InlineData("/api/audit/logged-action/meta", "GET", typeof(LoggedActionController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/count", "GET", typeof(LoggedActionController), "Count")]
        [InlineData("/api/audit/logged-action/count", "GET", typeof(LoggedActionController), "Count")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/all", "GET", typeof(LoggedActionController), "GetAll")]
        [InlineData("/api/audit/logged-action/all", "GET", typeof(LoggedActionController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/export", "GET", typeof(LoggedActionController), "Export")]
        [InlineData("/api/audit/logged-action/export", "GET", typeof(LoggedActionController), "Export")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/1", "GET", typeof(LoggedActionController), "Get")]
        [InlineData("/api/audit/logged-action/1", "GET", typeof(LoggedActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/get?eventIds=1", "GET", typeof(LoggedActionController), "Get")]
        [InlineData("/api/audit/logged-action/get?eventIds=1", "GET", typeof(LoggedActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action", "GET", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/audit/logged-action", "GET", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/page/1", "GET", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/audit/logged-action/page/1", "GET", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/count-filtered/{filterName}", "GET", typeof(LoggedActionController), "CountFiltered")]
        [InlineData("/api/audit/logged-action/count-filtered/{filterName}", "GET", typeof(LoggedActionController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LoggedActionController), "GetFiltered")]
        [InlineData("/api/audit/logged-action/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LoggedActionController), "GetFiltered")]
        [InlineData("/api/audit/logged-action/first", "GET", typeof(LoggedActionController), "GetFirst")]
        [InlineData("/api/audit/logged-action/previous/1", "GET", typeof(LoggedActionController), "GetPrevious")]
        [InlineData("/api/audit/logged-action/next/1", "GET", typeof(LoggedActionController), "GetNext")]
        [InlineData("/api/audit/logged-action/last", "GET", typeof(LoggedActionController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/audit/logged-action/custom-fields", "GET", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/audit/logged-action/custom-fields", "GET", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/custom-fields/{resourceId}", "GET", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/audit/logged-action/custom-fields/{resourceId}", "GET", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/meta", "HEAD", typeof(LoggedActionController), "GetEntityView")]
        [InlineData("/api/audit/logged-action/meta", "HEAD", typeof(LoggedActionController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/count", "HEAD", typeof(LoggedActionController), "Count")]
        [InlineData("/api/audit/logged-action/count", "HEAD", typeof(LoggedActionController), "Count")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/all", "HEAD", typeof(LoggedActionController), "GetAll")]
        [InlineData("/api/audit/logged-action/all", "HEAD", typeof(LoggedActionController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/export", "HEAD", typeof(LoggedActionController), "Export")]
        [InlineData("/api/audit/logged-action/export", "HEAD", typeof(LoggedActionController), "Export")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/1", "HEAD", typeof(LoggedActionController), "Get")]
        [InlineData("/api/audit/logged-action/1", "HEAD", typeof(LoggedActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/get?eventIds=1", "HEAD", typeof(LoggedActionController), "Get")]
        [InlineData("/api/audit/logged-action/get?eventIds=1", "HEAD", typeof(LoggedActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action", "HEAD", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/audit/logged-action", "HEAD", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/page/1", "HEAD", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/audit/logged-action/page/1", "HEAD", typeof(LoggedActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/count-filtered/{filterName}", "HEAD", typeof(LoggedActionController), "CountFiltered")]
        [InlineData("/api/audit/logged-action/count-filtered/{filterName}", "HEAD", typeof(LoggedActionController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LoggedActionController), "GetFiltered")]
        [InlineData("/api/audit/logged-action/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LoggedActionController), "GetFiltered")]
        [InlineData("/api/audit/logged-action/first", "HEAD", typeof(LoggedActionController), "GetFirst")]
        [InlineData("/api/audit/logged-action/previous/1", "HEAD", typeof(LoggedActionController), "GetPrevious")]
        [InlineData("/api/audit/logged-action/next/1", "HEAD", typeof(LoggedActionController), "GetNext")]
        [InlineData("/api/audit/logged-action/last", "HEAD", typeof(LoggedActionController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/audit/logged-action/custom-fields", "HEAD", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/audit/logged-action/custom-fields", "HEAD", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/audit/logged-action/custom-fields/{resourceId}", "HEAD", typeof(LoggedActionController), "GetCustomFields")]
        [InlineData("/api/audit/logged-action/custom-fields/{resourceId}", "HEAD", typeof(LoggedActionController), "GetCustomFields")]

        [Conditional("Debug")]
        public void TestRoute(string url, string verb, Type type, string actionName)
        {
            //Arrange
            url = url.Replace("{apiVersionNumber}", this.ApiVersionNumber);
            url = Host + url;

            //Act
            HttpRequestMessage request = new HttpRequestMessage(new HttpMethod(verb), url);

            IHttpControllerSelector controller = this.GetControllerSelector();
            IHttpActionSelector action = this.GetActionSelector();

            IHttpRouteData route = this.Config.Routes.GetRouteData(request);
            request.Properties[HttpPropertyKeys.HttpRouteDataKey] = route;
            request.Properties[HttpPropertyKeys.HttpConfigurationKey] = this.Config;

            HttpControllerDescriptor controllerDescriptor = controller.SelectController(request);

            HttpControllerContext context = new HttpControllerContext(this.Config, route, request)
            {
                ControllerDescriptor = controllerDescriptor
            };

            var actionDescriptor = action.SelectAction(context);

            //Assert
            Assert.NotNull(controllerDescriptor);
            Assert.NotNull(actionDescriptor);
            Assert.Equal(type, controllerDescriptor.ControllerType);
            Assert.Equal(actionName, actionDescriptor.ActionName);
        }

        #region Fixture
        private readonly HttpConfiguration Config;
        private readonly string Host;
        private readonly string ApiVersionNumber;

        public LoggedActionRouteTests()
        {
            this.Host = ConfigurationManager.AppSettings["HostPrefix"];
            this.ApiVersionNumber = ConfigurationManager.AppSettings["ApiVersionNumber"];
            this.Config = GetConfig();
        }

        private HttpConfiguration GetConfig()
        {
            if (MemoryCache.Default["Config"] == null)
            {
                HttpConfiguration config = new HttpConfiguration();
                config.MapHttpAttributeRoutes();
                config.Routes.MapHttpRoute("VersionedApi", "api/" + this.ApiVersionNumber + "/{schema}/{controller}/{action}/{id}", new { id = RouteParameter.Optional });
                config.Routes.MapHttpRoute("DefaultApi", "api/{schema}/{controller}/{action}/{id}", new { id = RouteParameter.Optional });

                config.EnsureInitialized();
                MemoryCache.Default["Config"] = config;
                return config;
            }

            return MemoryCache.Default["Config"] as HttpConfiguration;
        }

        private IHttpControllerSelector GetControllerSelector()
        {
            if (MemoryCache.Default["ControllerSelector"] == null)
            {
                IHttpControllerSelector selector = this.Config.Services.GetHttpControllerSelector();
                return selector;
            }

            return MemoryCache.Default["ControllerSelector"] as IHttpControllerSelector;
        }

        private IHttpActionSelector GetActionSelector()
        {
            if (MemoryCache.Default["ActionSelector"] == null)
            {
                IHttpActionSelector selector = this.Config.Services.GetActionSelector();
                return selector;
            }

            return MemoryCache.Default["ActionSelector"] as IHttpActionSelector;
        }
        #endregion
    }
}