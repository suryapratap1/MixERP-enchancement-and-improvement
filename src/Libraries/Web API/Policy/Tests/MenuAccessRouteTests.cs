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

namespace MixERP.Net.Api.Policy.Tests
{
    public class MenuAccessRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/delete/{accessId}", "DELETE", typeof(MenuAccessController), "Delete")]
        [InlineData("/api/policy/menu-access/delete/{accessId}", "DELETE", typeof(MenuAccessController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/edit/{accessId}", "PUT", typeof(MenuAccessController), "Edit")]
        [InlineData("/api/policy/menu-access/edit/{accessId}", "PUT", typeof(MenuAccessController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/count-where", "POST", typeof(MenuAccessController), "CountWhere")]
        [InlineData("/api/policy/menu-access/count-where", "POST", typeof(MenuAccessController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/get-where/{pageNumber}", "POST", typeof(MenuAccessController), "GetWhere")]
        [InlineData("/api/policy/menu-access/get-where/{pageNumber}", "POST", typeof(MenuAccessController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/add-or-edit", "POST", typeof(MenuAccessController), "AddOrEdit")]
        [InlineData("/api/policy/menu-access/add-or-edit", "POST", typeof(MenuAccessController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/add/{menuAccess}", "POST", typeof(MenuAccessController), "Add")]
        [InlineData("/api/policy/menu-access/add/{menuAccess}", "POST", typeof(MenuAccessController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/bulk-import", "POST", typeof(MenuAccessController), "BulkImport")]
        [InlineData("/api/policy/menu-access/bulk-import", "POST", typeof(MenuAccessController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/meta", "GET", typeof(MenuAccessController), "GetEntityView")]
        [InlineData("/api/policy/menu-access/meta", "GET", typeof(MenuAccessController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/count", "GET", typeof(MenuAccessController), "Count")]
        [InlineData("/api/policy/menu-access/count", "GET", typeof(MenuAccessController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/all", "GET", typeof(MenuAccessController), "GetAll")]
        [InlineData("/api/policy/menu-access/all", "GET", typeof(MenuAccessController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/export", "GET", typeof(MenuAccessController), "Export")]
        [InlineData("/api/policy/menu-access/export", "GET", typeof(MenuAccessController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/1", "GET", typeof(MenuAccessController), "Get")]
        [InlineData("/api/policy/menu-access/1", "GET", typeof(MenuAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/get?accessIds=1", "GET", typeof(MenuAccessController), "Get")]
        [InlineData("/api/policy/menu-access/get?accessIds=1", "GET", typeof(MenuAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access", "GET", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-access", "GET", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/page/1", "GET", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-access/page/1", "GET", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/count-filtered/{filterName}", "GET", typeof(MenuAccessController), "CountFiltered")]
        [InlineData("/api/policy/menu-access/count-filtered/{filterName}", "GET", typeof(MenuAccessController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MenuAccessController), "GetFiltered")]
        [InlineData("/api/policy/menu-access/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MenuAccessController), "GetFiltered")]
        [InlineData("/api/policy/menu-access/first", "GET", typeof(MenuAccessController), "GetFirst")]
        [InlineData("/api/policy/menu-access/previous/1", "GET", typeof(MenuAccessController), "GetPrevious")]
        [InlineData("/api/policy/menu-access/next/1", "GET", typeof(MenuAccessController), "GetNext")]
        [InlineData("/api/policy/menu-access/last", "GET", typeof(MenuAccessController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/menu-access/custom-fields", "GET", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/policy/menu-access/custom-fields", "GET", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/custom-fields/{resourceId}", "GET", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/policy/menu-access/custom-fields/{resourceId}", "GET", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/meta", "HEAD", typeof(MenuAccessController), "GetEntityView")]
        [InlineData("/api/policy/menu-access/meta", "HEAD", typeof(MenuAccessController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/count", "HEAD", typeof(MenuAccessController), "Count")]
        [InlineData("/api/policy/menu-access/count", "HEAD", typeof(MenuAccessController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/all", "HEAD", typeof(MenuAccessController), "GetAll")]
        [InlineData("/api/policy/menu-access/all", "HEAD", typeof(MenuAccessController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/export", "HEAD", typeof(MenuAccessController), "Export")]
        [InlineData("/api/policy/menu-access/export", "HEAD", typeof(MenuAccessController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/1", "HEAD", typeof(MenuAccessController), "Get")]
        [InlineData("/api/policy/menu-access/1", "HEAD", typeof(MenuAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/get?accessIds=1", "HEAD", typeof(MenuAccessController), "Get")]
        [InlineData("/api/policy/menu-access/get?accessIds=1", "HEAD", typeof(MenuAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access", "HEAD", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-access", "HEAD", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/page/1", "HEAD", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-access/page/1", "HEAD", typeof(MenuAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/count-filtered/{filterName}", "HEAD", typeof(MenuAccessController), "CountFiltered")]
        [InlineData("/api/policy/menu-access/count-filtered/{filterName}", "HEAD", typeof(MenuAccessController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MenuAccessController), "GetFiltered")]
        [InlineData("/api/policy/menu-access/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MenuAccessController), "GetFiltered")]
        [InlineData("/api/policy/menu-access/first", "HEAD", typeof(MenuAccessController), "GetFirst")]
        [InlineData("/api/policy/menu-access/previous/1", "HEAD", typeof(MenuAccessController), "GetPrevious")]
        [InlineData("/api/policy/menu-access/next/1", "HEAD", typeof(MenuAccessController), "GetNext")]
        [InlineData("/api/policy/menu-access/last", "HEAD", typeof(MenuAccessController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/menu-access/custom-fields", "HEAD", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/policy/menu-access/custom-fields", "HEAD", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-access/custom-fields/{resourceId}", "HEAD", typeof(MenuAccessController), "GetCustomFields")]
        [InlineData("/api/policy/menu-access/custom-fields/{resourceId}", "HEAD", typeof(MenuAccessController), "GetCustomFields")]

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

        public MenuAccessRouteTests()
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