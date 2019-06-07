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
    public class EntityRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/entity/delete/{entityId}", "DELETE", typeof(EntityController), "Delete")]
        [InlineData("/api/core/entity/delete/{entityId}", "DELETE", typeof(EntityController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/entity/edit/{entityId}", "PUT", typeof(EntityController), "Edit")]
        [InlineData("/api/core/entity/edit/{entityId}", "PUT", typeof(EntityController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/entity/count-where", "POST", typeof(EntityController), "CountWhere")]
        [InlineData("/api/core/entity/count-where", "POST", typeof(EntityController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/entity/get-where/{pageNumber}", "POST", typeof(EntityController), "GetWhere")]
        [InlineData("/api/core/entity/get-where/{pageNumber}", "POST", typeof(EntityController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/entity/add-or-edit", "POST", typeof(EntityController), "AddOrEdit")]
        [InlineData("/api/core/entity/add-or-edit", "POST", typeof(EntityController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/entity/add/{entity}", "POST", typeof(EntityController), "Add")]
        [InlineData("/api/core/entity/add/{entity}", "POST", typeof(EntityController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/entity/bulk-import", "POST", typeof(EntityController), "BulkImport")]
        [InlineData("/api/core/entity/bulk-import", "POST", typeof(EntityController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/entity/meta", "GET", typeof(EntityController), "GetEntityView")]
        [InlineData("/api/core/entity/meta", "GET", typeof(EntityController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/entity/count", "GET", typeof(EntityController), "Count")]
        [InlineData("/api/core/entity/count", "GET", typeof(EntityController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/entity/all", "GET", typeof(EntityController), "GetAll")]
        [InlineData("/api/core/entity/all", "GET", typeof(EntityController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/entity/export", "GET", typeof(EntityController), "Export")]
        [InlineData("/api/core/entity/export", "GET", typeof(EntityController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/entity/1", "GET", typeof(EntityController), "Get")]
        [InlineData("/api/core/entity/1", "GET", typeof(EntityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/entity/get?entityIds=1", "GET", typeof(EntityController), "Get")]
        [InlineData("/api/core/entity/get?entityIds=1", "GET", typeof(EntityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/entity", "GET", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/core/entity", "GET", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/entity/page/1", "GET", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/core/entity/page/1", "GET", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/entity/count-filtered/{filterName}", "GET", typeof(EntityController), "CountFiltered")]
        [InlineData("/api/core/entity/count-filtered/{filterName}", "GET", typeof(EntityController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/entity/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EntityController), "GetFiltered")]
        [InlineData("/api/core/entity/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EntityController), "GetFiltered")]
        [InlineData("/api/core/entity/first", "GET", typeof(EntityController), "GetFirst")]
        [InlineData("/api/core/entity/previous/1", "GET", typeof(EntityController), "GetPrevious")]
        [InlineData("/api/core/entity/next/1", "GET", typeof(EntityController), "GetNext")]
        [InlineData("/api/core/entity/last", "GET", typeof(EntityController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/entity/custom-fields", "GET", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/core/entity/custom-fields", "GET", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/entity/custom-fields/{resourceId}", "GET", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/core/entity/custom-fields/{resourceId}", "GET", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/entity/meta", "HEAD", typeof(EntityController), "GetEntityView")]
        [InlineData("/api/core/entity/meta", "HEAD", typeof(EntityController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/entity/count", "HEAD", typeof(EntityController), "Count")]
        [InlineData("/api/core/entity/count", "HEAD", typeof(EntityController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/entity/all", "HEAD", typeof(EntityController), "GetAll")]
        [InlineData("/api/core/entity/all", "HEAD", typeof(EntityController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/entity/export", "HEAD", typeof(EntityController), "Export")]
        [InlineData("/api/core/entity/export", "HEAD", typeof(EntityController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/entity/1", "HEAD", typeof(EntityController), "Get")]
        [InlineData("/api/core/entity/1", "HEAD", typeof(EntityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/entity/get?entityIds=1", "HEAD", typeof(EntityController), "Get")]
        [InlineData("/api/core/entity/get?entityIds=1", "HEAD", typeof(EntityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/entity", "HEAD", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/core/entity", "HEAD", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/entity/page/1", "HEAD", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/core/entity/page/1", "HEAD", typeof(EntityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/entity/count-filtered/{filterName}", "HEAD", typeof(EntityController), "CountFiltered")]
        [InlineData("/api/core/entity/count-filtered/{filterName}", "HEAD", typeof(EntityController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/entity/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EntityController), "GetFiltered")]
        [InlineData("/api/core/entity/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EntityController), "GetFiltered")]
        [InlineData("/api/core/entity/first", "HEAD", typeof(EntityController), "GetFirst")]
        [InlineData("/api/core/entity/previous/1", "HEAD", typeof(EntityController), "GetPrevious")]
        [InlineData("/api/core/entity/next/1", "HEAD", typeof(EntityController), "GetNext")]
        [InlineData("/api/core/entity/last", "HEAD", typeof(EntityController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/entity/custom-fields", "HEAD", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/core/entity/custom-fields", "HEAD", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/entity/custom-fields/{resourceId}", "HEAD", typeof(EntityController), "GetCustomFields")]
        [InlineData("/api/core/entity/custom-fields/{resourceId}", "HEAD", typeof(EntityController), "GetCustomFields")]

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

        public EntityRouteTests()
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