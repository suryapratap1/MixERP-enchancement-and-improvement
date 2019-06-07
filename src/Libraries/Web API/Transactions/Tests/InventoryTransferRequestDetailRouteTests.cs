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
    public class InventoryTransferRequestDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/delete/{inventoryTransferRequestDetailId}", "DELETE", typeof(InventoryTransferRequestDetailController), "Delete")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/delete/{inventoryTransferRequestDetailId}", "DELETE", typeof(InventoryTransferRequestDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/edit/{inventoryTransferRequestDetailId}", "PUT", typeof(InventoryTransferRequestDetailController), "Edit")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/edit/{inventoryTransferRequestDetailId}", "PUT", typeof(InventoryTransferRequestDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/count-where", "POST", typeof(InventoryTransferRequestDetailController), "CountWhere")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/count-where", "POST", typeof(InventoryTransferRequestDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/get-where/{pageNumber}", "POST", typeof(InventoryTransferRequestDetailController), "GetWhere")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/get-where/{pageNumber}", "POST", typeof(InventoryTransferRequestDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/add-or-edit", "POST", typeof(InventoryTransferRequestDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/add-or-edit", "POST", typeof(InventoryTransferRequestDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/add/{inventoryTransferRequestDetail}", "POST", typeof(InventoryTransferRequestDetailController), "Add")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/add/{inventoryTransferRequestDetail}", "POST", typeof(InventoryTransferRequestDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/bulk-import", "POST", typeof(InventoryTransferRequestDetailController), "BulkImport")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/bulk-import", "POST", typeof(InventoryTransferRequestDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/meta", "GET", typeof(InventoryTransferRequestDetailController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/meta", "GET", typeof(InventoryTransferRequestDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/count", "GET", typeof(InventoryTransferRequestDetailController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/count", "GET", typeof(InventoryTransferRequestDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/all", "GET", typeof(InventoryTransferRequestDetailController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/all", "GET", typeof(InventoryTransferRequestDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/export", "GET", typeof(InventoryTransferRequestDetailController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/export", "GET", typeof(InventoryTransferRequestDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/1", "GET", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/1", "GET", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/get?inventoryTransferRequestDetailIds=1", "GET", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/get?inventoryTransferRequestDetailIds=1", "GET", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail", "GET", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request-detail", "GET", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/page/1", "GET", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/page/1", "GET", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/count-filtered/{filterName}", "GET", typeof(InventoryTransferRequestDetailController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/count-filtered/{filterName}", "GET", typeof(InventoryTransferRequestDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferRequestDetailController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(InventoryTransferRequestDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/custom-fields", "GET", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/custom-fields", "GET", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/custom-fields/{resourceId}", "GET", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/custom-fields/{resourceId}", "GET", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/meta", "HEAD", typeof(InventoryTransferRequestDetailController), "GetEntityView")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/meta", "HEAD", typeof(InventoryTransferRequestDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/count", "HEAD", typeof(InventoryTransferRequestDetailController), "Count")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/count", "HEAD", typeof(InventoryTransferRequestDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/all", "HEAD", typeof(InventoryTransferRequestDetailController), "GetAll")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/all", "HEAD", typeof(InventoryTransferRequestDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/export", "HEAD", typeof(InventoryTransferRequestDetailController), "Export")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/export", "HEAD", typeof(InventoryTransferRequestDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/1", "HEAD", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/1", "HEAD", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/get?inventoryTransferRequestDetailIds=1", "HEAD", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/get?inventoryTransferRequestDetailIds=1", "HEAD", typeof(InventoryTransferRequestDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail", "HEAD", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request-detail", "HEAD", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/page/1", "HEAD", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/page/1", "HEAD", typeof(InventoryTransferRequestDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferRequestDetailController), "CountFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/count-filtered/{filterName}", "HEAD", typeof(InventoryTransferRequestDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferRequestDetailController), "GetFiltered")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(InventoryTransferRequestDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/custom-fields", "HEAD", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/custom-fields", "HEAD", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/inventory-transfer-request-detail/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/inventory-transfer-request-detail/custom-fields/{resourceId}", "HEAD", typeof(InventoryTransferRequestDetailController), "GetCustomFields")]

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

        public InventoryTransferRequestDetailRouteTests()
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