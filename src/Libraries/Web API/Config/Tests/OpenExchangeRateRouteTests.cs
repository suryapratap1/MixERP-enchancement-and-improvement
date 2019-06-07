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
    public class OpenExchangeRateRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/delete/{key}", "DELETE", typeof(OpenExchangeRateController), "Delete")]
        [InlineData("/api/config/open-exchange-rate/delete/{key}", "DELETE", typeof(OpenExchangeRateController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/edit/{key}", "PUT", typeof(OpenExchangeRateController), "Edit")]
        [InlineData("/api/config/open-exchange-rate/edit/{key}", "PUT", typeof(OpenExchangeRateController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/count-where", "POST", typeof(OpenExchangeRateController), "CountWhere")]
        [InlineData("/api/config/open-exchange-rate/count-where", "POST", typeof(OpenExchangeRateController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/get-where/{pageNumber}", "POST", typeof(OpenExchangeRateController), "GetWhere")]
        [InlineData("/api/config/open-exchange-rate/get-where/{pageNumber}", "POST", typeof(OpenExchangeRateController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/add-or-edit", "POST", typeof(OpenExchangeRateController), "AddOrEdit")]
        [InlineData("/api/config/open-exchange-rate/add-or-edit", "POST", typeof(OpenExchangeRateController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/add/{openExchangeRate}", "POST", typeof(OpenExchangeRateController), "Add")]
        [InlineData("/api/config/open-exchange-rate/add/{openExchangeRate}", "POST", typeof(OpenExchangeRateController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/bulk-import", "POST", typeof(OpenExchangeRateController), "BulkImport")]
        [InlineData("/api/config/open-exchange-rate/bulk-import", "POST", typeof(OpenExchangeRateController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/meta", "GET", typeof(OpenExchangeRateController), "GetEntityView")]
        [InlineData("/api/config/open-exchange-rate/meta", "GET", typeof(OpenExchangeRateController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/count", "GET", typeof(OpenExchangeRateController), "Count")]
        [InlineData("/api/config/open-exchange-rate/count", "GET", typeof(OpenExchangeRateController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/all", "GET", typeof(OpenExchangeRateController), "GetAll")]
        [InlineData("/api/config/open-exchange-rate/all", "GET", typeof(OpenExchangeRateController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/export", "GET", typeof(OpenExchangeRateController), "Export")]
        [InlineData("/api/config/open-exchange-rate/export", "GET", typeof(OpenExchangeRateController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/1", "GET", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/config/open-exchange-rate/1", "GET", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/get?keys=1", "GET", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/config/open-exchange-rate/get?keys=1", "GET", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate", "GET", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/config/open-exchange-rate", "GET", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/page/1", "GET", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/config/open-exchange-rate/page/1", "GET", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/count-filtered/{filterName}", "GET", typeof(OpenExchangeRateController), "CountFiltered")]
        [InlineData("/api/config/open-exchange-rate/count-filtered/{filterName}", "GET", typeof(OpenExchangeRateController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/get-filtered/{pageNumber}/{filterName}", "GET", typeof(OpenExchangeRateController), "GetFiltered")]
        [InlineData("/api/config/open-exchange-rate/get-filtered/{pageNumber}/{filterName}", "GET", typeof(OpenExchangeRateController), "GetFiltered")]
        [InlineData("/api/config/open-exchange-rate/first", "GET", typeof(OpenExchangeRateController), "GetFirst")]
        [InlineData("/api/config/open-exchange-rate/previous/1", "GET", typeof(OpenExchangeRateController), "GetPrevious")]
        [InlineData("/api/config/open-exchange-rate/next/1", "GET", typeof(OpenExchangeRateController), "GetNext")]
        [InlineData("/api/config/open-exchange-rate/last", "GET", typeof(OpenExchangeRateController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/custom-fields", "GET", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/config/open-exchange-rate/custom-fields", "GET", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/custom-fields/{resourceId}", "GET", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/config/open-exchange-rate/custom-fields/{resourceId}", "GET", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/meta", "HEAD", typeof(OpenExchangeRateController), "GetEntityView")]
        [InlineData("/api/config/open-exchange-rate/meta", "HEAD", typeof(OpenExchangeRateController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/count", "HEAD", typeof(OpenExchangeRateController), "Count")]
        [InlineData("/api/config/open-exchange-rate/count", "HEAD", typeof(OpenExchangeRateController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/all", "HEAD", typeof(OpenExchangeRateController), "GetAll")]
        [InlineData("/api/config/open-exchange-rate/all", "HEAD", typeof(OpenExchangeRateController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/export", "HEAD", typeof(OpenExchangeRateController), "Export")]
        [InlineData("/api/config/open-exchange-rate/export", "HEAD", typeof(OpenExchangeRateController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/1", "HEAD", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/config/open-exchange-rate/1", "HEAD", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/get?keys=1", "HEAD", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/config/open-exchange-rate/get?keys=1", "HEAD", typeof(OpenExchangeRateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate", "HEAD", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/config/open-exchange-rate", "HEAD", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/page/1", "HEAD", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/config/open-exchange-rate/page/1", "HEAD", typeof(OpenExchangeRateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/count-filtered/{filterName}", "HEAD", typeof(OpenExchangeRateController), "CountFiltered")]
        [InlineData("/api/config/open-exchange-rate/count-filtered/{filterName}", "HEAD", typeof(OpenExchangeRateController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(OpenExchangeRateController), "GetFiltered")]
        [InlineData("/api/config/open-exchange-rate/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(OpenExchangeRateController), "GetFiltered")]
        [InlineData("/api/config/open-exchange-rate/first", "HEAD", typeof(OpenExchangeRateController), "GetFirst")]
        [InlineData("/api/config/open-exchange-rate/previous/1", "HEAD", typeof(OpenExchangeRateController), "GetPrevious")]
        [InlineData("/api/config/open-exchange-rate/next/1", "HEAD", typeof(OpenExchangeRateController), "GetNext")]
        [InlineData("/api/config/open-exchange-rate/last", "HEAD", typeof(OpenExchangeRateController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/custom-fields", "HEAD", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/config/open-exchange-rate/custom-fields", "HEAD", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/open-exchange-rate/custom-fields/{resourceId}", "HEAD", typeof(OpenExchangeRateController), "GetCustomFields")]
        [InlineData("/api/config/open-exchange-rate/custom-fields/{resourceId}", "HEAD", typeof(OpenExchangeRateController), "GetCustomFields")]

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

        public OpenExchangeRateRouteTests()
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