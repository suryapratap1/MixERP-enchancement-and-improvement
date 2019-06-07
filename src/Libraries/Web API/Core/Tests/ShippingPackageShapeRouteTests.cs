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
    public class ShippingPackageShapeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/delete/{shippingPackageShapeId}", "DELETE", typeof(ShippingPackageShapeController), "Delete")]
        [InlineData("/api/core/shipping-package-shape/delete/{shippingPackageShapeId}", "DELETE", typeof(ShippingPackageShapeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/edit/{shippingPackageShapeId}", "PUT", typeof(ShippingPackageShapeController), "Edit")]
        [InlineData("/api/core/shipping-package-shape/edit/{shippingPackageShapeId}", "PUT", typeof(ShippingPackageShapeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/count-where", "POST", typeof(ShippingPackageShapeController), "CountWhere")]
        [InlineData("/api/core/shipping-package-shape/count-where", "POST", typeof(ShippingPackageShapeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/get-where/{pageNumber}", "POST", typeof(ShippingPackageShapeController), "GetWhere")]
        [InlineData("/api/core/shipping-package-shape/get-where/{pageNumber}", "POST", typeof(ShippingPackageShapeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/add-or-edit", "POST", typeof(ShippingPackageShapeController), "AddOrEdit")]
        [InlineData("/api/core/shipping-package-shape/add-or-edit", "POST", typeof(ShippingPackageShapeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/add/{shippingPackageShape}", "POST", typeof(ShippingPackageShapeController), "Add")]
        [InlineData("/api/core/shipping-package-shape/add/{shippingPackageShape}", "POST", typeof(ShippingPackageShapeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/bulk-import", "POST", typeof(ShippingPackageShapeController), "BulkImport")]
        [InlineData("/api/core/shipping-package-shape/bulk-import", "POST", typeof(ShippingPackageShapeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/meta", "GET", typeof(ShippingPackageShapeController), "GetEntityView")]
        [InlineData("/api/core/shipping-package-shape/meta", "GET", typeof(ShippingPackageShapeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/count", "GET", typeof(ShippingPackageShapeController), "Count")]
        [InlineData("/api/core/shipping-package-shape/count", "GET", typeof(ShippingPackageShapeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/all", "GET", typeof(ShippingPackageShapeController), "GetAll")]
        [InlineData("/api/core/shipping-package-shape/all", "GET", typeof(ShippingPackageShapeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/export", "GET", typeof(ShippingPackageShapeController), "Export")]
        [InlineData("/api/core/shipping-package-shape/export", "GET", typeof(ShippingPackageShapeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/1", "GET", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/core/shipping-package-shape/1", "GET", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/get?shippingPackageShapeIds=1", "GET", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/core/shipping-package-shape/get?shippingPackageShapeIds=1", "GET", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape", "GET", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-package-shape", "GET", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/page/1", "GET", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-package-shape/page/1", "GET", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/count-filtered/{filterName}", "GET", typeof(ShippingPackageShapeController), "CountFiltered")]
        [InlineData("/api/core/shipping-package-shape/count-filtered/{filterName}", "GET", typeof(ShippingPackageShapeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShippingPackageShapeController), "GetFiltered")]
        [InlineData("/api/core/shipping-package-shape/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShippingPackageShapeController), "GetFiltered")]
        [InlineData("/api/core/shipping-package-shape/first", "GET", typeof(ShippingPackageShapeController), "GetFirst")]
        [InlineData("/api/core/shipping-package-shape/previous/1", "GET", typeof(ShippingPackageShapeController), "GetPrevious")]
        [InlineData("/api/core/shipping-package-shape/next/1", "GET", typeof(ShippingPackageShapeController), "GetNext")]
        [InlineData("/api/core/shipping-package-shape/last", "GET", typeof(ShippingPackageShapeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/custom-fields", "GET", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-package-shape/custom-fields", "GET", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/custom-fields/{resourceId}", "GET", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-package-shape/custom-fields/{resourceId}", "GET", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/meta", "HEAD", typeof(ShippingPackageShapeController), "GetEntityView")]
        [InlineData("/api/core/shipping-package-shape/meta", "HEAD", typeof(ShippingPackageShapeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/count", "HEAD", typeof(ShippingPackageShapeController), "Count")]
        [InlineData("/api/core/shipping-package-shape/count", "HEAD", typeof(ShippingPackageShapeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/all", "HEAD", typeof(ShippingPackageShapeController), "GetAll")]
        [InlineData("/api/core/shipping-package-shape/all", "HEAD", typeof(ShippingPackageShapeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/export", "HEAD", typeof(ShippingPackageShapeController), "Export")]
        [InlineData("/api/core/shipping-package-shape/export", "HEAD", typeof(ShippingPackageShapeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/1", "HEAD", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/core/shipping-package-shape/1", "HEAD", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/get?shippingPackageShapeIds=1", "HEAD", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/core/shipping-package-shape/get?shippingPackageShapeIds=1", "HEAD", typeof(ShippingPackageShapeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape", "HEAD", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-package-shape", "HEAD", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/page/1", "HEAD", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-package-shape/page/1", "HEAD", typeof(ShippingPackageShapeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/count-filtered/{filterName}", "HEAD", typeof(ShippingPackageShapeController), "CountFiltered")]
        [InlineData("/api/core/shipping-package-shape/count-filtered/{filterName}", "HEAD", typeof(ShippingPackageShapeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShippingPackageShapeController), "GetFiltered")]
        [InlineData("/api/core/shipping-package-shape/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShippingPackageShapeController), "GetFiltered")]
        [InlineData("/api/core/shipping-package-shape/first", "HEAD", typeof(ShippingPackageShapeController), "GetFirst")]
        [InlineData("/api/core/shipping-package-shape/previous/1", "HEAD", typeof(ShippingPackageShapeController), "GetPrevious")]
        [InlineData("/api/core/shipping-package-shape/next/1", "HEAD", typeof(ShippingPackageShapeController), "GetNext")]
        [InlineData("/api/core/shipping-package-shape/last", "HEAD", typeof(ShippingPackageShapeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/custom-fields", "HEAD", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-package-shape/custom-fields", "HEAD", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-package-shape/custom-fields/{resourceId}", "HEAD", typeof(ShippingPackageShapeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-package-shape/custom-fields/{resourceId}", "HEAD", typeof(ShippingPackageShapeController), "GetCustomFields")]

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

        public ShippingPackageShapeRouteTests()
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