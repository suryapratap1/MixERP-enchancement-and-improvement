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
    public class StateRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/state/delete/{stateId}", "DELETE", typeof(StateController), "Delete")]
        [InlineData("/api/core/state/delete/{stateId}", "DELETE", typeof(StateController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/state/edit/{stateId}", "PUT", typeof(StateController), "Edit")]
        [InlineData("/api/core/state/edit/{stateId}", "PUT", typeof(StateController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/state/count-where", "POST", typeof(StateController), "CountWhere")]
        [InlineData("/api/core/state/count-where", "POST", typeof(StateController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/state/get-where/{pageNumber}", "POST", typeof(StateController), "GetWhere")]
        [InlineData("/api/core/state/get-where/{pageNumber}", "POST", typeof(StateController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/state/add-or-edit", "POST", typeof(StateController), "AddOrEdit")]
        [InlineData("/api/core/state/add-or-edit", "POST", typeof(StateController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/state/add/{state}", "POST", typeof(StateController), "Add")]
        [InlineData("/api/core/state/add/{state}", "POST", typeof(StateController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/state/bulk-import", "POST", typeof(StateController), "BulkImport")]
        [InlineData("/api/core/state/bulk-import", "POST", typeof(StateController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/state/meta", "GET", typeof(StateController), "GetEntityView")]
        [InlineData("/api/core/state/meta", "GET", typeof(StateController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/state/count", "GET", typeof(StateController), "Count")]
        [InlineData("/api/core/state/count", "GET", typeof(StateController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/state/all", "GET", typeof(StateController), "GetAll")]
        [InlineData("/api/core/state/all", "GET", typeof(StateController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/state/export", "GET", typeof(StateController), "Export")]
        [InlineData("/api/core/state/export", "GET", typeof(StateController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/state/1", "GET", typeof(StateController), "Get")]
        [InlineData("/api/core/state/1", "GET", typeof(StateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state/get?stateIds=1", "GET", typeof(StateController), "Get")]
        [InlineData("/api/core/state/get?stateIds=1", "GET", typeof(StateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state", "GET", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/core/state", "GET", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state/page/1", "GET", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/core/state/page/1", "GET", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state/count-filtered/{filterName}", "GET", typeof(StateController), "CountFiltered")]
        [InlineData("/api/core/state/count-filtered/{filterName}", "GET", typeof(StateController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/state/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StateController), "GetFiltered")]
        [InlineData("/api/core/state/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StateController), "GetFiltered")]
        [InlineData("/api/core/state/first", "GET", typeof(StateController), "GetFirst")]
        [InlineData("/api/core/state/previous/1", "GET", typeof(StateController), "GetPrevious")]
        [InlineData("/api/core/state/next/1", "GET", typeof(StateController), "GetNext")]
        [InlineData("/api/core/state/last", "GET", typeof(StateController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/state/custom-fields", "GET", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/core/state/custom-fields", "GET", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/state/custom-fields/{resourceId}", "GET", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/core/state/custom-fields/{resourceId}", "GET", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/state/meta", "HEAD", typeof(StateController), "GetEntityView")]
        [InlineData("/api/core/state/meta", "HEAD", typeof(StateController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/state/count", "HEAD", typeof(StateController), "Count")]
        [InlineData("/api/core/state/count", "HEAD", typeof(StateController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/state/all", "HEAD", typeof(StateController), "GetAll")]
        [InlineData("/api/core/state/all", "HEAD", typeof(StateController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/state/export", "HEAD", typeof(StateController), "Export")]
        [InlineData("/api/core/state/export", "HEAD", typeof(StateController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/state/1", "HEAD", typeof(StateController), "Get")]
        [InlineData("/api/core/state/1", "HEAD", typeof(StateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state/get?stateIds=1", "HEAD", typeof(StateController), "Get")]
        [InlineData("/api/core/state/get?stateIds=1", "HEAD", typeof(StateController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/state", "HEAD", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/core/state", "HEAD", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state/page/1", "HEAD", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/core/state/page/1", "HEAD", typeof(StateController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/state/count-filtered/{filterName}", "HEAD", typeof(StateController), "CountFiltered")]
        [InlineData("/api/core/state/count-filtered/{filterName}", "HEAD", typeof(StateController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/state/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StateController), "GetFiltered")]
        [InlineData("/api/core/state/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StateController), "GetFiltered")]
        [InlineData("/api/core/state/first", "HEAD", typeof(StateController), "GetFirst")]
        [InlineData("/api/core/state/previous/1", "HEAD", typeof(StateController), "GetPrevious")]
        [InlineData("/api/core/state/next/1", "HEAD", typeof(StateController), "GetNext")]
        [InlineData("/api/core/state/last", "HEAD", typeof(StateController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/state/custom-fields", "HEAD", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/core/state/custom-fields", "HEAD", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/state/custom-fields/{resourceId}", "HEAD", typeof(StateController), "GetCustomFields")]
        [InlineData("/api/core/state/custom-fields/{resourceId}", "HEAD", typeof(StateController), "GetCustomFields")]

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

        public StateRouteTests()
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