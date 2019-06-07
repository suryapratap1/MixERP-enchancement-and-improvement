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

namespace MixERP.Net.Api.Policy.Tests
{
    public class DefaultEntityAccessScrudViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/count", "GET", typeof(DefaultEntityAccessScrudViewController), "Count")]
        [InlineData("/api/policy/default-entity-access-scrud-view/count", "GET", typeof(DefaultEntityAccessScrudViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/all", "GET", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/policy/default-entity-access-scrud-view/all", "GET", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/export", "GET", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/policy/default-entity-access-scrud-view/export", "GET", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view", "GET", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/policy/default-entity-access-scrud-view", "GET", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/page/1", "GET", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/policy/default-entity-access-scrud-view/page/1", "GET", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/count-filtered/{filterName}", "GET", typeof(DefaultEntityAccessScrudViewController), "CountFiltered")]
        [InlineData("/api/policy/default-entity-access-scrud-view/count-filtered/{filterName}", "GET", typeof(DefaultEntityAccessScrudViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DefaultEntityAccessScrudViewController), "GetFiltered")]
        [InlineData("/api/policy/default-entity-access-scrud-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DefaultEntityAccessScrudViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/display-fields", "GET", typeof(DefaultEntityAccessScrudViewController), "GetDisplayFields")]
        [InlineData("/api/policy/default-entity-access-scrud-view/display-fields", "GET", typeof(DefaultEntityAccessScrudViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/count", "HEAD", typeof(DefaultEntityAccessScrudViewController), "Count")]
        [InlineData("/api/policy/default-entity-access-scrud-view/count", "HEAD", typeof(DefaultEntityAccessScrudViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/all", "HEAD", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/policy/default-entity-access-scrud-view/all", "HEAD", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/export", "HEAD", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/policy/default-entity-access-scrud-view/export", "HEAD", typeof(DefaultEntityAccessScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/policy/default-entity-access-scrud-view", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/page/1", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/policy/default-entity-access-scrud-view/page/1", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/count-filtered/{filterName}", "HEAD", typeof(DefaultEntityAccessScrudViewController), "CountFiltered")]
        [InlineData("/api/policy/default-entity-access-scrud-view/count-filtered/{filterName}", "HEAD", typeof(DefaultEntityAccessScrudViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetFiltered")]
        [InlineData("/api/policy/default-entity-access-scrud-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/default-entity-access-scrud-view/display-fields", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetDisplayFields")]
        [InlineData("/api/policy/default-entity-access-scrud-view/display-fields", "HEAD", typeof(DefaultEntityAccessScrudViewController), "GetDisplayFields")]

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

        public DefaultEntityAccessScrudViewRouteTests()
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