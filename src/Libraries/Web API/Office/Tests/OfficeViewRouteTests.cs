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
    public class OfficeViewRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/office-view/count", "GET", typeof(OfficeViewController), "Count")]
        [InlineData("/api/office/office-view/count", "GET", typeof(OfficeViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/all", "GET", typeof(OfficeViewController), "Get")]
        [InlineData("/api/office/office-view/all", "GET", typeof(OfficeViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/export", "GET", typeof(OfficeViewController), "Get")]
        [InlineData("/api/office/office-view/export", "GET", typeof(OfficeViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/office-view", "GET", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/office/office-view", "GET", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/page/1", "GET", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/office/office-view/page/1", "GET", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/count-filtered/{filterName}", "GET", typeof(OfficeViewController), "CountFiltered")]
        [InlineData("/api/office/office-view/count-filtered/{filterName}", "GET", typeof(OfficeViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(OfficeViewController), "GetFiltered")]
        [InlineData("/api/office/office-view/get-filtered/{pageNumber}/{filterName}", "GET", typeof(OfficeViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/display-fields", "GET", typeof(OfficeViewController), "GetDisplayFields")]
        [InlineData("/api/office/office-view/display-fields", "GET", typeof(OfficeViewController), "GetDisplayFields")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/count", "HEAD", typeof(OfficeViewController), "Count")]
        [InlineData("/api/office/office-view/count", "HEAD", typeof(OfficeViewController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/all", "HEAD", typeof(OfficeViewController), "Get")]
        [InlineData("/api/office/office-view/all", "HEAD", typeof(OfficeViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/export", "HEAD", typeof(OfficeViewController), "Get")]
        [InlineData("/api/office/office-view/export", "HEAD", typeof(OfficeViewController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/office-view", "HEAD", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/office/office-view", "HEAD", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/page/1", "HEAD", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/office/office-view/page/1", "HEAD", typeof(OfficeViewController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/count-filtered/{filterName}", "HEAD", typeof(OfficeViewController), "CountFiltered")]
        [InlineData("/api/office/office-view/count-filtered/{filterName}", "HEAD", typeof(OfficeViewController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(OfficeViewController), "GetFiltered")]
        [InlineData("/api/office/office-view/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(OfficeViewController), "GetFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/office-view/display-fields", "HEAD", typeof(OfficeViewController), "GetDisplayFields")]
        [InlineData("/api/office/office-view/display-fields", "HEAD", typeof(OfficeViewController), "GetDisplayFields")]

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

        public OfficeViewRouteTests()
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