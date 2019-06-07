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
    public class SalesTaxExemptRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/delete/{salesTaxExemptId}", "DELETE", typeof(SalesTaxExemptController), "Delete")]
        [InlineData("/api/core/sales-tax-exempt/delete/{salesTaxExemptId}", "DELETE", typeof(SalesTaxExemptController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/edit/{salesTaxExemptId}", "PUT", typeof(SalesTaxExemptController), "Edit")]
        [InlineData("/api/core/sales-tax-exempt/edit/{salesTaxExemptId}", "PUT", typeof(SalesTaxExemptController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/count-where", "POST", typeof(SalesTaxExemptController), "CountWhere")]
        [InlineData("/api/core/sales-tax-exempt/count-where", "POST", typeof(SalesTaxExemptController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/get-where/{pageNumber}", "POST", typeof(SalesTaxExemptController), "GetWhere")]
        [InlineData("/api/core/sales-tax-exempt/get-where/{pageNumber}", "POST", typeof(SalesTaxExemptController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/add-or-edit", "POST", typeof(SalesTaxExemptController), "AddOrEdit")]
        [InlineData("/api/core/sales-tax-exempt/add-or-edit", "POST", typeof(SalesTaxExemptController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/add/{salesTaxExempt}", "POST", typeof(SalesTaxExemptController), "Add")]
        [InlineData("/api/core/sales-tax-exempt/add/{salesTaxExempt}", "POST", typeof(SalesTaxExemptController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/bulk-import", "POST", typeof(SalesTaxExemptController), "BulkImport")]
        [InlineData("/api/core/sales-tax-exempt/bulk-import", "POST", typeof(SalesTaxExemptController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/meta", "GET", typeof(SalesTaxExemptController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-exempt/meta", "GET", typeof(SalesTaxExemptController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/count", "GET", typeof(SalesTaxExemptController), "Count")]
        [InlineData("/api/core/sales-tax-exempt/count", "GET", typeof(SalesTaxExemptController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/all", "GET", typeof(SalesTaxExemptController), "GetAll")]
        [InlineData("/api/core/sales-tax-exempt/all", "GET", typeof(SalesTaxExemptController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/export", "GET", typeof(SalesTaxExemptController), "Export")]
        [InlineData("/api/core/sales-tax-exempt/export", "GET", typeof(SalesTaxExemptController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/1", "GET", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/core/sales-tax-exempt/1", "GET", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/get?salesTaxExemptIds=1", "GET", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/core/sales-tax-exempt/get?salesTaxExemptIds=1", "GET", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt", "GET", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt", "GET", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/page/1", "GET", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt/page/1", "GET", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/count-filtered/{filterName}", "GET", typeof(SalesTaxExemptController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-exempt/count-filtered/{filterName}", "GET", typeof(SalesTaxExemptController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxExemptController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxExemptController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt/first", "GET", typeof(SalesTaxExemptController), "GetFirst")]
        [InlineData("/api/core/sales-tax-exempt/previous/1", "GET", typeof(SalesTaxExemptController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-exempt/next/1", "GET", typeof(SalesTaxExemptController), "GetNext")]
        [InlineData("/api/core/sales-tax-exempt/last", "GET", typeof(SalesTaxExemptController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/custom-fields", "GET", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt/custom-fields", "GET", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/custom-fields/{resourceId}", "GET", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt/custom-fields/{resourceId}", "GET", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/meta", "HEAD", typeof(SalesTaxExemptController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-exempt/meta", "HEAD", typeof(SalesTaxExemptController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/count", "HEAD", typeof(SalesTaxExemptController), "Count")]
        [InlineData("/api/core/sales-tax-exempt/count", "HEAD", typeof(SalesTaxExemptController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/all", "HEAD", typeof(SalesTaxExemptController), "GetAll")]
        [InlineData("/api/core/sales-tax-exempt/all", "HEAD", typeof(SalesTaxExemptController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/export", "HEAD", typeof(SalesTaxExemptController), "Export")]
        [InlineData("/api/core/sales-tax-exempt/export", "HEAD", typeof(SalesTaxExemptController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/1", "HEAD", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/core/sales-tax-exempt/1", "HEAD", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/get?salesTaxExemptIds=1", "HEAD", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/core/sales-tax-exempt/get?salesTaxExemptIds=1", "HEAD", typeof(SalesTaxExemptController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt", "HEAD", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt", "HEAD", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/page/1", "HEAD", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-exempt/page/1", "HEAD", typeof(SalesTaxExemptController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/count-filtered/{filterName}", "HEAD", typeof(SalesTaxExemptController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-exempt/count-filtered/{filterName}", "HEAD", typeof(SalesTaxExemptController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxExemptController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxExemptController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-exempt/first", "HEAD", typeof(SalesTaxExemptController), "GetFirst")]
        [InlineData("/api/core/sales-tax-exempt/previous/1", "HEAD", typeof(SalesTaxExemptController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-exempt/next/1", "HEAD", typeof(SalesTaxExemptController), "GetNext")]
        [InlineData("/api/core/sales-tax-exempt/last", "HEAD", typeof(SalesTaxExemptController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/custom-fields", "HEAD", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt/custom-fields", "HEAD", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-exempt/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxExemptController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-exempt/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxExemptController), "GetCustomFields")]

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

        public SalesTaxExemptRouteTests()
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