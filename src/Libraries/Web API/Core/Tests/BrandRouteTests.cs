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
    public class BrandRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/brand/delete/{brandId}", "DELETE", typeof(BrandController), "Delete")]
        [InlineData("/api/core/brand/delete/{brandId}", "DELETE", typeof(BrandController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/brand/edit/{brandId}", "PUT", typeof(BrandController), "Edit")]
        [InlineData("/api/core/brand/edit/{brandId}", "PUT", typeof(BrandController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/brand/count-where", "POST", typeof(BrandController), "CountWhere")]
        [InlineData("/api/core/brand/count-where", "POST", typeof(BrandController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/brand/get-where/{pageNumber}", "POST", typeof(BrandController), "GetWhere")]
        [InlineData("/api/core/brand/get-where/{pageNumber}", "POST", typeof(BrandController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/brand/add-or-edit", "POST", typeof(BrandController), "AddOrEdit")]
        [InlineData("/api/core/brand/add-or-edit", "POST", typeof(BrandController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/brand/add/{brand}", "POST", typeof(BrandController), "Add")]
        [InlineData("/api/core/brand/add/{brand}", "POST", typeof(BrandController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/brand/bulk-import", "POST", typeof(BrandController), "BulkImport")]
        [InlineData("/api/core/brand/bulk-import", "POST", typeof(BrandController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/brand/meta", "GET", typeof(BrandController), "GetEntityView")]
        [InlineData("/api/core/brand/meta", "GET", typeof(BrandController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/brand/count", "GET", typeof(BrandController), "Count")]
        [InlineData("/api/core/brand/count", "GET", typeof(BrandController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/brand/all", "GET", typeof(BrandController), "GetAll")]
        [InlineData("/api/core/brand/all", "GET", typeof(BrandController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/brand/export", "GET", typeof(BrandController), "Export")]
        [InlineData("/api/core/brand/export", "GET", typeof(BrandController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/brand/1", "GET", typeof(BrandController), "Get")]
        [InlineData("/api/core/brand/1", "GET", typeof(BrandController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/brand/get?brandIds=1", "GET", typeof(BrandController), "Get")]
        [InlineData("/api/core/brand/get?brandIds=1", "GET", typeof(BrandController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/brand", "GET", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/core/brand", "GET", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/brand/page/1", "GET", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/core/brand/page/1", "GET", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/brand/count-filtered/{filterName}", "GET", typeof(BrandController), "CountFiltered")]
        [InlineData("/api/core/brand/count-filtered/{filterName}", "GET", typeof(BrandController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/brand/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BrandController), "GetFiltered")]
        [InlineData("/api/core/brand/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BrandController), "GetFiltered")]
        [InlineData("/api/core/brand/first", "GET", typeof(BrandController), "GetFirst")]
        [InlineData("/api/core/brand/previous/1", "GET", typeof(BrandController), "GetPrevious")]
        [InlineData("/api/core/brand/next/1", "GET", typeof(BrandController), "GetNext")]
        [InlineData("/api/core/brand/last", "GET", typeof(BrandController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/brand/custom-fields", "GET", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/core/brand/custom-fields", "GET", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/brand/custom-fields/{resourceId}", "GET", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/core/brand/custom-fields/{resourceId}", "GET", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/brand/meta", "HEAD", typeof(BrandController), "GetEntityView")]
        [InlineData("/api/core/brand/meta", "HEAD", typeof(BrandController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/brand/count", "HEAD", typeof(BrandController), "Count")]
        [InlineData("/api/core/brand/count", "HEAD", typeof(BrandController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/brand/all", "HEAD", typeof(BrandController), "GetAll")]
        [InlineData("/api/core/brand/all", "HEAD", typeof(BrandController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/brand/export", "HEAD", typeof(BrandController), "Export")]
        [InlineData("/api/core/brand/export", "HEAD", typeof(BrandController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/brand/1", "HEAD", typeof(BrandController), "Get")]
        [InlineData("/api/core/brand/1", "HEAD", typeof(BrandController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/brand/get?brandIds=1", "HEAD", typeof(BrandController), "Get")]
        [InlineData("/api/core/brand/get?brandIds=1", "HEAD", typeof(BrandController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/brand", "HEAD", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/core/brand", "HEAD", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/brand/page/1", "HEAD", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/core/brand/page/1", "HEAD", typeof(BrandController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/brand/count-filtered/{filterName}", "HEAD", typeof(BrandController), "CountFiltered")]
        [InlineData("/api/core/brand/count-filtered/{filterName}", "HEAD", typeof(BrandController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/brand/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BrandController), "GetFiltered")]
        [InlineData("/api/core/brand/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BrandController), "GetFiltered")]
        [InlineData("/api/core/brand/first", "HEAD", typeof(BrandController), "GetFirst")]
        [InlineData("/api/core/brand/previous/1", "HEAD", typeof(BrandController), "GetPrevious")]
        [InlineData("/api/core/brand/next/1", "HEAD", typeof(BrandController), "GetNext")]
        [InlineData("/api/core/brand/last", "HEAD", typeof(BrandController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/brand/custom-fields", "HEAD", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/core/brand/custom-fields", "HEAD", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/brand/custom-fields/{resourceId}", "HEAD", typeof(BrandController), "GetCustomFields")]
        [InlineData("/api/core/brand/custom-fields/{resourceId}", "HEAD", typeof(BrandController), "GetCustomFields")]

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

        public BrandRouteTests()
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