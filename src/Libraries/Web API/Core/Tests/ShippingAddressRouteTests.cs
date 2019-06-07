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
    public class ShippingAddressRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/delete/{shippingAddressId}", "DELETE", typeof(ShippingAddressController), "Delete")]
        [InlineData("/api/core/shipping-address/delete/{shippingAddressId}", "DELETE", typeof(ShippingAddressController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/edit/{shippingAddressId}", "PUT", typeof(ShippingAddressController), "Edit")]
        [InlineData("/api/core/shipping-address/edit/{shippingAddressId}", "PUT", typeof(ShippingAddressController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/count-where", "POST", typeof(ShippingAddressController), "CountWhere")]
        [InlineData("/api/core/shipping-address/count-where", "POST", typeof(ShippingAddressController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/get-where/{pageNumber}", "POST", typeof(ShippingAddressController), "GetWhere")]
        [InlineData("/api/core/shipping-address/get-where/{pageNumber}", "POST", typeof(ShippingAddressController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/add-or-edit", "POST", typeof(ShippingAddressController), "AddOrEdit")]
        [InlineData("/api/core/shipping-address/add-or-edit", "POST", typeof(ShippingAddressController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/add/{shippingAddress}", "POST", typeof(ShippingAddressController), "Add")]
        [InlineData("/api/core/shipping-address/add/{shippingAddress}", "POST", typeof(ShippingAddressController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/bulk-import", "POST", typeof(ShippingAddressController), "BulkImport")]
        [InlineData("/api/core/shipping-address/bulk-import", "POST", typeof(ShippingAddressController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/meta", "GET", typeof(ShippingAddressController), "GetEntityView")]
        [InlineData("/api/core/shipping-address/meta", "GET", typeof(ShippingAddressController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/count", "GET", typeof(ShippingAddressController), "Count")]
        [InlineData("/api/core/shipping-address/count", "GET", typeof(ShippingAddressController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/all", "GET", typeof(ShippingAddressController), "GetAll")]
        [InlineData("/api/core/shipping-address/all", "GET", typeof(ShippingAddressController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/export", "GET", typeof(ShippingAddressController), "Export")]
        [InlineData("/api/core/shipping-address/export", "GET", typeof(ShippingAddressController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/1", "GET", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/core/shipping-address/1", "GET", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/get?shippingAddressIds=1", "GET", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/core/shipping-address/get?shippingAddressIds=1", "GET", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address", "GET", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-address", "GET", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/page/1", "GET", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-address/page/1", "GET", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/count-filtered/{filterName}", "GET", typeof(ShippingAddressController), "CountFiltered")]
        [InlineData("/api/core/shipping-address/count-filtered/{filterName}", "GET", typeof(ShippingAddressController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShippingAddressController), "GetFiltered")]
        [InlineData("/api/core/shipping-address/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShippingAddressController), "GetFiltered")]
        [InlineData("/api/core/shipping-address/first", "GET", typeof(ShippingAddressController), "GetFirst")]
        [InlineData("/api/core/shipping-address/previous/1", "GET", typeof(ShippingAddressController), "GetPrevious")]
        [InlineData("/api/core/shipping-address/next/1", "GET", typeof(ShippingAddressController), "GetNext")]
        [InlineData("/api/core/shipping-address/last", "GET", typeof(ShippingAddressController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipping-address/custom-fields", "GET", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/core/shipping-address/custom-fields", "GET", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/custom-fields/{resourceId}", "GET", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/core/shipping-address/custom-fields/{resourceId}", "GET", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/meta", "HEAD", typeof(ShippingAddressController), "GetEntityView")]
        [InlineData("/api/core/shipping-address/meta", "HEAD", typeof(ShippingAddressController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/count", "HEAD", typeof(ShippingAddressController), "Count")]
        [InlineData("/api/core/shipping-address/count", "HEAD", typeof(ShippingAddressController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/all", "HEAD", typeof(ShippingAddressController), "GetAll")]
        [InlineData("/api/core/shipping-address/all", "HEAD", typeof(ShippingAddressController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/export", "HEAD", typeof(ShippingAddressController), "Export")]
        [InlineData("/api/core/shipping-address/export", "HEAD", typeof(ShippingAddressController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/1", "HEAD", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/core/shipping-address/1", "HEAD", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/get?shippingAddressIds=1", "HEAD", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/core/shipping-address/get?shippingAddressIds=1", "HEAD", typeof(ShippingAddressController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address", "HEAD", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-address", "HEAD", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/page/1", "HEAD", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-address/page/1", "HEAD", typeof(ShippingAddressController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/count-filtered/{filterName}", "HEAD", typeof(ShippingAddressController), "CountFiltered")]
        [InlineData("/api/core/shipping-address/count-filtered/{filterName}", "HEAD", typeof(ShippingAddressController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShippingAddressController), "GetFiltered")]
        [InlineData("/api/core/shipping-address/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShippingAddressController), "GetFiltered")]
        [InlineData("/api/core/shipping-address/first", "HEAD", typeof(ShippingAddressController), "GetFirst")]
        [InlineData("/api/core/shipping-address/previous/1", "HEAD", typeof(ShippingAddressController), "GetPrevious")]
        [InlineData("/api/core/shipping-address/next/1", "HEAD", typeof(ShippingAddressController), "GetNext")]
        [InlineData("/api/core/shipping-address/last", "HEAD", typeof(ShippingAddressController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipping-address/custom-fields", "HEAD", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/core/shipping-address/custom-fields", "HEAD", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-address/custom-fields/{resourceId}", "HEAD", typeof(ShippingAddressController), "GetCustomFields")]
        [InlineData("/api/core/shipping-address/custom-fields/{resourceId}", "HEAD", typeof(ShippingAddressController), "GetCustomFields")]

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

        public ShippingAddressRouteTests()
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