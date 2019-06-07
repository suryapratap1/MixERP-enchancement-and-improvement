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
    public class BonusSlabRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/delete/{bonusSlabId}", "DELETE", typeof(BonusSlabController), "Delete")]
        [InlineData("/api/core/bonus-slab/delete/{bonusSlabId}", "DELETE", typeof(BonusSlabController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/edit/{bonusSlabId}", "PUT", typeof(BonusSlabController), "Edit")]
        [InlineData("/api/core/bonus-slab/edit/{bonusSlabId}", "PUT", typeof(BonusSlabController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/count-where", "POST", typeof(BonusSlabController), "CountWhere")]
        [InlineData("/api/core/bonus-slab/count-where", "POST", typeof(BonusSlabController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/get-where/{pageNumber}", "POST", typeof(BonusSlabController), "GetWhere")]
        [InlineData("/api/core/bonus-slab/get-where/{pageNumber}", "POST", typeof(BonusSlabController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/add-or-edit", "POST", typeof(BonusSlabController), "AddOrEdit")]
        [InlineData("/api/core/bonus-slab/add-or-edit", "POST", typeof(BonusSlabController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/add/{bonusSlab}", "POST", typeof(BonusSlabController), "Add")]
        [InlineData("/api/core/bonus-slab/add/{bonusSlab}", "POST", typeof(BonusSlabController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/bulk-import", "POST", typeof(BonusSlabController), "BulkImport")]
        [InlineData("/api/core/bonus-slab/bulk-import", "POST", typeof(BonusSlabController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/meta", "GET", typeof(BonusSlabController), "GetEntityView")]
        [InlineData("/api/core/bonus-slab/meta", "GET", typeof(BonusSlabController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/count", "GET", typeof(BonusSlabController), "Count")]
        [InlineData("/api/core/bonus-slab/count", "GET", typeof(BonusSlabController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/all", "GET", typeof(BonusSlabController), "GetAll")]
        [InlineData("/api/core/bonus-slab/all", "GET", typeof(BonusSlabController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/export", "GET", typeof(BonusSlabController), "Export")]
        [InlineData("/api/core/bonus-slab/export", "GET", typeof(BonusSlabController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/1", "GET", typeof(BonusSlabController), "Get")]
        [InlineData("/api/core/bonus-slab/1", "GET", typeof(BonusSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/get?bonusSlabIds=1", "GET", typeof(BonusSlabController), "Get")]
        [InlineData("/api/core/bonus-slab/get?bonusSlabIds=1", "GET", typeof(BonusSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab", "GET", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab", "GET", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/page/1", "GET", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab/page/1", "GET", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/count-filtered/{filterName}", "GET", typeof(BonusSlabController), "CountFiltered")]
        [InlineData("/api/core/bonus-slab/count-filtered/{filterName}", "GET", typeof(BonusSlabController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BonusSlabController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BonusSlabController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab/first", "GET", typeof(BonusSlabController), "GetFirst")]
        [InlineData("/api/core/bonus-slab/previous/1", "GET", typeof(BonusSlabController), "GetPrevious")]
        [InlineData("/api/core/bonus-slab/next/1", "GET", typeof(BonusSlabController), "GetNext")]
        [InlineData("/api/core/bonus-slab/last", "GET", typeof(BonusSlabController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/custom-fields", "GET", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab/custom-fields", "GET", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/custom-fields/{resourceId}", "GET", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab/custom-fields/{resourceId}", "GET", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/meta", "HEAD", typeof(BonusSlabController), "GetEntityView")]
        [InlineData("/api/core/bonus-slab/meta", "HEAD", typeof(BonusSlabController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/count", "HEAD", typeof(BonusSlabController), "Count")]
        [InlineData("/api/core/bonus-slab/count", "HEAD", typeof(BonusSlabController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/all", "HEAD", typeof(BonusSlabController), "GetAll")]
        [InlineData("/api/core/bonus-slab/all", "HEAD", typeof(BonusSlabController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/export", "HEAD", typeof(BonusSlabController), "Export")]
        [InlineData("/api/core/bonus-slab/export", "HEAD", typeof(BonusSlabController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/1", "HEAD", typeof(BonusSlabController), "Get")]
        [InlineData("/api/core/bonus-slab/1", "HEAD", typeof(BonusSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/get?bonusSlabIds=1", "HEAD", typeof(BonusSlabController), "Get")]
        [InlineData("/api/core/bonus-slab/get?bonusSlabIds=1", "HEAD", typeof(BonusSlabController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab", "HEAD", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab", "HEAD", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/page/1", "HEAD", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab/page/1", "HEAD", typeof(BonusSlabController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/count-filtered/{filterName}", "HEAD", typeof(BonusSlabController), "CountFiltered")]
        [InlineData("/api/core/bonus-slab/count-filtered/{filterName}", "HEAD", typeof(BonusSlabController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BonusSlabController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BonusSlabController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab/first", "HEAD", typeof(BonusSlabController), "GetFirst")]
        [InlineData("/api/core/bonus-slab/previous/1", "HEAD", typeof(BonusSlabController), "GetPrevious")]
        [InlineData("/api/core/bonus-slab/next/1", "HEAD", typeof(BonusSlabController), "GetNext")]
        [InlineData("/api/core/bonus-slab/last", "HEAD", typeof(BonusSlabController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/custom-fields", "HEAD", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab/custom-fields", "HEAD", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab/custom-fields/{resourceId}", "HEAD", typeof(BonusSlabController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab/custom-fields/{resourceId}", "HEAD", typeof(BonusSlabController), "GetCustomFields")]

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

        public BonusSlabRouteTests()
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