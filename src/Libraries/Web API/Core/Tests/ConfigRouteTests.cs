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

namespace MixERP.Net.Api.Core.Tests
{
    public class ConfigRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/config/delete/{configId}", "DELETE", typeof(ConfigController), "Delete")]
        [InlineData("/api/core/config/delete/{configId}", "DELETE", typeof(ConfigController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/config/edit/{configId}", "PUT", typeof(ConfigController), "Edit")]
        [InlineData("/api/core/config/edit/{configId}", "PUT", typeof(ConfigController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/config/count-where", "POST", typeof(ConfigController), "CountWhere")]
        [InlineData("/api/core/config/count-where", "POST", typeof(ConfigController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/config/get-where/{pageNumber}", "POST", typeof(ConfigController), "GetWhere")]
        [InlineData("/api/core/config/get-where/{pageNumber}", "POST", typeof(ConfigController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/config/add-or-edit", "POST", typeof(ConfigController), "AddOrEdit")]
        [InlineData("/api/core/config/add-or-edit", "POST", typeof(ConfigController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/config/add/{config}", "POST", typeof(ConfigController), "Add")]
        [InlineData("/api/core/config/add/{config}", "POST", typeof(ConfigController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/config/bulk-import", "POST", typeof(ConfigController), "BulkImport")]
        [InlineData("/api/core/config/bulk-import", "POST", typeof(ConfigController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/config/meta", "GET", typeof(ConfigController), "GetEntityView")]
        [InlineData("/api/core/config/meta", "GET", typeof(ConfigController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/config/count", "GET", typeof(ConfigController), "Count")]
        [InlineData("/api/core/config/count", "GET", typeof(ConfigController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/config/all", "GET", typeof(ConfigController), "GetAll")]
        [InlineData("/api/core/config/all", "GET", typeof(ConfigController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/config/export", "GET", typeof(ConfigController), "Export")]
        [InlineData("/api/core/config/export", "GET", typeof(ConfigController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/config/1", "GET", typeof(ConfigController), "Get")]
        [InlineData("/api/core/config/1", "GET", typeof(ConfigController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/config/get?configIds=1", "GET", typeof(ConfigController), "Get")]
        [InlineData("/api/core/config/get?configIds=1", "GET", typeof(ConfigController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/config", "GET", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/core/config", "GET", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/config/page/1", "GET", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/core/config/page/1", "GET", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/config/count-filtered/{filterName}", "GET", typeof(ConfigController), "CountFiltered")]
        [InlineData("/api/core/config/count-filtered/{filterName}", "GET", typeof(ConfigController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/config/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ConfigController), "GetFiltered")]
        [InlineData("/api/core/config/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ConfigController), "GetFiltered")]
        [InlineData("/api/core/config/first", "GET", typeof(ConfigController), "GetFirst")]
        [InlineData("/api/core/config/previous/1", "GET", typeof(ConfigController), "GetPrevious")]
        [InlineData("/api/core/config/next/1", "GET", typeof(ConfigController), "GetNext")]
        [InlineData("/api/core/config/last", "GET", typeof(ConfigController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/config/custom-fields", "GET", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/core/config/custom-fields", "GET", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/config/custom-fields/{resourceId}", "GET", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/core/config/custom-fields/{resourceId}", "GET", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/config/meta", "HEAD", typeof(ConfigController), "GetEntityView")]
        [InlineData("/api/core/config/meta", "HEAD", typeof(ConfigController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/config/count", "HEAD", typeof(ConfigController), "Count")]
        [InlineData("/api/core/config/count", "HEAD", typeof(ConfigController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/config/all", "HEAD", typeof(ConfigController), "GetAll")]
        [InlineData("/api/core/config/all", "HEAD", typeof(ConfigController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/config/export", "HEAD", typeof(ConfigController), "Export")]
        [InlineData("/api/core/config/export", "HEAD", typeof(ConfigController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/config/1", "HEAD", typeof(ConfigController), "Get")]
        [InlineData("/api/core/config/1", "HEAD", typeof(ConfigController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/config/get?configIds=1", "HEAD", typeof(ConfigController), "Get")]
        [InlineData("/api/core/config/get?configIds=1", "HEAD", typeof(ConfigController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/config", "HEAD", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/core/config", "HEAD", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/config/page/1", "HEAD", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/core/config/page/1", "HEAD", typeof(ConfigController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/config/count-filtered/{filterName}", "HEAD", typeof(ConfigController), "CountFiltered")]
        [InlineData("/api/core/config/count-filtered/{filterName}", "HEAD", typeof(ConfigController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/config/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ConfigController), "GetFiltered")]
        [InlineData("/api/core/config/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ConfigController), "GetFiltered")]
        [InlineData("/api/core/config/first", "HEAD", typeof(ConfigController), "GetFirst")]
        [InlineData("/api/core/config/previous/1", "HEAD", typeof(ConfigController), "GetPrevious")]
        [InlineData("/api/core/config/next/1", "HEAD", typeof(ConfigController), "GetNext")]
        [InlineData("/api/core/config/last", "HEAD", typeof(ConfigController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/config/custom-fields", "HEAD", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/core/config/custom-fields", "HEAD", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/config/custom-fields/{resourceId}", "HEAD", typeof(ConfigController), "GetCustomFields")]
        [InlineData("/api/core/config/custom-fields/{resourceId}", "HEAD", typeof(ConfigController), "GetCustomFields")]

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

        public ConfigRouteTests()
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