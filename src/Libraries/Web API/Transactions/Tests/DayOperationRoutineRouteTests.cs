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
    public class DayOperationRoutineRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/delete/{dayOperationRoutineId}", "DELETE", typeof(DayOperationRoutineController), "Delete")]
        [InlineData("/api/transactions/day-operation-routine/delete/{dayOperationRoutineId}", "DELETE", typeof(DayOperationRoutineController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/edit/{dayOperationRoutineId}", "PUT", typeof(DayOperationRoutineController), "Edit")]
        [InlineData("/api/transactions/day-operation-routine/edit/{dayOperationRoutineId}", "PUT", typeof(DayOperationRoutineController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/count-where", "POST", typeof(DayOperationRoutineController), "CountWhere")]
        [InlineData("/api/transactions/day-operation-routine/count-where", "POST", typeof(DayOperationRoutineController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/get-where/{pageNumber}", "POST", typeof(DayOperationRoutineController), "GetWhere")]
        [InlineData("/api/transactions/day-operation-routine/get-where/{pageNumber}", "POST", typeof(DayOperationRoutineController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/add-or-edit", "POST", typeof(DayOperationRoutineController), "AddOrEdit")]
        [InlineData("/api/transactions/day-operation-routine/add-or-edit", "POST", typeof(DayOperationRoutineController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/add/{dayOperationRoutine}", "POST", typeof(DayOperationRoutineController), "Add")]
        [InlineData("/api/transactions/day-operation-routine/add/{dayOperationRoutine}", "POST", typeof(DayOperationRoutineController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/bulk-import", "POST", typeof(DayOperationRoutineController), "BulkImport")]
        [InlineData("/api/transactions/day-operation-routine/bulk-import", "POST", typeof(DayOperationRoutineController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/meta", "GET", typeof(DayOperationRoutineController), "GetEntityView")]
        [InlineData("/api/transactions/day-operation-routine/meta", "GET", typeof(DayOperationRoutineController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/count", "GET", typeof(DayOperationRoutineController), "Count")]
        [InlineData("/api/transactions/day-operation-routine/count", "GET", typeof(DayOperationRoutineController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/all", "GET", typeof(DayOperationRoutineController), "GetAll")]
        [InlineData("/api/transactions/day-operation-routine/all", "GET", typeof(DayOperationRoutineController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/export", "GET", typeof(DayOperationRoutineController), "Export")]
        [InlineData("/api/transactions/day-operation-routine/export", "GET", typeof(DayOperationRoutineController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/1", "GET", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/transactions/day-operation-routine/1", "GET", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/get?dayOperationRoutineIds=1", "GET", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/transactions/day-operation-routine/get?dayOperationRoutineIds=1", "GET", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine", "GET", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation-routine", "GET", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/page/1", "GET", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation-routine/page/1", "GET", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/count-filtered/{filterName}", "GET", typeof(DayOperationRoutineController), "CountFiltered")]
        [InlineData("/api/transactions/day-operation-routine/count-filtered/{filterName}", "GET", typeof(DayOperationRoutineController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DayOperationRoutineController), "GetFiltered")]
        [InlineData("/api/transactions/day-operation-routine/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DayOperationRoutineController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/custom-fields", "GET", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation-routine/custom-fields", "GET", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/custom-fields/{resourceId}", "GET", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation-routine/custom-fields/{resourceId}", "GET", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/meta", "HEAD", typeof(DayOperationRoutineController), "GetEntityView")]
        [InlineData("/api/transactions/day-operation-routine/meta", "HEAD", typeof(DayOperationRoutineController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/count", "HEAD", typeof(DayOperationRoutineController), "Count")]
        [InlineData("/api/transactions/day-operation-routine/count", "HEAD", typeof(DayOperationRoutineController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/all", "HEAD", typeof(DayOperationRoutineController), "GetAll")]
        [InlineData("/api/transactions/day-operation-routine/all", "HEAD", typeof(DayOperationRoutineController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/export", "HEAD", typeof(DayOperationRoutineController), "Export")]
        [InlineData("/api/transactions/day-operation-routine/export", "HEAD", typeof(DayOperationRoutineController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/1", "HEAD", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/transactions/day-operation-routine/1", "HEAD", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/get?dayOperationRoutineIds=1", "HEAD", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/transactions/day-operation-routine/get?dayOperationRoutineIds=1", "HEAD", typeof(DayOperationRoutineController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine", "HEAD", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation-routine", "HEAD", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/page/1", "HEAD", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation-routine/page/1", "HEAD", typeof(DayOperationRoutineController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/count-filtered/{filterName}", "HEAD", typeof(DayOperationRoutineController), "CountFiltered")]
        [InlineData("/api/transactions/day-operation-routine/count-filtered/{filterName}", "HEAD", typeof(DayOperationRoutineController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DayOperationRoutineController), "GetFiltered")]
        [InlineData("/api/transactions/day-operation-routine/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DayOperationRoutineController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/custom-fields", "HEAD", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation-routine/custom-fields", "HEAD", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation-routine/custom-fields/{resourceId}", "HEAD", typeof(DayOperationRoutineController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation-routine/custom-fields/{resourceId}", "HEAD", typeof(DayOperationRoutineController), "GetCustomFields")]

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

        public DayOperationRoutineRouteTests()
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