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
    public class TransactionDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/delete/{transactionDetailId}", "DELETE", typeof(TransactionDetailController), "Delete")]
        [InlineData("/api/transactions/transaction-detail/delete/{transactionDetailId}", "DELETE", typeof(TransactionDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/edit/{transactionDetailId}", "PUT", typeof(TransactionDetailController), "Edit")]
        [InlineData("/api/transactions/transaction-detail/edit/{transactionDetailId}", "PUT", typeof(TransactionDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/count-where", "POST", typeof(TransactionDetailController), "CountWhere")]
        [InlineData("/api/transactions/transaction-detail/count-where", "POST", typeof(TransactionDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/get-where/{pageNumber}", "POST", typeof(TransactionDetailController), "GetWhere")]
        [InlineData("/api/transactions/transaction-detail/get-where/{pageNumber}", "POST", typeof(TransactionDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/add-or-edit", "POST", typeof(TransactionDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/transaction-detail/add-or-edit", "POST", typeof(TransactionDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/add/{transactionDetail}", "POST", typeof(TransactionDetailController), "Add")]
        [InlineData("/api/transactions/transaction-detail/add/{transactionDetail}", "POST", typeof(TransactionDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/bulk-import", "POST", typeof(TransactionDetailController), "BulkImport")]
        [InlineData("/api/transactions/transaction-detail/bulk-import", "POST", typeof(TransactionDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/meta", "GET", typeof(TransactionDetailController), "GetEntityView")]
        [InlineData("/api/transactions/transaction-detail/meta", "GET", typeof(TransactionDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/count", "GET", typeof(TransactionDetailController), "Count")]
        [InlineData("/api/transactions/transaction-detail/count", "GET", typeof(TransactionDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/all", "GET", typeof(TransactionDetailController), "GetAll")]
        [InlineData("/api/transactions/transaction-detail/all", "GET", typeof(TransactionDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/export", "GET", typeof(TransactionDetailController), "Export")]
        [InlineData("/api/transactions/transaction-detail/export", "GET", typeof(TransactionDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/1", "GET", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/transactions/transaction-detail/1", "GET", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/get?transactionDetailIds=1", "GET", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/transactions/transaction-detail/get?transactionDetailIds=1", "GET", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail", "GET", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-detail", "GET", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/page/1", "GET", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-detail/page/1", "GET", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/count-filtered/{filterName}", "GET", typeof(TransactionDetailController), "CountFiltered")]
        [InlineData("/api/transactions/transaction-detail/count-filtered/{filterName}", "GET", typeof(TransactionDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionDetailController), "GetFiltered")]
        [InlineData("/api/transactions/transaction-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/custom-fields", "GET", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-detail/custom-fields", "GET", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/custom-fields/{resourceId}", "GET", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-detail/custom-fields/{resourceId}", "GET", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/meta", "HEAD", typeof(TransactionDetailController), "GetEntityView")]
        [InlineData("/api/transactions/transaction-detail/meta", "HEAD", typeof(TransactionDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/count", "HEAD", typeof(TransactionDetailController), "Count")]
        [InlineData("/api/transactions/transaction-detail/count", "HEAD", typeof(TransactionDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/all", "HEAD", typeof(TransactionDetailController), "GetAll")]
        [InlineData("/api/transactions/transaction-detail/all", "HEAD", typeof(TransactionDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/export", "HEAD", typeof(TransactionDetailController), "Export")]
        [InlineData("/api/transactions/transaction-detail/export", "HEAD", typeof(TransactionDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/1", "HEAD", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/transactions/transaction-detail/1", "HEAD", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/get?transactionDetailIds=1", "HEAD", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/transactions/transaction-detail/get?transactionDetailIds=1", "HEAD", typeof(TransactionDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail", "HEAD", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-detail", "HEAD", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/page/1", "HEAD", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-detail/page/1", "HEAD", typeof(TransactionDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/count-filtered/{filterName}", "HEAD", typeof(TransactionDetailController), "CountFiltered")]
        [InlineData("/api/transactions/transaction-detail/count-filtered/{filterName}", "HEAD", typeof(TransactionDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionDetailController), "GetFiltered")]
        [InlineData("/api/transactions/transaction-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/custom-fields", "HEAD", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-detail/custom-fields", "HEAD", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-detail/custom-fields/{resourceId}", "HEAD", typeof(TransactionDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-detail/custom-fields/{resourceId}", "HEAD", typeof(TransactionDetailController), "GetCustomFields")]

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

        public TransactionDetailRouteTests()
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