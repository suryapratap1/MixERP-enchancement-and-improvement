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
    public class StockReturnRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/delete/{salesReturnId}", "DELETE", typeof(StockReturnController), "Delete")]
        [InlineData("/api/transactions/stock-return/delete/{salesReturnId}", "DELETE", typeof(StockReturnController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/edit/{salesReturnId}", "PUT", typeof(StockReturnController), "Edit")]
        [InlineData("/api/transactions/stock-return/edit/{salesReturnId}", "PUT", typeof(StockReturnController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/count-where", "POST", typeof(StockReturnController), "CountWhere")]
        [InlineData("/api/transactions/stock-return/count-where", "POST", typeof(StockReturnController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/get-where/{pageNumber}", "POST", typeof(StockReturnController), "GetWhere")]
        [InlineData("/api/transactions/stock-return/get-where/{pageNumber}", "POST", typeof(StockReturnController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/add-or-edit", "POST", typeof(StockReturnController), "AddOrEdit")]
        [InlineData("/api/transactions/stock-return/add-or-edit", "POST", typeof(StockReturnController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/add/{stockReturn}", "POST", typeof(StockReturnController), "Add")]
        [InlineData("/api/transactions/stock-return/add/{stockReturn}", "POST", typeof(StockReturnController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/bulk-import", "POST", typeof(StockReturnController), "BulkImport")]
        [InlineData("/api/transactions/stock-return/bulk-import", "POST", typeof(StockReturnController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/meta", "GET", typeof(StockReturnController), "GetEntityView")]
        [InlineData("/api/transactions/stock-return/meta", "GET", typeof(StockReturnController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/count", "GET", typeof(StockReturnController), "Count")]
        [InlineData("/api/transactions/stock-return/count", "GET", typeof(StockReturnController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/all", "GET", typeof(StockReturnController), "GetAll")]
        [InlineData("/api/transactions/stock-return/all", "GET", typeof(StockReturnController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/export", "GET", typeof(StockReturnController), "Export")]
        [InlineData("/api/transactions/stock-return/export", "GET", typeof(StockReturnController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/1", "GET", typeof(StockReturnController), "Get")]
        [InlineData("/api/transactions/stock-return/1", "GET", typeof(StockReturnController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/get?salesReturnIds=1", "GET", typeof(StockReturnController), "Get")]
        [InlineData("/api/transactions/stock-return/get?salesReturnIds=1", "GET", typeof(StockReturnController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return", "GET", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-return", "GET", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/page/1", "GET", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-return/page/1", "GET", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/count-filtered/{filterName}", "GET", typeof(StockReturnController), "CountFiltered")]
        [InlineData("/api/transactions/stock-return/count-filtered/{filterName}", "GET", typeof(StockReturnController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockReturnController), "GetFiltered")]
        [InlineData("/api/transactions/stock-return/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockReturnController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/custom-fields", "GET", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-return/custom-fields", "GET", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/custom-fields/{resourceId}", "GET", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-return/custom-fields/{resourceId}", "GET", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/meta", "HEAD", typeof(StockReturnController), "GetEntityView")]
        [InlineData("/api/transactions/stock-return/meta", "HEAD", typeof(StockReturnController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/count", "HEAD", typeof(StockReturnController), "Count")]
        [InlineData("/api/transactions/stock-return/count", "HEAD", typeof(StockReturnController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/all", "HEAD", typeof(StockReturnController), "GetAll")]
        [InlineData("/api/transactions/stock-return/all", "HEAD", typeof(StockReturnController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/export", "HEAD", typeof(StockReturnController), "Export")]
        [InlineData("/api/transactions/stock-return/export", "HEAD", typeof(StockReturnController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/1", "HEAD", typeof(StockReturnController), "Get")]
        [InlineData("/api/transactions/stock-return/1", "HEAD", typeof(StockReturnController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/get?salesReturnIds=1", "HEAD", typeof(StockReturnController), "Get")]
        [InlineData("/api/transactions/stock-return/get?salesReturnIds=1", "HEAD", typeof(StockReturnController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return", "HEAD", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-return", "HEAD", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/page/1", "HEAD", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-return/page/1", "HEAD", typeof(StockReturnController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/count-filtered/{filterName}", "HEAD", typeof(StockReturnController), "CountFiltered")]
        [InlineData("/api/transactions/stock-return/count-filtered/{filterName}", "HEAD", typeof(StockReturnController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockReturnController), "GetFiltered")]
        [InlineData("/api/transactions/stock-return/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockReturnController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/custom-fields", "HEAD", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-return/custom-fields", "HEAD", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-return/custom-fields/{resourceId}", "HEAD", typeof(StockReturnController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-return/custom-fields/{resourceId}", "HEAD", typeof(StockReturnController), "GetCustomFields")]

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

        public StockReturnRouteTests()
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