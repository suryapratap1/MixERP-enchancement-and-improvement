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
    public class SalesTaxExemptDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/delete/{salesTaxExemptDetailId}", "DELETE", typeof(SalesTaxExemptDetailController), "Delete")]
        [InlineData("/api/core/sales-tax-exempt-detail/delete/{salesTaxExemptDetailId}", "DELETE", typeof(SalesTaxExemptDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/edit/{salesTaxExemptDetailId}", "PUT", typeof(SalesTaxExemptDetailController), "Edit")]
        [InlineData("/api/core/sales-tax-exempt-detail/edit/{salesTaxExemptDetailId}", "PUT", typeof(SalesTaxExemptDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/count-where", "POST", typeof(SalesTaxExemptDetailController), "CountWhere")]
        [InlineData("/api/core/sales-tax-exempt-detail/count-where", "POST", typeof(SalesTaxExemptDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/get-where/{pageNumber}", "POST", typeof(SalesTaxExemptDetailController), "GetWhere")]
        [InlineData("/api/core/sales-tax-exempt-detail/get-where/{pageNumber}", "POST", typeof(SalesTaxExemptDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/add-or-edit", "POST", typeof(SalesTaxExemptDetailController), "AddOrEdit")]
        [InlineData("/api/core/sales-tax-exempt-detail/add-or-edit", "POST", typeof(SalesTaxExemptDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/add/{salesTaxExemptDetail}", "POST", typeof(SalesTaxExemptDetailController), "Add")]
        [InlineData("/api/core/sales-tax-exempt-detail/add/{salesTaxExemptDetail}", "POST", typeof(SalesTaxExemptDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/bulk-import", "POST", typeof(SalesTaxExemptDetailController), "BulkImport")]
        [InlineData("/api/core/sales-tax-exempt-detail/bulk-import", "POST", typeof(SalesTaxExemptDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/meta", "GET", typeof(SalesTaxExemptDetailController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-exempt-detail/meta", "GET", typeof(SalesTaxExemptDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/count", "GET", typeof(SalesTaxExemptDetailController), "Count")]
        [InlineData("/api/core/sales-tax-exempt-detail/count", "GET", typeof(SalesTaxExemptDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/all", "GET", typeof(SalesTaxExemptDetailController), "GetAll")]
        [InlineData("/api/core/sales-tax-exempt-detail/all", "GET", typeof(SalesTaxExemptDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/export", "GET", typeof(SalesTaxExemptDetailController), "Export")]
        [InlineData("/api/core/sales-tax-exempt-detail/export", "GET", typeof(SalesTaxExemptDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/1", "GET", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/core/sales-tax-exempt-detail/1", "GET", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/get?salesTaxExemptDetailIds=1", "GET", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/core/sales-tax-exempt-detail/get?salesTaxExemptDetailIds=1", "GET", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail", "GET", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt-detail", "GET", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/page/1", "GET", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt-detail/page/1", "GET", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/count-filtered/{filterName}", "GET", typeof(SalesTaxExemptDetailController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-exempt-detail/count-filtered/{filterName}", "GET", typeof(SalesTaxExemptDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxExemptDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxExemptDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt-detail/first", "GET", typeof(SalesTaxExemptDetailController), "GetFirst")]
        [InlineData("/api/core/sales-tax-exempt-detail/previous/1", "GET", typeof(SalesTaxExemptDetailController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-exempt-detail/next/1", "GET", typeof(SalesTaxExemptDetailController), "GetNext")]
        [InlineData("/api/core/sales-tax-exempt-detail/last", "GET", typeof(SalesTaxExemptDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/custom-fields", "GET", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt-detail/custom-fields", "GET", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/custom-fields/{resourceId}", "GET", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt-detail/custom-fields/{resourceId}", "GET", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/meta", "HEAD", typeof(SalesTaxExemptDetailController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-exempt-detail/meta", "HEAD", typeof(SalesTaxExemptDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/count", "HEAD", typeof(SalesTaxExemptDetailController), "Count")]
        [InlineData("/api/core/sales-tax-exempt-detail/count", "HEAD", typeof(SalesTaxExemptDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/all", "HEAD", typeof(SalesTaxExemptDetailController), "GetAll")]
        [InlineData("/api/core/sales-tax-exempt-detail/all", "HEAD", typeof(SalesTaxExemptDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/export", "HEAD", typeof(SalesTaxExemptDetailController), "Export")]
        [InlineData("/api/core/sales-tax-exempt-detail/export", "HEAD", typeof(SalesTaxExemptDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/1", "HEAD", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/core/sales-tax-exempt-detail/1", "HEAD", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/get?salesTaxExemptDetailIds=1", "HEAD", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/core/sales-tax-exempt-detail/get?salesTaxExemptDetailIds=1", "HEAD", typeof(SalesTaxExemptDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail", "HEAD", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt-detail", "HEAD", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/page/1", "HEAD", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt-detail/page/1", "HEAD", typeof(SalesTaxExemptDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/count-filtered/{filterName}", "HEAD", typeof(SalesTaxExemptDetailController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-exempt-detail/count-filtered/{filterName}", "HEAD", typeof(SalesTaxExemptDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxExemptDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxExemptDetailController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt-detail/first", "HEAD", typeof(SalesTaxExemptDetailController), "GetFirst")]
        [InlineData("/api/core/sales-tax-exempt-detail/previous/1", "HEAD", typeof(SalesTaxExemptDetailController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-exempt-detail/next/1", "HEAD", typeof(SalesTaxExemptDetailController), "GetNext")]
        [InlineData("/api/core/sales-tax-exempt-detail/last", "HEAD", typeof(SalesTaxExemptDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/custom-fields", "HEAD", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt-detail/custom-fields", "HEAD", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt-detail/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxExemptDetailController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt-detail/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxExemptDetailController), "GetCustomFields")]

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

        public SalesTaxExemptDetailRouteTests()
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