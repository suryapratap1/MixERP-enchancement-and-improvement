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
    public class MenuLocaleRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/delete/{menuLocaleId}", "DELETE", typeof(MenuLocaleController), "Delete")]
        [InlineData("/api/core/menu-locale/delete/{menuLocaleId}", "DELETE", typeof(MenuLocaleController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/edit/{menuLocaleId}", "PUT", typeof(MenuLocaleController), "Edit")]
        [InlineData("/api/core/menu-locale/edit/{menuLocaleId}", "PUT", typeof(MenuLocaleController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/count-where", "POST", typeof(MenuLocaleController), "CountWhere")]
        [InlineData("/api/core/menu-locale/count-where", "POST", typeof(MenuLocaleController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/get-where/{pageNumber}", "POST", typeof(MenuLocaleController), "GetWhere")]
        [InlineData("/api/core/menu-locale/get-where/{pageNumber}", "POST", typeof(MenuLocaleController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/add-or-edit", "POST", typeof(MenuLocaleController), "AddOrEdit")]
        [InlineData("/api/core/menu-locale/add-or-edit", "POST", typeof(MenuLocaleController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/add/{menuLocale}", "POST", typeof(MenuLocaleController), "Add")]
        [InlineData("/api/core/menu-locale/add/{menuLocale}", "POST", typeof(MenuLocaleController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/bulk-import", "POST", typeof(MenuLocaleController), "BulkImport")]
        [InlineData("/api/core/menu-locale/bulk-import", "POST", typeof(MenuLocaleController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/meta", "GET", typeof(MenuLocaleController), "GetEntityView")]
        [InlineData("/api/core/menu-locale/meta", "GET", typeof(MenuLocaleController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/count", "GET", typeof(MenuLocaleController), "Count")]
        [InlineData("/api/core/menu-locale/count", "GET", typeof(MenuLocaleController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/all", "GET", typeof(MenuLocaleController), "GetAll")]
        [InlineData("/api/core/menu-locale/all", "GET", typeof(MenuLocaleController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/export", "GET", typeof(MenuLocaleController), "Export")]
        [InlineData("/api/core/menu-locale/export", "GET", typeof(MenuLocaleController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/1", "GET", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/core/menu-locale/1", "GET", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/get?menuLocaleIds=1", "GET", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/core/menu-locale/get?menuLocaleIds=1", "GET", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale", "GET", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/core/menu-locale", "GET", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/page/1", "GET", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/core/menu-locale/page/1", "GET", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/count-filtered/{filterName}", "GET", typeof(MenuLocaleController), "CountFiltered")]
        [InlineData("/api/core/menu-locale/count-filtered/{filterName}", "GET", typeof(MenuLocaleController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MenuLocaleController), "GetFiltered")]
        [InlineData("/api/core/menu-locale/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MenuLocaleController), "GetFiltered")]
        [InlineData("/api/core/menu-locale/first", "GET", typeof(MenuLocaleController), "GetFirst")]
        [InlineData("/api/core/menu-locale/previous/1", "GET", typeof(MenuLocaleController), "GetPrevious")]
        [InlineData("/api/core/menu-locale/next/1", "GET", typeof(MenuLocaleController), "GetNext")]
        [InlineData("/api/core/menu-locale/last", "GET", typeof(MenuLocaleController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/menu-locale/custom-fields", "GET", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/core/menu-locale/custom-fields", "GET", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/custom-fields/{resourceId}", "GET", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/core/menu-locale/custom-fields/{resourceId}", "GET", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/meta", "HEAD", typeof(MenuLocaleController), "GetEntityView")]
        [InlineData("/api/core/menu-locale/meta", "HEAD", typeof(MenuLocaleController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/count", "HEAD", typeof(MenuLocaleController), "Count")]
        [InlineData("/api/core/menu-locale/count", "HEAD", typeof(MenuLocaleController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/all", "HEAD", typeof(MenuLocaleController), "GetAll")]
        [InlineData("/api/core/menu-locale/all", "HEAD", typeof(MenuLocaleController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/export", "HEAD", typeof(MenuLocaleController), "Export")]
        [InlineData("/api/core/menu-locale/export", "HEAD", typeof(MenuLocaleController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/1", "HEAD", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/core/menu-locale/1", "HEAD", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/get?menuLocaleIds=1", "HEAD", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/core/menu-locale/get?menuLocaleIds=1", "HEAD", typeof(MenuLocaleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale", "HEAD", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/core/menu-locale", "HEAD", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/page/1", "HEAD", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/core/menu-locale/page/1", "HEAD", typeof(MenuLocaleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/count-filtered/{filterName}", "HEAD", typeof(MenuLocaleController), "CountFiltered")]
        [InlineData("/api/core/menu-locale/count-filtered/{filterName}", "HEAD", typeof(MenuLocaleController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MenuLocaleController), "GetFiltered")]
        [InlineData("/api/core/menu-locale/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MenuLocaleController), "GetFiltered")]
        [InlineData("/api/core/menu-locale/first", "HEAD", typeof(MenuLocaleController), "GetFirst")]
        [InlineData("/api/core/menu-locale/previous/1", "HEAD", typeof(MenuLocaleController), "GetPrevious")]
        [InlineData("/api/core/menu-locale/next/1", "HEAD", typeof(MenuLocaleController), "GetNext")]
        [InlineData("/api/core/menu-locale/last", "HEAD", typeof(MenuLocaleController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/menu-locale/custom-fields", "HEAD", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/core/menu-locale/custom-fields", "HEAD", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/menu-locale/custom-fields/{resourceId}", "HEAD", typeof(MenuLocaleController), "GetCustomFields")]
        [InlineData("/api/core/menu-locale/custom-fields/{resourceId}", "HEAD", typeof(MenuLocaleController), "GetCustomFields")]

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

        public MenuLocaleRouteTests()
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