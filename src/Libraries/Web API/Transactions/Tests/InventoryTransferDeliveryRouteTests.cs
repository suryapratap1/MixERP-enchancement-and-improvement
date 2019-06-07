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

namespace MixERP.Net.Api.Transactions.Tests
{
    public class InventoryTransferDeliveryRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/delete/{inventoryTransferDeliveryId}", "DELETE", typeof(InventoryTransferDeliveryController), "Delete")]
        [InlineData("/api/transactions/inventory-transfer-delivery/delete/{inventoryTransferDeliveryId}", "DELETE", typeof(InventoryTransferDeliveryController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/edit/{inventoryTransferDeliveryId}", "PUT", typeof(InventoryTransferDeliveryController), "Edit")]
        [InlineData("/api/transactions/inventory-transfer-delivery/edit/{inventoryTransferDeliveryId}", "PUT", typeof(InventoryTransferDeliveryController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/count-where", "POST", typeof(InventoryTransferDeliveryController), "CountWhere")]
        [InlineData("/api/transactions/inventory-transfer-delivery/count-where", "POST", typeof(InventoryTransferDeliveryController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/get-where/{pageNumber}", "POST", typeof(InventoryTransferDeliveryController), "GetWhere")]
        [InlineData("/api/transactions/inventory-transfer-delivery/get-where/{pageNumber}", "POST", typeof(InventoryTransferDeliveryController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/add-or-edit", "POST", typeof(InventoryTransferDeliveryController), "AddOrEdit")]
        [InlineData("/api/transactions/inventory-transfer-delivery/add-or-edit", "POST", typeof(InventoryTransferDeliveryController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/add/{inventoryTransferDelivery}", "POST", typeof(InventoryTransferDeliveryController), "Add")]
        [InlineData("/api/transactions/inventory-transfer-delivery/add/{inventoryTransferDelivery}", "POST", typeof(InventoryTransferDeliveryController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/bulk-import", "POST", typeof(InventoryTransferDeliveryController), "BulkImport")]
        [InlineData("/api/transactions/inventory-transfer-delivery/bulk-import", "POST", typeof(InventoryTransferDeliveryController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/meta", "GET", typeof(InventoryTransferDeliveryController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-delivery/meta", "GET", typeof(InventoryTransferDeliveryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/count", "GET", typeof(InventoryTransferDeliveryController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-delivery/count", "GET", typeof(InventoryTransferDeliveryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/all", "GET", typeof(InventoryTransferDeliveryController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-delivery/all", "GET", typeof(InventoryTransferDeliveryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/export", "GET", typeof(InventoryTransferDeliveryController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-delivery/export", "GET", typeof(InventoryTransferDeliveryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/1", "GET", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery/1", "GET", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/get?inventoryTransferDeliveryIds=1", "GET", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery/get?inventoryTransferDeliveryIds=1", "GET", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery", "GET", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery", "GET", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/page/1", "GET", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery/page/1", "GET", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/count-filtered/{filterName}", "GET", typeof(InventoryTransferDeliveryController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery/count-filtered/{filterName}", "GET", typeof(InventoryTransferDeliveryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferDeliveryController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferDeliveryController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/custom-fields", "GET", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery/custom-fields", "GET", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/custom-fields/{resourceId}", "GET", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery/custom-fields/{resourceId}", "GET", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/meta", "HEAD", typeof(InventoryTransferDeliveryController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-delivery/meta", "HEAD", typeof(InventoryTransferDeliveryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/count", "HEAD", typeof(InventoryTransferDeliveryController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-delivery/count", "HEAD", typeof(InventoryTransferDeliveryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/all", "HEAD", typeof(InventoryTransferDeliveryController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-delivery/all", "HEAD", typeof(InventoryTransferDeliveryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/export", "HEAD", typeof(InventoryTransferDeliveryController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-delivery/export", "HEAD", typeof(InventoryTransferDeliveryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/1", "HEAD", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery/1", "HEAD", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/get?inventoryTransferDeliveryIds=1", "HEAD", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery/get?inventoryTransferDeliveryIds=1", "HEAD", typeof(InventoryTransferDeliveryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery", "HEAD", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery", "HEAD", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/page/1", "HEAD", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery/page/1", "HEAD", typeof(InventoryTransferDeliveryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferDeliveryController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferDeliveryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferDeliveryController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferDeliveryController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/custom-fields", "HEAD", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery/custom-fields", "HEAD", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferDeliveryController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferDeliveryController), "GetCustomFields")]

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

        public InventoryTransferDeliveryRouteTests()
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