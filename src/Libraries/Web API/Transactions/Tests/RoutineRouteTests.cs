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
    public class RoutineRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/delete/{routineId}", "DELETE", typeof(TransactionsRoutineController), "Delete")]
        [InlineData("/api/transactions/routine/delete/{routineId}", "DELETE", typeof(TransactionsRoutineController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/edit/{routineId}", "PUT", typeof(TransactionsRoutineController), "Edit")]
        [InlineData("/api/transactions/routine/edit/{routineId}", "PUT", typeof(TransactionsRoutineController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/count-where", "POST", typeof(TransactionsRoutineController), "CountWhere")]
        [InlineData("/api/transactions/routine/count-where", "POST", typeof(TransactionsRoutineController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/get-where/{pageNumber}", "POST", typeof(TransactionsRoutineController), "GetWhere")]
        [InlineData("/api/transactions/routine/get-where/{pageNumber}", "POST", typeof(TransactionsRoutineController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/add-or-edit", "POST", typeof(TransactionsRoutineController), "AddOrEdit")]
        [InlineData("/api/transactions/routine/add-or-edit", "POST", typeof(TransactionsRoutineController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/add/{routine}", "POST", typeof(TransactionsRoutineController), "Add")]
        [InlineData("/api/transactions/routine/add/{routine}", "POST", typeof(TransactionsRoutineController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/bulk-import", "POST", typeof(TransactionsRoutineController), "BulkImport")]
        [InlineData("/api/transactions/routine/bulk-import", "POST", typeof(TransactionsRoutineController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/meta", "GET", typeof(TransactionsRoutineController), "GetEntityView")]
        [InlineData("/api/transactions/routine/meta", "GET", typeof(TransactionsRoutineController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/count", "GET", typeof(TransactionsRoutineController), "Count")]
        [InlineData("/api/transactions/routine/count", "GET", typeof(TransactionsRoutineController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/all", "GET", typeof(TransactionsRoutineController), "GetAll")]
        [InlineData("/api/transactions/routine/all", "GET", typeof(TransactionsRoutineController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/export", "GET", typeof(TransactionsRoutineController), "Export")]
        [InlineData("/api/transactions/routine/export", "GET", typeof(TransactionsRoutineController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/1", "GET", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/transactions/routine/1", "GET", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/get?routineIds=1", "GET", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/transactions/routine/get?routineIds=1", "GET", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine", "GET", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/routine", "GET", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/page/1", "GET", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/routine/page/1", "GET", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/count-filtered/{filterName}", "GET", typeof(TransactionsRoutineController), "CountFiltered")]
        [InlineData("/api/transactions/routine/count-filtered/{filterName}", "GET", typeof(TransactionsRoutineController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionsRoutineController), "GetFiltered")]
        [InlineData("/api/transactions/routine/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionsRoutineController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/routine/custom-fields", "GET", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/routine/custom-fields", "GET", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/custom-fields/{resourceId}", "GET", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/routine/custom-fields/{resourceId}", "GET", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/meta", "HEAD", typeof(TransactionsRoutineController), "GetEntityView")]
        [InlineData("/api/transactions/routine/meta", "HEAD", typeof(TransactionsRoutineController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/count", "HEAD", typeof(TransactionsRoutineController), "Count")]
        [InlineData("/api/transactions/routine/count", "HEAD", typeof(TransactionsRoutineController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/all", "HEAD", typeof(TransactionsRoutineController), "GetAll")]
        [InlineData("/api/transactions/routine/all", "HEAD", typeof(TransactionsRoutineController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/export", "HEAD", typeof(TransactionsRoutineController), "Export")]
        [InlineData("/api/transactions/routine/export", "HEAD", typeof(TransactionsRoutineController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/1", "HEAD", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/transactions/routine/1", "HEAD", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/get?routineIds=1", "HEAD", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/transactions/routine/get?routineIds=1", "HEAD", typeof(TransactionsRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine", "HEAD", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/routine", "HEAD", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/page/1", "HEAD", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/routine/page/1", "HEAD", typeof(TransactionsRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/count-filtered/{filterName}", "HEAD", typeof(TransactionsRoutineController), "CountFiltered")]
        [InlineData("/api/transactions/routine/count-filtered/{filterName}", "HEAD", typeof(TransactionsRoutineController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionsRoutineController), "GetFiltered")]
        [InlineData("/api/transactions/routine/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionsRoutineController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/routine/custom-fields", "HEAD", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/routine/custom-fields", "HEAD", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/routine/custom-fields/{resourceId}", "HEAD", typeof(TransactionsRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/routine/custom-fields/{resourceId}", "HEAD", typeof(TransactionsRoutineController), "GetCustomFields")]

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

        public RoutineRouteTests()
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