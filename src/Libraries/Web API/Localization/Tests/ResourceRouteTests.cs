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

namespace MixERP.Net.Api.Localization.Tests
{
    public class ResourceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/localization/resource/delete/{resourceId}", "DELETE", typeof(ResourceController), "Delete")]
        [InlineData("/api/localization/resource/delete/{resourceId}", "DELETE", typeof(ResourceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/edit/{resourceId}", "PUT", typeof(ResourceController), "Edit")]
        [InlineData("/api/localization/resource/edit/{resourceId}", "PUT", typeof(ResourceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/count-where", "POST", typeof(ResourceController), "CountWhere")]
        [InlineData("/api/localization/resource/count-where", "POST", typeof(ResourceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/get-where/{pageNumber}", "POST", typeof(ResourceController), "GetWhere")]
        [InlineData("/api/localization/resource/get-where/{pageNumber}", "POST", typeof(ResourceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/add-or-edit", "POST", typeof(ResourceController), "AddOrEdit")]
        [InlineData("/api/localization/resource/add-or-edit", "POST", typeof(ResourceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/add/{resource}", "POST", typeof(ResourceController), "Add")]
        [InlineData("/api/localization/resource/add/{resource}", "POST", typeof(ResourceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/bulk-import", "POST", typeof(ResourceController), "BulkImport")]
        [InlineData("/api/localization/resource/bulk-import", "POST", typeof(ResourceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/meta", "GET", typeof(ResourceController), "GetEntityView")]
        [InlineData("/api/localization/resource/meta", "GET", typeof(ResourceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/count", "GET", typeof(ResourceController), "Count")]
        [InlineData("/api/localization/resource/count", "GET", typeof(ResourceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/all", "GET", typeof(ResourceController), "GetAll")]
        [InlineData("/api/localization/resource/all", "GET", typeof(ResourceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/export", "GET", typeof(ResourceController), "Export")]
        [InlineData("/api/localization/resource/export", "GET", typeof(ResourceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/1", "GET", typeof(ResourceController), "Get")]
        [InlineData("/api/localization/resource/1", "GET", typeof(ResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/get?resourceIds=1", "GET", typeof(ResourceController), "Get")]
        [InlineData("/api/localization/resource/get?resourceIds=1", "GET", typeof(ResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/resource", "GET", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/resource", "GET", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/page/1", "GET", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/resource/page/1", "GET", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/count-filtered/{filterName}", "GET", typeof(ResourceController), "CountFiltered")]
        [InlineData("/api/localization/resource/count-filtered/{filterName}", "GET", typeof(ResourceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ResourceController), "GetFiltered")]
        [InlineData("/api/localization/resource/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ResourceController), "GetFiltered")]
        [InlineData("/api/localization/resource/first", "GET", typeof(ResourceController), "GetFirst")]
        [InlineData("/api/localization/resource/previous/1", "GET", typeof(ResourceController), "GetPrevious")]
        [InlineData("/api/localization/resource/next/1", "GET", typeof(ResourceController), "GetNext")]
        [InlineData("/api/localization/resource/last", "GET", typeof(ResourceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/localization/resource/custom-fields", "GET", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/localization/resource/custom-fields", "GET", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/custom-fields/{resourceId}", "GET", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/localization/resource/custom-fields/{resourceId}", "GET", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/meta", "HEAD", typeof(ResourceController), "GetEntityView")]
        [InlineData("/api/localization/resource/meta", "HEAD", typeof(ResourceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/count", "HEAD", typeof(ResourceController), "Count")]
        [InlineData("/api/localization/resource/count", "HEAD", typeof(ResourceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/all", "HEAD", typeof(ResourceController), "GetAll")]
        [InlineData("/api/localization/resource/all", "HEAD", typeof(ResourceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/export", "HEAD", typeof(ResourceController), "Export")]
        [InlineData("/api/localization/resource/export", "HEAD", typeof(ResourceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/1", "HEAD", typeof(ResourceController), "Get")]
        [InlineData("/api/localization/resource/1", "HEAD", typeof(ResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/get?resourceIds=1", "HEAD", typeof(ResourceController), "Get")]
        [InlineData("/api/localization/resource/get?resourceIds=1", "HEAD", typeof(ResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/resource", "HEAD", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/resource", "HEAD", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/page/1", "HEAD", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/resource/page/1", "HEAD", typeof(ResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/count-filtered/{filterName}", "HEAD", typeof(ResourceController), "CountFiltered")]
        [InlineData("/api/localization/resource/count-filtered/{filterName}", "HEAD", typeof(ResourceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ResourceController), "GetFiltered")]
        [InlineData("/api/localization/resource/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ResourceController), "GetFiltered")]
        [InlineData("/api/localization/resource/first", "HEAD", typeof(ResourceController), "GetFirst")]
        [InlineData("/api/localization/resource/previous/1", "HEAD", typeof(ResourceController), "GetPrevious")]
        [InlineData("/api/localization/resource/next/1", "HEAD", typeof(ResourceController), "GetNext")]
        [InlineData("/api/localization/resource/last", "HEAD", typeof(ResourceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/localization/resource/custom-fields", "HEAD", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/localization/resource/custom-fields", "HEAD", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/resource/custom-fields/{resourceId}", "HEAD", typeof(ResourceController), "GetCustomFields")]
        [InlineData("/api/localization/resource/custom-fields/{resourceId}", "HEAD", typeof(ResourceController), "GetCustomFields")]

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

        public ResourceRouteTests()
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