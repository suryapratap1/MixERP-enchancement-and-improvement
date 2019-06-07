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
    public class ShippingMailTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/delete/{shippingMailTypeId}", "DELETE", typeof(ShippingMailTypeController), "Delete")]
        [InlineData("/api/core/shipping-mail-type/delete/{shippingMailTypeId}", "DELETE", typeof(ShippingMailTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/edit/{shippingMailTypeId}", "PUT", typeof(ShippingMailTypeController), "Edit")]
        [InlineData("/api/core/shipping-mail-type/edit/{shippingMailTypeId}", "PUT", typeof(ShippingMailTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/count-where", "POST", typeof(ShippingMailTypeController), "CountWhere")]
        [InlineData("/api/core/shipping-mail-type/count-where", "POST", typeof(ShippingMailTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/get-where/{pageNumber}", "POST", typeof(ShippingMailTypeController), "GetWhere")]
        [InlineData("/api/core/shipping-mail-type/get-where/{pageNumber}", "POST", typeof(ShippingMailTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/add-or-edit", "POST", typeof(ShippingMailTypeController), "AddOrEdit")]
        [InlineData("/api/core/shipping-mail-type/add-or-edit", "POST", typeof(ShippingMailTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/add/{shippingMailType}", "POST", typeof(ShippingMailTypeController), "Add")]
        [InlineData("/api/core/shipping-mail-type/add/{shippingMailType}", "POST", typeof(ShippingMailTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/bulk-import", "POST", typeof(ShippingMailTypeController), "BulkImport")]
        [InlineData("/api/core/shipping-mail-type/bulk-import", "POST", typeof(ShippingMailTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/meta", "GET", typeof(ShippingMailTypeController), "GetEntityView")]
        [InlineData("/api/core/shipping-mail-type/meta", "GET", typeof(ShippingMailTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/count", "GET", typeof(ShippingMailTypeController), "Count")]
        [InlineData("/api/core/shipping-mail-type/count", "GET", typeof(ShippingMailTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/all", "GET", typeof(ShippingMailTypeController), "GetAll")]
        [InlineData("/api/core/shipping-mail-type/all", "GET", typeof(ShippingMailTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/export", "GET", typeof(ShippingMailTypeController), "Export")]
        [InlineData("/api/core/shipping-mail-type/export", "GET", typeof(ShippingMailTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/1", "GET", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/core/shipping-mail-type/1", "GET", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/get?shippingMailTypeIds=1", "GET", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/core/shipping-mail-type/get?shippingMailTypeIds=1", "GET", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type", "GET", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-mail-type", "GET", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/page/1", "GET", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-mail-type/page/1", "GET", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/count-filtered/{filterName}", "GET", typeof(ShippingMailTypeController), "CountFiltered")]
        [InlineData("/api/core/shipping-mail-type/count-filtered/{filterName}", "GET", typeof(ShippingMailTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShippingMailTypeController), "GetFiltered")]
        [InlineData("/api/core/shipping-mail-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShippingMailTypeController), "GetFiltered")]
        [InlineData("/api/core/shipping-mail-type/first", "GET", typeof(ShippingMailTypeController), "GetFirst")]
        [InlineData("/api/core/shipping-mail-type/previous/1", "GET", typeof(ShippingMailTypeController), "GetPrevious")]
        [InlineData("/api/core/shipping-mail-type/next/1", "GET", typeof(ShippingMailTypeController), "GetNext")]
        [InlineData("/api/core/shipping-mail-type/last", "GET", typeof(ShippingMailTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/custom-fields", "GET", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-mail-type/custom-fields", "GET", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/custom-fields/{resourceId}", "GET", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-mail-type/custom-fields/{resourceId}", "GET", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/meta", "HEAD", typeof(ShippingMailTypeController), "GetEntityView")]
        [InlineData("/api/core/shipping-mail-type/meta", "HEAD", typeof(ShippingMailTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/count", "HEAD", typeof(ShippingMailTypeController), "Count")]
        [InlineData("/api/core/shipping-mail-type/count", "HEAD", typeof(ShippingMailTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/all", "HEAD", typeof(ShippingMailTypeController), "GetAll")]
        [InlineData("/api/core/shipping-mail-type/all", "HEAD", typeof(ShippingMailTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/export", "HEAD", typeof(ShippingMailTypeController), "Export")]
        [InlineData("/api/core/shipping-mail-type/export", "HEAD", typeof(ShippingMailTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/1", "HEAD", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/core/shipping-mail-type/1", "HEAD", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/get?shippingMailTypeIds=1", "HEAD", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/core/shipping-mail-type/get?shippingMailTypeIds=1", "HEAD", typeof(ShippingMailTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type", "HEAD", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-mail-type", "HEAD", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/page/1", "HEAD", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/shipping-mail-type/page/1", "HEAD", typeof(ShippingMailTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/count-filtered/{filterName}", "HEAD", typeof(ShippingMailTypeController), "CountFiltered")]
        [InlineData("/api/core/shipping-mail-type/count-filtered/{filterName}", "HEAD", typeof(ShippingMailTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShippingMailTypeController), "GetFiltered")]
        [InlineData("/api/core/shipping-mail-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShippingMailTypeController), "GetFiltered")]
        [InlineData("/api/core/shipping-mail-type/first", "HEAD", typeof(ShippingMailTypeController), "GetFirst")]
        [InlineData("/api/core/shipping-mail-type/previous/1", "HEAD", typeof(ShippingMailTypeController), "GetPrevious")]
        [InlineData("/api/core/shipping-mail-type/next/1", "HEAD", typeof(ShippingMailTypeController), "GetNext")]
        [InlineData("/api/core/shipping-mail-type/last", "HEAD", typeof(ShippingMailTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/custom-fields", "HEAD", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-mail-type/custom-fields", "HEAD", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/shipping-mail-type/custom-fields/{resourceId}", "HEAD", typeof(ShippingMailTypeController), "GetCustomFields")]
        [InlineData("/api/core/shipping-mail-type/custom-fields/{resourceId}", "HEAD", typeof(ShippingMailTypeController), "GetCustomFields")]

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

        public ShippingMailTypeRouteTests()
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