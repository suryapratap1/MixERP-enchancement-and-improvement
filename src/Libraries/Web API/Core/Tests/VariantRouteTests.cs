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
    public class VariantRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/variant/delete/{variantId}", "DELETE", typeof(VariantController), "Delete")]
        [InlineData("/api/core/variant/delete/{variantId}", "DELETE", typeof(VariantController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/variant/edit/{variantId}", "PUT", typeof(VariantController), "Edit")]
        [InlineData("/api/core/variant/edit/{variantId}", "PUT", typeof(VariantController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/variant/count-where", "POST", typeof(VariantController), "CountWhere")]
        [InlineData("/api/core/variant/count-where", "POST", typeof(VariantController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/variant/get-where/{pageNumber}", "POST", typeof(VariantController), "GetWhere")]
        [InlineData("/api/core/variant/get-where/{pageNumber}", "POST", typeof(VariantController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/variant/add-or-edit", "POST", typeof(VariantController), "AddOrEdit")]
        [InlineData("/api/core/variant/add-or-edit", "POST", typeof(VariantController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/variant/add/{variant}", "POST", typeof(VariantController), "Add")]
        [InlineData("/api/core/variant/add/{variant}", "POST", typeof(VariantController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/variant/bulk-import", "POST", typeof(VariantController), "BulkImport")]
        [InlineData("/api/core/variant/bulk-import", "POST", typeof(VariantController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/variant/meta", "GET", typeof(VariantController), "GetEntityView")]
        [InlineData("/api/core/variant/meta", "GET", typeof(VariantController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/variant/count", "GET", typeof(VariantController), "Count")]
        [InlineData("/api/core/variant/count", "GET", typeof(VariantController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/variant/all", "GET", typeof(VariantController), "GetAll")]
        [InlineData("/api/core/variant/all", "GET", typeof(VariantController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/variant/export", "GET", typeof(VariantController), "Export")]
        [InlineData("/api/core/variant/export", "GET", typeof(VariantController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/variant/1", "GET", typeof(VariantController), "Get")]
        [InlineData("/api/core/variant/1", "GET", typeof(VariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/variant/get?variantIds=1", "GET", typeof(VariantController), "Get")]
        [InlineData("/api/core/variant/get?variantIds=1", "GET", typeof(VariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/variant", "GET", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/core/variant", "GET", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/variant/page/1", "GET", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/core/variant/page/1", "GET", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/variant/count-filtered/{filterName}", "GET", typeof(VariantController), "CountFiltered")]
        [InlineData("/api/core/variant/count-filtered/{filterName}", "GET", typeof(VariantController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/variant/get-filtered/{pageNumber}/{filterName}", "GET", typeof(VariantController), "GetFiltered")]
        [InlineData("/api/core/variant/get-filtered/{pageNumber}/{filterName}", "GET", typeof(VariantController), "GetFiltered")]
        [InlineData("/api/core/variant/first", "GET", typeof(VariantController), "GetFirst")]
        [InlineData("/api/core/variant/previous/1", "GET", typeof(VariantController), "GetPrevious")]
        [InlineData("/api/core/variant/next/1", "GET", typeof(VariantController), "GetNext")]
        [InlineData("/api/core/variant/last", "GET", typeof(VariantController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/variant/custom-fields", "GET", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/core/variant/custom-fields", "GET", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/variant/custom-fields/{resourceId}", "GET", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/core/variant/custom-fields/{resourceId}", "GET", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/variant/meta", "HEAD", typeof(VariantController), "GetEntityView")]
        [InlineData("/api/core/variant/meta", "HEAD", typeof(VariantController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/variant/count", "HEAD", typeof(VariantController), "Count")]
        [InlineData("/api/core/variant/count", "HEAD", typeof(VariantController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/variant/all", "HEAD", typeof(VariantController), "GetAll")]
        [InlineData("/api/core/variant/all", "HEAD", typeof(VariantController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/variant/export", "HEAD", typeof(VariantController), "Export")]
        [InlineData("/api/core/variant/export", "HEAD", typeof(VariantController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/variant/1", "HEAD", typeof(VariantController), "Get")]
        [InlineData("/api/core/variant/1", "HEAD", typeof(VariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/variant/get?variantIds=1", "HEAD", typeof(VariantController), "Get")]
        [InlineData("/api/core/variant/get?variantIds=1", "HEAD", typeof(VariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/variant", "HEAD", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/core/variant", "HEAD", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/variant/page/1", "HEAD", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/core/variant/page/1", "HEAD", typeof(VariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/variant/count-filtered/{filterName}", "HEAD", typeof(VariantController), "CountFiltered")]
        [InlineData("/api/core/variant/count-filtered/{filterName}", "HEAD", typeof(VariantController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/variant/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(VariantController), "GetFiltered")]
        [InlineData("/api/core/variant/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(VariantController), "GetFiltered")]
        [InlineData("/api/core/variant/first", "HEAD", typeof(VariantController), "GetFirst")]
        [InlineData("/api/core/variant/previous/1", "HEAD", typeof(VariantController), "GetPrevious")]
        [InlineData("/api/core/variant/next/1", "HEAD", typeof(VariantController), "GetNext")]
        [InlineData("/api/core/variant/last", "HEAD", typeof(VariantController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/variant/custom-fields", "HEAD", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/core/variant/custom-fields", "HEAD", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/variant/custom-fields/{resourceId}", "HEAD", typeof(VariantController), "GetCustomFields")]
        [InlineData("/api/core/variant/custom-fields/{resourceId}", "HEAD", typeof(VariantController), "GetCustomFields")]

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

        public VariantRouteTests()
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