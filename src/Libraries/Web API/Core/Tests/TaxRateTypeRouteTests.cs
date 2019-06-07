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
    public class TaxRateTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/delete/{taxRateTypeCode}", "DELETE", typeof(TaxRateTypeController), "Delete")]
        [InlineData("/api/core/tax-rate-type/delete/{taxRateTypeCode}", "DELETE", typeof(TaxRateTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/edit/{taxRateTypeCode}", "PUT", typeof(TaxRateTypeController), "Edit")]
        [InlineData("/api/core/tax-rate-type/edit/{taxRateTypeCode}", "PUT", typeof(TaxRateTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/count-where", "POST", typeof(TaxRateTypeController), "CountWhere")]
        [InlineData("/api/core/tax-rate-type/count-where", "POST", typeof(TaxRateTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/get-where/{pageNumber}", "POST", typeof(TaxRateTypeController), "GetWhere")]
        [InlineData("/api/core/tax-rate-type/get-where/{pageNumber}", "POST", typeof(TaxRateTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/add-or-edit", "POST", typeof(TaxRateTypeController), "AddOrEdit")]
        [InlineData("/api/core/tax-rate-type/add-or-edit", "POST", typeof(TaxRateTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/add/{taxRateType}", "POST", typeof(TaxRateTypeController), "Add")]
        [InlineData("/api/core/tax-rate-type/add/{taxRateType}", "POST", typeof(TaxRateTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/bulk-import", "POST", typeof(TaxRateTypeController), "BulkImport")]
        [InlineData("/api/core/tax-rate-type/bulk-import", "POST", typeof(TaxRateTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/meta", "GET", typeof(TaxRateTypeController), "GetEntityView")]
        [InlineData("/api/core/tax-rate-type/meta", "GET", typeof(TaxRateTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/count", "GET", typeof(TaxRateTypeController), "Count")]
        [InlineData("/api/core/tax-rate-type/count", "GET", typeof(TaxRateTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/all", "GET", typeof(TaxRateTypeController), "GetAll")]
        [InlineData("/api/core/tax-rate-type/all", "GET", typeof(TaxRateTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/export", "GET", typeof(TaxRateTypeController), "Export")]
        [InlineData("/api/core/tax-rate-type/export", "GET", typeof(TaxRateTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/1", "GET", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/core/tax-rate-type/1", "GET", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/get?taxRateTypeCodes=1", "GET", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/core/tax-rate-type/get?taxRateTypeCodes=1", "GET", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type", "GET", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-rate-type", "GET", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/page/1", "GET", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-rate-type/page/1", "GET", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/count-filtered/{filterName}", "GET", typeof(TaxRateTypeController), "CountFiltered")]
        [InlineData("/api/core/tax-rate-type/count-filtered/{filterName}", "GET", typeof(TaxRateTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxRateTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-rate-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxRateTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-rate-type/first", "GET", typeof(TaxRateTypeController), "GetFirst")]
        [InlineData("/api/core/tax-rate-type/previous/1", "GET", typeof(TaxRateTypeController), "GetPrevious")]
        [InlineData("/api/core/tax-rate-type/next/1", "GET", typeof(TaxRateTypeController), "GetNext")]
        [InlineData("/api/core/tax-rate-type/last", "GET", typeof(TaxRateTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/custom-fields", "GET", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-rate-type/custom-fields", "GET", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/custom-fields/{resourceId}", "GET", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-rate-type/custom-fields/{resourceId}", "GET", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/meta", "HEAD", typeof(TaxRateTypeController), "GetEntityView")]
        [InlineData("/api/core/tax-rate-type/meta", "HEAD", typeof(TaxRateTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/count", "HEAD", typeof(TaxRateTypeController), "Count")]
        [InlineData("/api/core/tax-rate-type/count", "HEAD", typeof(TaxRateTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/all", "HEAD", typeof(TaxRateTypeController), "GetAll")]
        [InlineData("/api/core/tax-rate-type/all", "HEAD", typeof(TaxRateTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/export", "HEAD", typeof(TaxRateTypeController), "Export")]
        [InlineData("/api/core/tax-rate-type/export", "HEAD", typeof(TaxRateTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/1", "HEAD", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/core/tax-rate-type/1", "HEAD", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/get?taxRateTypeCodes=1", "HEAD", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/core/tax-rate-type/get?taxRateTypeCodes=1", "HEAD", typeof(TaxRateTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type", "HEAD", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-rate-type", "HEAD", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/page/1", "HEAD", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-rate-type/page/1", "HEAD", typeof(TaxRateTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/count-filtered/{filterName}", "HEAD", typeof(TaxRateTypeController), "CountFiltered")]
        [InlineData("/api/core/tax-rate-type/count-filtered/{filterName}", "HEAD", typeof(TaxRateTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxRateTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-rate-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxRateTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-rate-type/first", "HEAD", typeof(TaxRateTypeController), "GetFirst")]
        [InlineData("/api/core/tax-rate-type/previous/1", "HEAD", typeof(TaxRateTypeController), "GetPrevious")]
        [InlineData("/api/core/tax-rate-type/next/1", "HEAD", typeof(TaxRateTypeController), "GetNext")]
        [InlineData("/api/core/tax-rate-type/last", "HEAD", typeof(TaxRateTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/custom-fields", "HEAD", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-rate-type/custom-fields", "HEAD", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-rate-type/custom-fields/{resourceId}", "HEAD", typeof(TaxRateTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-rate-type/custom-fields/{resourceId}", "HEAD", typeof(TaxRateTypeController), "GetCustomFields")]

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

        public TaxRateTypeRouteTests()
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