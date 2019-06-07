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
    public class CountyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/county/delete/{countyId}", "DELETE", typeof(CountyController), "Delete")]
        [InlineData("/api/core/county/delete/{countyId}", "DELETE", typeof(CountyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/county/edit/{countyId}", "PUT", typeof(CountyController), "Edit")]
        [InlineData("/api/core/county/edit/{countyId}", "PUT", typeof(CountyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/county/count-where", "POST", typeof(CountyController), "CountWhere")]
        [InlineData("/api/core/county/count-where", "POST", typeof(CountyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/county/get-where/{pageNumber}", "POST", typeof(CountyController), "GetWhere")]
        [InlineData("/api/core/county/get-where/{pageNumber}", "POST", typeof(CountyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/county/add-or-edit", "POST", typeof(CountyController), "AddOrEdit")]
        [InlineData("/api/core/county/add-or-edit", "POST", typeof(CountyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/county/add/{county}", "POST", typeof(CountyController), "Add")]
        [InlineData("/api/core/county/add/{county}", "POST", typeof(CountyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/county/bulk-import", "POST", typeof(CountyController), "BulkImport")]
        [InlineData("/api/core/county/bulk-import", "POST", typeof(CountyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/county/meta", "GET", typeof(CountyController), "GetEntityView")]
        [InlineData("/api/core/county/meta", "GET", typeof(CountyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/county/count", "GET", typeof(CountyController), "Count")]
        [InlineData("/api/core/county/count", "GET", typeof(CountyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/county/all", "GET", typeof(CountyController), "GetAll")]
        [InlineData("/api/core/county/all", "GET", typeof(CountyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/county/export", "GET", typeof(CountyController), "Export")]
        [InlineData("/api/core/county/export", "GET", typeof(CountyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/county/1", "GET", typeof(CountyController), "Get")]
        [InlineData("/api/core/county/1", "GET", typeof(CountyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county/get?countyIds=1", "GET", typeof(CountyController), "Get")]
        [InlineData("/api/core/county/get?countyIds=1", "GET", typeof(CountyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county", "GET", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/core/county", "GET", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county/page/1", "GET", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/core/county/page/1", "GET", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county/count-filtered/{filterName}", "GET", typeof(CountyController), "CountFiltered")]
        [InlineData("/api/core/county/count-filtered/{filterName}", "GET", typeof(CountyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/county/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CountyController), "GetFiltered")]
        [InlineData("/api/core/county/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CountyController), "GetFiltered")]
        [InlineData("/api/core/county/first", "GET", typeof(CountyController), "GetFirst")]
        [InlineData("/api/core/county/previous/1", "GET", typeof(CountyController), "GetPrevious")]
        [InlineData("/api/core/county/next/1", "GET", typeof(CountyController), "GetNext")]
        [InlineData("/api/core/county/last", "GET", typeof(CountyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/county/custom-fields", "GET", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/core/county/custom-fields", "GET", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/county/custom-fields/{resourceId}", "GET", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/core/county/custom-fields/{resourceId}", "GET", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/county/meta", "HEAD", typeof(CountyController), "GetEntityView")]
        [InlineData("/api/core/county/meta", "HEAD", typeof(CountyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/county/count", "HEAD", typeof(CountyController), "Count")]
        [InlineData("/api/core/county/count", "HEAD", typeof(CountyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/county/all", "HEAD", typeof(CountyController), "GetAll")]
        [InlineData("/api/core/county/all", "HEAD", typeof(CountyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/county/export", "HEAD", typeof(CountyController), "Export")]
        [InlineData("/api/core/county/export", "HEAD", typeof(CountyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/county/1", "HEAD", typeof(CountyController), "Get")]
        [InlineData("/api/core/county/1", "HEAD", typeof(CountyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county/get?countyIds=1", "HEAD", typeof(CountyController), "Get")]
        [InlineData("/api/core/county/get?countyIds=1", "HEAD", typeof(CountyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/county", "HEAD", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/core/county", "HEAD", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county/page/1", "HEAD", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/core/county/page/1", "HEAD", typeof(CountyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/county/count-filtered/{filterName}", "HEAD", typeof(CountyController), "CountFiltered")]
        [InlineData("/api/core/county/count-filtered/{filterName}", "HEAD", typeof(CountyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/county/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CountyController), "GetFiltered")]
        [InlineData("/api/core/county/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CountyController), "GetFiltered")]
        [InlineData("/api/core/county/first", "HEAD", typeof(CountyController), "GetFirst")]
        [InlineData("/api/core/county/previous/1", "HEAD", typeof(CountyController), "GetPrevious")]
        [InlineData("/api/core/county/next/1", "HEAD", typeof(CountyController), "GetNext")]
        [InlineData("/api/core/county/last", "HEAD", typeof(CountyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/county/custom-fields", "HEAD", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/core/county/custom-fields", "HEAD", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/county/custom-fields/{resourceId}", "HEAD", typeof(CountyController), "GetCustomFields")]
        [InlineData("/api/core/county/custom-fields/{resourceId}", "HEAD", typeof(CountyController), "GetCustomFields")]

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

        public CountyRouteTests()
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