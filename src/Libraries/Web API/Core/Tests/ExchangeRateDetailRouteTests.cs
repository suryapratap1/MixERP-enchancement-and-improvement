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
    public class ExchangeRateDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/delete/{exchangeRateDetailId}", "DELETE", typeof(ExchangeRateDetailController), "Delete")]
        [InlineData("/api/core/exchange-rate-detail/delete/{exchangeRateDetailId}", "DELETE", typeof(ExchangeRateDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/edit/{exchangeRateDetailId}", "PUT", typeof(ExchangeRateDetailController), "Edit")]
        [InlineData("/api/core/exchange-rate-detail/edit/{exchangeRateDetailId}", "PUT", typeof(ExchangeRateDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/count-where", "POST", typeof(ExchangeRateDetailController), "CountWhere")]
        [InlineData("/api/core/exchange-rate-detail/count-where", "POST", typeof(ExchangeRateDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/get-where/{pageNumber}", "POST", typeof(ExchangeRateDetailController), "GetWhere")]
        [InlineData("/api/core/exchange-rate-detail/get-where/{pageNumber}", "POST", typeof(ExchangeRateDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/add-or-edit", "POST", typeof(ExchangeRateDetailController), "AddOrEdit")]
        [InlineData("/api/core/exchange-rate-detail/add-or-edit", "POST", typeof(ExchangeRateDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/add/{exchangeRateDetail}", "POST", typeof(ExchangeRateDetailController), "Add")]
        [InlineData("/api/core/exchange-rate-detail/add/{exchangeRateDetail}", "POST", typeof(ExchangeRateDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/bulk-import", "POST", typeof(ExchangeRateDetailController), "BulkImport")]
        [InlineData("/api/core/exchange-rate-detail/bulk-import", "POST", typeof(ExchangeRateDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/meta", "GET", typeof(ExchangeRateDetailController), "GetEntityView")]
        [InlineData("/api/core/exchange-rate-detail/meta", "GET", typeof(ExchangeRateDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/count", "GET", typeof(ExchangeRateDetailController), "Count")]
        [InlineData("/api/core/exchange-rate-detail/count", "GET", typeof(ExchangeRateDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/all", "GET", typeof(ExchangeRateDetailController), "GetAll")]
        [InlineData("/api/core/exchange-rate-detail/all", "GET", typeof(ExchangeRateDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/export", "GET", typeof(ExchangeRateDetailController), "Export")]
        [InlineData("/api/core/exchange-rate-detail/export", "GET", typeof(ExchangeRateDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/1", "GET", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/core/exchange-rate-detail/1", "GET", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/get?exchangeRateDetailIds=1", "GET", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/core/exchange-rate-detail/get?exchangeRateDetailIds=1", "GET", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail", "GET", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/exchange-rate-detail", "GET", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/page/1", "GET", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/exchange-rate-detail/page/1", "GET", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/count-filtered/{filterName}", "GET", typeof(ExchangeRateDetailController), "CountFiltered")]
        [InlineData("/api/core/exchange-rate-detail/count-filtered/{filterName}", "GET", typeof(ExchangeRateDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ExchangeRateDetailController), "GetFiltered")]
        [InlineData("/api/core/exchange-rate-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ExchangeRateDetailController), "GetFiltered")]
        [InlineData("/api/core/exchange-rate-detail/first", "GET", typeof(ExchangeRateDetailController), "GetFirst")]
        [InlineData("/api/core/exchange-rate-detail/previous/1", "GET", typeof(ExchangeRateDetailController), "GetPrevious")]
        [InlineData("/api/core/exchange-rate-detail/next/1", "GET", typeof(ExchangeRateDetailController), "GetNext")]
        [InlineData("/api/core/exchange-rate-detail/last", "GET", typeof(ExchangeRateDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/custom-fields", "GET", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/core/exchange-rate-detail/custom-fields", "GET", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/custom-fields/{resourceId}", "GET", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/core/exchange-rate-detail/custom-fields/{resourceId}", "GET", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/meta", "HEAD", typeof(ExchangeRateDetailController), "GetEntityView")]
        [InlineData("/api/core/exchange-rate-detail/meta", "HEAD", typeof(ExchangeRateDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/count", "HEAD", typeof(ExchangeRateDetailController), "Count")]
        [InlineData("/api/core/exchange-rate-detail/count", "HEAD", typeof(ExchangeRateDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/all", "HEAD", typeof(ExchangeRateDetailController), "GetAll")]
        [InlineData("/api/core/exchange-rate-detail/all", "HEAD", typeof(ExchangeRateDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/export", "HEAD", typeof(ExchangeRateDetailController), "Export")]
        [InlineData("/api/core/exchange-rate-detail/export", "HEAD", typeof(ExchangeRateDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/1", "HEAD", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/core/exchange-rate-detail/1", "HEAD", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/get?exchangeRateDetailIds=1", "HEAD", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/core/exchange-rate-detail/get?exchangeRateDetailIds=1", "HEAD", typeof(ExchangeRateDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail", "HEAD", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/exchange-rate-detail", "HEAD", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/page/1", "HEAD", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/exchange-rate-detail/page/1", "HEAD", typeof(ExchangeRateDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/count-filtered/{filterName}", "HEAD", typeof(ExchangeRateDetailController), "CountFiltered")]
        [InlineData("/api/core/exchange-rate-detail/count-filtered/{filterName}", "HEAD", typeof(ExchangeRateDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ExchangeRateDetailController), "GetFiltered")]
        [InlineData("/api/core/exchange-rate-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ExchangeRateDetailController), "GetFiltered")]
        [InlineData("/api/core/exchange-rate-detail/first", "HEAD", typeof(ExchangeRateDetailController), "GetFirst")]
        [InlineData("/api/core/exchange-rate-detail/previous/1", "HEAD", typeof(ExchangeRateDetailController), "GetPrevious")]
        [InlineData("/api/core/exchange-rate-detail/next/1", "HEAD", typeof(ExchangeRateDetailController), "GetNext")]
        [InlineData("/api/core/exchange-rate-detail/last", "HEAD", typeof(ExchangeRateDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/custom-fields", "HEAD", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/core/exchange-rate-detail/custom-fields", "HEAD", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/exchange-rate-detail/custom-fields/{resourceId}", "HEAD", typeof(ExchangeRateDetailController), "GetCustomFields")]
        [InlineData("/api/core/exchange-rate-detail/custom-fields/{resourceId}", "HEAD", typeof(ExchangeRateDetailController), "GetCustomFields")]

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

        public ExchangeRateDetailRouteTests()
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