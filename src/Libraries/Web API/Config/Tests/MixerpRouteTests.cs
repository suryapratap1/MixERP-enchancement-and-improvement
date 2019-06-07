// ReSharper disable All
using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Hosting;
using System.Web.Http.Routing;
using Xunit;

namespace MixERP.Net.Api.Config.Tests
{
    public class MixerpRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/delete/{key}", "DELETE", typeof(MixerpController), "Delete")]
        [InlineData("/api/config/mixerp/delete/{key}", "DELETE", typeof(MixerpController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/edit/{key}", "PUT", typeof(MixerpController), "Edit")]
        [InlineData("/api/config/mixerp/edit/{key}", "PUT", typeof(MixerpController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/count-where", "POST", typeof(MixerpController), "CountWhere")]
        [InlineData("/api/config/mixerp/count-where", "POST", typeof(MixerpController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/get-where/{pageNumber}", "POST", typeof(MixerpController), "GetWhere")]
        [InlineData("/api/config/mixerp/get-where/{pageNumber}", "POST", typeof(MixerpController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/add-or-edit", "POST", typeof(MixerpController), "AddOrEdit")]
        [InlineData("/api/config/mixerp/add-or-edit", "POST", typeof(MixerpController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/add/{mixerp}", "POST", typeof(MixerpController), "Add")]
        [InlineData("/api/config/mixerp/add/{mixerp}", "POST", typeof(MixerpController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/bulk-import", "POST", typeof(MixerpController), "BulkImport")]
        [InlineData("/api/config/mixerp/bulk-import", "POST", typeof(MixerpController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/meta", "GET", typeof(MixerpController), "GetEntityView")]
        [InlineData("/api/config/mixerp/meta", "GET", typeof(MixerpController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/count", "GET", typeof(MixerpController), "Count")]
        [InlineData("/api/config/mixerp/count", "GET", typeof(MixerpController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/all", "GET", typeof(MixerpController), "GetAll")]
        [InlineData("/api/config/mixerp/all", "GET", typeof(MixerpController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/export", "GET", typeof(MixerpController), "Export")]
        [InlineData("/api/config/mixerp/export", "GET", typeof(MixerpController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/1", "GET", typeof(MixerpController), "Get")]
        [InlineData("/api/config/mixerp/1", "GET", typeof(MixerpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/get?keys=1", "GET", typeof(MixerpController), "Get")]
        [InlineData("/api/config/mixerp/get?keys=1", "GET", typeof(MixerpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp", "GET", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/config/mixerp", "GET", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/page/1", "GET", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/config/mixerp/page/1", "GET", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/count-filtered/{filterName}", "GET", typeof(MixerpController), "CountFiltered")]
        [InlineData("/api/config/mixerp/count-filtered/{filterName}", "GET", typeof(MixerpController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MixerpController), "GetFiltered")]
        [InlineData("/api/config/mixerp/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MixerpController), "GetFiltered")]
        [InlineData("/api/config/mixerp/first", "GET", typeof(MixerpController), "GetFirst")]
        [InlineData("/api/config/mixerp/previous/1", "GET", typeof(MixerpController), "GetPrevious")]
        [InlineData("/api/config/mixerp/next/1", "GET", typeof(MixerpController), "GetNext")]
        [InlineData("/api/config/mixerp/last", "GET", typeof(MixerpController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/mixerp/custom-fields", "GET", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/config/mixerp/custom-fields", "GET", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/custom-fields/{resourceId}", "GET", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/config/mixerp/custom-fields/{resourceId}", "GET", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/meta", "HEAD", typeof(MixerpController), "GetEntityView")]
        [InlineData("/api/config/mixerp/meta", "HEAD", typeof(MixerpController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/count", "HEAD", typeof(MixerpController), "Count")]
        [InlineData("/api/config/mixerp/count", "HEAD", typeof(MixerpController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/all", "HEAD", typeof(MixerpController), "GetAll")]
        [InlineData("/api/config/mixerp/all", "HEAD", typeof(MixerpController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/export", "HEAD", typeof(MixerpController), "Export")]
        [InlineData("/api/config/mixerp/export", "HEAD", typeof(MixerpController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/1", "HEAD", typeof(MixerpController), "Get")]
        [InlineData("/api/config/mixerp/1", "HEAD", typeof(MixerpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/get?keys=1", "HEAD", typeof(MixerpController), "Get")]
        [InlineData("/api/config/mixerp/get?keys=1", "HEAD", typeof(MixerpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp", "HEAD", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/config/mixerp", "HEAD", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/page/1", "HEAD", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/config/mixerp/page/1", "HEAD", typeof(MixerpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/count-filtered/{filterName}", "HEAD", typeof(MixerpController), "CountFiltered")]
        [InlineData("/api/config/mixerp/count-filtered/{filterName}", "HEAD", typeof(MixerpController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MixerpController), "GetFiltered")]
        [InlineData("/api/config/mixerp/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MixerpController), "GetFiltered")]
        [InlineData("/api/config/mixerp/first", "HEAD", typeof(MixerpController), "GetFirst")]
        [InlineData("/api/config/mixerp/previous/1", "HEAD", typeof(MixerpController), "GetPrevious")]
        [InlineData("/api/config/mixerp/next/1", "HEAD", typeof(MixerpController), "GetNext")]
        [InlineData("/api/config/mixerp/last", "HEAD", typeof(MixerpController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/mixerp/custom-fields", "HEAD", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/config/mixerp/custom-fields", "HEAD", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/mixerp/custom-fields/{resourceId}", "HEAD", typeof(MixerpController), "GetCustomFields")]
        [InlineData("/api/config/mixerp/custom-fields/{resourceId}", "HEAD", typeof(MixerpController), "GetCustomFields")]

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

        public MixerpRouteTests()
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