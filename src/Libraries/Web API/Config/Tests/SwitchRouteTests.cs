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

namespace MixERP.Net.Api.Config.Tests
{
    public class SwitchRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/switch/delete/{key}", "DELETE", typeof(SwitchController), "Delete")]
        [InlineData("/api/config/switch/delete/{key}", "DELETE", typeof(SwitchController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/switch/edit/{key}", "PUT", typeof(SwitchController), "Edit")]
        [InlineData("/api/config/switch/edit/{key}", "PUT", typeof(SwitchController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/switch/count-where", "POST", typeof(SwitchController), "CountWhere")]
        [InlineData("/api/config/switch/count-where", "POST", typeof(SwitchController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/switch/get-where/{pageNumber}", "POST", typeof(SwitchController), "GetWhere")]
        [InlineData("/api/config/switch/get-where/{pageNumber}", "POST", typeof(SwitchController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/switch/add-or-edit", "POST", typeof(SwitchController), "AddOrEdit")]
        [InlineData("/api/config/switch/add-or-edit", "POST", typeof(SwitchController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/switch/add/{switchParameter}", "POST", typeof(SwitchController), "Add")]
        [InlineData("/api/config/switch/add/{switchParameter}", "POST", typeof(SwitchController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/switch/bulk-import", "POST", typeof(SwitchController), "BulkImport")]
        [InlineData("/api/config/switch/bulk-import", "POST", typeof(SwitchController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/switch/meta", "GET", typeof(SwitchController), "GetEntityView")]
        [InlineData("/api/config/switch/meta", "GET", typeof(SwitchController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/switch/count", "GET", typeof(SwitchController), "Count")]
        [InlineData("/api/config/switch/count", "GET", typeof(SwitchController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/switch/all", "GET", typeof(SwitchController), "GetAll")]
        [InlineData("/api/config/switch/all", "GET", typeof(SwitchController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/switch/export", "GET", typeof(SwitchController), "Export")]
        [InlineData("/api/config/switch/export", "GET", typeof(SwitchController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/switch/1", "GET", typeof(SwitchController), "Get")]
        [InlineData("/api/config/switch/1", "GET", typeof(SwitchController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/switch/get?keys=1", "GET", typeof(SwitchController), "Get")]
        [InlineData("/api/config/switch/get?keys=1", "GET", typeof(SwitchController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/switch", "GET", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/config/switch", "GET", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/switch/page/1", "GET", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/config/switch/page/1", "GET", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/switch/count-filtered/{filterName}", "GET", typeof(SwitchController), "CountFiltered")]
        [InlineData("/api/config/switch/count-filtered/{filterName}", "GET", typeof(SwitchController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/switch/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SwitchController), "GetFiltered")]
        [InlineData("/api/config/switch/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SwitchController), "GetFiltered")]
        [InlineData("/api/config/switch/first", "GET", typeof(SwitchController), "GetFirst")]
        [InlineData("/api/config/switch/previous/1", "GET", typeof(SwitchController), "GetPrevious")]
        [InlineData("/api/config/switch/next/1", "GET", typeof(SwitchController), "GetNext")]
        [InlineData("/api/config/switch/last", "GET", typeof(SwitchController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/switch/custom-fields", "GET", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/config/switch/custom-fields", "GET", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/switch/custom-fields/{resourceId}", "GET", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/config/switch/custom-fields/{resourceId}", "GET", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/switch/meta", "HEAD", typeof(SwitchController), "GetEntityView")]
        [InlineData("/api/config/switch/meta", "HEAD", typeof(SwitchController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/switch/count", "HEAD", typeof(SwitchController), "Count")]
        [InlineData("/api/config/switch/count", "HEAD", typeof(SwitchController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/switch/all", "HEAD", typeof(SwitchController), "GetAll")]
        [InlineData("/api/config/switch/all", "HEAD", typeof(SwitchController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/switch/export", "HEAD", typeof(SwitchController), "Export")]
        [InlineData("/api/config/switch/export", "HEAD", typeof(SwitchController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/switch/1", "HEAD", typeof(SwitchController), "Get")]
        [InlineData("/api/config/switch/1", "HEAD", typeof(SwitchController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/switch/get?keys=1", "HEAD", typeof(SwitchController), "Get")]
        [InlineData("/api/config/switch/get?keys=1", "HEAD", typeof(SwitchController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/switch", "HEAD", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/config/switch", "HEAD", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/switch/page/1", "HEAD", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/config/switch/page/1", "HEAD", typeof(SwitchController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/switch/count-filtered/{filterName}", "HEAD", typeof(SwitchController), "CountFiltered")]
        [InlineData("/api/config/switch/count-filtered/{filterName}", "HEAD", typeof(SwitchController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/switch/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SwitchController), "GetFiltered")]
        [InlineData("/api/config/switch/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SwitchController), "GetFiltered")]
        [InlineData("/api/config/switch/first", "HEAD", typeof(SwitchController), "GetFirst")]
        [InlineData("/api/config/switch/previous/1", "HEAD", typeof(SwitchController), "GetPrevious")]
        [InlineData("/api/config/switch/next/1", "HEAD", typeof(SwitchController), "GetNext")]
        [InlineData("/api/config/switch/last", "HEAD", typeof(SwitchController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/switch/custom-fields", "HEAD", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/config/switch/custom-fields", "HEAD", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/switch/custom-fields/{resourceId}", "HEAD", typeof(SwitchController), "GetCustomFields")]
        [InlineData("/api/config/switch/custom-fields/{resourceId}", "HEAD", typeof(SwitchController), "GetCustomFields")]

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

        public SwitchRouteTests()
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