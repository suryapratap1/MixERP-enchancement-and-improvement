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
    public class WidgetSetupViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/count", "GET", typeof(WidgetSetupViewController), "Count")]
        [InlineData("/api/core/widget-setup-view/count", "GET", typeof(WidgetSetupViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/all", "GET", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/core/widget-setup-view/all", "GET", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/export", "GET", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/core/widget-setup-view/export", "GET", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view", "GET", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup-view", "GET", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/page/1", "GET", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup-view/page/1", "GET", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/count-filtered/{filterName}", "GET", typeof(WidgetSetupViewController), "CountFiltered")]
        [InlineData("/api/core/widget-setup-view/count-filtered/{filterName}", "GET", typeof(WidgetSetupViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetSetupViewController), "GetFiltered")]
        [InlineData("/api/core/widget-setup-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetSetupViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/display-fields", "GET", typeof(WidgetSetupViewController), "GetDisplayFields")]
        [InlineData("/api/core/widget-setup-view/display-fields", "GET", typeof(WidgetSetupViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/count", "HEAD", typeof(WidgetSetupViewController), "Count")]
        [InlineData("/api/core/widget-setup-view/count", "HEAD", typeof(WidgetSetupViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/all", "HEAD", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/core/widget-setup-view/all", "HEAD", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/export", "HEAD", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/core/widget-setup-view/export", "HEAD", typeof(WidgetSetupViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view", "HEAD", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup-view", "HEAD", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/page/1", "HEAD", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup-view/page/1", "HEAD", typeof(WidgetSetupViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/count-filtered/{filterName}", "HEAD", typeof(WidgetSetupViewController), "CountFiltered")]
        [InlineData("/api/core/widget-setup-view/count-filtered/{filterName}", "HEAD", typeof(WidgetSetupViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetSetupViewController), "GetFiltered")]
        [InlineData("/api/core/widget-setup-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetSetupViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup-view/display-fields", "HEAD", typeof(WidgetSetupViewController), "GetDisplayFields")]
        [InlineData("/api/core/widget-setup-view/display-fields", "HEAD", typeof(WidgetSetupViewController), "GetDisplayFields")]

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

        public WidgetSetupViewRouteTests()
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