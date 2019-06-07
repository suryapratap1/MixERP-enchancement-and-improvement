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

namespace MixERP.Net.Api.Audit.Tests
{
    public class LoginRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/audit/login/delete/{loginId}", "DELETE", typeof(LoginController), "Delete")]
        [InlineData("/api/audit/login/delete/{loginId}", "DELETE", typeof(LoginController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/audit/login/edit/{loginId}", "PUT", typeof(LoginController), "Edit")]
        [InlineData("/api/audit/login/edit/{loginId}", "PUT", typeof(LoginController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/audit/login/count-where", "POST", typeof(LoginController), "CountWhere")]
        [InlineData("/api/audit/login/count-where", "POST", typeof(LoginController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/audit/login/get-where/{pageNumber}", "POST", typeof(LoginController), "GetWhere")]
        [InlineData("/api/audit/login/get-where/{pageNumber}", "POST", typeof(LoginController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/audit/login/add-or-edit", "POST", typeof(LoginController), "AddOrEdit")]
        [InlineData("/api/audit/login/add-or-edit", "POST", typeof(LoginController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/audit/login/add/{login}", "POST", typeof(LoginController), "Add")]
        [InlineData("/api/audit/login/add/{login}", "POST", typeof(LoginController), "Add")]
        [InlineData("/api/{apiVersionNumber}/audit/login/bulk-import", "POST", typeof(LoginController), "BulkImport")]
        [InlineData("/api/audit/login/bulk-import", "POST", typeof(LoginController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/audit/login/meta", "GET", typeof(LoginController), "GetEntityView")]
        [InlineData("/api/audit/login/meta", "GET", typeof(LoginController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/audit/login/count", "GET", typeof(LoginController), "Count")]
        [InlineData("/api/audit/login/count", "GET", typeof(LoginController), "Count")]
        [InlineData("/api/{apiVersionNumber}/audit/login/all", "GET", typeof(LoginController), "GetAll")]
        [InlineData("/api/audit/login/all", "GET", typeof(LoginController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/audit/login/export", "GET", typeof(LoginController), "Export")]
        [InlineData("/api/audit/login/export", "GET", typeof(LoginController), "Export")]
        [InlineData("/api/{apiVersionNumber}/audit/login/1", "GET", typeof(LoginController), "Get")]
        [InlineData("/api/audit/login/1", "GET", typeof(LoginController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/login/get?loginIds=1", "GET", typeof(LoginController), "Get")]
        [InlineData("/api/audit/login/get?loginIds=1", "GET", typeof(LoginController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/login", "GET", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/audit/login", "GET", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/login/page/1", "GET", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/audit/login/page/1", "GET", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/login/count-filtered/{filterName}", "GET", typeof(LoginController), "CountFiltered")]
        [InlineData("/api/audit/login/count-filtered/{filterName}", "GET", typeof(LoginController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/audit/login/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LoginController), "GetFiltered")]
        [InlineData("/api/audit/login/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LoginController), "GetFiltered")]
        [InlineData("/api/audit/login/first", "GET", typeof(LoginController), "GetFirst")]
        [InlineData("/api/audit/login/previous/1", "GET", typeof(LoginController), "GetPrevious")]
        [InlineData("/api/audit/login/next/1", "GET", typeof(LoginController), "GetNext")]
        [InlineData("/api/audit/login/last", "GET", typeof(LoginController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/audit/login/custom-fields", "GET", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/audit/login/custom-fields", "GET", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/audit/login/custom-fields/{resourceId}", "GET", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/audit/login/custom-fields/{resourceId}", "GET", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/audit/login/meta", "HEAD", typeof(LoginController), "GetEntityView")]
        [InlineData("/api/audit/login/meta", "HEAD", typeof(LoginController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/audit/login/count", "HEAD", typeof(LoginController), "Count")]
        [InlineData("/api/audit/login/count", "HEAD", typeof(LoginController), "Count")]
        [InlineData("/api/{apiVersionNumber}/audit/login/all", "HEAD", typeof(LoginController), "GetAll")]
        [InlineData("/api/audit/login/all", "HEAD", typeof(LoginController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/audit/login/export", "HEAD", typeof(LoginController), "Export")]
        [InlineData("/api/audit/login/export", "HEAD", typeof(LoginController), "Export")]
        [InlineData("/api/{apiVersionNumber}/audit/login/1", "HEAD", typeof(LoginController), "Get")]
        [InlineData("/api/audit/login/1", "HEAD", typeof(LoginController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/login/get?loginIds=1", "HEAD", typeof(LoginController), "Get")]
        [InlineData("/api/audit/login/get?loginIds=1", "HEAD", typeof(LoginController), "Get")]
        [InlineData("/api/{apiVersionNumber}/audit/login", "HEAD", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/audit/login", "HEAD", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/login/page/1", "HEAD", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/audit/login/page/1", "HEAD", typeof(LoginController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/audit/login/count-filtered/{filterName}", "HEAD", typeof(LoginController), "CountFiltered")]
        [InlineData("/api/audit/login/count-filtered/{filterName}", "HEAD", typeof(LoginController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/audit/login/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LoginController), "GetFiltered")]
        [InlineData("/api/audit/login/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LoginController), "GetFiltered")]
        [InlineData("/api/audit/login/first", "HEAD", typeof(LoginController), "GetFirst")]
        [InlineData("/api/audit/login/previous/1", "HEAD", typeof(LoginController), "GetPrevious")]
        [InlineData("/api/audit/login/next/1", "HEAD", typeof(LoginController), "GetNext")]
        [InlineData("/api/audit/login/last", "HEAD", typeof(LoginController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/audit/login/custom-fields", "HEAD", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/audit/login/custom-fields", "HEAD", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/audit/login/custom-fields/{resourceId}", "HEAD", typeof(LoginController), "GetCustomFields")]
        [InlineData("/api/audit/login/custom-fields/{resourceId}", "HEAD", typeof(LoginController), "GetCustomFields")]

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

        public LoginRouteTests()
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