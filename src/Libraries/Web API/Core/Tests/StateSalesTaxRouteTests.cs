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
    public class StateSalesTaxRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/delete/{stateSalesTaxId}", "DELETE", typeof(StateSalesTaxController), "Delete")]
        [InlineData("/api/core/state-sales-tax/delete/{stateSalesTaxId}", "DELETE", typeof(StateSalesTaxController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/edit/{stateSalesTaxId}", "PUT", typeof(StateSalesTaxController), "Edit")]
        [InlineData("/api/core/state-sales-tax/edit/{stateSalesTaxId}", "PUT", typeof(StateSalesTaxController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/count-where", "POST", typeof(StateSalesTaxController), "CountWhere")]
        [InlineData("/api/core/state-sales-tax/count-where", "POST", typeof(StateSalesTaxController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/get-where/{pageNumber}", "POST", typeof(StateSalesTaxController), "GetWhere")]
        [InlineData("/api/core/state-sales-tax/get-where/{pageNumber}", "POST", typeof(StateSalesTaxController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/add-or-edit", "POST", typeof(StateSalesTaxController), "AddOrEdit")]
        [InlineData("/api/core/state-sales-tax/add-or-edit", "POST", typeof(StateSalesTaxController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/add/{stateSalesTax}", "POST", typeof(StateSalesTaxController), "Add")]
        [InlineData("/api/core/state-sales-tax/add/{stateSalesTax}", "POST", typeof(StateSalesTaxController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/bulk-import", "POST", typeof(StateSalesTaxController), "BulkImport")]
        [InlineData("/api/core/state-sales-tax/bulk-import", "POST", typeof(StateSalesTaxController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/meta", "GET", typeof(StateSalesTaxController), "GetEntityView")]
        [InlineData("/api/core/state-sales-tax/meta", "GET", typeof(StateSalesTaxController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/count", "GET", typeof(StateSalesTaxController), "Count")]
        [InlineData("/api/core/state-sales-tax/count", "GET", typeof(StateSalesTaxController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/all", "GET", typeof(StateSalesTaxController), "GetAll")]
        [InlineData("/api/core/state-sales-tax/all", "GET", typeof(StateSalesTaxController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/export", "GET", typeof(StateSalesTaxController), "Export")]
        [InlineData("/api/core/state-sales-tax/export", "GET", typeof(StateSalesTaxController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/1", "GET", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/core/state-sales-tax/1", "GET", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/get?stateSalesTaxIds=1", "GET", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/core/state-sales-tax/get?stateSalesTaxIds=1", "GET", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax", "GET", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/state-sales-tax", "GET", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/page/1", "GET", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/state-sales-tax/page/1", "GET", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/count-filtered/{filterName}", "GET", typeof(StateSalesTaxController), "CountFiltered")]
        [InlineData("/api/core/state-sales-tax/count-filtered/{filterName}", "GET", typeof(StateSalesTaxController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StateSalesTaxController), "GetFiltered")]
        [InlineData("/api/core/state-sales-tax/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StateSalesTaxController), "GetFiltered")]
        [InlineData("/api/core/state-sales-tax/first", "GET", typeof(StateSalesTaxController), "GetFirst")]
        [InlineData("/api/core/state-sales-tax/previous/1", "GET", typeof(StateSalesTaxController), "GetPrevious")]
        [InlineData("/api/core/state-sales-tax/next/1", "GET", typeof(StateSalesTaxController), "GetNext")]
        [InlineData("/api/core/state-sales-tax/last", "GET", typeof(StateSalesTaxController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/custom-fields", "GET", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/state-sales-tax/custom-fields", "GET", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/custom-fields/{resourceId}", "GET", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/state-sales-tax/custom-fields/{resourceId}", "GET", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/meta", "HEAD", typeof(StateSalesTaxController), "GetEntityView")]
        [InlineData("/api/core/state-sales-tax/meta", "HEAD", typeof(StateSalesTaxController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/count", "HEAD", typeof(StateSalesTaxController), "Count")]
        [InlineData("/api/core/state-sales-tax/count", "HEAD", typeof(StateSalesTaxController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/all", "HEAD", typeof(StateSalesTaxController), "GetAll")]
        [InlineData("/api/core/state-sales-tax/all", "HEAD", typeof(StateSalesTaxController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/export", "HEAD", typeof(StateSalesTaxController), "Export")]
        [InlineData("/api/core/state-sales-tax/export", "HEAD", typeof(StateSalesTaxController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/1", "HEAD", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/core/state-sales-tax/1", "HEAD", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/get?stateSalesTaxIds=1", "HEAD", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/core/state-sales-tax/get?stateSalesTaxIds=1", "HEAD", typeof(StateSalesTaxController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax", "HEAD", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/state-sales-tax", "HEAD", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/page/1", "HEAD", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/core/state-sales-tax/page/1", "HEAD", typeof(StateSalesTaxController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/count-filtered/{filterName}", "HEAD", typeof(StateSalesTaxController), "CountFiltered")]
        [InlineData("/api/core/state-sales-tax/count-filtered/{filterName}", "HEAD", typeof(StateSalesTaxController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StateSalesTaxController), "GetFiltered")]
        [InlineData("/api/core/state-sales-tax/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StateSalesTaxController), "GetFiltered")]
        [InlineData("/api/core/state-sales-tax/first", "HEAD", typeof(StateSalesTaxController), "GetFirst")]
        [InlineData("/api/core/state-sales-tax/previous/1", "HEAD", typeof(StateSalesTaxController), "GetPrevious")]
        [InlineData("/api/core/state-sales-tax/next/1", "HEAD", typeof(StateSalesTaxController), "GetNext")]
        [InlineData("/api/core/state-sales-tax/last", "HEAD", typeof(StateSalesTaxController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/custom-fields", "HEAD", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/state-sales-tax/custom-fields", "HEAD", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/state-sales-tax/custom-fields/{resourceId}", "HEAD", typeof(StateSalesTaxController), "GetCustomFields")]
        [InlineData("/api/core/state-sales-tax/custom-fields/{resourceId}", "HEAD", typeof(StateSalesTaxController), "GetCustomFields")]

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

        public StateSalesTaxRouteTests()
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