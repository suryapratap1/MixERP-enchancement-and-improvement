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
    public class PriceTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/price-type/delete/{priceTypeId}", "DELETE", typeof(PriceTypeController), "Delete")]
        [InlineData("/api/core/price-type/delete/{priceTypeId}", "DELETE", typeof(PriceTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/edit/{priceTypeId}", "PUT", typeof(PriceTypeController), "Edit")]
        [InlineData("/api/core/price-type/edit/{priceTypeId}", "PUT", typeof(PriceTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/count-where", "POST", typeof(PriceTypeController), "CountWhere")]
        [InlineData("/api/core/price-type/count-where", "POST", typeof(PriceTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/get-where/{pageNumber}", "POST", typeof(PriceTypeController), "GetWhere")]
        [InlineData("/api/core/price-type/get-where/{pageNumber}", "POST", typeof(PriceTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/add-or-edit", "POST", typeof(PriceTypeController), "AddOrEdit")]
        [InlineData("/api/core/price-type/add-or-edit", "POST", typeof(PriceTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/add/{priceType}", "POST", typeof(PriceTypeController), "Add")]
        [InlineData("/api/core/price-type/add/{priceType}", "POST", typeof(PriceTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/bulk-import", "POST", typeof(PriceTypeController), "BulkImport")]
        [InlineData("/api/core/price-type/bulk-import", "POST", typeof(PriceTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/meta", "GET", typeof(PriceTypeController), "GetEntityView")]
        [InlineData("/api/core/price-type/meta", "GET", typeof(PriceTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/count", "GET", typeof(PriceTypeController), "Count")]
        [InlineData("/api/core/price-type/count", "GET", typeof(PriceTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/all", "GET", typeof(PriceTypeController), "GetAll")]
        [InlineData("/api/core/price-type/all", "GET", typeof(PriceTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/export", "GET", typeof(PriceTypeController), "Export")]
        [InlineData("/api/core/price-type/export", "GET", typeof(PriceTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/1", "GET", typeof(PriceTypeController), "Get")]
        [InlineData("/api/core/price-type/1", "GET", typeof(PriceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/get?priceTypeIds=1", "GET", typeof(PriceTypeController), "Get")]
        [InlineData("/api/core/price-type/get?priceTypeIds=1", "GET", typeof(PriceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/price-type", "GET", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/price-type", "GET", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/page/1", "GET", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/price-type/page/1", "GET", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/count-filtered/{filterName}", "GET", typeof(PriceTypeController), "CountFiltered")]
        [InlineData("/api/core/price-type/count-filtered/{filterName}", "GET", typeof(PriceTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PriceTypeController), "GetFiltered")]
        [InlineData("/api/core/price-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PriceTypeController), "GetFiltered")]
        [InlineData("/api/core/price-type/first", "GET", typeof(PriceTypeController), "GetFirst")]
        [InlineData("/api/core/price-type/previous/1", "GET", typeof(PriceTypeController), "GetPrevious")]
        [InlineData("/api/core/price-type/next/1", "GET", typeof(PriceTypeController), "GetNext")]
        [InlineData("/api/core/price-type/last", "GET", typeof(PriceTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/price-type/custom-fields", "GET", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/core/price-type/custom-fields", "GET", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/custom-fields/{resourceId}", "GET", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/core/price-type/custom-fields/{resourceId}", "GET", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/meta", "HEAD", typeof(PriceTypeController), "GetEntityView")]
        [InlineData("/api/core/price-type/meta", "HEAD", typeof(PriceTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/count", "HEAD", typeof(PriceTypeController), "Count")]
        [InlineData("/api/core/price-type/count", "HEAD", typeof(PriceTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/all", "HEAD", typeof(PriceTypeController), "GetAll")]
        [InlineData("/api/core/price-type/all", "HEAD", typeof(PriceTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/export", "HEAD", typeof(PriceTypeController), "Export")]
        [InlineData("/api/core/price-type/export", "HEAD", typeof(PriceTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/1", "HEAD", typeof(PriceTypeController), "Get")]
        [InlineData("/api/core/price-type/1", "HEAD", typeof(PriceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/get?priceTypeIds=1", "HEAD", typeof(PriceTypeController), "Get")]
        [InlineData("/api/core/price-type/get?priceTypeIds=1", "HEAD", typeof(PriceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/price-type", "HEAD", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/price-type", "HEAD", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/page/1", "HEAD", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/price-type/page/1", "HEAD", typeof(PriceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/count-filtered/{filterName}", "HEAD", typeof(PriceTypeController), "CountFiltered")]
        [InlineData("/api/core/price-type/count-filtered/{filterName}", "HEAD", typeof(PriceTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PriceTypeController), "GetFiltered")]
        [InlineData("/api/core/price-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PriceTypeController), "GetFiltered")]
        [InlineData("/api/core/price-type/first", "HEAD", typeof(PriceTypeController), "GetFirst")]
        [InlineData("/api/core/price-type/previous/1", "HEAD", typeof(PriceTypeController), "GetPrevious")]
        [InlineData("/api/core/price-type/next/1", "HEAD", typeof(PriceTypeController), "GetNext")]
        [InlineData("/api/core/price-type/last", "HEAD", typeof(PriceTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/price-type/custom-fields", "HEAD", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/core/price-type/custom-fields", "HEAD", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/price-type/custom-fields/{resourceId}", "HEAD", typeof(PriceTypeController), "GetCustomFields")]
        [InlineData("/api/core/price-type/custom-fields/{resourceId}", "HEAD", typeof(PriceTypeController), "GetCustomFields")]

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

        public PriceTypeRouteTests()
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