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
    public class NonGlStockMasterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/delete/{nonGlStockMasterId}", "DELETE", typeof(NonGlStockMasterController), "Delete")]
        [InlineData("/api/transactions/non-gl-stock-master/delete/{nonGlStockMasterId}", "DELETE", typeof(NonGlStockMasterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/edit/{nonGlStockMasterId}", "PUT", typeof(NonGlStockMasterController), "Edit")]
        [InlineData("/api/transactions/non-gl-stock-master/edit/{nonGlStockMasterId}", "PUT", typeof(NonGlStockMasterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/count-where", "POST", typeof(NonGlStockMasterController), "CountWhere")]
        [InlineData("/api/transactions/non-gl-stock-master/count-where", "POST", typeof(NonGlStockMasterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/get-where/{pageNumber}", "POST", typeof(NonGlStockMasterController), "GetWhere")]
        [InlineData("/api/transactions/non-gl-stock-master/get-where/{pageNumber}", "POST", typeof(NonGlStockMasterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/add-or-edit", "POST", typeof(NonGlStockMasterController), "AddOrEdit")]
        [InlineData("/api/transactions/non-gl-stock-master/add-or-edit", "POST", typeof(NonGlStockMasterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/add/{nonGlStockMaster}", "POST", typeof(NonGlStockMasterController), "Add")]
        [InlineData("/api/transactions/non-gl-stock-master/add/{nonGlStockMaster}", "POST", typeof(NonGlStockMasterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/bulk-import", "POST", typeof(NonGlStockMasterController), "BulkImport")]
        [InlineData("/api/transactions/non-gl-stock-master/bulk-import", "POST", typeof(NonGlStockMasterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/meta", "GET", typeof(NonGlStockMasterController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-master/meta", "GET", typeof(NonGlStockMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/count", "GET", typeof(NonGlStockMasterController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-master/count", "GET", typeof(NonGlStockMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/all", "GET", typeof(NonGlStockMasterController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-master/all", "GET", typeof(NonGlStockMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/export", "GET", typeof(NonGlStockMasterController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-master/export", "GET", typeof(NonGlStockMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/1", "GET", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master/1", "GET", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/get?nonGlStockMasterIds=1", "GET", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master/get?nonGlStockMasterIds=1", "GET", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master", "GET", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master", "GET", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/page/1", "GET", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master/page/1", "GET", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/count-filtered/{filterName}", "GET", typeof(NonGlStockMasterController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master/count-filtered/{filterName}", "GET", typeof(NonGlStockMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockMasterController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockMasterController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/custom-fields", "GET", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master/custom-fields", "GET", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/custom-fields/{resourceId}", "GET", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master/custom-fields/{resourceId}", "GET", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/meta", "HEAD", typeof(NonGlStockMasterController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-master/meta", "HEAD", typeof(NonGlStockMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/count", "HEAD", typeof(NonGlStockMasterController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-master/count", "HEAD", typeof(NonGlStockMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/all", "HEAD", typeof(NonGlStockMasterController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-master/all", "HEAD", typeof(NonGlStockMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/export", "HEAD", typeof(NonGlStockMasterController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-master/export", "HEAD", typeof(NonGlStockMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/1", "HEAD", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master/1", "HEAD", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/get?nonGlStockMasterIds=1", "HEAD", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master/get?nonGlStockMasterIds=1", "HEAD", typeof(NonGlStockMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master", "HEAD", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master", "HEAD", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/page/1", "HEAD", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master/page/1", "HEAD", typeof(NonGlStockMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/count-filtered/{filterName}", "HEAD", typeof(NonGlStockMasterController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master/count-filtered/{filterName}", "HEAD", typeof(NonGlStockMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockMasterController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockMasterController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/custom-fields", "HEAD", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master/custom-fields", "HEAD", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockMasterController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockMasterController), "GetCustomFields")]

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

        public NonGlStockMasterRouteTests()
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