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
    public class LateFeeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/delete/{transactionMasterId}", "DELETE", typeof(TransactionsLateFeeController), "Delete")]
        [InlineData("/api/transactions/late-fee/delete/{transactionMasterId}", "DELETE", typeof(TransactionsLateFeeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/edit/{transactionMasterId}", "PUT", typeof(TransactionsLateFeeController), "Edit")]
        [InlineData("/api/transactions/late-fee/edit/{transactionMasterId}", "PUT", typeof(TransactionsLateFeeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/count-where", "POST", typeof(TransactionsLateFeeController), "CountWhere")]
        [InlineData("/api/transactions/late-fee/count-where", "POST", typeof(TransactionsLateFeeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/get-where/{pageNumber}", "POST", typeof(TransactionsLateFeeController), "GetWhere")]
        [InlineData("/api/transactions/late-fee/get-where/{pageNumber}", "POST", typeof(TransactionsLateFeeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/add-or-edit", "POST", typeof(TransactionsLateFeeController), "AddOrEdit")]
        [InlineData("/api/transactions/late-fee/add-or-edit", "POST", typeof(TransactionsLateFeeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/add/{lateFee}", "POST", typeof(TransactionsLateFeeController), "Add")]
        [InlineData("/api/transactions/late-fee/add/{lateFee}", "POST", typeof(TransactionsLateFeeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/bulk-import", "POST", typeof(TransactionsLateFeeController), "BulkImport")]
        [InlineData("/api/transactions/late-fee/bulk-import", "POST", typeof(TransactionsLateFeeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/meta", "GET", typeof(TransactionsLateFeeController), "GetEntityView")]
        [InlineData("/api/transactions/late-fee/meta", "GET", typeof(TransactionsLateFeeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/count", "GET", typeof(TransactionsLateFeeController), "Count")]
        [InlineData("/api/transactions/late-fee/count", "GET", typeof(TransactionsLateFeeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/all", "GET", typeof(TransactionsLateFeeController), "GetAll")]
        [InlineData("/api/transactions/late-fee/all", "GET", typeof(TransactionsLateFeeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/export", "GET", typeof(TransactionsLateFeeController), "Export")]
        [InlineData("/api/transactions/late-fee/export", "GET", typeof(TransactionsLateFeeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/1", "GET", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/transactions/late-fee/1", "GET", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/get?transactionMasterIds=1", "GET", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/transactions/late-fee/get?transactionMasterIds=1", "GET", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee", "GET", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/transactions/late-fee", "GET", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/page/1", "GET", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/transactions/late-fee/page/1", "GET", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/count-filtered/{filterName}", "GET", typeof(TransactionsLateFeeController), "CountFiltered")]
        [InlineData("/api/transactions/late-fee/count-filtered/{filterName}", "GET", typeof(TransactionsLateFeeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionsLateFeeController), "GetFiltered")]
        [InlineData("/api/transactions/late-fee/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionsLateFeeController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/custom-fields", "GET", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/transactions/late-fee/custom-fields", "GET", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/custom-fields/{resourceId}", "GET", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/transactions/late-fee/custom-fields/{resourceId}", "GET", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/meta", "HEAD", typeof(TransactionsLateFeeController), "GetEntityView")]
        [InlineData("/api/transactions/late-fee/meta", "HEAD", typeof(TransactionsLateFeeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/count", "HEAD", typeof(TransactionsLateFeeController), "Count")]
        [InlineData("/api/transactions/late-fee/count", "HEAD", typeof(TransactionsLateFeeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/all", "HEAD", typeof(TransactionsLateFeeController), "GetAll")]
        [InlineData("/api/transactions/late-fee/all", "HEAD", typeof(TransactionsLateFeeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/export", "HEAD", typeof(TransactionsLateFeeController), "Export")]
        [InlineData("/api/transactions/late-fee/export", "HEAD", typeof(TransactionsLateFeeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/1", "HEAD", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/transactions/late-fee/1", "HEAD", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/get?transactionMasterIds=1", "HEAD", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/transactions/late-fee/get?transactionMasterIds=1", "HEAD", typeof(TransactionsLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee", "HEAD", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/transactions/late-fee", "HEAD", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/page/1", "HEAD", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/transactions/late-fee/page/1", "HEAD", typeof(TransactionsLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/count-filtered/{filterName}", "HEAD", typeof(TransactionsLateFeeController), "CountFiltered")]
        [InlineData("/api/transactions/late-fee/count-filtered/{filterName}", "HEAD", typeof(TransactionsLateFeeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionsLateFeeController), "GetFiltered")]
        [InlineData("/api/transactions/late-fee/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionsLateFeeController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/custom-fields", "HEAD", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/transactions/late-fee/custom-fields", "HEAD", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/late-fee/custom-fields/{resourceId}", "HEAD", typeof(TransactionsLateFeeController), "GetCustomFields")]
        [InlineData("/api/transactions/late-fee/custom-fields/{resourceId}", "HEAD", typeof(TransactionsLateFeeController), "GetCustomFields")]

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

        public LateFeeRouteTests()
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