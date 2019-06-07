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

namespace MixERP.Net.Api.Core.Tests
{
    public class UnitRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/unit/delete/{unitId}", "DELETE", typeof(UnitController), "Delete")]
        [InlineData("/api/core/unit/delete/{unitId}", "DELETE", typeof(UnitController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/unit/edit/{unitId}", "PUT", typeof(UnitController), "Edit")]
        [InlineData("/api/core/unit/edit/{unitId}", "PUT", typeof(UnitController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/unit/count-where", "POST", typeof(UnitController), "CountWhere")]
        [InlineData("/api/core/unit/count-where", "POST", typeof(UnitController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/unit/get-where/{pageNumber}", "POST", typeof(UnitController), "GetWhere")]
        [InlineData("/api/core/unit/get-where/{pageNumber}", "POST", typeof(UnitController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/unit/add-or-edit", "POST", typeof(UnitController), "AddOrEdit")]
        [InlineData("/api/core/unit/add-or-edit", "POST", typeof(UnitController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/unit/add/{unit}", "POST", typeof(UnitController), "Add")]
        [InlineData("/api/core/unit/add/{unit}", "POST", typeof(UnitController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/unit/bulk-import", "POST", typeof(UnitController), "BulkImport")]
        [InlineData("/api/core/unit/bulk-import", "POST", typeof(UnitController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/unit/meta", "GET", typeof(UnitController), "GetEntityView")]
        [InlineData("/api/core/unit/meta", "GET", typeof(UnitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/unit/count", "GET", typeof(UnitController), "Count")]
        [InlineData("/api/core/unit/count", "GET", typeof(UnitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/unit/all", "GET", typeof(UnitController), "GetAll")]
        [InlineData("/api/core/unit/all", "GET", typeof(UnitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/unit/export", "GET", typeof(UnitController), "Export")]
        [InlineData("/api/core/unit/export", "GET", typeof(UnitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/unit/1", "GET", typeof(UnitController), "Get")]
        [InlineData("/api/core/unit/1", "GET", typeof(UnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/unit/get?unitIds=1", "GET", typeof(UnitController), "Get")]
        [InlineData("/api/core/unit/get?unitIds=1", "GET", typeof(UnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/unit", "GET", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/core/unit", "GET", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/unit/page/1", "GET", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/core/unit/page/1", "GET", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/unit/count-filtered/{filterName}", "GET", typeof(UnitController), "CountFiltered")]
        [InlineData("/api/core/unit/count-filtered/{filterName}", "GET", typeof(UnitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/unit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(UnitController), "GetFiltered")]
        [InlineData("/api/core/unit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(UnitController), "GetFiltered")]
        [InlineData("/api/core/unit/first", "GET", typeof(UnitController), "GetFirst")]
        [InlineData("/api/core/unit/previous/1", "GET", typeof(UnitController), "GetPrevious")]
        [InlineData("/api/core/unit/next/1", "GET", typeof(UnitController), "GetNext")]
        [InlineData("/api/core/unit/last", "GET", typeof(UnitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/unit/custom-fields", "GET", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/core/unit/custom-fields", "GET", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/unit/custom-fields/{resourceId}", "GET", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/core/unit/custom-fields/{resourceId}", "GET", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/unit/meta", "HEAD", typeof(UnitController), "GetEntityView")]
        [InlineData("/api/core/unit/meta", "HEAD", typeof(UnitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/unit/count", "HEAD", typeof(UnitController), "Count")]
        [InlineData("/api/core/unit/count", "HEAD", typeof(UnitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/unit/all", "HEAD", typeof(UnitController), "GetAll")]
        [InlineData("/api/core/unit/all", "HEAD", typeof(UnitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/unit/export", "HEAD", typeof(UnitController), "Export")]
        [InlineData("/api/core/unit/export", "HEAD", typeof(UnitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/unit/1", "HEAD", typeof(UnitController), "Get")]
        [InlineData("/api/core/unit/1", "HEAD", typeof(UnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/unit/get?unitIds=1", "HEAD", typeof(UnitController), "Get")]
        [InlineData("/api/core/unit/get?unitIds=1", "HEAD", typeof(UnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/unit", "HEAD", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/core/unit", "HEAD", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/unit/page/1", "HEAD", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/core/unit/page/1", "HEAD", typeof(UnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/unit/count-filtered/{filterName}", "HEAD", typeof(UnitController), "CountFiltered")]
        [InlineData("/api/core/unit/count-filtered/{filterName}", "HEAD", typeof(UnitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/unit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(UnitController), "GetFiltered")]
        [InlineData("/api/core/unit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(UnitController), "GetFiltered")]
        [InlineData("/api/core/unit/first", "HEAD", typeof(UnitController), "GetFirst")]
        [InlineData("/api/core/unit/previous/1", "HEAD", typeof(UnitController), "GetPrevious")]
        [InlineData("/api/core/unit/next/1", "HEAD", typeof(UnitController), "GetNext")]
        [InlineData("/api/core/unit/last", "HEAD", typeof(UnitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/unit/custom-fields", "HEAD", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/core/unit/custom-fields", "HEAD", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/unit/custom-fields/{resourceId}", "HEAD", typeof(UnitController), "GetCustomFields")]
        [InlineData("/api/core/unit/custom-fields/{resourceId}", "HEAD", typeof(UnitController), "GetCustomFields")]

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

        public UnitRouteTests()
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