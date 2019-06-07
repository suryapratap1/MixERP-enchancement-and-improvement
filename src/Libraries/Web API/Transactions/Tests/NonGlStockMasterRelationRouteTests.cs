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
    public class NonGlStockMasterRelationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/delete/{nonGlStockMasterRelationId}", "DELETE", typeof(NonGlStockMasterRelationController), "Delete")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/delete/{nonGlStockMasterRelationId}", "DELETE", typeof(NonGlStockMasterRelationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/edit/{nonGlStockMasterRelationId}", "PUT", typeof(NonGlStockMasterRelationController), "Edit")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/edit/{nonGlStockMasterRelationId}", "PUT", typeof(NonGlStockMasterRelationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/count-where", "POST", typeof(NonGlStockMasterRelationController), "CountWhere")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/count-where", "POST", typeof(NonGlStockMasterRelationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/get-where/{pageNumber}", "POST", typeof(NonGlStockMasterRelationController), "GetWhere")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/get-where/{pageNumber}", "POST", typeof(NonGlStockMasterRelationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/add-or-edit", "POST", typeof(NonGlStockMasterRelationController), "AddOrEdit")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/add-or-edit", "POST", typeof(NonGlStockMasterRelationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/add/{nonGlStockMasterRelation}", "POST", typeof(NonGlStockMasterRelationController), "Add")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/add/{nonGlStockMasterRelation}", "POST", typeof(NonGlStockMasterRelationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/bulk-import", "POST", typeof(NonGlStockMasterRelationController), "BulkImport")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/bulk-import", "POST", typeof(NonGlStockMasterRelationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/meta", "GET", typeof(NonGlStockMasterRelationController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/meta", "GET", typeof(NonGlStockMasterRelationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/count", "GET", typeof(NonGlStockMasterRelationController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/count", "GET", typeof(NonGlStockMasterRelationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/all", "GET", typeof(NonGlStockMasterRelationController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/all", "GET", typeof(NonGlStockMasterRelationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/export", "GET", typeof(NonGlStockMasterRelationController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/export", "GET", typeof(NonGlStockMasterRelationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/1", "GET", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/1", "GET", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/get?nonGlStockMasterRelationIds=1", "GET", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/get?nonGlStockMasterRelationIds=1", "GET", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation", "GET", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master-relation", "GET", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/page/1", "GET", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/page/1", "GET", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/count-filtered/{filterName}", "GET", typeof(NonGlStockMasterRelationController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/count-filtered/{filterName}", "GET", typeof(NonGlStockMasterRelationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockMasterRelationController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockMasterRelationController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/custom-fields", "GET", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/custom-fields", "GET", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/custom-fields/{resourceId}", "GET", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/custom-fields/{resourceId}", "GET", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/meta", "HEAD", typeof(NonGlStockMasterRelationController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/meta", "HEAD", typeof(NonGlStockMasterRelationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/count", "HEAD", typeof(NonGlStockMasterRelationController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/count", "HEAD", typeof(NonGlStockMasterRelationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/all", "HEAD", typeof(NonGlStockMasterRelationController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/all", "HEAD", typeof(NonGlStockMasterRelationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/export", "HEAD", typeof(NonGlStockMasterRelationController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/export", "HEAD", typeof(NonGlStockMasterRelationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/1", "HEAD", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/1", "HEAD", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/get?nonGlStockMasterRelationIds=1", "HEAD", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/get?nonGlStockMasterRelationIds=1", "HEAD", typeof(NonGlStockMasterRelationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation", "HEAD", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master-relation", "HEAD", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/page/1", "HEAD", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/page/1", "HEAD", typeof(NonGlStockMasterRelationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/count-filtered/{filterName}", "HEAD", typeof(NonGlStockMasterRelationController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/count-filtered/{filterName}", "HEAD", typeof(NonGlStockMasterRelationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockMasterRelationController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockMasterRelationController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/custom-fields", "HEAD", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/custom-fields", "HEAD", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-master-relation/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockMasterRelationController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-master-relation/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockMasterRelationController), "GetCustomFields")]

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

        public NonGlStockMasterRelationRouteTests()
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