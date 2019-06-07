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
    public class KanbanRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/kanban/delete/{kanbanId}", "DELETE", typeof(CoreKanbanController), "Delete")]
        [InlineData("/api/core/kanban/delete/{kanbanId}", "DELETE", typeof(CoreKanbanController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/edit/{kanbanId}", "PUT", typeof(CoreKanbanController), "Edit")]
        [InlineData("/api/core/kanban/edit/{kanbanId}", "PUT", typeof(CoreKanbanController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/count-where", "POST", typeof(CoreKanbanController), "CountWhere")]
        [InlineData("/api/core/kanban/count-where", "POST", typeof(CoreKanbanController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/get-where/{pageNumber}", "POST", typeof(CoreKanbanController), "GetWhere")]
        [InlineData("/api/core/kanban/get-where/{pageNumber}", "POST", typeof(CoreKanbanController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/add-or-edit", "POST", typeof(CoreKanbanController), "AddOrEdit")]
        [InlineData("/api/core/kanban/add-or-edit", "POST", typeof(CoreKanbanController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/add/{kanban}", "POST", typeof(CoreKanbanController), "Add")]
        [InlineData("/api/core/kanban/add/{kanban}", "POST", typeof(CoreKanbanController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/bulk-import", "POST", typeof(CoreKanbanController), "BulkImport")]
        [InlineData("/api/core/kanban/bulk-import", "POST", typeof(CoreKanbanController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/meta", "GET", typeof(CoreKanbanController), "GetEntityView")]
        [InlineData("/api/core/kanban/meta", "GET", typeof(CoreKanbanController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/count", "GET", typeof(CoreKanbanController), "Count")]
        [InlineData("/api/core/kanban/count", "GET", typeof(CoreKanbanController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/all", "GET", typeof(CoreKanbanController), "GetAll")]
        [InlineData("/api/core/kanban/all", "GET", typeof(CoreKanbanController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/export", "GET", typeof(CoreKanbanController), "Export")]
        [InlineData("/api/core/kanban/export", "GET", typeof(CoreKanbanController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/1", "GET", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/core/kanban/1", "GET", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/get?kanbanIds=1", "GET", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/core/kanban/get?kanbanIds=1", "GET", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/kanban", "GET", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/core/kanban", "GET", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/page/1", "GET", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/core/kanban/page/1", "GET", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/count-filtered/{filterName}", "GET", typeof(CoreKanbanController), "CountFiltered")]
        [InlineData("/api/core/kanban/count-filtered/{filterName}", "GET", typeof(CoreKanbanController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CoreKanbanController), "GetFiltered")]
        [InlineData("/api/core/kanban/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CoreKanbanController), "GetFiltered")]
        [InlineData("/api/core/kanban/first", "GET", typeof(CoreKanbanController), "GetFirst")]
        [InlineData("/api/core/kanban/previous/1", "GET", typeof(CoreKanbanController), "GetPrevious")]
        [InlineData("/api/core/kanban/next/1", "GET", typeof(CoreKanbanController), "GetNext")]
        [InlineData("/api/core/kanban/last", "GET", typeof(CoreKanbanController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/kanban/custom-fields", "GET", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/core/kanban/custom-fields", "GET", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/custom-fields/{resourceId}", "GET", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/core/kanban/custom-fields/{resourceId}", "GET", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/meta", "HEAD", typeof(CoreKanbanController), "GetEntityView")]
        [InlineData("/api/core/kanban/meta", "HEAD", typeof(CoreKanbanController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/count", "HEAD", typeof(CoreKanbanController), "Count")]
        [InlineData("/api/core/kanban/count", "HEAD", typeof(CoreKanbanController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/all", "HEAD", typeof(CoreKanbanController), "GetAll")]
        [InlineData("/api/core/kanban/all", "HEAD", typeof(CoreKanbanController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/export", "HEAD", typeof(CoreKanbanController), "Export")]
        [InlineData("/api/core/kanban/export", "HEAD", typeof(CoreKanbanController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/1", "HEAD", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/core/kanban/1", "HEAD", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/get?kanbanIds=1", "HEAD", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/core/kanban/get?kanbanIds=1", "HEAD", typeof(CoreKanbanController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/kanban", "HEAD", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/core/kanban", "HEAD", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/page/1", "HEAD", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/core/kanban/page/1", "HEAD", typeof(CoreKanbanController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/count-filtered/{filterName}", "HEAD", typeof(CoreKanbanController), "CountFiltered")]
        [InlineData("/api/core/kanban/count-filtered/{filterName}", "HEAD", typeof(CoreKanbanController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CoreKanbanController), "GetFiltered")]
        [InlineData("/api/core/kanban/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CoreKanbanController), "GetFiltered")]
        [InlineData("/api/core/kanban/first", "HEAD", typeof(CoreKanbanController), "GetFirst")]
        [InlineData("/api/core/kanban/previous/1", "HEAD", typeof(CoreKanbanController), "GetPrevious")]
        [InlineData("/api/core/kanban/next/1", "HEAD", typeof(CoreKanbanController), "GetNext")]
        [InlineData("/api/core/kanban/last", "HEAD", typeof(CoreKanbanController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/kanban/custom-fields", "HEAD", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/core/kanban/custom-fields", "HEAD", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/kanban/custom-fields/{resourceId}", "HEAD", typeof(CoreKanbanController), "GetCustomFields")]
        [InlineData("/api/core/kanban/custom-fields/{resourceId}", "HEAD", typeof(CoreKanbanController), "GetCustomFields")]

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

        public KanbanRouteTests()
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