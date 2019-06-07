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
    public class CountySalesTaxRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/delete/{countySalesTaxId}", "DELETE", typeof(CountySalesTaxController), "Delete")]
        [InlineData("/api/core/county-sales-tax/delete/{countySalesTaxId}", "DELETE", typeof(CountySalesTaxController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/edit/{countySalesTaxId}", "PUT", typeof(CountySalesTaxController), "Edit")]
        [InlineData("/api/core/county-sales-tax/edit/{countySalesTaxId}", "PUT", typeof(CountySalesTaxController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/count-where", "POST", typeof(CountySalesTaxController), "CountWhere")]
        [InlineData("/api/core/county-sales-tax/count-where", "POST", typeof(CountySalesTaxController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/get-where/{pageNumber}", "POST", typeof(CountySalesTaxController), "GetWhere")]
        [InlineData("/api/core/county-sales-tax/get-where/{pageNumber}", "POST", typeof(CountySalesTaxController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/add-or-edit", "POST", typeof(CountySalesTaxController), "AddOrEdit")]
        [InlineData("/api/core/county-sales-tax/add-or-edit", "POST", typeof(CountySalesTaxController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/add/{countySalesTax}", "POST", typeof(CountySalesTaxController), "Add")]
        [InlineData("/api/core/county-sales-tax/add/{countySalesTax}", "POST", typeof(CountySalesTaxController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/bulk-import", "POST", typeof(CountySalesTaxController), "BulkImport")]
        [InlineData("/api/core/county-sales-tax/bulk-import", "POST", typeof(CountySalesTaxController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/meta", "GET", typeof(CountySalesTaxController), "GetEntityView")]
        [InlineData("/api/core/county-sales-tax/meta", "GET", typeof(CountySalesTaxController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/count", "GET", typeof(CountySalesTaxController), "Count")]
        [InlineData("/api/core/county-sales-tax/count", "GET", typeof(CountySalesTaxController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/all", "GET", typeof(CountySalesTaxController), "GetAll")]
        [InlineData("/api/core/county-sales-tax/all", "GET", typeof(CountySalesTaxController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/export", "GET", typeof(CountySalesTaxController), "Export")]
        [InlineData("/api/core/county-sales-tax/export", "GET", typeof(CountySalesTaxController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/1", "GET", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/core/county-sales-tax/1", "GET", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/get?countySalesTaxIds=1", "GET", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/core/county-sales-tax/get?countySalesTaxIds=1", "GET", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax", "GET", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/county-sales-tax", "GET", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/page/1", "GET", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/county-sales-tax/page/1", "GET", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/count-filtered/{filterName}", "GET", typeof(CountySalesTaxController), "CountFiltered")]
        [InlineData("/api/core/county-sales-tax/count-filtered/{filterName}", "GET", typeof(CountySalesTaxController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CountySalesTaxController), "GetFiltered")]
        [InlineData("/api/core/county-sales-tax/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CountySalesTaxController), "GetFiltered")]
        [InlineData("/api/core/county-sales-tax/first", "GET", typeof(CountySalesTaxController), "GetFirst")]
        [InlineData("/api/core/county-sales-tax/previous/1", "GET", typeof(CountySalesTaxController), "GetPrevious")]
        [InlineData("/api/core/county-sales-tax/next/1", "GET", typeof(CountySalesTaxController), "GetNext")]
        [InlineData("/api/core/county-sales-tax/last", "GET", typeof(CountySalesTaxController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/custom-fields", "GET", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/county-sales-tax/custom-fields", "GET", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/custom-fields/{resourceId}", "GET", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/county-sales-tax/custom-fields/{resourceId}", "GET", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/meta", "HEAD", typeof(CountySalesTaxController), "GetEntityView")]
        [InlineData("/api/core/county-sales-tax/meta", "HEAD", typeof(CountySalesTaxController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/count", "HEAD", typeof(CountySalesTaxController), "Count")]
        [InlineData("/api/core/county-sales-tax/count", "HEAD", typeof(CountySalesTaxController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/all", "HEAD", typeof(CountySalesTaxController), "GetAll")]
        [InlineData("/api/core/county-sales-tax/all", "HEAD", typeof(CountySalesTaxController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/export", "HEAD", typeof(CountySalesTaxController), "Export")]
        [InlineData("/api/core/county-sales-tax/export", "HEAD", typeof(CountySalesTaxController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/1", "HEAD", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/core/county-sales-tax/1", "HEAD", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/get?countySalesTaxIds=1", "HEAD", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/core/county-sales-tax/get?countySalesTaxIds=1", "HEAD", typeof(CountySalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax", "HEAD", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/county-sales-tax", "HEAD", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/page/1", "HEAD", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/county-sales-tax/page/1", "HEAD", typeof(CountySalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/count-filtered/{filterName}", "HEAD", typeof(CountySalesTaxController), "CountFiltered")]
        [InlineData("/api/core/county-sales-tax/count-filtered/{filterName}", "HEAD", typeof(CountySalesTaxController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CountySalesTaxController), "GetFiltered")]
        [InlineData("/api/core/county-sales-tax/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CountySalesTaxController), "GetFiltered")]
        [InlineData("/api/core/county-sales-tax/first", "HEAD", typeof(CountySalesTaxController), "GetFirst")]
        [InlineData("/api/core/county-sales-tax/previous/1", "HEAD", typeof(CountySalesTaxController), "GetPrevious")]
        [InlineData("/api/core/county-sales-tax/next/1", "HEAD", typeof(CountySalesTaxController), "GetNext")]
        [InlineData("/api/core/county-sales-tax/last", "HEAD", typeof(CountySalesTaxController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/custom-fields", "HEAD", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/county-sales-tax/custom-fields", "HEAD", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/county-sales-tax/custom-fields/{resourceId}", "HEAD", typeof(CountySalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/county-sales-tax/custom-fields/{resourceId}", "HEAD", typeof(CountySalesTaxController), "GetCustomFields")]

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

        public CountySalesTaxRouteTests()
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