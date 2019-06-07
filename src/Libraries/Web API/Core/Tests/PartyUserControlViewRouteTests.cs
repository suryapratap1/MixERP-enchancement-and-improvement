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

namespace MixERP.Net.Api.Core.Tests
{
    public class PartyUserControlViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/count", "GET", typeof(PartyUserControlViewController), "Count")]
        [InlineData("/api/core/party-user-control-view/count", "GET", typeof(PartyUserControlViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/all", "GET", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/core/party-user-control-view/all", "GET", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/export", "GET", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/core/party-user-control-view/export", "GET", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view", "GET", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/core/party-user-control-view", "GET", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/page/1", "GET", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/core/party-user-control-view/page/1", "GET", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/count-filtered/{filterName}", "GET", typeof(PartyUserControlViewController), "CountFiltered")]
        [InlineData("/api/core/party-user-control-view/count-filtered/{filterName}", "GET", typeof(PartyUserControlViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyUserControlViewController), "GetFiltered")]
        [InlineData("/api/core/party-user-control-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyUserControlViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/display-fields", "GET", typeof(PartyUserControlViewController), "GetDisplayFields")]
        [InlineData("/api/core/party-user-control-view/display-fields", "GET", typeof(PartyUserControlViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/count", "HEAD", typeof(PartyUserControlViewController), "Count")]
        [InlineData("/api/core/party-user-control-view/count", "HEAD", typeof(PartyUserControlViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/all", "HEAD", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/core/party-user-control-view/all", "HEAD", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/export", "HEAD", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/core/party-user-control-view/export", "HEAD", typeof(PartyUserControlViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view", "HEAD", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/core/party-user-control-view", "HEAD", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/page/1", "HEAD", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/core/party-user-control-view/page/1", "HEAD", typeof(PartyUserControlViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/count-filtered/{filterName}", "HEAD", typeof(PartyUserControlViewController), "CountFiltered")]
        [InlineData("/api/core/party-user-control-view/count-filtered/{filterName}", "HEAD", typeof(PartyUserControlViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyUserControlViewController), "GetFiltered")]
        [InlineData("/api/core/party-user-control-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyUserControlViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party-user-control-view/display-fields", "HEAD", typeof(PartyUserControlViewController), "GetDisplayFields")]
        [InlineData("/api/core/party-user-control-view/display-fields", "HEAD", typeof(PartyUserControlViewController), "GetDisplayFields")]

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

        public PartyUserControlViewRouteTests()
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