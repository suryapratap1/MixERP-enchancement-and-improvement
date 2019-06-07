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
    public class CurrencyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/currency/delete/{currencyCode}", "DELETE", typeof(CurrencyController), "Delete")]
        [InlineData("/api/core/currency/delete/{currencyCode}", "DELETE", typeof(CurrencyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/currency/edit/{currencyCode}", "PUT", typeof(CurrencyController), "Edit")]
        [InlineData("/api/core/currency/edit/{currencyCode}", "PUT", typeof(CurrencyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/currency/count-where", "POST", typeof(CurrencyController), "CountWhere")]
        [InlineData("/api/core/currency/count-where", "POST", typeof(CurrencyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/currency/get-where/{pageNumber}", "POST", typeof(CurrencyController), "GetWhere")]
        [InlineData("/api/core/currency/get-where/{pageNumber}", "POST", typeof(CurrencyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/currency/add-or-edit", "POST", typeof(CurrencyController), "AddOrEdit")]
        [InlineData("/api/core/currency/add-or-edit", "POST", typeof(CurrencyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/currency/add/{currency}", "POST", typeof(CurrencyController), "Add")]
        [InlineData("/api/core/currency/add/{currency}", "POST", typeof(CurrencyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/currency/bulk-import", "POST", typeof(CurrencyController), "BulkImport")]
        [InlineData("/api/core/currency/bulk-import", "POST", typeof(CurrencyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/currency/meta", "GET", typeof(CurrencyController), "GetEntityView")]
        [InlineData("/api/core/currency/meta", "GET", typeof(CurrencyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/currency/count", "GET", typeof(CurrencyController), "Count")]
        [InlineData("/api/core/currency/count", "GET", typeof(CurrencyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/currency/all", "GET", typeof(CurrencyController), "GetAll")]
        [InlineData("/api/core/currency/all", "GET", typeof(CurrencyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/currency/export", "GET", typeof(CurrencyController), "Export")]
        [InlineData("/api/core/currency/export", "GET", typeof(CurrencyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/currency/1", "GET", typeof(CurrencyController), "Get")]
        [InlineData("/api/core/currency/1", "GET", typeof(CurrencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/currency/get?currencyCodes=1", "GET", typeof(CurrencyController), "Get")]
        [InlineData("/api/core/currency/get?currencyCodes=1", "GET", typeof(CurrencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/currency", "GET", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/core/currency", "GET", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/currency/page/1", "GET", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/core/currency/page/1", "GET", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/currency/count-filtered/{filterName}", "GET", typeof(CurrencyController), "CountFiltered")]
        [InlineData("/api/core/currency/count-filtered/{filterName}", "GET", typeof(CurrencyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/currency/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CurrencyController), "GetFiltered")]
        [InlineData("/api/core/currency/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CurrencyController), "GetFiltered")]
        [InlineData("/api/core/currency/first", "GET", typeof(CurrencyController), "GetFirst")]
        [InlineData("/api/core/currency/previous/1", "GET", typeof(CurrencyController), "GetPrevious")]
        [InlineData("/api/core/currency/next/1", "GET", typeof(CurrencyController), "GetNext")]
        [InlineData("/api/core/currency/last", "GET", typeof(CurrencyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/currency/custom-fields", "GET", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/core/currency/custom-fields", "GET", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/currency/custom-fields/{resourceId}", "GET", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/core/currency/custom-fields/{resourceId}", "GET", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/currency/meta", "HEAD", typeof(CurrencyController), "GetEntityView")]
        [InlineData("/api/core/currency/meta", "HEAD", typeof(CurrencyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/currency/count", "HEAD", typeof(CurrencyController), "Count")]
        [InlineData("/api/core/currency/count", "HEAD", typeof(CurrencyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/currency/all", "HEAD", typeof(CurrencyController), "GetAll")]
        [InlineData("/api/core/currency/all", "HEAD", typeof(CurrencyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/currency/export", "HEAD", typeof(CurrencyController), "Export")]
        [InlineData("/api/core/currency/export", "HEAD", typeof(CurrencyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/currency/1", "HEAD", typeof(CurrencyController), "Get")]
        [InlineData("/api/core/currency/1", "HEAD", typeof(CurrencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/currency/get?currencyCodes=1", "HEAD", typeof(CurrencyController), "Get")]
        [InlineData("/api/core/currency/get?currencyCodes=1", "HEAD", typeof(CurrencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/currency", "HEAD", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/core/currency", "HEAD", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/currency/page/1", "HEAD", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/core/currency/page/1", "HEAD", typeof(CurrencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/currency/count-filtered/{filterName}", "HEAD", typeof(CurrencyController), "CountFiltered")]
        [InlineData("/api/core/currency/count-filtered/{filterName}", "HEAD", typeof(CurrencyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/currency/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CurrencyController), "GetFiltered")]
        [InlineData("/api/core/currency/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CurrencyController), "GetFiltered")]
        [InlineData("/api/core/currency/first", "HEAD", typeof(CurrencyController), "GetFirst")]
        [InlineData("/api/core/currency/previous/1", "HEAD", typeof(CurrencyController), "GetPrevious")]
        [InlineData("/api/core/currency/next/1", "HEAD", typeof(CurrencyController), "GetNext")]
        [InlineData("/api/core/currency/last", "HEAD", typeof(CurrencyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/currency/custom-fields", "HEAD", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/core/currency/custom-fields", "HEAD", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/currency/custom-fields/{resourceId}", "HEAD", typeof(CurrencyController), "GetCustomFields")]
        [InlineData("/api/core/currency/custom-fields/{resourceId}", "HEAD", typeof(CurrencyController), "GetCustomFields")]

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

        public CurrencyRouteTests()
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