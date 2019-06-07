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
    public class ShipperRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/shipper/delete/{shipperId}", "DELETE", typeof(ShipperController), "Delete")]
        [InlineData("/api/core/shipper/delete/{shipperId}", "DELETE", typeof(ShipperController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/edit/{shipperId}", "PUT", typeof(ShipperController), "Edit")]
        [InlineData("/api/core/shipper/edit/{shipperId}", "PUT", typeof(ShipperController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/count-where", "POST", typeof(ShipperController), "CountWhere")]
        [InlineData("/api/core/shipper/count-where", "POST", typeof(ShipperController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/get-where/{pageNumber}", "POST", typeof(ShipperController), "GetWhere")]
        [InlineData("/api/core/shipper/get-where/{pageNumber}", "POST", typeof(ShipperController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/add-or-edit", "POST", typeof(ShipperController), "AddOrEdit")]
        [InlineData("/api/core/shipper/add-or-edit", "POST", typeof(ShipperController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/add/{shipper}", "POST", typeof(ShipperController), "Add")]
        [InlineData("/api/core/shipper/add/{shipper}", "POST", typeof(ShipperController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/bulk-import", "POST", typeof(ShipperController), "BulkImport")]
        [InlineData("/api/core/shipper/bulk-import", "POST", typeof(ShipperController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/meta", "GET", typeof(ShipperController), "GetEntityView")]
        [InlineData("/api/core/shipper/meta", "GET", typeof(ShipperController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/count", "GET", typeof(ShipperController), "Count")]
        [InlineData("/api/core/shipper/count", "GET", typeof(ShipperController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/all", "GET", typeof(ShipperController), "GetAll")]
        [InlineData("/api/core/shipper/all", "GET", typeof(ShipperController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/export", "GET", typeof(ShipperController), "Export")]
        [InlineData("/api/core/shipper/export", "GET", typeof(ShipperController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/1", "GET", typeof(ShipperController), "Get")]
        [InlineData("/api/core/shipper/1", "GET", typeof(ShipperController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/get?shipperIds=1", "GET", typeof(ShipperController), "Get")]
        [InlineData("/api/core/shipper/get?shipperIds=1", "GET", typeof(ShipperController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipper", "GET", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/core/shipper", "GET", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/page/1", "GET", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/core/shipper/page/1", "GET", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/count-filtered/{filterName}", "GET", typeof(ShipperController), "CountFiltered")]
        [InlineData("/api/core/shipper/count-filtered/{filterName}", "GET", typeof(ShipperController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShipperController), "GetFiltered")]
        [InlineData("/api/core/shipper/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShipperController), "GetFiltered")]
        [InlineData("/api/core/shipper/first", "GET", typeof(ShipperController), "GetFirst")]
        [InlineData("/api/core/shipper/previous/1", "GET", typeof(ShipperController), "GetPrevious")]
        [InlineData("/api/core/shipper/next/1", "GET", typeof(ShipperController), "GetNext")]
        [InlineData("/api/core/shipper/last", "GET", typeof(ShipperController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipper/custom-fields", "GET", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/core/shipper/custom-fields", "GET", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/custom-fields/{resourceId}", "GET", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/core/shipper/custom-fields/{resourceId}", "GET", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/meta", "HEAD", typeof(ShipperController), "GetEntityView")]
        [InlineData("/api/core/shipper/meta", "HEAD", typeof(ShipperController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/count", "HEAD", typeof(ShipperController), "Count")]
        [InlineData("/api/core/shipper/count", "HEAD", typeof(ShipperController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/all", "HEAD", typeof(ShipperController), "GetAll")]
        [InlineData("/api/core/shipper/all", "HEAD", typeof(ShipperController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/export", "HEAD", typeof(ShipperController), "Export")]
        [InlineData("/api/core/shipper/export", "HEAD", typeof(ShipperController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/1", "HEAD", typeof(ShipperController), "Get")]
        [InlineData("/api/core/shipper/1", "HEAD", typeof(ShipperController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/get?shipperIds=1", "HEAD", typeof(ShipperController), "Get")]
        [InlineData("/api/core/shipper/get?shipperIds=1", "HEAD", typeof(ShipperController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipper", "HEAD", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/core/shipper", "HEAD", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/page/1", "HEAD", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/core/shipper/page/1", "HEAD", typeof(ShipperController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/count-filtered/{filterName}", "HEAD", typeof(ShipperController), "CountFiltered")]
        [InlineData("/api/core/shipper/count-filtered/{filterName}", "HEAD", typeof(ShipperController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShipperController), "GetFiltered")]
        [InlineData("/api/core/shipper/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShipperController), "GetFiltered")]
        [InlineData("/api/core/shipper/first", "HEAD", typeof(ShipperController), "GetFirst")]
        [InlineData("/api/core/shipper/previous/1", "HEAD", typeof(ShipperController), "GetPrevious")]
        [InlineData("/api/core/shipper/next/1", "HEAD", typeof(ShipperController), "GetNext")]
        [InlineData("/api/core/shipper/last", "HEAD", typeof(ShipperController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipper/custom-fields", "HEAD", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/core/shipper/custom-fields", "HEAD", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipper/custom-fields/{resourceId}", "HEAD", typeof(ShipperController), "GetCustomFields")]
        [InlineData("/api/core/shipper/custom-fields/{resourceId}", "HEAD", typeof(ShipperController), "GetCustomFields")]

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

        public ShipperRouteTests()
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