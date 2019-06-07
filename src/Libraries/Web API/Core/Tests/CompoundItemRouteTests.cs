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
    public class CompoundItemRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/delete/{compoundItemId}", "DELETE", typeof(CompoundItemController), "Delete")]
        [InlineData("/api/core/compound-item/delete/{compoundItemId}", "DELETE", typeof(CompoundItemController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/edit/{compoundItemId}", "PUT", typeof(CompoundItemController), "Edit")]
        [InlineData("/api/core/compound-item/edit/{compoundItemId}", "PUT", typeof(CompoundItemController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/count-where", "POST", typeof(CompoundItemController), "CountWhere")]
        [InlineData("/api/core/compound-item/count-where", "POST", typeof(CompoundItemController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/get-where/{pageNumber}", "POST", typeof(CompoundItemController), "GetWhere")]
        [InlineData("/api/core/compound-item/get-where/{pageNumber}", "POST", typeof(CompoundItemController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/add-or-edit", "POST", typeof(CompoundItemController), "AddOrEdit")]
        [InlineData("/api/core/compound-item/add-or-edit", "POST", typeof(CompoundItemController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/add/{compoundItem}", "POST", typeof(CompoundItemController), "Add")]
        [InlineData("/api/core/compound-item/add/{compoundItem}", "POST", typeof(CompoundItemController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/bulk-import", "POST", typeof(CompoundItemController), "BulkImport")]
        [InlineData("/api/core/compound-item/bulk-import", "POST", typeof(CompoundItemController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/meta", "GET", typeof(CompoundItemController), "GetEntityView")]
        [InlineData("/api/core/compound-item/meta", "GET", typeof(CompoundItemController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/count", "GET", typeof(CompoundItemController), "Count")]
        [InlineData("/api/core/compound-item/count", "GET", typeof(CompoundItemController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/all", "GET", typeof(CompoundItemController), "GetAll")]
        [InlineData("/api/core/compound-item/all", "GET", typeof(CompoundItemController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/export", "GET", typeof(CompoundItemController), "Export")]
        [InlineData("/api/core/compound-item/export", "GET", typeof(CompoundItemController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/1", "GET", typeof(CompoundItemController), "Get")]
        [InlineData("/api/core/compound-item/1", "GET", typeof(CompoundItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/get?compoundItemIds=1", "GET", typeof(CompoundItemController), "Get")]
        [InlineData("/api/core/compound-item/get?compoundItemIds=1", "GET", typeof(CompoundItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item", "GET", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item", "GET", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/page/1", "GET", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item/page/1", "GET", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/count-filtered/{filterName}", "GET", typeof(CompoundItemController), "CountFiltered")]
        [InlineData("/api/core/compound-item/count-filtered/{filterName}", "GET", typeof(CompoundItemController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CompoundItemController), "GetFiltered")]
        [InlineData("/api/core/compound-item/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CompoundItemController), "GetFiltered")]
        [InlineData("/api/core/compound-item/first", "GET", typeof(CompoundItemController), "GetFirst")]
        [InlineData("/api/core/compound-item/previous/1", "GET", typeof(CompoundItemController), "GetPrevious")]
        [InlineData("/api/core/compound-item/next/1", "GET", typeof(CompoundItemController), "GetNext")]
        [InlineData("/api/core/compound-item/last", "GET", typeof(CompoundItemController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/compound-item/custom-fields", "GET", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/core/compound-item/custom-fields", "GET", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/custom-fields/{resourceId}", "GET", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/core/compound-item/custom-fields/{resourceId}", "GET", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/meta", "HEAD", typeof(CompoundItemController), "GetEntityView")]
        [InlineData("/api/core/compound-item/meta", "HEAD", typeof(CompoundItemController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/count", "HEAD", typeof(CompoundItemController), "Count")]
        [InlineData("/api/core/compound-item/count", "HEAD", typeof(CompoundItemController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/all", "HEAD", typeof(CompoundItemController), "GetAll")]
        [InlineData("/api/core/compound-item/all", "HEAD", typeof(CompoundItemController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/export", "HEAD", typeof(CompoundItemController), "Export")]
        [InlineData("/api/core/compound-item/export", "HEAD", typeof(CompoundItemController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/1", "HEAD", typeof(CompoundItemController), "Get")]
        [InlineData("/api/core/compound-item/1", "HEAD", typeof(CompoundItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/get?compoundItemIds=1", "HEAD", typeof(CompoundItemController), "Get")]
        [InlineData("/api/core/compound-item/get?compoundItemIds=1", "HEAD", typeof(CompoundItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item", "HEAD", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item", "HEAD", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/page/1", "HEAD", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item/page/1", "HEAD", typeof(CompoundItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/count-filtered/{filterName}", "HEAD", typeof(CompoundItemController), "CountFiltered")]
        [InlineData("/api/core/compound-item/count-filtered/{filterName}", "HEAD", typeof(CompoundItemController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CompoundItemController), "GetFiltered")]
        [InlineData("/api/core/compound-item/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CompoundItemController), "GetFiltered")]
        [InlineData("/api/core/compound-item/first", "HEAD", typeof(CompoundItemController), "GetFirst")]
        [InlineData("/api/core/compound-item/previous/1", "HEAD", typeof(CompoundItemController), "GetPrevious")]
        [InlineData("/api/core/compound-item/next/1", "HEAD", typeof(CompoundItemController), "GetNext")]
        [InlineData("/api/core/compound-item/last", "HEAD", typeof(CompoundItemController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/compound-item/custom-fields", "HEAD", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/core/compound-item/custom-fields", "HEAD", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item/custom-fields/{resourceId}", "HEAD", typeof(CompoundItemController), "GetCustomFields")]
        [InlineData("/api/core/compound-item/custom-fields/{resourceId}", "HEAD", typeof(CompoundItemController), "GetCustomFields")]

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

        public CompoundItemRouteTests()
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