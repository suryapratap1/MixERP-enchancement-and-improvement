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
    public class FiscalYearRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/delete/{fiscalYearCode}", "DELETE", typeof(FiscalYearController), "Delete")]
        [InlineData("/api/core/fiscal-year/delete/{fiscalYearCode}", "DELETE", typeof(FiscalYearController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/edit/{fiscalYearCode}", "PUT", typeof(FiscalYearController), "Edit")]
        [InlineData("/api/core/fiscal-year/edit/{fiscalYearCode}", "PUT", typeof(FiscalYearController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/count-where", "POST", typeof(FiscalYearController), "CountWhere")]
        [InlineData("/api/core/fiscal-year/count-where", "POST", typeof(FiscalYearController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/get-where/{pageNumber}", "POST", typeof(FiscalYearController), "GetWhere")]
        [InlineData("/api/core/fiscal-year/get-where/{pageNumber}", "POST", typeof(FiscalYearController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/add-or-edit", "POST", typeof(FiscalYearController), "AddOrEdit")]
        [InlineData("/api/core/fiscal-year/add-or-edit", "POST", typeof(FiscalYearController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/add/{fiscalYear}", "POST", typeof(FiscalYearController), "Add")]
        [InlineData("/api/core/fiscal-year/add/{fiscalYear}", "POST", typeof(FiscalYearController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/bulk-import", "POST", typeof(FiscalYearController), "BulkImport")]
        [InlineData("/api/core/fiscal-year/bulk-import", "POST", typeof(FiscalYearController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/meta", "GET", typeof(FiscalYearController), "GetEntityView")]
        [InlineData("/api/core/fiscal-year/meta", "GET", typeof(FiscalYearController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/count", "GET", typeof(FiscalYearController), "Count")]
        [InlineData("/api/core/fiscal-year/count", "GET", typeof(FiscalYearController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/all", "GET", typeof(FiscalYearController), "GetAll")]
        [InlineData("/api/core/fiscal-year/all", "GET", typeof(FiscalYearController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/export", "GET", typeof(FiscalYearController), "Export")]
        [InlineData("/api/core/fiscal-year/export", "GET", typeof(FiscalYearController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/1", "GET", typeof(FiscalYearController), "Get")]
        [InlineData("/api/core/fiscal-year/1", "GET", typeof(FiscalYearController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/get?fiscalYearCodes=1", "GET", typeof(FiscalYearController), "Get")]
        [InlineData("/api/core/fiscal-year/get?fiscalYearCodes=1", "GET", typeof(FiscalYearController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year", "GET", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/core/fiscal-year", "GET", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/page/1", "GET", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/core/fiscal-year/page/1", "GET", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/count-filtered/{filterName}", "GET", typeof(FiscalYearController), "CountFiltered")]
        [InlineData("/api/core/fiscal-year/count-filtered/{filterName}", "GET", typeof(FiscalYearController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/get-filtered/{pageNumber}/{filterName}", "GET", typeof(FiscalYearController), "GetFiltered")]
        [InlineData("/api/core/fiscal-year/get-filtered/{pageNumber}/{filterName}", "GET", typeof(FiscalYearController), "GetFiltered")]
        [InlineData("/api/core/fiscal-year/first", "GET", typeof(FiscalYearController), "GetFirst")]
        [InlineData("/api/core/fiscal-year/previous/1", "GET", typeof(FiscalYearController), "GetPrevious")]
        [InlineData("/api/core/fiscal-year/next/1", "GET", typeof(FiscalYearController), "GetNext")]
        [InlineData("/api/core/fiscal-year/last", "GET", typeof(FiscalYearController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/custom-fields", "GET", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/core/fiscal-year/custom-fields", "GET", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/custom-fields/{resourceId}", "GET", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/core/fiscal-year/custom-fields/{resourceId}", "GET", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/meta", "HEAD", typeof(FiscalYearController), "GetEntityView")]
        [InlineData("/api/core/fiscal-year/meta", "HEAD", typeof(FiscalYearController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/count", "HEAD", typeof(FiscalYearController), "Count")]
        [InlineData("/api/core/fiscal-year/count", "HEAD", typeof(FiscalYearController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/all", "HEAD", typeof(FiscalYearController), "GetAll")]
        [InlineData("/api/core/fiscal-year/all", "HEAD", typeof(FiscalYearController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/export", "HEAD", typeof(FiscalYearController), "Export")]
        [InlineData("/api/core/fiscal-year/export", "HEAD", typeof(FiscalYearController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/1", "HEAD", typeof(FiscalYearController), "Get")]
        [InlineData("/api/core/fiscal-year/1", "HEAD", typeof(FiscalYearController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/get?fiscalYearCodes=1", "HEAD", typeof(FiscalYearController), "Get")]
        [InlineData("/api/core/fiscal-year/get?fiscalYearCodes=1", "HEAD", typeof(FiscalYearController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year", "HEAD", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/core/fiscal-year", "HEAD", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/page/1", "HEAD", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/core/fiscal-year/page/1", "HEAD", typeof(FiscalYearController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/count-filtered/{filterName}", "HEAD", typeof(FiscalYearController), "CountFiltered")]
        [InlineData("/api/core/fiscal-year/count-filtered/{filterName}", "HEAD", typeof(FiscalYearController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(FiscalYearController), "GetFiltered")]
        [InlineData("/api/core/fiscal-year/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(FiscalYearController), "GetFiltered")]
        [InlineData("/api/core/fiscal-year/first", "HEAD", typeof(FiscalYearController), "GetFirst")]
        [InlineData("/api/core/fiscal-year/previous/1", "HEAD", typeof(FiscalYearController), "GetPrevious")]
        [InlineData("/api/core/fiscal-year/next/1", "HEAD", typeof(FiscalYearController), "GetNext")]
        [InlineData("/api/core/fiscal-year/last", "HEAD", typeof(FiscalYearController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/custom-fields", "HEAD", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/core/fiscal-year/custom-fields", "HEAD", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/fiscal-year/custom-fields/{resourceId}", "HEAD", typeof(FiscalYearController), "GetCustomFields")]
        [InlineData("/api/core/fiscal-year/custom-fields/{resourceId}", "HEAD", typeof(FiscalYearController), "GetCustomFields")]

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

        public FiscalYearRouteTests()
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