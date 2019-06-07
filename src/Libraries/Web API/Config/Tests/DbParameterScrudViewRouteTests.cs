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

namespace MixERP.Net.Api.Config.Tests
{
    public class DbParameterScrudViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/count", "GET", typeof(DbParameterScrudViewController), "Count")]
        [InlineData("/api/config/db-parameter-scrud-view/count", "GET", typeof(DbParameterScrudViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/all", "GET", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/config/db-parameter-scrud-view/all", "GET", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/export", "GET", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/config/db-parameter-scrud-view/export", "GET", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view", "GET", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter-scrud-view", "GET", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/page/1", "GET", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter-scrud-view/page/1", "GET", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/count-filtered/{filterName}", "GET", typeof(DbParameterScrudViewController), "CountFiltered")]
        [InlineData("/api/config/db-parameter-scrud-view/count-filtered/{filterName}", "GET", typeof(DbParameterScrudViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DbParameterScrudViewController), "GetFiltered")]
        [InlineData("/api/config/db-parameter-scrud-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DbParameterScrudViewController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/count", "HEAD", typeof(DbParameterScrudViewController), "Count")]
        [InlineData("/api/config/db-parameter-scrud-view/count", "HEAD", typeof(DbParameterScrudViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/all", "HEAD", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/config/db-parameter-scrud-view/all", "HEAD", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/export", "HEAD", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/config/db-parameter-scrud-view/export", "HEAD", typeof(DbParameterScrudViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view", "HEAD", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter-scrud-view", "HEAD", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/page/1", "HEAD", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter-scrud-view/page/1", "HEAD", typeof(DbParameterScrudViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/count-filtered/{filterName}", "HEAD", typeof(DbParameterScrudViewController), "CountFiltered")]
        [InlineData("/api/config/db-parameter-scrud-view/count-filtered/{filterName}", "HEAD", typeof(DbParameterScrudViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter-scrud-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DbParameterScrudViewController), "GetFiltered")]
        [InlineData("/api/config/db-parameter-scrud-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DbParameterScrudViewController), "GetFiltered")]


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

        public DbParameterScrudViewRouteTests()
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