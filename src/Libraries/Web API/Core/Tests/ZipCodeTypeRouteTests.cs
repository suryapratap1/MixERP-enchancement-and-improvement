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
    public class ZipCodeTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/delete/{zipCodeTypeId}", "DELETE", typeof(ZipCodeTypeController), "Delete")]
        [InlineData("/api/core/zip-code-type/delete/{zipCodeTypeId}", "DELETE", typeof(ZipCodeTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/edit/{zipCodeTypeId}", "PUT", typeof(ZipCodeTypeController), "Edit")]
        [InlineData("/api/core/zip-code-type/edit/{zipCodeTypeId}", "PUT", typeof(ZipCodeTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/count-where", "POST", typeof(ZipCodeTypeController), "CountWhere")]
        [InlineData("/api/core/zip-code-type/count-where", "POST", typeof(ZipCodeTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/get-where/{pageNumber}", "POST", typeof(ZipCodeTypeController), "GetWhere")]
        [InlineData("/api/core/zip-code-type/get-where/{pageNumber}", "POST", typeof(ZipCodeTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/add-or-edit", "POST", typeof(ZipCodeTypeController), "AddOrEdit")]
        [InlineData("/api/core/zip-code-type/add-or-edit", "POST", typeof(ZipCodeTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/add/{zipCodeType}", "POST", typeof(ZipCodeTypeController), "Add")]
        [InlineData("/api/core/zip-code-type/add/{zipCodeType}", "POST", typeof(ZipCodeTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/bulk-import", "POST", typeof(ZipCodeTypeController), "BulkImport")]
        [InlineData("/api/core/zip-code-type/bulk-import", "POST", typeof(ZipCodeTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/meta", "GET", typeof(ZipCodeTypeController), "GetEntityView")]
        [InlineData("/api/core/zip-code-type/meta", "GET", typeof(ZipCodeTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/count", "GET", typeof(ZipCodeTypeController), "Count")]
        [InlineData("/api/core/zip-code-type/count", "GET", typeof(ZipCodeTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/all", "GET", typeof(ZipCodeTypeController), "GetAll")]
        [InlineData("/api/core/zip-code-type/all", "GET", typeof(ZipCodeTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/export", "GET", typeof(ZipCodeTypeController), "Export")]
        [InlineData("/api/core/zip-code-type/export", "GET", typeof(ZipCodeTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/1", "GET", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/core/zip-code-type/1", "GET", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/get?zipCodeTypeIds=1", "GET", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/core/zip-code-type/get?zipCodeTypeIds=1", "GET", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type", "GET", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code-type", "GET", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/page/1", "GET", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code-type/page/1", "GET", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/count-filtered/{filterName}", "GET", typeof(ZipCodeTypeController), "CountFiltered")]
        [InlineData("/api/core/zip-code-type/count-filtered/{filterName}", "GET", typeof(ZipCodeTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ZipCodeTypeController), "GetFiltered")]
        [InlineData("/api/core/zip-code-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ZipCodeTypeController), "GetFiltered")]
        [InlineData("/api/core/zip-code-type/first", "GET", typeof(ZipCodeTypeController), "GetFirst")]
        [InlineData("/api/core/zip-code-type/previous/1", "GET", typeof(ZipCodeTypeController), "GetPrevious")]
        [InlineData("/api/core/zip-code-type/next/1", "GET", typeof(ZipCodeTypeController), "GetNext")]
        [InlineData("/api/core/zip-code-type/last", "GET", typeof(ZipCodeTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/custom-fields", "GET", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code-type/custom-fields", "GET", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/custom-fields/{resourceId}", "GET", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code-type/custom-fields/{resourceId}", "GET", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/meta", "HEAD", typeof(ZipCodeTypeController), "GetEntityView")]
        [InlineData("/api/core/zip-code-type/meta", "HEAD", typeof(ZipCodeTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/count", "HEAD", typeof(ZipCodeTypeController), "Count")]
        [InlineData("/api/core/zip-code-type/count", "HEAD", typeof(ZipCodeTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/all", "HEAD", typeof(ZipCodeTypeController), "GetAll")]
        [InlineData("/api/core/zip-code-type/all", "HEAD", typeof(ZipCodeTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/export", "HEAD", typeof(ZipCodeTypeController), "Export")]
        [InlineData("/api/core/zip-code-type/export", "HEAD", typeof(ZipCodeTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/1", "HEAD", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/core/zip-code-type/1", "HEAD", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/get?zipCodeTypeIds=1", "HEAD", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/core/zip-code-type/get?zipCodeTypeIds=1", "HEAD", typeof(ZipCodeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type", "HEAD", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code-type", "HEAD", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/page/1", "HEAD", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code-type/page/1", "HEAD", typeof(ZipCodeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/count-filtered/{filterName}", "HEAD", typeof(ZipCodeTypeController), "CountFiltered")]
        [InlineData("/api/core/zip-code-type/count-filtered/{filterName}", "HEAD", typeof(ZipCodeTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ZipCodeTypeController), "GetFiltered")]
        [InlineData("/api/core/zip-code-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ZipCodeTypeController), "GetFiltered")]
        [InlineData("/api/core/zip-code-type/first", "HEAD", typeof(ZipCodeTypeController), "GetFirst")]
        [InlineData("/api/core/zip-code-type/previous/1", "HEAD", typeof(ZipCodeTypeController), "GetPrevious")]
        [InlineData("/api/core/zip-code-type/next/1", "HEAD", typeof(ZipCodeTypeController), "GetNext")]
        [InlineData("/api/core/zip-code-type/last", "HEAD", typeof(ZipCodeTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/custom-fields", "HEAD", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code-type/custom-fields", "HEAD", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code-type/custom-fields/{resourceId}", "HEAD", typeof(ZipCodeTypeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code-type/custom-fields/{resourceId}", "HEAD", typeof(ZipCodeTypeController), "GetCustomFields")]

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

        public ZipCodeTypeRouteTests()
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