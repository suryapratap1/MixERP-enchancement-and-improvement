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
    public class CurrencyLayerRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/delete/{key}", "DELETE", typeof(CurrencyLayerController), "Delete")]
        [InlineData("/api/config/currency-layer/delete/{key}", "DELETE", typeof(CurrencyLayerController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/edit/{key}", "PUT", typeof(CurrencyLayerController), "Edit")]
        [InlineData("/api/config/currency-layer/edit/{key}", "PUT", typeof(CurrencyLayerController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/count-where", "POST", typeof(CurrencyLayerController), "CountWhere")]
        [InlineData("/api/config/currency-layer/count-where", "POST", typeof(CurrencyLayerController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/get-where/{pageNumber}", "POST", typeof(CurrencyLayerController), "GetWhere")]
        [InlineData("/api/config/currency-layer/get-where/{pageNumber}", "POST", typeof(CurrencyLayerController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/add-or-edit", "POST", typeof(CurrencyLayerController), "AddOrEdit")]
        [InlineData("/api/config/currency-layer/add-or-edit", "POST", typeof(CurrencyLayerController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/add/{currencyLayer}", "POST", typeof(CurrencyLayerController), "Add")]
        [InlineData("/api/config/currency-layer/add/{currencyLayer}", "POST", typeof(CurrencyLayerController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/bulk-import", "POST", typeof(CurrencyLayerController), "BulkImport")]
        [InlineData("/api/config/currency-layer/bulk-import", "POST", typeof(CurrencyLayerController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/meta", "GET", typeof(CurrencyLayerController), "GetEntityView")]
        [InlineData("/api/config/currency-layer/meta", "GET", typeof(CurrencyLayerController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/count", "GET", typeof(CurrencyLayerController), "Count")]
        [InlineData("/api/config/currency-layer/count", "GET", typeof(CurrencyLayerController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/all", "GET", typeof(CurrencyLayerController), "GetAll")]
        [InlineData("/api/config/currency-layer/all", "GET", typeof(CurrencyLayerController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/export", "GET", typeof(CurrencyLayerController), "Export")]
        [InlineData("/api/config/currency-layer/export", "GET", typeof(CurrencyLayerController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/1", "GET", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/config/currency-layer/1", "GET", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/get?keys=1", "GET", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/config/currency-layer/get?keys=1", "GET", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer", "GET", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/config/currency-layer", "GET", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/page/1", "GET", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/config/currency-layer/page/1", "GET", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/count-filtered/{filterName}", "GET", typeof(CurrencyLayerController), "CountFiltered")]
        [InlineData("/api/config/currency-layer/count-filtered/{filterName}", "GET", typeof(CurrencyLayerController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CurrencyLayerController), "GetFiltered")]
        [InlineData("/api/config/currency-layer/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CurrencyLayerController), "GetFiltered")]
        [InlineData("/api/config/currency-layer/first", "GET", typeof(CurrencyLayerController), "GetFirst")]
        [InlineData("/api/config/currency-layer/previous/1", "GET", typeof(CurrencyLayerController), "GetPrevious")]
        [InlineData("/api/config/currency-layer/next/1", "GET", typeof(CurrencyLayerController), "GetNext")]
        [InlineData("/api/config/currency-layer/last", "GET", typeof(CurrencyLayerController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/currency-layer/custom-fields", "GET", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/config/currency-layer/custom-fields", "GET", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/custom-fields/{resourceId}", "GET", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/config/currency-layer/custom-fields/{resourceId}", "GET", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/meta", "HEAD", typeof(CurrencyLayerController), "GetEntityView")]
        [InlineData("/api/config/currency-layer/meta", "HEAD", typeof(CurrencyLayerController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/count", "HEAD", typeof(CurrencyLayerController), "Count")]
        [InlineData("/api/config/currency-layer/count", "HEAD", typeof(CurrencyLayerController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/all", "HEAD", typeof(CurrencyLayerController), "GetAll")]
        [InlineData("/api/config/currency-layer/all", "HEAD", typeof(CurrencyLayerController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/export", "HEAD", typeof(CurrencyLayerController), "Export")]
        [InlineData("/api/config/currency-layer/export", "HEAD", typeof(CurrencyLayerController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/1", "HEAD", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/config/currency-layer/1", "HEAD", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/get?keys=1", "HEAD", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/config/currency-layer/get?keys=1", "HEAD", typeof(CurrencyLayerController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer", "HEAD", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/config/currency-layer", "HEAD", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/page/1", "HEAD", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/config/currency-layer/page/1", "HEAD", typeof(CurrencyLayerController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/count-filtered/{filterName}", "HEAD", typeof(CurrencyLayerController), "CountFiltered")]
        [InlineData("/api/config/currency-layer/count-filtered/{filterName}", "HEAD", typeof(CurrencyLayerController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CurrencyLayerController), "GetFiltered")]
        [InlineData("/api/config/currency-layer/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CurrencyLayerController), "GetFiltered")]
        [InlineData("/api/config/currency-layer/first", "HEAD", typeof(CurrencyLayerController), "GetFirst")]
        [InlineData("/api/config/currency-layer/previous/1", "HEAD", typeof(CurrencyLayerController), "GetPrevious")]
        [InlineData("/api/config/currency-layer/next/1", "HEAD", typeof(CurrencyLayerController), "GetNext")]
        [InlineData("/api/config/currency-layer/last", "HEAD", typeof(CurrencyLayerController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/currency-layer/custom-fields", "HEAD", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/config/currency-layer/custom-fields", "HEAD", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/currency-layer/custom-fields/{resourceId}", "HEAD", typeof(CurrencyLayerController), "GetCustomFields")]
        [InlineData("/api/config/currency-layer/custom-fields/{resourceId}", "HEAD", typeof(CurrencyLayerController), "GetCustomFields")]

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

        public CurrencyLayerRouteTests()
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