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
    public class TransactionMasterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/delete/{transactionMasterId}", "DELETE", typeof(TransactionMasterController), "Delete")]
        [InlineData("/api/transactions/transaction-master/delete/{transactionMasterId}", "DELETE", typeof(TransactionMasterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/edit/{transactionMasterId}", "PUT", typeof(TransactionMasterController), "Edit")]
        [InlineData("/api/transactions/transaction-master/edit/{transactionMasterId}", "PUT", typeof(TransactionMasterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/verify/{transactionMasterId}/{verificationStatusId}/{reason}", "PUT", typeof(TransactionMasterController), "Verifiy")]
        [InlineData("/api/transactions/transaction-master/verify/{transactionMasterId}/{verificationStatusId}/{reason}", "PUT", typeof(TransactionMasterController), "Verifiy")]

        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/count-where", "POST", typeof(TransactionMasterController), "CountWhere")]
        [InlineData("/api/transactions/transaction-master/count-where", "POST", typeof(TransactionMasterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/get-where/{pageNumber}", "POST", typeof(TransactionMasterController), "GetWhere")]
        [InlineData("/api/transactions/transaction-master/get-where/{pageNumber}", "POST", typeof(TransactionMasterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/add-or-edit", "POST", typeof(TransactionMasterController), "AddOrEdit")]
        [InlineData("/api/transactions/transaction-master/add-or-edit", "POST", typeof(TransactionMasterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/add/{transactionMaster}", "POST", typeof(TransactionMasterController), "Add")]
        [InlineData("/api/transactions/transaction-master/add/{transactionMaster}", "POST", typeof(TransactionMasterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/bulk-import", "POST", typeof(TransactionMasterController), "BulkImport")]
        [InlineData("/api/transactions/transaction-master/bulk-import", "POST", typeof(TransactionMasterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/meta", "GET", typeof(TransactionMasterController), "GetEntityView")]
        [InlineData("/api/transactions/transaction-master/meta", "GET", typeof(TransactionMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/count", "GET", typeof(TransactionMasterController), "Count")]
        [InlineData("/api/transactions/transaction-master/count", "GET", typeof(TransactionMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/all", "GET", typeof(TransactionMasterController), "GetAll")]
        [InlineData("/api/transactions/transaction-master/all", "GET", typeof(TransactionMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/export", "GET", typeof(TransactionMasterController), "Export")]
        [InlineData("/api/transactions/transaction-master/export", "GET", typeof(TransactionMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/1", "GET", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/transactions/transaction-master/1", "GET", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/get?transactionMasterIds=1", "GET", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/transactions/transaction-master/get?transactionMasterIds=1", "GET", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master", "GET", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-master", "GET", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/page/1", "GET", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-master/page/1", "GET", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/count-filtered/{filterName}", "GET", typeof(TransactionMasterController), "CountFiltered")]
        [InlineData("/api/transactions/transaction-master/count-filtered/{filterName}", "GET", typeof(TransactionMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionMasterController), "GetFiltered")]
        [InlineData("/api/transactions/transaction-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionMasterController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/custom-fields", "GET", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-master/custom-fields", "GET", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/custom-fields/{resourceId}", "GET", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-master/custom-fields/{resourceId}", "GET", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/meta", "HEAD", typeof(TransactionMasterController), "GetEntityView")]
        [InlineData("/api/transactions/transaction-master/meta", "HEAD", typeof(TransactionMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/count", "HEAD", typeof(TransactionMasterController), "Count")]
        [InlineData("/api/transactions/transaction-master/count", "HEAD", typeof(TransactionMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/all", "HEAD", typeof(TransactionMasterController), "GetAll")]
        [InlineData("/api/transactions/transaction-master/all", "HEAD", typeof(TransactionMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/export", "HEAD", typeof(TransactionMasterController), "Export")]
        [InlineData("/api/transactions/transaction-master/export", "HEAD", typeof(TransactionMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/1", "HEAD", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/transactions/transaction-master/1", "HEAD", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/get?transactionMasterIds=1", "HEAD", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/transactions/transaction-master/get?transactionMasterIds=1", "HEAD", typeof(TransactionMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master", "HEAD", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-master", "HEAD", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/page/1", "HEAD", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/transaction-master/page/1", "HEAD", typeof(TransactionMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/count-filtered/{filterName}", "HEAD", typeof(TransactionMasterController), "CountFiltered")]
        [InlineData("/api/transactions/transaction-master/count-filtered/{filterName}", "HEAD", typeof(TransactionMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionMasterController), "GetFiltered")]
        [InlineData("/api/transactions/transaction-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionMasterController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/custom-fields", "HEAD", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-master/custom-fields", "HEAD", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/transaction-master/custom-fields/{resourceId}", "HEAD", typeof(TransactionMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/transaction-master/custom-fields/{resourceId}", "HEAD", typeof(TransactionMasterController), "GetCustomFields")]

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

        public TransactionMasterRouteTests()
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