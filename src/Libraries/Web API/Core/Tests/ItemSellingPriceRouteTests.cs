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
    public class ItemSellingPriceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/delete/{itemSellingPriceId}", "DELETE", typeof(ItemSellingPriceController), "Delete")]
        [InlineData("/api/core/item-selling-price/delete/{itemSellingPriceId}", "DELETE", typeof(ItemSellingPriceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/edit/{itemSellingPriceId}", "PUT", typeof(ItemSellingPriceController), "Edit")]
        [InlineData("/api/core/item-selling-price/edit/{itemSellingPriceId}", "PUT", typeof(ItemSellingPriceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/count-where", "POST", typeof(ItemSellingPriceController), "CountWhere")]
        [InlineData("/api/core/item-selling-price/count-where", "POST", typeof(ItemSellingPriceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/get-where/{pageNumber}", "POST", typeof(ItemSellingPriceController), "GetWhere")]
        [InlineData("/api/core/item-selling-price/get-where/{pageNumber}", "POST", typeof(ItemSellingPriceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/add-or-edit", "POST", typeof(ItemSellingPriceController), "AddOrEdit")]
        [InlineData("/api/core/item-selling-price/add-or-edit", "POST", typeof(ItemSellingPriceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/add/{itemSellingPrice}", "POST", typeof(ItemSellingPriceController), "Add")]
        [InlineData("/api/core/item-selling-price/add/{itemSellingPrice}", "POST", typeof(ItemSellingPriceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/bulk-import", "POST", typeof(ItemSellingPriceController), "BulkImport")]
        [InlineData("/api/core/item-selling-price/bulk-import", "POST", typeof(ItemSellingPriceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/meta", "GET", typeof(ItemSellingPriceController), "GetEntityView")]
        [InlineData("/api/core/item-selling-price/meta", "GET", typeof(ItemSellingPriceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/count", "GET", typeof(ItemSellingPriceController), "Count")]
        [InlineData("/api/core/item-selling-price/count", "GET", typeof(ItemSellingPriceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/all", "GET", typeof(ItemSellingPriceController), "GetAll")]
        [InlineData("/api/core/item-selling-price/all", "GET", typeof(ItemSellingPriceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/export", "GET", typeof(ItemSellingPriceController), "Export")]
        [InlineData("/api/core/item-selling-price/export", "GET", typeof(ItemSellingPriceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/1", "GET", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/core/item-selling-price/1", "GET", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/get?itemSellingPriceIds=1", "GET", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/core/item-selling-price/get?itemSellingPriceIds=1", "GET", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price", "GET", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-selling-price", "GET", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/page/1", "GET", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-selling-price/page/1", "GET", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/count-filtered/{filterName}", "GET", typeof(ItemSellingPriceController), "CountFiltered")]
        [InlineData("/api/core/item-selling-price/count-filtered/{filterName}", "GET", typeof(ItemSellingPriceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemSellingPriceController), "GetFiltered")]
        [InlineData("/api/core/item-selling-price/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemSellingPriceController), "GetFiltered")]
        [InlineData("/api/core/item-selling-price/first", "GET", typeof(ItemSellingPriceController), "GetFirst")]
        [InlineData("/api/core/item-selling-price/previous/1", "GET", typeof(ItemSellingPriceController), "GetPrevious")]
        [InlineData("/api/core/item-selling-price/next/1", "GET", typeof(ItemSellingPriceController), "GetNext")]
        [InlineData("/api/core/item-selling-price/last", "GET", typeof(ItemSellingPriceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/custom-fields", "GET", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-selling-price/custom-fields", "GET", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/custom-fields/{resourceId}", "GET", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-selling-price/custom-fields/{resourceId}", "GET", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/meta", "HEAD", typeof(ItemSellingPriceController), "GetEntityView")]
        [InlineData("/api/core/item-selling-price/meta", "HEAD", typeof(ItemSellingPriceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/count", "HEAD", typeof(ItemSellingPriceController), "Count")]
        [InlineData("/api/core/item-selling-price/count", "HEAD", typeof(ItemSellingPriceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/all", "HEAD", typeof(ItemSellingPriceController), "GetAll")]
        [InlineData("/api/core/item-selling-price/all", "HEAD", typeof(ItemSellingPriceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/export", "HEAD", typeof(ItemSellingPriceController), "Export")]
        [InlineData("/api/core/item-selling-price/export", "HEAD", typeof(ItemSellingPriceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/1", "HEAD", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/core/item-selling-price/1", "HEAD", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/get?itemSellingPriceIds=1", "HEAD", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/core/item-selling-price/get?itemSellingPriceIds=1", "HEAD", typeof(ItemSellingPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price", "HEAD", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-selling-price", "HEAD", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/page/1", "HEAD", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-selling-price/page/1", "HEAD", typeof(ItemSellingPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/count-filtered/{filterName}", "HEAD", typeof(ItemSellingPriceController), "CountFiltered")]
        [InlineData("/api/core/item-selling-price/count-filtered/{filterName}", "HEAD", typeof(ItemSellingPriceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemSellingPriceController), "GetFiltered")]
        [InlineData("/api/core/item-selling-price/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemSellingPriceController), "GetFiltered")]
        [InlineData("/api/core/item-selling-price/first", "HEAD", typeof(ItemSellingPriceController), "GetFirst")]
        [InlineData("/api/core/item-selling-price/previous/1", "HEAD", typeof(ItemSellingPriceController), "GetPrevious")]
        [InlineData("/api/core/item-selling-price/next/1", "HEAD", typeof(ItemSellingPriceController), "GetNext")]
        [InlineData("/api/core/item-selling-price/last", "HEAD", typeof(ItemSellingPriceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/custom-fields", "HEAD", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-selling-price/custom-fields", "HEAD", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-selling-price/custom-fields/{resourceId}", "HEAD", typeof(ItemSellingPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-selling-price/custom-fields/{resourceId}", "HEAD", typeof(ItemSellingPriceController), "GetCustomFields")]

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

        public ItemSellingPriceRouteTests()
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