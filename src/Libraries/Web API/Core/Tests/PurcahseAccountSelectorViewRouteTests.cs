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
    public class PurcahseAccountSelectorViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/count", "GET", typeof(PurcahseAccountSelectorViewController), "Count")]
        [InlineData("/api/core/purcahse-account-selector-view/count", "GET", typeof(PurcahseAccountSelectorViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/all", "GET", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/core/purcahse-account-selector-view/all", "GET", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/export", "GET", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/core/purcahse-account-selector-view/export", "GET", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view", "GET", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/core/purcahse-account-selector-view", "GET", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/page/1", "GET", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/core/purcahse-account-selector-view/page/1", "GET", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/count-filtered/{filterName}", "GET", typeof(PurcahseAccountSelectorViewController), "CountFiltered")]
        [InlineData("/api/core/purcahse-account-selector-view/count-filtered/{filterName}", "GET", typeof(PurcahseAccountSelectorViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PurcahseAccountSelectorViewController), "GetFiltered")]
        [InlineData("/api/core/purcahse-account-selector-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PurcahseAccountSelectorViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/display-fields", "GET", typeof(PurcahseAccountSelectorViewController), "GetDisplayFields")]
        [InlineData("/api/core/purcahse-account-selector-view/display-fields", "GET", typeof(PurcahseAccountSelectorViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/count", "HEAD", typeof(PurcahseAccountSelectorViewController), "Count")]
        [InlineData("/api/core/purcahse-account-selector-view/count", "HEAD", typeof(PurcahseAccountSelectorViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/all", "HEAD", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/core/purcahse-account-selector-view/all", "HEAD", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/export", "HEAD", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/core/purcahse-account-selector-view/export", "HEAD", typeof(PurcahseAccountSelectorViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/core/purcahse-account-selector-view", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/page/1", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/core/purcahse-account-selector-view/page/1", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/count-filtered/{filterName}", "HEAD", typeof(PurcahseAccountSelectorViewController), "CountFiltered")]
        [InlineData("/api/core/purcahse-account-selector-view/count-filtered/{filterName}", "HEAD", typeof(PurcahseAccountSelectorViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetFiltered")]
        [InlineData("/api/core/purcahse-account-selector-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/purcahse-account-selector-view/display-fields", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetDisplayFields")]
        [InlineData("/api/core/purcahse-account-selector-view/display-fields", "HEAD", typeof(PurcahseAccountSelectorViewController), "GetDisplayFields")]

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

        public PurcahseAccountSelectorViewRouteTests()
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