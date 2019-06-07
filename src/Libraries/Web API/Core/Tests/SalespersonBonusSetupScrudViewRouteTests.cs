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
    public class SalespersonBonusSetupScrudViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/count", "GET", typeof(SalespersonBonusSetupScrudViewController), "Count")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/count", "GET", typeof(SalespersonBonusSetupScrudViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/all", "GET", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/all", "GET", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/export", "GET", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/export", "GET", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/page/1", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/page/1", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/count-filtered/{filterName}", "GET", typeof(SalespersonBonusSetupScrudViewController), "CountFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/count-filtered/{filterName}", "GET", typeof(SalespersonBonusSetupScrudViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/display-fields", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetDisplayFields")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/display-fields", "GET", typeof(SalespersonBonusSetupScrudViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/count", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "Count")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/count", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/all", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/all", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/export", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/export", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/page/1", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/page/1", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/count-filtered/{filterName}", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "CountFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/count-filtered/{filterName}", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup-scrud-view/display-fields", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetDisplayFields")]
        [InlineData("/api/core/salesperson-bonus-setup-scrud-view/display-fields", "HEAD", typeof(SalespersonBonusSetupScrudViewController), "GetDisplayFields")]

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

        public SalespersonBonusSetupScrudViewRouteTests()
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