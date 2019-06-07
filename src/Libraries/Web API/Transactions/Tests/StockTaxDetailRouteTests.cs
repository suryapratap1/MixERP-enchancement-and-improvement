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
    public class StockTaxDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/delete/{stockTaxDetailId}", "DELETE", typeof(StockTaxDetailController), "Delete")]
        [InlineData("/api/transactions/stock-tax-detail/delete/{stockTaxDetailId}", "DELETE", typeof(StockTaxDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/edit/{stockTaxDetailId}", "PUT", typeof(StockTaxDetailController), "Edit")]
        [InlineData("/api/transactions/stock-tax-detail/edit/{stockTaxDetailId}", "PUT", typeof(StockTaxDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/count-where", "POST", typeof(StockTaxDetailController), "CountWhere")]
        [InlineData("/api/transactions/stock-tax-detail/count-where", "POST", typeof(StockTaxDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/get-where/{pageNumber}", "POST", typeof(StockTaxDetailController), "GetWhere")]
        [InlineData("/api/transactions/stock-tax-detail/get-where/{pageNumber}", "POST", typeof(StockTaxDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/add-or-edit", "POST", typeof(StockTaxDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/stock-tax-detail/add-or-edit", "POST", typeof(StockTaxDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/add/{stockTaxDetail}", "POST", typeof(StockTaxDetailController), "Add")]
        [InlineData("/api/transactions/stock-tax-detail/add/{stockTaxDetail}", "POST", typeof(StockTaxDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/bulk-import", "POST", typeof(StockTaxDetailController), "BulkImport")]
        [InlineData("/api/transactions/stock-tax-detail/bulk-import", "POST", typeof(StockTaxDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/meta", "GET", typeof(StockTaxDetailController), "GetEntityView")]
        [InlineData("/api/transactions/stock-tax-detail/meta", "GET", typeof(StockTaxDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/count", "GET", typeof(StockTaxDetailController), "Count")]
        [InlineData("/api/transactions/stock-tax-detail/count", "GET", typeof(StockTaxDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/all", "GET", typeof(StockTaxDetailController), "GetAll")]
        [InlineData("/api/transactions/stock-tax-detail/all", "GET", typeof(StockTaxDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/export", "GET", typeof(StockTaxDetailController), "Export")]
        [InlineData("/api/transactions/stock-tax-detail/export", "GET", typeof(StockTaxDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/1", "GET", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/transactions/stock-tax-detail/1", "GET", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/get?stockTaxDetailIds=1", "GET", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/transactions/stock-tax-detail/get?stockTaxDetailIds=1", "GET", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail", "GET", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-tax-detail", "GET", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/page/1", "GET", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-tax-detail/page/1", "GET", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/count-filtered/{filterName}", "GET", typeof(StockTaxDetailController), "CountFiltered")]
        [InlineData("/api/transactions/stock-tax-detail/count-filtered/{filterName}", "GET", typeof(StockTaxDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockTaxDetailController), "GetFiltered")]
        [InlineData("/api/transactions/stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockTaxDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/custom-fields", "GET", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-tax-detail/custom-fields", "GET", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/custom-fields/{resourceId}", "GET", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-tax-detail/custom-fields/{resourceId}", "GET", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/meta", "HEAD", typeof(StockTaxDetailController), "GetEntityView")]
        [InlineData("/api/transactions/stock-tax-detail/meta", "HEAD", typeof(StockTaxDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/count", "HEAD", typeof(StockTaxDetailController), "Count")]
        [InlineData("/api/transactions/stock-tax-detail/count", "HEAD", typeof(StockTaxDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/all", "HEAD", typeof(StockTaxDetailController), "GetAll")]
        [InlineData("/api/transactions/stock-tax-detail/all", "HEAD", typeof(StockTaxDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/export", "HEAD", typeof(StockTaxDetailController), "Export")]
        [InlineData("/api/transactions/stock-tax-detail/export", "HEAD", typeof(StockTaxDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/1", "HEAD", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/transactions/stock-tax-detail/1", "HEAD", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/get?stockTaxDetailIds=1", "HEAD", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/transactions/stock-tax-detail/get?stockTaxDetailIds=1", "HEAD", typeof(StockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail", "HEAD", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-tax-detail", "HEAD", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/page/1", "HEAD", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-tax-detail/page/1", "HEAD", typeof(StockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/count-filtered/{filterName}", "HEAD", typeof(StockTaxDetailController), "CountFiltered")]
        [InlineData("/api/transactions/stock-tax-detail/count-filtered/{filterName}", "HEAD", typeof(StockTaxDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockTaxDetailController), "GetFiltered")]
        [InlineData("/api/transactions/stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockTaxDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/custom-fields", "HEAD", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-tax-detail/custom-fields", "HEAD", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-tax-detail/custom-fields/{resourceId}", "HEAD", typeof(StockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-tax-detail/custom-fields/{resourceId}", "HEAD", typeof(StockTaxDetailController), "GetCustomFields")]

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

        public StockTaxDetailRouteTests()
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