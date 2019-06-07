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
    public class ItemCostPriceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/delete/{itemCostPriceId}", "DELETE", typeof(ItemCostPriceController), "Delete")]
        [InlineData("/api/core/item-cost-price/delete/{itemCostPriceId}", "DELETE", typeof(ItemCostPriceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/edit/{itemCostPriceId}", "PUT", typeof(ItemCostPriceController), "Edit")]
        [InlineData("/api/core/item-cost-price/edit/{itemCostPriceId}", "PUT", typeof(ItemCostPriceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/count-where", "POST", typeof(ItemCostPriceController), "CountWhere")]
        [InlineData("/api/core/item-cost-price/count-where", "POST", typeof(ItemCostPriceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/get-where/{pageNumber}", "POST", typeof(ItemCostPriceController), "GetWhere")]
        [InlineData("/api/core/item-cost-price/get-where/{pageNumber}", "POST", typeof(ItemCostPriceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/add-or-edit", "POST", typeof(ItemCostPriceController), "AddOrEdit")]
        [InlineData("/api/core/item-cost-price/add-or-edit", "POST", typeof(ItemCostPriceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/add/{itemCostPrice}", "POST", typeof(ItemCostPriceController), "Add")]
        [InlineData("/api/core/item-cost-price/add/{itemCostPrice}", "POST", typeof(ItemCostPriceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/bulk-import", "POST", typeof(ItemCostPriceController), "BulkImport")]
        [InlineData("/api/core/item-cost-price/bulk-import", "POST", typeof(ItemCostPriceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/meta", "GET", typeof(ItemCostPriceController), "GetEntityView")]
        [InlineData("/api/core/item-cost-price/meta", "GET", typeof(ItemCostPriceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/count", "GET", typeof(ItemCostPriceController), "Count")]
        [InlineData("/api/core/item-cost-price/count", "GET", typeof(ItemCostPriceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/all", "GET", typeof(ItemCostPriceController), "GetAll")]
        [InlineData("/api/core/item-cost-price/all", "GET", typeof(ItemCostPriceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/export", "GET", typeof(ItemCostPriceController), "Export")]
        [InlineData("/api/core/item-cost-price/export", "GET", typeof(ItemCostPriceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/1", "GET", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/core/item-cost-price/1", "GET", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/get?itemCostPriceIds=1", "GET", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/core/item-cost-price/get?itemCostPriceIds=1", "GET", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price", "GET", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-cost-price", "GET", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/page/1", "GET", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-cost-price/page/1", "GET", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/count-filtered/{filterName}", "GET", typeof(ItemCostPriceController), "CountFiltered")]
        [InlineData("/api/core/item-cost-price/count-filtered/{filterName}", "GET", typeof(ItemCostPriceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemCostPriceController), "GetFiltered")]
        [InlineData("/api/core/item-cost-price/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemCostPriceController), "GetFiltered")]
        [InlineData("/api/core/item-cost-price/first", "GET", typeof(ItemCostPriceController), "GetFirst")]
        [InlineData("/api/core/item-cost-price/previous/1", "GET", typeof(ItemCostPriceController), "GetPrevious")]
        [InlineData("/api/core/item-cost-price/next/1", "GET", typeof(ItemCostPriceController), "GetNext")]
        [InlineData("/api/core/item-cost-price/last", "GET", typeof(ItemCostPriceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/custom-fields", "GET", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-cost-price/custom-fields", "GET", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/custom-fields/{resourceId}", "GET", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-cost-price/custom-fields/{resourceId}", "GET", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/meta", "HEAD", typeof(ItemCostPriceController), "GetEntityView")]
        [InlineData("/api/core/item-cost-price/meta", "HEAD", typeof(ItemCostPriceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/count", "HEAD", typeof(ItemCostPriceController), "Count")]
        [InlineData("/api/core/item-cost-price/count", "HEAD", typeof(ItemCostPriceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/all", "HEAD", typeof(ItemCostPriceController), "GetAll")]
        [InlineData("/api/core/item-cost-price/all", "HEAD", typeof(ItemCostPriceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/export", "HEAD", typeof(ItemCostPriceController), "Export")]
        [InlineData("/api/core/item-cost-price/export", "HEAD", typeof(ItemCostPriceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/1", "HEAD", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/core/item-cost-price/1", "HEAD", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/get?itemCostPriceIds=1", "HEAD", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/core/item-cost-price/get?itemCostPriceIds=1", "HEAD", typeof(ItemCostPriceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price", "HEAD", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-cost-price", "HEAD", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/page/1", "HEAD", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/core/item-cost-price/page/1", "HEAD", typeof(ItemCostPriceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/count-filtered/{filterName}", "HEAD", typeof(ItemCostPriceController), "CountFiltered")]
        [InlineData("/api/core/item-cost-price/count-filtered/{filterName}", "HEAD", typeof(ItemCostPriceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemCostPriceController), "GetFiltered")]
        [InlineData("/api/core/item-cost-price/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemCostPriceController), "GetFiltered")]
        [InlineData("/api/core/item-cost-price/first", "HEAD", typeof(ItemCostPriceController), "GetFirst")]
        [InlineData("/api/core/item-cost-price/previous/1", "HEAD", typeof(ItemCostPriceController), "GetPrevious")]
        [InlineData("/api/core/item-cost-price/next/1", "HEAD", typeof(ItemCostPriceController), "GetNext")]
        [InlineData("/api/core/item-cost-price/last", "HEAD", typeof(ItemCostPriceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/custom-fields", "HEAD", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-cost-price/custom-fields", "HEAD", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-cost-price/custom-fields/{resourceId}", "HEAD", typeof(ItemCostPriceController), "GetCustomFields")]
        [InlineData("/api/core/item-cost-price/custom-fields/{resourceId}", "HEAD", typeof(ItemCostPriceController), "GetCustomFields")]

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

        public ItemCostPriceRouteTests()
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