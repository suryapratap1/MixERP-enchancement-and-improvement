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
    public class NonGlStockTaxDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/delete/{nonGlStockTaxDetailId}", "DELETE", typeof(NonGlStockTaxDetailController), "Delete")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/delete/{nonGlStockTaxDetailId}", "DELETE", typeof(NonGlStockTaxDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/edit/{nonGlStockTaxDetailId}", "PUT", typeof(NonGlStockTaxDetailController), "Edit")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/edit/{nonGlStockTaxDetailId}", "PUT", typeof(NonGlStockTaxDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/count-where", "POST", typeof(NonGlStockTaxDetailController), "CountWhere")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/count-where", "POST", typeof(NonGlStockTaxDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/get-where/{pageNumber}", "POST", typeof(NonGlStockTaxDetailController), "GetWhere")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/get-where/{pageNumber}", "POST", typeof(NonGlStockTaxDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/add-or-edit", "POST", typeof(NonGlStockTaxDetailController), "AddOrEdit")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/add-or-edit", "POST", typeof(NonGlStockTaxDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/add/{nonGlStockTaxDetail}", "POST", typeof(NonGlStockTaxDetailController), "Add")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/add/{nonGlStockTaxDetail}", "POST", typeof(NonGlStockTaxDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/bulk-import", "POST", typeof(NonGlStockTaxDetailController), "BulkImport")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/bulk-import", "POST", typeof(NonGlStockTaxDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/meta", "GET", typeof(NonGlStockTaxDetailController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/meta", "GET", typeof(NonGlStockTaxDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/count", "GET", typeof(NonGlStockTaxDetailController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/count", "GET", typeof(NonGlStockTaxDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/all", "GET", typeof(NonGlStockTaxDetailController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/all", "GET", typeof(NonGlStockTaxDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/export", "GET", typeof(NonGlStockTaxDetailController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/export", "GET", typeof(NonGlStockTaxDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/1", "GET", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/1", "GET", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/get?nonGlStockTaxDetailIds=1", "GET", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/get?nonGlStockTaxDetailIds=1", "GET", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail", "GET", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail", "GET", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/page/1", "GET", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/page/1", "GET", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/count-filtered/{filterName}", "GET", typeof(NonGlStockTaxDetailController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/count-filtered/{filterName}", "GET", typeof(NonGlStockTaxDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockTaxDetailController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NonGlStockTaxDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/custom-fields", "GET", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/custom-fields", "GET", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/custom-fields/{resourceId}", "GET", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/custom-fields/{resourceId}", "GET", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/meta", "HEAD", typeof(NonGlStockTaxDetailController), "GetEntityView")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/meta", "HEAD", typeof(NonGlStockTaxDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/count", "HEAD", typeof(NonGlStockTaxDetailController), "Count")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/count", "HEAD", typeof(NonGlStockTaxDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/all", "HEAD", typeof(NonGlStockTaxDetailController), "GetAll")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/all", "HEAD", typeof(NonGlStockTaxDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/export", "HEAD", typeof(NonGlStockTaxDetailController), "Export")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/export", "HEAD", typeof(NonGlStockTaxDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/1", "HEAD", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/1", "HEAD", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/get?nonGlStockTaxDetailIds=1", "HEAD", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/get?nonGlStockTaxDetailIds=1", "HEAD", typeof(NonGlStockTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail", "HEAD", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail", "HEAD", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/page/1", "HEAD", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/page/1", "HEAD", typeof(NonGlStockTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/count-filtered/{filterName}", "HEAD", typeof(NonGlStockTaxDetailController), "CountFiltered")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/count-filtered/{filterName}", "HEAD", typeof(NonGlStockTaxDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockTaxDetailController), "GetFiltered")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NonGlStockTaxDetailController), "GetFiltered")]

        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/custom-fields", "HEAD", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/custom-fields", "HEAD", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/transactions/non-gl-stock-tax-detail/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockTaxDetailController), "GetCustomFields")]
        [InlineData("/api/transactions/non-gl-stock-tax-detail/custom-fields/{resourceId}", "HEAD", typeof(NonGlStockTaxDetailController), "GetCustomFields")]

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

        public NonGlStockTaxDetailRouteTests()
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