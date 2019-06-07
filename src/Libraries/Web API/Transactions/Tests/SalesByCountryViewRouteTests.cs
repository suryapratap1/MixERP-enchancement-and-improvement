// ReSharper disable All
using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Web.Http;
using System.Runtime.Caching;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class SalesByCountryViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/count", "GET", typeof(SalesByCountryViewController), "Count")]
        [InlineData("/api/transactions/sales-by-country-view/count", "GET", typeof(SalesByCountryViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/all", "GET", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/transactions/sales-by-country-view/all", "GET", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/export", "GET", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/transactions/sales-by-country-view/export", "GET", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view", "GET", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/sales-by-country-view", "GET", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/page/1", "GET", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/sales-by-country-view/page/1", "GET", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/count-filtered/{filterName}", "GET", typeof(SalesByCountryViewController), "CountFiltered")]
        [InlineData("/api/transactions/sales-by-country-view/count-filtered/{filterName}", "GET", typeof(SalesByCountryViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesByCountryViewController), "GetFiltered")]
        [InlineData("/api/transactions/sales-by-country-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesByCountryViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/display-fields", "GET", typeof(SalesByCountryViewController), "GetDisplayFields")]
        [InlineData("/api/transactions/sales-by-country-view/display-fields", "GET", typeof(SalesByCountryViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/count", "HEAD", typeof(SalesByCountryViewController), "Count")]
        [InlineData("/api/transactions/sales-by-country-view/count", "HEAD", typeof(SalesByCountryViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/all", "HEAD", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/transactions/sales-by-country-view/all", "HEAD", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/export", "HEAD", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/transactions/sales-by-country-view/export", "HEAD", typeof(SalesByCountryViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view", "HEAD", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/sales-by-country-view", "HEAD", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/page/1", "HEAD", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/sales-by-country-view/page/1", "HEAD", typeof(SalesByCountryViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/count-filtered/{filterName}", "HEAD", typeof(SalesByCountryViewController), "CountFiltered")]
        [InlineData("/api/transactions/sales-by-country-view/count-filtered/{filterName}", "HEAD", typeof(SalesByCountryViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesByCountryViewController), "GetFiltered")]
        [InlineData("/api/transactions/sales-by-country-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesByCountryViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/sales-by-country-view/display-fields", "HEAD", typeof(SalesByCountryViewController), "GetDisplayFields")]
        [InlineData("/api/transactions/sales-by-country-view/display-fields", "HEAD", typeof(SalesByCountryViewController), "GetDisplayFields")]

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

        public SalesByCountryViewRouteTests()
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