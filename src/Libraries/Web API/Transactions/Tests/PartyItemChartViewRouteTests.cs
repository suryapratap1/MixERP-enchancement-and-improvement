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
    public class PartyItemChartViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/count", "GET", typeof(PartyItemChartViewController), "Count")]
        [InlineData("/api/transactions/party-item-chart-view/count", "GET", typeof(PartyItemChartViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/all", "GET", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/transactions/party-item-chart-view/all", "GET", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/export", "GET", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/transactions/party-item-chart-view/export", "GET", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view", "GET", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/party-item-chart-view", "GET", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/page/1", "GET", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/party-item-chart-view/page/1", "GET", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/count-filtered/{filterName}", "GET", typeof(PartyItemChartViewController), "CountFiltered")]
        [InlineData("/api/transactions/party-item-chart-view/count-filtered/{filterName}", "GET", typeof(PartyItemChartViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyItemChartViewController), "GetFiltered")]
        [InlineData("/api/transactions/party-item-chart-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyItemChartViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/display-fields", "GET", typeof(PartyItemChartViewController), "GetDisplayFields")]
        [InlineData("/api/transactions/party-item-chart-view/display-fields", "GET", typeof(PartyItemChartViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/count", "HEAD", typeof(PartyItemChartViewController), "Count")]
        [InlineData("/api/transactions/party-item-chart-view/count", "HEAD", typeof(PartyItemChartViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/all", "HEAD", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/transactions/party-item-chart-view/all", "HEAD", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/export", "HEAD", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/transactions/party-item-chart-view/export", "HEAD", typeof(PartyItemChartViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view", "HEAD", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/party-item-chart-view", "HEAD", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/page/1", "HEAD", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/transactions/party-item-chart-view/page/1", "HEAD", typeof(PartyItemChartViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/count-filtered/{filterName}", "HEAD", typeof(PartyItemChartViewController), "CountFiltered")]
        [InlineData("/api/transactions/party-item-chart-view/count-filtered/{filterName}", "HEAD", typeof(PartyItemChartViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyItemChartViewController), "GetFiltered")]
        [InlineData("/api/transactions/party-item-chart-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyItemChartViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/party-item-chart-view/display-fields", "HEAD", typeof(PartyItemChartViewController), "GetDisplayFields")]
        [InlineData("/api/transactions/party-item-chart-view/display-fields", "HEAD", typeof(PartyItemChartViewController), "GetDisplayFields")]

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

        public PartyItemChartViewRouteTests()
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