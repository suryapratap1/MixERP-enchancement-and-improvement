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
    public class AgeingSlabRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/delete/{ageingSlabId}", "DELETE", typeof(AgeingSlabController), "Delete")]
        [InlineData("/api/core/ageing-slab/delete/{ageingSlabId}", "DELETE", typeof(AgeingSlabController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/edit/{ageingSlabId}", "PUT", typeof(AgeingSlabController), "Edit")]
        [InlineData("/api/core/ageing-slab/edit/{ageingSlabId}", "PUT", typeof(AgeingSlabController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/count-where", "POST", typeof(AgeingSlabController), "CountWhere")]
        [InlineData("/api/core/ageing-slab/count-where", "POST", typeof(AgeingSlabController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/get-where/{pageNumber}", "POST", typeof(AgeingSlabController), "GetWhere")]
        [InlineData("/api/core/ageing-slab/get-where/{pageNumber}", "POST", typeof(AgeingSlabController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/add-or-edit", "POST", typeof(AgeingSlabController), "AddOrEdit")]
        [InlineData("/api/core/ageing-slab/add-or-edit", "POST", typeof(AgeingSlabController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/add/{ageingSlab}", "POST", typeof(AgeingSlabController), "Add")]
        [InlineData("/api/core/ageing-slab/add/{ageingSlab}", "POST", typeof(AgeingSlabController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/bulk-import", "POST", typeof(AgeingSlabController), "BulkImport")]
        [InlineData("/api/core/ageing-slab/bulk-import", "POST", typeof(AgeingSlabController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/meta", "GET", typeof(AgeingSlabController), "GetEntityView")]
        [InlineData("/api/core/ageing-slab/meta", "GET", typeof(AgeingSlabController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/count", "GET", typeof(AgeingSlabController), "Count")]
        [InlineData("/api/core/ageing-slab/count", "GET", typeof(AgeingSlabController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/all", "GET", typeof(AgeingSlabController), "GetAll")]
        [InlineData("/api/core/ageing-slab/all", "GET", typeof(AgeingSlabController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/export", "GET", typeof(AgeingSlabController), "Export")]
        [InlineData("/api/core/ageing-slab/export", "GET", typeof(AgeingSlabController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/1", "GET", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/core/ageing-slab/1", "GET", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/get?ageingSlabIds=1", "GET", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/core/ageing-slab/get?ageingSlabIds=1", "GET", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab", "GET", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/ageing-slab", "GET", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/page/1", "GET", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/ageing-slab/page/1", "GET", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/count-filtered/{filterName}", "GET", typeof(AgeingSlabController), "CountFiltered")]
        [InlineData("/api/core/ageing-slab/count-filtered/{filterName}", "GET", typeof(AgeingSlabController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AgeingSlabController), "GetFiltered")]
        [InlineData("/api/core/ageing-slab/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AgeingSlabController), "GetFiltered")]
        [InlineData("/api/core/ageing-slab/first", "GET", typeof(AgeingSlabController), "GetFirst")]
        [InlineData("/api/core/ageing-slab/previous/1", "GET", typeof(AgeingSlabController), "GetPrevious")]
        [InlineData("/api/core/ageing-slab/next/1", "GET", typeof(AgeingSlabController), "GetNext")]
        [InlineData("/api/core/ageing-slab/last", "GET", typeof(AgeingSlabController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/custom-fields", "GET", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/core/ageing-slab/custom-fields", "GET", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/custom-fields/{resourceId}", "GET", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/core/ageing-slab/custom-fields/{resourceId}", "GET", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/meta", "HEAD", typeof(AgeingSlabController), "GetEntityView")]
        [InlineData("/api/core/ageing-slab/meta", "HEAD", typeof(AgeingSlabController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/count", "HEAD", typeof(AgeingSlabController), "Count")]
        [InlineData("/api/core/ageing-slab/count", "HEAD", typeof(AgeingSlabController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/all", "HEAD", typeof(AgeingSlabController), "GetAll")]
        [InlineData("/api/core/ageing-slab/all", "HEAD", typeof(AgeingSlabController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/export", "HEAD", typeof(AgeingSlabController), "Export")]
        [InlineData("/api/core/ageing-slab/export", "HEAD", typeof(AgeingSlabController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/1", "HEAD", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/core/ageing-slab/1", "HEAD", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/get?ageingSlabIds=1", "HEAD", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/core/ageing-slab/get?ageingSlabIds=1", "HEAD", typeof(AgeingSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab", "HEAD", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/ageing-slab", "HEAD", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/page/1", "HEAD", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/ageing-slab/page/1", "HEAD", typeof(AgeingSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/count-filtered/{filterName}", "HEAD", typeof(AgeingSlabController), "CountFiltered")]
        [InlineData("/api/core/ageing-slab/count-filtered/{filterName}", "HEAD", typeof(AgeingSlabController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AgeingSlabController), "GetFiltered")]
        [InlineData("/api/core/ageing-slab/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AgeingSlabController), "GetFiltered")]
        [InlineData("/api/core/ageing-slab/first", "HEAD", typeof(AgeingSlabController), "GetFirst")]
        [InlineData("/api/core/ageing-slab/previous/1", "HEAD", typeof(AgeingSlabController), "GetPrevious")]
        [InlineData("/api/core/ageing-slab/next/1", "HEAD", typeof(AgeingSlabController), "GetNext")]
        [InlineData("/api/core/ageing-slab/last", "HEAD", typeof(AgeingSlabController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/custom-fields", "HEAD", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/core/ageing-slab/custom-fields", "HEAD", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/ageing-slab/custom-fields/{resourceId}", "HEAD", typeof(AgeingSlabController), "GetCustomFields")]
        [InlineData("/api/core/ageing-slab/custom-fields/{resourceId}", "HEAD", typeof(AgeingSlabController), "GetCustomFields")]

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

        public AgeingSlabRouteTests()
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