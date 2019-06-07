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
    public class StockMasterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/delete/{stockMasterId}", "DELETE", typeof(StockMasterController), "Delete")]
        [InlineData("/api/transactions/stock-master/delete/{stockMasterId}", "DELETE", typeof(StockMasterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/edit/{stockMasterId}", "PUT", typeof(StockMasterController), "Edit")]
        [InlineData("/api/transactions/stock-master/edit/{stockMasterId}", "PUT", typeof(StockMasterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/count-where", "POST", typeof(StockMasterController), "CountWhere")]
        [InlineData("/api/transactions/stock-master/count-where", "POST", typeof(StockMasterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/get-where/{pageNumber}", "POST", typeof(StockMasterController), "GetWhere")]
        [InlineData("/api/transactions/stock-master/get-where/{pageNumber}", "POST", typeof(StockMasterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/add-or-edit", "POST", typeof(StockMasterController), "AddOrEdit")]
        [InlineData("/api/transactions/stock-master/add-or-edit", "POST", typeof(StockMasterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/add/{stockMaster}", "POST", typeof(StockMasterController), "Add")]
        [InlineData("/api/transactions/stock-master/add/{stockMaster}", "POST", typeof(StockMasterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/bulk-import", "POST", typeof(StockMasterController), "BulkImport")]
        [InlineData("/api/transactions/stock-master/bulk-import", "POST", typeof(StockMasterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/meta", "GET", typeof(StockMasterController), "GetEntityView")]
        [InlineData("/api/transactions/stock-master/meta", "GET", typeof(StockMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/count", "GET", typeof(StockMasterController), "Count")]
        [InlineData("/api/transactions/stock-master/count", "GET", typeof(StockMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/all", "GET", typeof(StockMasterController), "GetAll")]
        [InlineData("/api/transactions/stock-master/all", "GET", typeof(StockMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/export", "GET", typeof(StockMasterController), "Export")]
        [InlineData("/api/transactions/stock-master/export", "GET", typeof(StockMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/1", "GET", typeof(StockMasterController), "Get")]
        [InlineData("/api/transactions/stock-master/1", "GET", typeof(StockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/get?stockMasterIds=1", "GET", typeof(StockMasterController), "Get")]
        [InlineData("/api/transactions/stock-master/get?stockMasterIds=1", "GET", typeof(StockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master", "GET", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master", "GET", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/page/1", "GET", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master/page/1", "GET", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/count-filtered/{filterName}", "GET", typeof(StockMasterController), "CountFiltered")]
        [InlineData("/api/transactions/stock-master/count-filtered/{filterName}", "GET", typeof(StockMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockMasterController), "GetFiltered")]
        [InlineData("/api/transactions/stock-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockMasterController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/custom-fields", "GET", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master/custom-fields", "GET", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/custom-fields/{resourceId}", "GET", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master/custom-fields/{resourceId}", "GET", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/meta", "HEAD", typeof(StockMasterController), "GetEntityView")]
        [InlineData("/api/transactions/stock-master/meta", "HEAD", typeof(StockMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/count", "HEAD", typeof(StockMasterController), "Count")]
        [InlineData("/api/transactions/stock-master/count", "HEAD", typeof(StockMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/all", "HEAD", typeof(StockMasterController), "GetAll")]
        [InlineData("/api/transactions/stock-master/all", "HEAD", typeof(StockMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/export", "HEAD", typeof(StockMasterController), "Export")]
        [InlineData("/api/transactions/stock-master/export", "HEAD", typeof(StockMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/1", "HEAD", typeof(StockMasterController), "Get")]
        [InlineData("/api/transactions/stock-master/1", "HEAD", typeof(StockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/get?stockMasterIds=1", "HEAD", typeof(StockMasterController), "Get")]
        [InlineData("/api/transactions/stock-master/get?stockMasterIds=1", "HEAD", typeof(StockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master", "HEAD", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master", "HEAD", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/page/1", "HEAD", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master/page/1", "HEAD", typeof(StockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/count-filtered/{filterName}", "HEAD", typeof(StockMasterController), "CountFiltered")]
        [InlineData("/api/transactions/stock-master/count-filtered/{filterName}", "HEAD", typeof(StockMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockMasterController), "GetFiltered")]
        [InlineData("/api/transactions/stock-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockMasterController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/custom-fields", "HEAD", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master/custom-fields", "HEAD", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master/custom-fields/{resourceId}", "HEAD", typeof(StockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master/custom-fields/{resourceId}", "HEAD", typeof(StockMasterController), "GetCustomFields")]

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

        public StockMasterRouteTests()
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