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
    public class BonusSlabDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/delete/{bonusSlabDetailId}", "DELETE", typeof(BonusSlabDetailController), "Delete")]
        [InlineData("/api/core/bonus-slab-detail/delete/{bonusSlabDetailId}", "DELETE", typeof(BonusSlabDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/edit/{bonusSlabDetailId}", "PUT", typeof(BonusSlabDetailController), "Edit")]
        [InlineData("/api/core/bonus-slab-detail/edit/{bonusSlabDetailId}", "PUT", typeof(BonusSlabDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/count-where", "POST", typeof(BonusSlabDetailController), "CountWhere")]
        [InlineData("/api/core/bonus-slab-detail/count-where", "POST", typeof(BonusSlabDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/get-where/{pageNumber}", "POST", typeof(BonusSlabDetailController), "GetWhere")]
        [InlineData("/api/core/bonus-slab-detail/get-where/{pageNumber}", "POST", typeof(BonusSlabDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/add-or-edit", "POST", typeof(BonusSlabDetailController), "AddOrEdit")]
        [InlineData("/api/core/bonus-slab-detail/add-or-edit", "POST", typeof(BonusSlabDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/add/{bonusSlabDetail}", "POST", typeof(BonusSlabDetailController), "Add")]
        [InlineData("/api/core/bonus-slab-detail/add/{bonusSlabDetail}", "POST", typeof(BonusSlabDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/bulk-import", "POST", typeof(BonusSlabDetailController), "BulkImport")]
        [InlineData("/api/core/bonus-slab-detail/bulk-import", "POST", typeof(BonusSlabDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/meta", "GET", typeof(BonusSlabDetailController), "GetEntityView")]
        [InlineData("/api/core/bonus-slab-detail/meta", "GET", typeof(BonusSlabDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/count", "GET", typeof(BonusSlabDetailController), "Count")]
        [InlineData("/api/core/bonus-slab-detail/count", "GET", typeof(BonusSlabDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/all", "GET", typeof(BonusSlabDetailController), "GetAll")]
        [InlineData("/api/core/bonus-slab-detail/all", "GET", typeof(BonusSlabDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/export", "GET", typeof(BonusSlabDetailController), "Export")]
        [InlineData("/api/core/bonus-slab-detail/export", "GET", typeof(BonusSlabDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/1", "GET", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/core/bonus-slab-detail/1", "GET", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/get?bonusSlabDetailIds=1", "GET", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/core/bonus-slab-detail/get?bonusSlabDetailIds=1", "GET", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail", "GET", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab-detail", "GET", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/page/1", "GET", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab-detail/page/1", "GET", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/count-filtered/{filterName}", "GET", typeof(BonusSlabDetailController), "CountFiltered")]
        [InlineData("/api/core/bonus-slab-detail/count-filtered/{filterName}", "GET", typeof(BonusSlabDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BonusSlabDetailController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BonusSlabDetailController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab-detail/first", "GET", typeof(BonusSlabDetailController), "GetFirst")]
        [InlineData("/api/core/bonus-slab-detail/previous/1", "GET", typeof(BonusSlabDetailController), "GetPrevious")]
        [InlineData("/api/core/bonus-slab-detail/next/1", "GET", typeof(BonusSlabDetailController), "GetNext")]
        [InlineData("/api/core/bonus-slab-detail/last", "GET", typeof(BonusSlabDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/custom-fields", "GET", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab-detail/custom-fields", "GET", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/custom-fields/{resourceId}", "GET", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab-detail/custom-fields/{resourceId}", "GET", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/meta", "HEAD", typeof(BonusSlabDetailController), "GetEntityView")]
        [InlineData("/api/core/bonus-slab-detail/meta", "HEAD", typeof(BonusSlabDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/count", "HEAD", typeof(BonusSlabDetailController), "Count")]
        [InlineData("/api/core/bonus-slab-detail/count", "HEAD", typeof(BonusSlabDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/all", "HEAD", typeof(BonusSlabDetailController), "GetAll")]
        [InlineData("/api/core/bonus-slab-detail/all", "HEAD", typeof(BonusSlabDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/export", "HEAD", typeof(BonusSlabDetailController), "Export")]
        [InlineData("/api/core/bonus-slab-detail/export", "HEAD", typeof(BonusSlabDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/1", "HEAD", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/core/bonus-slab-detail/1", "HEAD", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/get?bonusSlabDetailIds=1", "HEAD", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/core/bonus-slab-detail/get?bonusSlabDetailIds=1", "HEAD", typeof(BonusSlabDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail", "HEAD", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab-detail", "HEAD", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/page/1", "HEAD", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/bonus-slab-detail/page/1", "HEAD", typeof(BonusSlabDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/count-filtered/{filterName}", "HEAD", typeof(BonusSlabDetailController), "CountFiltered")]
        [InlineData("/api/core/bonus-slab-detail/count-filtered/{filterName}", "HEAD", typeof(BonusSlabDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BonusSlabDetailController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BonusSlabDetailController), "GetFiltered")]
        [InlineData("/api/core/bonus-slab-detail/first", "HEAD", typeof(BonusSlabDetailController), "GetFirst")]
        [InlineData("/api/core/bonus-slab-detail/previous/1", "HEAD", typeof(BonusSlabDetailController), "GetPrevious")]
        [InlineData("/api/core/bonus-slab-detail/next/1", "HEAD", typeof(BonusSlabDetailController), "GetNext")]
        [InlineData("/api/core/bonus-slab-detail/last", "HEAD", typeof(BonusSlabDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/custom-fields", "HEAD", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab-detail/custom-fields", "HEAD", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bonus-slab-detail/custom-fields/{resourceId}", "HEAD", typeof(BonusSlabDetailController), "GetCustomFields")]
        [InlineData("/api/core/bonus-slab-detail/custom-fields/{resourceId}", "HEAD", typeof(BonusSlabDetailController), "GetCustomFields")]

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

        public BonusSlabDetailRouteTests()
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