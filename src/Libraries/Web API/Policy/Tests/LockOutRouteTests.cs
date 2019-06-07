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
    public class LockOutRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/delete/{lockOutId}", "DELETE", typeof(LockOutController), "Delete")]
        [InlineData("/api/policy/lock-out/delete/{lockOutId}", "DELETE", typeof(LockOutController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/edit/{lockOutId}", "PUT", typeof(LockOutController), "Edit")]
        [InlineData("/api/policy/lock-out/edit/{lockOutId}", "PUT", typeof(LockOutController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/count-where", "POST", typeof(LockOutController), "CountWhere")]
        [InlineData("/api/policy/lock-out/count-where", "POST", typeof(LockOutController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/get-where/{pageNumber}", "POST", typeof(LockOutController), "GetWhere")]
        [InlineData("/api/policy/lock-out/get-where/{pageNumber}", "POST", typeof(LockOutController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/add-or-edit", "POST", typeof(LockOutController), "AddOrEdit")]
        [InlineData("/api/policy/lock-out/add-or-edit", "POST", typeof(LockOutController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/add/{lockOut}", "POST", typeof(LockOutController), "Add")]
        [InlineData("/api/policy/lock-out/add/{lockOut}", "POST", typeof(LockOutController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/bulk-import", "POST", typeof(LockOutController), "BulkImport")]
        [InlineData("/api/policy/lock-out/bulk-import", "POST", typeof(LockOutController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/meta", "GET", typeof(LockOutController), "GetEntityView")]
        [InlineData("/api/policy/lock-out/meta", "GET", typeof(LockOutController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/count", "GET", typeof(LockOutController), "Count")]
        [InlineData("/api/policy/lock-out/count", "GET", typeof(LockOutController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/all", "GET", typeof(LockOutController), "GetAll")]
        [InlineData("/api/policy/lock-out/all", "GET", typeof(LockOutController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/export", "GET", typeof(LockOutController), "Export")]
        [InlineData("/api/policy/lock-out/export", "GET", typeof(LockOutController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/1", "GET", typeof(LockOutController), "Get")]
        [InlineData("/api/policy/lock-out/1", "GET", typeof(LockOutController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/get?lockOutIds=1", "GET", typeof(LockOutController), "Get")]
        [InlineData("/api/policy/lock-out/get?lockOutIds=1", "GET", typeof(LockOutController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out", "GET", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/policy/lock-out", "GET", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/page/1", "GET", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/policy/lock-out/page/1", "GET", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/count-filtered/{filterName}", "GET", typeof(LockOutController), "CountFiltered")]
        [InlineData("/api/policy/lock-out/count-filtered/{filterName}", "GET", typeof(LockOutController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LockOutController), "GetFiltered")]
        [InlineData("/api/policy/lock-out/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LockOutController), "GetFiltered")]
        [InlineData("/api/policy/lock-out/first", "GET", typeof(LockOutController), "GetFirst")]
        [InlineData("/api/policy/lock-out/previous/1", "GET", typeof(LockOutController), "GetPrevious")]
        [InlineData("/api/policy/lock-out/next/1", "GET", typeof(LockOutController), "GetNext")]
        [InlineData("/api/policy/lock-out/last", "GET", typeof(LockOutController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/lock-out/custom-fields", "GET", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/policy/lock-out/custom-fields", "GET", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/custom-fields/{resourceId}", "GET", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/policy/lock-out/custom-fields/{resourceId}", "GET", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/meta", "HEAD", typeof(LockOutController), "GetEntityView")]
        [InlineData("/api/policy/lock-out/meta", "HEAD", typeof(LockOutController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/count", "HEAD", typeof(LockOutController), "Count")]
        [InlineData("/api/policy/lock-out/count", "HEAD", typeof(LockOutController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/all", "HEAD", typeof(LockOutController), "GetAll")]
        [InlineData("/api/policy/lock-out/all", "HEAD", typeof(LockOutController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/export", "HEAD", typeof(LockOutController), "Export")]
        [InlineData("/api/policy/lock-out/export", "HEAD", typeof(LockOutController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/1", "HEAD", typeof(LockOutController), "Get")]
        [InlineData("/api/policy/lock-out/1", "HEAD", typeof(LockOutController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/get?lockOutIds=1", "HEAD", typeof(LockOutController), "Get")]
        [InlineData("/api/policy/lock-out/get?lockOutIds=1", "HEAD", typeof(LockOutController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out", "HEAD", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/policy/lock-out", "HEAD", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/page/1", "HEAD", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/policy/lock-out/page/1", "HEAD", typeof(LockOutController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/count-filtered/{filterName}", "HEAD", typeof(LockOutController), "CountFiltered")]
        [InlineData("/api/policy/lock-out/count-filtered/{filterName}", "HEAD", typeof(LockOutController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LockOutController), "GetFiltered")]
        [InlineData("/api/policy/lock-out/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LockOutController), "GetFiltered")]
        [InlineData("/api/policy/lock-out/first", "HEAD", typeof(LockOutController), "GetFirst")]
        [InlineData("/api/policy/lock-out/previous/1", "HEAD", typeof(LockOutController), "GetPrevious")]
        [InlineData("/api/policy/lock-out/next/1", "HEAD", typeof(LockOutController), "GetNext")]
        [InlineData("/api/policy/lock-out/last", "HEAD", typeof(LockOutController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/lock-out/custom-fields", "HEAD", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/policy/lock-out/custom-fields", "HEAD", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/lock-out/custom-fields/{resourceId}", "HEAD", typeof(LockOutController), "GetCustomFields")]
        [InlineData("/api/policy/lock-out/custom-fields/{resourceId}", "HEAD", typeof(LockOutController), "GetCustomFields")]

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

        public LockOutRouteTests()
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