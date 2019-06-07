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

namespace MixERP.Net.Api.Core.Tests
{
    public class SalesTaxDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/delete/{salesTaxDetailId}", "DELETE", typeof(SalesTaxDetailController), "Delete")]
        [InlineData("/api/core/sales-tax-detail/delete/{salesTaxDetailId}", "DELETE", typeof(SalesTaxDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/edit/{salesTaxDetailId}", "PUT", typeof(SalesTaxDetailController), "Edit")]
        [InlineData("/api/core/sales-tax-detail/edit/{salesTaxDetailId}", "PUT", typeof(SalesTaxDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/count-where", "POST", typeof(SalesTaxDetailController), "CountWhere")]
        [InlineData("/api/core/sales-tax-detail/count-where", "POST", typeof(SalesTaxDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/get-where/{pageNumber}", "POST", typeof(SalesTaxDetailController), "GetWhere")]
        [InlineData("/api/core/sales-tax-detail/get-where/{pageNumber}", "POST", typeof(SalesTaxDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/add-or-edit", "POST", typeof(SalesTaxDetailController), "AddOrEdit")]
        [InlineData("/api/core/sales-tax-detail/add-or-edit", "POST", typeof(SalesTaxDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/add/{salesTaxDetail}", "POST", typeof(SalesTaxDetailController), "Add")]
        [InlineData("/api/core/sales-tax-detail/add/{salesTaxDetail}", "POST", typeof(SalesTaxDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/bulk-import", "POST", typeof(SalesTaxDetailController), "BulkImport")]
        [InlineData("/api/core/sales-tax-detail/bulk-import", "POST", typeof(SalesTaxDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/meta", "GET", typeof(SalesTaxDetailController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-detail/meta", "GET", typeof(SalesTaxDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/count", "GET", typeof(SalesTaxDetailController), "Count")]
        [InlineData("/api/core/sales-tax-detail/count", "GET", typeof(SalesTaxDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/all", "GET", typeof(SalesTaxDetailController), "GetAll")]
        [InlineData("/api/core/sales-tax-detail/all", "GET", typeof(SalesTaxDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/export", "GET", typeof(SalesTaxDetailController), "Export")]
        [InlineData("/api/core/sales-tax-detail/export", "GET", typeof(SalesTaxDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/1", "GET", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/core/sales-tax-detail/1", "GET", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/get?salesTaxDetailIds=1", "GET", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/core/sales-tax-detail/get?salesTaxDetailIds=1", "GET", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail", "GET", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-detail", "GET", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/page/1", "GET", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-detail/page/1", "GET", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/count-filtered/{filterName}", "GET", typeof(SalesTaxDetailController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-detail/count-filtered/{filterName}", "GET", typeof(SalesTaxDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-detail/first", "GET", typeof(SalesTaxDetailController), "GetFirst")]
        [InlineData("/api/core/sales-tax-detail/previous/1", "GET", typeof(SalesTaxDetailController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-detail/next/1", "GET", typeof(SalesTaxDetailController), "GetNext")]
        [InlineData("/api/core/sales-tax-detail/last", "GET", typeof(SalesTaxDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/custom-fields", "GET", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-detail/custom-fields", "GET", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/custom-fields/{resourceId}", "GET", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-detail/custom-fields/{resourceId}", "GET", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/meta", "HEAD", typeof(SalesTaxDetailController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-detail/meta", "HEAD", typeof(SalesTaxDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/count", "HEAD", typeof(SalesTaxDetailController), "Count")]
        [InlineData("/api/core/sales-tax-detail/count", "HEAD", typeof(SalesTaxDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/all", "HEAD", typeof(SalesTaxDetailController), "GetAll")]
        [InlineData("/api/core/sales-tax-detail/all", "HEAD", typeof(SalesTaxDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/export", "HEAD", typeof(SalesTaxDetailController), "Export")]
        [InlineData("/api/core/sales-tax-detail/export", "HEAD", typeof(SalesTaxDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/1", "HEAD", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/core/sales-tax-detail/1", "HEAD", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/get?salesTaxDetailIds=1", "HEAD", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/core/sales-tax-detail/get?salesTaxDetailIds=1", "HEAD", typeof(SalesTaxDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail", "HEAD", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-detail", "HEAD", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/page/1", "HEAD", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-detail/page/1", "HEAD", typeof(SalesTaxDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/count-filtered/{filterName}", "HEAD", typeof(SalesTaxDetailController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-detail/count-filtered/{filterName}", "HEAD", typeof(SalesTaxDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-detail/first", "HEAD", typeof(SalesTaxDetailController), "GetFirst")]
        [InlineData("/api/core/sales-tax-detail/previous/1", "HEAD", typeof(SalesTaxDetailController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-detail/next/1", "HEAD", typeof(SalesTaxDetailController), "GetNext")]
        [InlineData("/api/core/sales-tax-detail/last", "HEAD", typeof(SalesTaxDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/custom-fields", "HEAD", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-detail/custom-fields", "HEAD", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-detail/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-detail/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxDetailController), "GetCustomFields")]

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

        public SalesTaxDetailRouteTests()
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