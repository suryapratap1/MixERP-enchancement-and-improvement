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
    public class SalesTaxTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/delete/{salesTaxTypeId}", "DELETE", typeof(SalesTaxTypeController), "Delete")]
        [InlineData("/api/core/sales-tax-type/delete/{salesTaxTypeId}", "DELETE", typeof(SalesTaxTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/edit/{salesTaxTypeId}", "PUT", typeof(SalesTaxTypeController), "Edit")]
        [InlineData("/api/core/sales-tax-type/edit/{salesTaxTypeId}", "PUT", typeof(SalesTaxTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/count-where", "POST", typeof(SalesTaxTypeController), "CountWhere")]
        [InlineData("/api/core/sales-tax-type/count-where", "POST", typeof(SalesTaxTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/get-where/{pageNumber}", "POST", typeof(SalesTaxTypeController), "GetWhere")]
        [InlineData("/api/core/sales-tax-type/get-where/{pageNumber}", "POST", typeof(SalesTaxTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/add-or-edit", "POST", typeof(SalesTaxTypeController), "AddOrEdit")]
        [InlineData("/api/core/sales-tax-type/add-or-edit", "POST", typeof(SalesTaxTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/add/{salesTaxType}", "POST", typeof(SalesTaxTypeController), "Add")]
        [InlineData("/api/core/sales-tax-type/add/{salesTaxType}", "POST", typeof(SalesTaxTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/bulk-import", "POST", typeof(SalesTaxTypeController), "BulkImport")]
        [InlineData("/api/core/sales-tax-type/bulk-import", "POST", typeof(SalesTaxTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/meta", "GET", typeof(SalesTaxTypeController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-type/meta", "GET", typeof(SalesTaxTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/count", "GET", typeof(SalesTaxTypeController), "Count")]
        [InlineData("/api/core/sales-tax-type/count", "GET", typeof(SalesTaxTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/all", "GET", typeof(SalesTaxTypeController), "GetAll")]
        [InlineData("/api/core/sales-tax-type/all", "GET", typeof(SalesTaxTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/export", "GET", typeof(SalesTaxTypeController), "Export")]
        [InlineData("/api/core/sales-tax-type/export", "GET", typeof(SalesTaxTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/1", "GET", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/core/sales-tax-type/1", "GET", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/get?salesTaxTypeIds=1", "GET", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/core/sales-tax-type/get?salesTaxTypeIds=1", "GET", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type", "GET", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-type", "GET", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/page/1", "GET", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-type/page/1", "GET", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/count-filtered/{filterName}", "GET", typeof(SalesTaxTypeController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-type/count-filtered/{filterName}", "GET", typeof(SalesTaxTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxTypeController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTaxTypeController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-type/first", "GET", typeof(SalesTaxTypeController), "GetFirst")]
        [InlineData("/api/core/sales-tax-type/previous/1", "GET", typeof(SalesTaxTypeController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-type/next/1", "GET", typeof(SalesTaxTypeController), "GetNext")]
        [InlineData("/api/core/sales-tax-type/last", "GET", typeof(SalesTaxTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/custom-fields", "GET", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-type/custom-fields", "GET", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/custom-fields/{resourceId}", "GET", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-type/custom-fields/{resourceId}", "GET", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/meta", "HEAD", typeof(SalesTaxTypeController), "GetEntityView")]
        [InlineData("/api/core/sales-tax-type/meta", "HEAD", typeof(SalesTaxTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/count", "HEAD", typeof(SalesTaxTypeController), "Count")]
        [InlineData("/api/core/sales-tax-type/count", "HEAD", typeof(SalesTaxTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/all", "HEAD", typeof(SalesTaxTypeController), "GetAll")]
        [InlineData("/api/core/sales-tax-type/all", "HEAD", typeof(SalesTaxTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/export", "HEAD", typeof(SalesTaxTypeController), "Export")]
        [InlineData("/api/core/sales-tax-type/export", "HEAD", typeof(SalesTaxTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/1", "HEAD", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/core/sales-tax-type/1", "HEAD", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/get?salesTaxTypeIds=1", "HEAD", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/core/sales-tax-type/get?salesTaxTypeIds=1", "HEAD", typeof(SalesTaxTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type", "HEAD", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-type", "HEAD", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/page/1", "HEAD", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-tax-type/page/1", "HEAD", typeof(SalesTaxTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/count-filtered/{filterName}", "HEAD", typeof(SalesTaxTypeController), "CountFiltered")]
        [InlineData("/api/core/sales-tax-type/count-filtered/{filterName}", "HEAD", typeof(SalesTaxTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxTypeController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTaxTypeController), "GetFiltered")]
        [InlineData("/api/core/sales-tax-type/first", "HEAD", typeof(SalesTaxTypeController), "GetFirst")]
        [InlineData("/api/core/sales-tax-type/previous/1", "HEAD", typeof(SalesTaxTypeController), "GetPrevious")]
        [InlineData("/api/core/sales-tax-type/next/1", "HEAD", typeof(SalesTaxTypeController), "GetNext")]
        [InlineData("/api/core/sales-tax-type/last", "HEAD", typeof(SalesTaxTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/custom-fields", "HEAD", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-type/custom-fields", "HEAD", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-tax-type/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxTypeController), "GetCustomFields")]
        [InlineData("/api/core/sales-tax-type/custom-fields/{resourceId}", "HEAD", typeof(SalesTaxTypeController), "GetCustomFields")]

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

        public SalesTaxTypeRouteTests()
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