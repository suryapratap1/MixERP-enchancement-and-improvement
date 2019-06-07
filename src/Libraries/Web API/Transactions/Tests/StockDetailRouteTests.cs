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
    public class StockDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/delete/{stockDetailId}", "DELETE", typeof(StockDetailController), "Delete")]
        [InlineData("/api/transactions/stock-detail/delete/{stockDetailId}", "DELETE", typeof(StockDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/edit/{stockDetailId}", "PUT", typeof(StockDetailController), "Edit")]
        [InlineData("/api/transactions/stock-detail/edit/{stockDetailId}", "PUT", typeof(StockDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/count-where", "POST", typeof(StockDetailController), "CountWhere")]
        [InlineData("/api/transactions/stock-detail/count-where", "POST", typeof(StockDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/get-where/{pageNumber}", "POST", typeof(StockDetailController), "GetWhere")]
        [InlineData("/api/transactions/stock-detail/get-where/{pageNumber}", "POST", typeof(StockDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/add-or-edit", "POST", typeof(StockDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/stock-detail/add-or-edit", "POST", typeof(StockDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/add/{stockDetail}", "POST", typeof(StockDetailController), "Add")]
        [InlineData("/api/transactions/stock-detail/add/{stockDetail}", "POST", typeof(StockDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/bulk-import", "POST", typeof(StockDetailController), "BulkImport")]
        [InlineData("/api/transactions/stock-detail/bulk-import", "POST", typeof(StockDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/meta", "GET", typeof(StockDetailController), "GetEntityView")]
        [InlineData("/api/transactions/stock-detail/meta", "GET", typeof(StockDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/count", "GET", typeof(StockDetailController), "Count")]
        [InlineData("/api/transactions/stock-detail/count", "GET", typeof(StockDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/all", "GET", typeof(StockDetailController), "GetAll")]
        [InlineData("/api/transactions/stock-detail/all", "GET", typeof(StockDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/export", "GET", typeof(StockDetailController), "Export")]
        [InlineData("/api/transactions/stock-detail/export", "GET", typeof(StockDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/1", "GET", typeof(StockDetailController), "Get")]
        [InlineData("/api/transactions/stock-detail/1", "GET", typeof(StockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/get?stockDetailIds=1", "GET", typeof(StockDetailController), "Get")]
        [InlineData("/api/transactions/stock-detail/get?stockDetailIds=1", "GET", typeof(StockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail", "GET", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-detail", "GET", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/page/1", "GET", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-detail/page/1", "GET", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/count-filtered/{filterName}", "GET", typeof(StockDetailController), "CountFiltered")]
        [InlineData("/api/transactions/stock-detail/count-filtered/{filterName}", "GET", typeof(StockDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockDetailController), "GetFiltered")]
        [InlineData("/api/transactions/stock-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/custom-fields", "GET", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-detail/custom-fields", "GET", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/custom-fields/{resourceId}", "GET", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-detail/custom-fields/{resourceId}", "GET", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/meta", "HEAD", typeof(StockDetailController), "GetEntityView")]
        [InlineData("/api/transactions/stock-detail/meta", "HEAD", typeof(StockDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/count", "HEAD", typeof(StockDetailController), "Count")]
        [InlineData("/api/transactions/stock-detail/count", "HEAD", typeof(StockDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/all", "HEAD", typeof(StockDetailController), "GetAll")]
        [InlineData("/api/transactions/stock-detail/all", "HEAD", typeof(StockDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/export", "HEAD", typeof(StockDetailController), "Export")]
        [InlineData("/api/transactions/stock-detail/export", "HEAD", typeof(StockDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/1", "HEAD", typeof(StockDetailController), "Get")]
        [InlineData("/api/transactions/stock-detail/1", "HEAD", typeof(StockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/get?stockDetailIds=1", "HEAD", typeof(StockDetailController), "Get")]
        [InlineData("/api/transactions/stock-detail/get?stockDetailIds=1", "HEAD", typeof(StockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail", "HEAD", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-detail", "HEAD", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/page/1", "HEAD", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-detail/page/1", "HEAD", typeof(StockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/count-filtered/{filterName}", "HEAD", typeof(StockDetailController), "CountFiltered")]
        [InlineData("/api/transactions/stock-detail/count-filtered/{filterName}", "HEAD", typeof(StockDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockDetailController), "GetFiltered")]
        [InlineData("/api/transactions/stock-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/custom-fields", "HEAD", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-detail/custom-fields", "HEAD", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-detail/custom-fields/{resourceId}", "HEAD", typeof(StockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-detail/custom-fields/{resourceId}", "HEAD", typeof(StockDetailController), "GetCustomFields")]

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

        public StockDetailRouteTests()
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