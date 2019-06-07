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

namespace MixERP.Net.Api.Office.Tests
{
    public class UserViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/user-view/count", "GET", typeof(UserViewController), "Count")]
        [InlineData("/api/office/user-view/count", "GET", typeof(UserViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/all", "GET", typeof(UserViewController), "Get")]
        [InlineData("/api/office/user-view/all", "GET", typeof(UserViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/export", "GET", typeof(UserViewController), "Get")]
        [InlineData("/api/office/user-view/export", "GET", typeof(UserViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user-view", "GET", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/office/user-view", "GET", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/page/1", "GET", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/office/user-view/page/1", "GET", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/count-filtered/{filterName}", "GET", typeof(UserViewController), "CountFiltered")]
        [InlineData("/api/office/user-view/count-filtered/{filterName}", "GET", typeof(UserViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(UserViewController), "GetFiltered")]
        [InlineData("/api/office/user-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(UserViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/display-fields", "GET", typeof(UserViewController), "GetDisplayFields")]
        [InlineData("/api/office/user-view/display-fields", "GET", typeof(UserViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/count", "HEAD", typeof(UserViewController), "Count")]
        [InlineData("/api/office/user-view/count", "HEAD", typeof(UserViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/all", "HEAD", typeof(UserViewController), "Get")]
        [InlineData("/api/office/user-view/all", "HEAD", typeof(UserViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/export", "HEAD", typeof(UserViewController), "Get")]
        [InlineData("/api/office/user-view/export", "HEAD", typeof(UserViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user-view", "HEAD", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/office/user-view", "HEAD", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/page/1", "HEAD", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/office/user-view/page/1", "HEAD", typeof(UserViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/count-filtered/{filterName}", "HEAD", typeof(UserViewController), "CountFiltered")]
        [InlineData("/api/office/user-view/count-filtered/{filterName}", "HEAD", typeof(UserViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(UserViewController), "GetFiltered")]
        [InlineData("/api/office/user-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(UserViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/user-view/display-fields", "HEAD", typeof(UserViewController), "GetDisplayFields")]
        [InlineData("/api/office/user-view/display-fields", "HEAD", typeof(UserViewController), "GetDisplayFields")]

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

        public UserViewRouteTests()
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