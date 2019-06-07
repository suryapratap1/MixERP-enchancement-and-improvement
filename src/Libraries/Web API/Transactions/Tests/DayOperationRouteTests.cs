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
    public class DayOperationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/delete/{dayId}", "DELETE", typeof(DayOperationController), "Delete")]
        [InlineData("/api/transactions/day-operation/delete/{dayId}", "DELETE", typeof(DayOperationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/edit/{dayId}", "PUT", typeof(DayOperationController), "Edit")]
        [InlineData("/api/transactions/day-operation/edit/{dayId}", "PUT", typeof(DayOperationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/count-where", "POST", typeof(DayOperationController), "CountWhere")]
        [InlineData("/api/transactions/day-operation/count-where", "POST", typeof(DayOperationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/get-where/{pageNumber}", "POST", typeof(DayOperationController), "GetWhere")]
        [InlineData("/api/transactions/day-operation/get-where/{pageNumber}", "POST", typeof(DayOperationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/add-or-edit", "POST", typeof(DayOperationController), "AddOrEdit")]
        [InlineData("/api/transactions/day-operation/add-or-edit", "POST", typeof(DayOperationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/add/{dayOperation}", "POST", typeof(DayOperationController), "Add")]
        [InlineData("/api/transactions/day-operation/add/{dayOperation}", "POST", typeof(DayOperationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/bulk-import", "POST", typeof(DayOperationController), "BulkImport")]
        [InlineData("/api/transactions/day-operation/bulk-import", "POST", typeof(DayOperationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/meta", "GET", typeof(DayOperationController), "GetEntityView")]
        [InlineData("/api/transactions/day-operation/meta", "GET", typeof(DayOperationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/count", "GET", typeof(DayOperationController), "Count")]
        [InlineData("/api/transactions/day-operation/count", "GET", typeof(DayOperationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/all", "GET", typeof(DayOperationController), "GetAll")]
        [InlineData("/api/transactions/day-operation/all", "GET", typeof(DayOperationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/export", "GET", typeof(DayOperationController), "Export")]
        [InlineData("/api/transactions/day-operation/export", "GET", typeof(DayOperationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/1", "GET", typeof(DayOperationController), "Get")]
        [InlineData("/api/transactions/day-operation/1", "GET", typeof(DayOperationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/get?dayIds=1", "GET", typeof(DayOperationController), "Get")]
        [InlineData("/api/transactions/day-operation/get?dayIds=1", "GET", typeof(DayOperationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation", "GET", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation", "GET", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/page/1", "GET", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation/page/1", "GET", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/count-filtered/{filterName}", "GET", typeof(DayOperationController), "CountFiltered")]
        [InlineData("/api/transactions/day-operation/count-filtered/{filterName}", "GET", typeof(DayOperationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DayOperationController), "GetFiltered")]
        [InlineData("/api/transactions/day-operation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DayOperationController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/custom-fields", "GET", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation/custom-fields", "GET", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/custom-fields/{resourceId}", "GET", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation/custom-fields/{resourceId}", "GET", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/meta", "HEAD", typeof(DayOperationController), "GetEntityView")]
        [InlineData("/api/transactions/day-operation/meta", "HEAD", typeof(DayOperationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/count", "HEAD", typeof(DayOperationController), "Count")]
        [InlineData("/api/transactions/day-operation/count", "HEAD", typeof(DayOperationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/all", "HEAD", typeof(DayOperationController), "GetAll")]
        [InlineData("/api/transactions/day-operation/all", "HEAD", typeof(DayOperationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/export", "HEAD", typeof(DayOperationController), "Export")]
        [InlineData("/api/transactions/day-operation/export", "HEAD", typeof(DayOperationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/1", "HEAD", typeof(DayOperationController), "Get")]
        [InlineData("/api/transactions/day-operation/1", "HEAD", typeof(DayOperationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/get?dayIds=1", "HEAD", typeof(DayOperationController), "Get")]
        [InlineData("/api/transactions/day-operation/get?dayIds=1", "HEAD", typeof(DayOperationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation", "HEAD", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation", "HEAD", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/page/1", "HEAD", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/day-operation/page/1", "HEAD", typeof(DayOperationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/count-filtered/{filterName}", "HEAD", typeof(DayOperationController), "CountFiltered")]
        [InlineData("/api/transactions/day-operation/count-filtered/{filterName}", "HEAD", typeof(DayOperationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DayOperationController), "GetFiltered")]
        [InlineData("/api/transactions/day-operation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DayOperationController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/custom-fields", "HEAD", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation/custom-fields", "HEAD", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/day-operation/custom-fields/{resourceId}", "HEAD", typeof(DayOperationController), "GetCustomFields")]
        [InlineData("/api/transactions/day-operation/custom-fields/{resourceId}", "HEAD", typeof(DayOperationController), "GetCustomFields")]

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

        public DayOperationRouteTests()
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