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
    public class SalesTaxRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/delete/{salesTaxId}", "DELETE", typeof(SalesTaxController), "Delete")]
        [InlineData("/api/core/sales-tax/delete/{salesTaxId}", "DELETE", typeof(SalesTaxController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/edit/{salesTaxId}", "PUT", typeof(SalesTaxController), "Edit")]
        [InlineData("/api/core/sales-tax/edit/{salesTaxId}", "PUT", typeof(SalesTaxController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/count-where", "POST", typeof(SalesTaxController), "CountWhere")]
        [InlineData("/api/core/sales-tax/count-where", "POST", typeof(SalesTaxController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/get-where/{pageNumber}", "POST", typeof(SalesTaxController), "GetWhere")]
        [InlineData("/api/core/sales-tax/get-where/{pageNumber}", "POST", typeof(SalesTaxController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/add-or-edit", "POST", typeof(SalesTaxController), "AddOrEdit")]
        [InlineData("/api/core/sales-tax/add-or-edit", "POST", typeof(SalesTaxController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/add/{salesTax}", "POST", typeof(SalesTaxController), "Add")]
        [InlineData("/api/core/sales-tax/add/{salesTax}", "POST", typeof(SalesTaxController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/bulk-import", "POST", typeof(SalesTaxController), "BulkImport")]
        [InlineData("/api/core/sales-tax/bulk-import", "POST", typeof(SalesTaxController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/meta", "GET", typeof(SalesTaxController), "GetEntityView")]
        [InlineData("/api/core/sales-tax/meta", "GET", typeof(SalesTaxController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/count", "GET", typeof(SalesTaxController), "Count")]
        [InlineData("/api/core/sales-tax/count", "GET", typeof(SalesTaxController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/all", "GET", typeof(SalesTaxController), "GetAll")]
        [InlineData("/api/core/sales-tax/all", "GET", typeof(SalesTaxController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/export", "GET", typeof(SalesTaxController), "Export")]
        [InlineData("/api/core/sales-tax/export", "GET", typeof(SalesTaxController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/1", "GET", typeof(SalesTaxController), "Get")]
        [InlineData("/api/core/sales-tax/1", "GET", typeof(SalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/get?salesTaxIds=1", "GET", typeof(SalesTaxController), "Get")]
        [InlineData("/api/core/sales-tax/get?salesTaxIds=1", "GET", typeof(SalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax", "GET", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax", "GET", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/page/1", "GET", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax/page/1", "GET", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/count-filtered/{filterName}", "GET", typeof(SalesTaxController), "CountFiltered")]
        [InlineData("/api/core/sales-tax/count-filtered/{filterName}", "GET", typeof(SalesTaxController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxController), "GetFiltered")]
        [InlineData("/api/core/sales-tax/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxController), "GetFiltered")]
        [InlineData("/api/core/sales-tax/first", "GET", typeof(SalesTaxController), "GetFirst")]
        [InlineData("/api/core/sales-tax/previous/1", "GET", typeof(SalesTaxController), "GetPrevious")]
        [InlineData("/api/core/sales-tax/next/1", "GET", typeof(SalesTaxController), "GetNext")]
        [InlineData("/api/core/sales-tax/last", "GET", typeof(SalesTaxController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax/custom-fields", "GET", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax/custom-fields", "GET", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/custom-fields/{resourceId}", "GET", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax/custom-fields/{resourceId}", "GET", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/meta", "HEAD", typeof(SalesTaxController), "GetEntityView")]
        [InlineData("/api/core/sales-tax/meta", "HEAD", typeof(SalesTaxController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/count", "HEAD", typeof(SalesTaxController), "Count")]
        [InlineData("/api/core/sales-tax/count", "HEAD", typeof(SalesTaxController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/all", "HEAD", typeof(SalesTaxController), "GetAll")]
        [InlineData("/api/core/sales-tax/all", "HEAD", typeof(SalesTaxController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/export", "HEAD", typeof(SalesTaxController), "Export")]
        [InlineData("/api/core/sales-tax/export", "HEAD", typeof(SalesTaxController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/1", "HEAD", typeof(SalesTaxController), "Get")]
        [InlineData("/api/core/sales-tax/1", "HEAD", typeof(SalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/get?salesTaxIds=1", "HEAD", typeof(SalesTaxController), "Get")]
        [InlineData("/api/core/sales-tax/get?salesTaxIds=1", "HEAD", typeof(SalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax", "HEAD", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax", "HEAD", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/page/1", "HEAD", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax/page/1", "HEAD", typeof(SalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/count-filtered/{filterName}", "HEAD", typeof(SalesTaxController), "CountFiltered")]
        [InlineData("/api/core/sales-tax/count-filtered/{filterName}", "HEAD", typeof(SalesTaxController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxController), "GetFiltered")]
        [InlineData("/api/core/sales-tax/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxController), "GetFiltered")]
        [InlineData("/api/core/sales-tax/first", "HEAD", typeof(SalesTaxController), "GetFirst")]
        [InlineData("/api/core/sales-tax/previous/1", "HEAD", typeof(SalesTaxController), "GetPrevious")]
        [InlineData("/api/core/sales-tax/next/1", "HEAD", typeof(SalesTaxController), "GetNext")]
        [InlineData("/api/core/sales-tax/last", "HEAD", typeof(SalesTaxController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax/custom-fields", "HEAD", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax/custom-fields", "HEAD", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxController), "GetCustomFields")]

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

        public SalesTaxRouteTests()
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