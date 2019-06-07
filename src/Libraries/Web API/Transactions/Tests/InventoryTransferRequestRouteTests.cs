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
    public class InventoryTransferRequestRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/delete/{inventoryTransferRequestId}", "DELETE", typeof(InventoryTransferRequestController), "Delete")]
        [InlineData("/api/transactions/inventory-transfer-request/delete/{inventoryTransferRequestId}", "DELETE", typeof(InventoryTransferRequestController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/edit/{inventoryTransferRequestId}", "PUT", typeof(InventoryTransferRequestController), "Edit")]
        [InlineData("/api/transactions/inventory-transfer-request/edit/{inventoryTransferRequestId}", "PUT", typeof(InventoryTransferRequestController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/count-where", "POST", typeof(InventoryTransferRequestController), "CountWhere")]
        [InlineData("/api/transactions/inventory-transfer-request/count-where", "POST", typeof(InventoryTransferRequestController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/get-where/{pageNumber}", "POST", typeof(InventoryTransferRequestController), "GetWhere")]
        [InlineData("/api/transactions/inventory-transfer-request/get-where/{pageNumber}", "POST", typeof(InventoryTransferRequestController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/add-or-edit", "POST", typeof(InventoryTransferRequestController), "AddOrEdit")]
        [InlineData("/api/transactions/inventory-transfer-request/add-or-edit", "POST", typeof(InventoryTransferRequestController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/add/{inventoryTransferRequest}", "POST", typeof(InventoryTransferRequestController), "Add")]
        [InlineData("/api/transactions/inventory-transfer-request/add/{inventoryTransferRequest}", "POST", typeof(InventoryTransferRequestController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/bulk-import", "POST", typeof(InventoryTransferRequestController), "BulkImport")]
        [InlineData("/api/transactions/inventory-transfer-request/bulk-import", "POST", typeof(InventoryTransferRequestController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/meta", "GET", typeof(InventoryTransferRequestController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-request/meta", "GET", typeof(InventoryTransferRequestController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/count", "GET", typeof(InventoryTransferRequestController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-request/count", "GET", typeof(InventoryTransferRequestController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/all", "GET", typeof(InventoryTransferRequestController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-request/all", "GET", typeof(InventoryTransferRequestController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/export", "GET", typeof(InventoryTransferRequestController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-request/export", "GET", typeof(InventoryTransferRequestController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/1", "GET", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request/1", "GET", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/get?inventoryTransferRequestIds=1", "GET", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request/get?inventoryTransferRequestIds=1", "GET", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request", "GET", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request", "GET", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/page/1", "GET", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request/page/1", "GET", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/count-filtered/{filterName}", "GET", typeof(InventoryTransferRequestController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request/count-filtered/{filterName}", "GET", typeof(InventoryTransferRequestController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferRequestController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferRequestController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/custom-fields", "GET", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request/custom-fields", "GET", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/custom-fields/{resourceId}", "GET", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request/custom-fields/{resourceId}", "GET", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/meta", "HEAD", typeof(InventoryTransferRequestController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-request/meta", "HEAD", typeof(InventoryTransferRequestController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/count", "HEAD", typeof(InventoryTransferRequestController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-request/count", "HEAD", typeof(InventoryTransferRequestController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/all", "HEAD", typeof(InventoryTransferRequestController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-request/all", "HEAD", typeof(InventoryTransferRequestController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/export", "HEAD", typeof(InventoryTransferRequestController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-request/export", "HEAD", typeof(InventoryTransferRequestController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/1", "HEAD", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request/1", "HEAD", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/get?inventoryTransferRequestIds=1", "HEAD", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request/get?inventoryTransferRequestIds=1", "HEAD", typeof(InventoryTransferRequestController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request", "HEAD", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request", "HEAD", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/page/1", "HEAD", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request/page/1", "HEAD", typeof(InventoryTransferRequestController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferRequestController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferRequestController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferRequestController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferRequestController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/custom-fields", "HEAD", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request/custom-fields", "HEAD", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferRequestController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferRequestController), "GetCustomFields")]

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

        public InventoryTransferRequestRouteTests()
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