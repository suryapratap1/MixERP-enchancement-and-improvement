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
    public class NonGlStockDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/delete/{nonGlStockDetailId}", "DELETE", typeof(NonGlStockDetailController), "Delete")]
        [InlineData("/api/transactions/non-gl-stock-detail/delete/{nonGlStockDetailId}", "DELETE", typeof(NonGlStockDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/edit/{nonGlStockDetailId}", "PUT", typeof(NonGlStockDetailController), "Edit")]
        [InlineData("/api/transactions/non-gl-stock-detail/edit/{nonGlStockDetailId}", "PUT", typeof(NonGlStockDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/count-where", "POST", typeof(NonGlStockDetailController), "CountWhere")]
        [InlineData("/api/transactions/non-gl-stock-detail/count-where", "POST", typeof(NonGlStockDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/get-where/{pageNumber}", "POST", typeof(NonGlStockDetailController), "GetWhere")]
        [InlineData("/api/transactions/non-gl-stock-detail/get-where/{pageNumber}", "POST", typeof(NonGlStockDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/add-or-edit", "POST", typeof(NonGlStockDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/non-gl-stock-detail/add-or-edit", "POST", typeof(NonGlStockDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/add/{nonGlStockDetail}", "POST", typeof(NonGlStockDetailController), "Add")]
        [InlineData("/api/transactions/non-gl-stock-detail/add/{nonGlStockDetail}", "POST", typeof(NonGlStockDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/bulk-import", "POST", typeof(NonGlStockDetailController), "BulkImport")]
        [InlineData("/api/transactions/non-gl-stock-detail/bulk-import", "POST", typeof(NonGlStockDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/meta", "GET", typeof(NonGlStockDetailController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-detail/meta", "GET", typeof(NonGlStockDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/count", "GET", typeof(NonGlStockDetailController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-detail/count", "GET", typeof(NonGlStockDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/all", "GET", typeof(NonGlStockDetailController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-detail/all", "GET", typeof(NonGlStockDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/export", "GET", typeof(NonGlStockDetailController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-detail/export", "GET", typeof(NonGlStockDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/1", "GET", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-detail/1", "GET", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/get?nonGlStockDetailIds=1", "GET", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-detail/get?nonGlStockDetailIds=1", "GET", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail", "GET", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-detail", "GET", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/page/1", "GET", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-detail/page/1", "GET", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/count-filtered/{filterName}", "GET", typeof(NonGlStockDetailController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-detail/count-filtered/{filterName}", "GET", typeof(NonGlStockDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockDetailController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/custom-fields", "GET", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-detail/custom-fields", "GET", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/custom-fields/{resourceId}", "GET", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-detail/custom-fields/{resourceId}", "GET", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/meta", "HEAD", typeof(NonGlStockDetailController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-detail/meta", "HEAD", typeof(NonGlStockDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/count", "HEAD", typeof(NonGlStockDetailController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-detail/count", "HEAD", typeof(NonGlStockDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/all", "HEAD", typeof(NonGlStockDetailController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-detail/all", "HEAD", typeof(NonGlStockDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/export", "HEAD", typeof(NonGlStockDetailController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-detail/export", "HEAD", typeof(NonGlStockDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/1", "HEAD", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-detail/1", "HEAD", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/get?nonGlStockDetailIds=1", "HEAD", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-detail/get?nonGlStockDetailIds=1", "HEAD", typeof(NonGlStockDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail", "HEAD", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-detail", "HEAD", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/page/1", "HEAD", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-detail/page/1", "HEAD", typeof(NonGlStockDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/count-filtered/{filterName}", "HEAD", typeof(NonGlStockDetailController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-detail/count-filtered/{filterName}", "HEAD", typeof(NonGlStockDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockDetailController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/custom-fields", "HEAD", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-detail/custom-fields", "HEAD", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-detail/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-detail/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockDetailController), "GetCustomFields")]

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

        public NonGlStockDetailRouteTests()
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