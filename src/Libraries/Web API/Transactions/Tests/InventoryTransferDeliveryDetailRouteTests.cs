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
    public class InventoryTransferDeliveryDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/delete/{inventoryTransferDeliveryDetailId}", "DELETE", typeof(InventoryTransferDeliveryDetailController), "Delete")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/delete/{inventoryTransferDeliveryDetailId}", "DELETE", typeof(InventoryTransferDeliveryDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/edit/{inventoryTransferDeliveryDetailId}", "PUT", typeof(InventoryTransferDeliveryDetailController), "Edit")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/edit/{inventoryTransferDeliveryDetailId}", "PUT", typeof(InventoryTransferDeliveryDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/count-where", "POST", typeof(InventoryTransferDeliveryDetailController), "CountWhere")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/count-where", "POST", typeof(InventoryTransferDeliveryDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/get-where/{pageNumber}", "POST", typeof(InventoryTransferDeliveryDetailController), "GetWhere")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/get-where/{pageNumber}", "POST", typeof(InventoryTransferDeliveryDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/add-or-edit", "POST", typeof(InventoryTransferDeliveryDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/add-or-edit", "POST", typeof(InventoryTransferDeliveryDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/add/{inventoryTransferDeliveryDetail}", "POST", typeof(InventoryTransferDeliveryDetailController), "Add")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/add/{inventoryTransferDeliveryDetail}", "POST", typeof(InventoryTransferDeliveryDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/bulk-import", "POST", typeof(InventoryTransferDeliveryDetailController), "BulkImport")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/bulk-import", "POST", typeof(InventoryTransferDeliveryDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/meta", "GET", typeof(InventoryTransferDeliveryDetailController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/meta", "GET", typeof(InventoryTransferDeliveryDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/count", "GET", typeof(InventoryTransferDeliveryDetailController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/count", "GET", typeof(InventoryTransferDeliveryDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/all", "GET", typeof(InventoryTransferDeliveryDetailController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/all", "GET", typeof(InventoryTransferDeliveryDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/export", "GET", typeof(InventoryTransferDeliveryDetailController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/export", "GET", typeof(InventoryTransferDeliveryDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/1", "GET", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/1", "GET", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/get?inventoryTransferDeliveryDetailIds=1", "GET", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/get?inventoryTransferDeliveryDetailIds=1", "GET", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail", "GET", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail", "GET", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/page/1", "GET", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/page/1", "GET", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/count-filtered/{filterName}", "GET", typeof(InventoryTransferDeliveryDetailController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/count-filtered/{filterName}", "GET", typeof(InventoryTransferDeliveryDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferDeliveryDetailController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferDeliveryDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/custom-fields", "GET", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/custom-fields", "GET", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/custom-fields/{resourceId}", "GET", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/custom-fields/{resourceId}", "GET", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/meta", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/meta", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/count", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/count", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/all", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/all", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/export", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/export", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/1", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/1", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/get?inventoryTransferDeliveryDetailIds=1", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/get?inventoryTransferDeliveryDetailIds=1", "HEAD", typeof(InventoryTransferDeliveryDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/page/1", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/page/1", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferDeliveryDetailController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferDeliveryDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/custom-fields", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/custom-fields", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-delivery-detail/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-delivery-detail/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferDeliveryDetailController), "GetCustomFields")]

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

        public InventoryTransferDeliveryDetailRouteTests()
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