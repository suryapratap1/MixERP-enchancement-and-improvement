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
    public class StockMasterNonGlRelationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/delete/{stockMasterNonGlRelationId}", "DELETE", typeof(StockMasterNonGlRelationController), "Delete")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/delete/{stockMasterNonGlRelationId}", "DELETE", typeof(StockMasterNonGlRelationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/edit/{stockMasterNonGlRelationId}", "PUT", typeof(StockMasterNonGlRelationController), "Edit")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/edit/{stockMasterNonGlRelationId}", "PUT", typeof(StockMasterNonGlRelationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/count-where", "POST", typeof(StockMasterNonGlRelationController), "CountWhere")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/count-where", "POST", typeof(StockMasterNonGlRelationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/get-where/{pageNumber}", "POST", typeof(StockMasterNonGlRelationController), "GetWhere")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/get-where/{pageNumber}", "POST", typeof(StockMasterNonGlRelationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/add-or-edit", "POST", typeof(StockMasterNonGlRelationController), "AddOrEdit")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/add-or-edit", "POST", typeof(StockMasterNonGlRelationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/add/{stockMasterNonGlRelation}", "POST", typeof(StockMasterNonGlRelationController), "Add")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/add/{stockMasterNonGlRelation}", "POST", typeof(StockMasterNonGlRelationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/bulk-import", "POST", typeof(StockMasterNonGlRelationController), "BulkImport")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/bulk-import", "POST", typeof(StockMasterNonGlRelationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/meta", "GET", typeof(StockMasterNonGlRelationController), "GetEntityView")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/meta", "GET", typeof(StockMasterNonGlRelationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/count", "GET", typeof(StockMasterNonGlRelationController), "Count")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/count", "GET", typeof(StockMasterNonGlRelationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/all", "GET", typeof(StockMasterNonGlRelationController), "GetAll")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/all", "GET", typeof(StockMasterNonGlRelationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/export", "GET", typeof(StockMasterNonGlRelationController), "Export")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/export", "GET", typeof(StockMasterNonGlRelationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/1", "GET", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/1", "GET", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/get?stockMasterNonGlRelationIds=1", "GET", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/get?stockMasterNonGlRelationIds=1", "GET", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation", "GET", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master-non-gl-relation", "GET", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/page/1", "GET", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/page/1", "GET", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/count-filtered/{filterName}", "GET", typeof(StockMasterNonGlRelationController), "CountFiltered")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/count-filtered/{filterName}", "GET", typeof(StockMasterNonGlRelationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockMasterNonGlRelationController), "GetFiltered")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StockMasterNonGlRelationController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/custom-fields", "GET", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/custom-fields", "GET", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/custom-fields/{resourceId}", "GET", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/custom-fields/{resourceId}", "GET", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/meta", "HEAD", typeof(StockMasterNonGlRelationController), "GetEntityView")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/meta", "HEAD", typeof(StockMasterNonGlRelationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/count", "HEAD", typeof(StockMasterNonGlRelationController), "Count")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/count", "HEAD", typeof(StockMasterNonGlRelationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/all", "HEAD", typeof(StockMasterNonGlRelationController), "GetAll")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/all", "HEAD", typeof(StockMasterNonGlRelationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/export", "HEAD", typeof(StockMasterNonGlRelationController), "Export")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/export", "HEAD", typeof(StockMasterNonGlRelationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/1", "HEAD", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/1", "HEAD", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/get?stockMasterNonGlRelationIds=1", "HEAD", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/get?stockMasterNonGlRelationIds=1", "HEAD", typeof(StockMasterNonGlRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation", "HEAD", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master-non-gl-relation", "HEAD", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/page/1", "HEAD", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/page/1", "HEAD", typeof(StockMasterNonGlRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/count-filtered/{filterName}", "HEAD", typeof(StockMasterNonGlRelationController), "CountFiltered")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/count-filtered/{filterName}", "HEAD", typeof(StockMasterNonGlRelationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockMasterNonGlRelationController), "GetFiltered")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StockMasterNonGlRelationController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/custom-fields", "HEAD", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/custom-fields", "HEAD", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/stock-master-non-gl-relation/custom-fields/{resourceId}", "HEAD", typeof(StockMasterNonGlRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/stock-master-non-gl-relation/custom-fields/{resourceId}", "HEAD", typeof(StockMasterNonGlRelationController), "GetCustomFields")]

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

        public StockMasterNonGlRelationRouteTests()
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