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
    public class ZipCodeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/delete/{zipCodeId}", "DELETE", typeof(ZipCodeController), "Delete")]
        [InlineData("/api/core/zip-code/delete/{zipCodeId}", "DELETE", typeof(ZipCodeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/edit/{zipCodeId}", "PUT", typeof(ZipCodeController), "Edit")]
        [InlineData("/api/core/zip-code/edit/{zipCodeId}", "PUT", typeof(ZipCodeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/count-where", "POST", typeof(ZipCodeController), "CountWhere")]
        [InlineData("/api/core/zip-code/count-where", "POST", typeof(ZipCodeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/get-where/{pageNumber}", "POST", typeof(ZipCodeController), "GetWhere")]
        [InlineData("/api/core/zip-code/get-where/{pageNumber}", "POST", typeof(ZipCodeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/add-or-edit", "POST", typeof(ZipCodeController), "AddOrEdit")]
        [InlineData("/api/core/zip-code/add-or-edit", "POST", typeof(ZipCodeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/add/{zipCode}", "POST", typeof(ZipCodeController), "Add")]
        [InlineData("/api/core/zip-code/add/{zipCode}", "POST", typeof(ZipCodeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/bulk-import", "POST", typeof(ZipCodeController), "BulkImport")]
        [InlineData("/api/core/zip-code/bulk-import", "POST", typeof(ZipCodeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/meta", "GET", typeof(ZipCodeController), "GetEntityView")]
        [InlineData("/api/core/zip-code/meta", "GET", typeof(ZipCodeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/count", "GET", typeof(ZipCodeController), "Count")]
        [InlineData("/api/core/zip-code/count", "GET", typeof(ZipCodeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/all", "GET", typeof(ZipCodeController), "GetAll")]
        [InlineData("/api/core/zip-code/all", "GET", typeof(ZipCodeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/export", "GET", typeof(ZipCodeController), "Export")]
        [InlineData("/api/core/zip-code/export", "GET", typeof(ZipCodeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/1", "GET", typeof(ZipCodeController), "Get")]
        [InlineData("/api/core/zip-code/1", "GET", typeof(ZipCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/get?zipCodeIds=1", "GET", typeof(ZipCodeController), "Get")]
        [InlineData("/api/core/zip-code/get?zipCodeIds=1", "GET", typeof(ZipCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code", "GET", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code", "GET", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/page/1", "GET", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code/page/1", "GET", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/count-filtered/{filterName}", "GET", typeof(ZipCodeController), "CountFiltered")]
        [InlineData("/api/core/zip-code/count-filtered/{filterName}", "GET", typeof(ZipCodeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ZipCodeController), "GetFiltered")]
        [InlineData("/api/core/zip-code/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ZipCodeController), "GetFiltered")]
        [InlineData("/api/core/zip-code/first", "GET", typeof(ZipCodeController), "GetFirst")]
        [InlineData("/api/core/zip-code/previous/1", "GET", typeof(ZipCodeController), "GetPrevious")]
        [InlineData("/api/core/zip-code/next/1", "GET", typeof(ZipCodeController), "GetNext")]
        [InlineData("/api/core/zip-code/last", "GET", typeof(ZipCodeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/zip-code/custom-fields", "GET", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code/custom-fields", "GET", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/custom-fields/{resourceId}", "GET", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code/custom-fields/{resourceId}", "GET", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/meta", "HEAD", typeof(ZipCodeController), "GetEntityView")]
        [InlineData("/api/core/zip-code/meta", "HEAD", typeof(ZipCodeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/count", "HEAD", typeof(ZipCodeController), "Count")]
        [InlineData("/api/core/zip-code/count", "HEAD", typeof(ZipCodeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/all", "HEAD", typeof(ZipCodeController), "GetAll")]
        [InlineData("/api/core/zip-code/all", "HEAD", typeof(ZipCodeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/export", "HEAD", typeof(ZipCodeController), "Export")]
        [InlineData("/api/core/zip-code/export", "HEAD", typeof(ZipCodeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/1", "HEAD", typeof(ZipCodeController), "Get")]
        [InlineData("/api/core/zip-code/1", "HEAD", typeof(ZipCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/get?zipCodeIds=1", "HEAD", typeof(ZipCodeController), "Get")]
        [InlineData("/api/core/zip-code/get?zipCodeIds=1", "HEAD", typeof(ZipCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code", "HEAD", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code", "HEAD", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/page/1", "HEAD", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/core/zip-code/page/1", "HEAD", typeof(ZipCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/count-filtered/{filterName}", "HEAD", typeof(ZipCodeController), "CountFiltered")]
        [InlineData("/api/core/zip-code/count-filtered/{filterName}", "HEAD", typeof(ZipCodeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ZipCodeController), "GetFiltered")]
        [InlineData("/api/core/zip-code/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ZipCodeController), "GetFiltered")]
        [InlineData("/api/core/zip-code/first", "HEAD", typeof(ZipCodeController), "GetFirst")]
        [InlineData("/api/core/zip-code/previous/1", "HEAD", typeof(ZipCodeController), "GetPrevious")]
        [InlineData("/api/core/zip-code/next/1", "HEAD", typeof(ZipCodeController), "GetNext")]
        [InlineData("/api/core/zip-code/last", "HEAD", typeof(ZipCodeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/zip-code/custom-fields", "HEAD", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code/custom-fields", "HEAD", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/zip-code/custom-fields/{resourceId}", "HEAD", typeof(ZipCodeController), "GetCustomFields")]
        [InlineData("/api/core/zip-code/custom-fields/{resourceId}", "HEAD", typeof(ZipCodeController), "GetCustomFields")]

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

        public ZipCodeRouteTests()
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