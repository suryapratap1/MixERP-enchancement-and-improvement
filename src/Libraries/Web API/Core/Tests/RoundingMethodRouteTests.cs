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
    public class RoundingMethodRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/delete/{roundingMethodCode}", "DELETE", typeof(RoundingMethodController), "Delete")]
        [InlineData("/api/core/rounding-method/delete/{roundingMethodCode}", "DELETE", typeof(RoundingMethodController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/edit/{roundingMethodCode}", "PUT", typeof(RoundingMethodController), "Edit")]
        [InlineData("/api/core/rounding-method/edit/{roundingMethodCode}", "PUT", typeof(RoundingMethodController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/count-where", "POST", typeof(RoundingMethodController), "CountWhere")]
        [InlineData("/api/core/rounding-method/count-where", "POST", typeof(RoundingMethodController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/get-where/{pageNumber}", "POST", typeof(RoundingMethodController), "GetWhere")]
        [InlineData("/api/core/rounding-method/get-where/{pageNumber}", "POST", typeof(RoundingMethodController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/add-or-edit", "POST", typeof(RoundingMethodController), "AddOrEdit")]
        [InlineData("/api/core/rounding-method/add-or-edit", "POST", typeof(RoundingMethodController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/add/{roundingMethod}", "POST", typeof(RoundingMethodController), "Add")]
        [InlineData("/api/core/rounding-method/add/{roundingMethod}", "POST", typeof(RoundingMethodController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/bulk-import", "POST", typeof(RoundingMethodController), "BulkImport")]
        [InlineData("/api/core/rounding-method/bulk-import", "POST", typeof(RoundingMethodController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/meta", "GET", typeof(RoundingMethodController), "GetEntityView")]
        [InlineData("/api/core/rounding-method/meta", "GET", typeof(RoundingMethodController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/count", "GET", typeof(RoundingMethodController), "Count")]
        [InlineData("/api/core/rounding-method/count", "GET", typeof(RoundingMethodController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/all", "GET", typeof(RoundingMethodController), "GetAll")]
        [InlineData("/api/core/rounding-method/all", "GET", typeof(RoundingMethodController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/export", "GET", typeof(RoundingMethodController), "Export")]
        [InlineData("/api/core/rounding-method/export", "GET", typeof(RoundingMethodController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/1", "GET", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/core/rounding-method/1", "GET", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/get?roundingMethodCodes=1", "GET", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/core/rounding-method/get?roundingMethodCodes=1", "GET", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method", "GET", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/core/rounding-method", "GET", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/page/1", "GET", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/core/rounding-method/page/1", "GET", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/count-filtered/{filterName}", "GET", typeof(RoundingMethodController), "CountFiltered")]
        [InlineData("/api/core/rounding-method/count-filtered/{filterName}", "GET", typeof(RoundingMethodController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RoundingMethodController), "GetFiltered")]
        [InlineData("/api/core/rounding-method/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RoundingMethodController), "GetFiltered")]
        [InlineData("/api/core/rounding-method/first", "GET", typeof(RoundingMethodController), "GetFirst")]
        [InlineData("/api/core/rounding-method/previous/1", "GET", typeof(RoundingMethodController), "GetPrevious")]
        [InlineData("/api/core/rounding-method/next/1", "GET", typeof(RoundingMethodController), "GetNext")]
        [InlineData("/api/core/rounding-method/last", "GET", typeof(RoundingMethodController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/rounding-method/custom-fields", "GET", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/core/rounding-method/custom-fields", "GET", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/custom-fields/{resourceId}", "GET", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/core/rounding-method/custom-fields/{resourceId}", "GET", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/meta", "HEAD", typeof(RoundingMethodController), "GetEntityView")]
        [InlineData("/api/core/rounding-method/meta", "HEAD", typeof(RoundingMethodController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/count", "HEAD", typeof(RoundingMethodController), "Count")]
        [InlineData("/api/core/rounding-method/count", "HEAD", typeof(RoundingMethodController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/all", "HEAD", typeof(RoundingMethodController), "GetAll")]
        [InlineData("/api/core/rounding-method/all", "HEAD", typeof(RoundingMethodController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/export", "HEAD", typeof(RoundingMethodController), "Export")]
        [InlineData("/api/core/rounding-method/export", "HEAD", typeof(RoundingMethodController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/1", "HEAD", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/core/rounding-method/1", "HEAD", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/get?roundingMethodCodes=1", "HEAD", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/core/rounding-method/get?roundingMethodCodes=1", "HEAD", typeof(RoundingMethodController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method", "HEAD", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/core/rounding-method", "HEAD", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/page/1", "HEAD", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/core/rounding-method/page/1", "HEAD", typeof(RoundingMethodController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/count-filtered/{filterName}", "HEAD", typeof(RoundingMethodController), "CountFiltered")]
        [InlineData("/api/core/rounding-method/count-filtered/{filterName}", "HEAD", typeof(RoundingMethodController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RoundingMethodController), "GetFiltered")]
        [InlineData("/api/core/rounding-method/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RoundingMethodController), "GetFiltered")]
        [InlineData("/api/core/rounding-method/first", "HEAD", typeof(RoundingMethodController), "GetFirst")]
        [InlineData("/api/core/rounding-method/previous/1", "HEAD", typeof(RoundingMethodController), "GetPrevious")]
        [InlineData("/api/core/rounding-method/next/1", "HEAD", typeof(RoundingMethodController), "GetNext")]
        [InlineData("/api/core/rounding-method/last", "HEAD", typeof(RoundingMethodController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/rounding-method/custom-fields", "HEAD", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/core/rounding-method/custom-fields", "HEAD", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/rounding-method/custom-fields/{resourceId}", "HEAD", typeof(RoundingMethodController), "GetCustomFields")]
        [InlineData("/api/core/rounding-method/custom-fields/{resourceId}", "HEAD", typeof(RoundingMethodController), "GetCustomFields")]

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

        public RoundingMethodRouteTests()
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