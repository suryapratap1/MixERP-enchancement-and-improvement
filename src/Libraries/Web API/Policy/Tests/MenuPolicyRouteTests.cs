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
    public class MenuPolicyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/delete/{policyId}", "DELETE", typeof(MenuPolicyController), "Delete")]
        [InlineData("/api/policy/menu-policy/delete/{policyId}", "DELETE", typeof(MenuPolicyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/edit/{policyId}", "PUT", typeof(MenuPolicyController), "Edit")]
        [InlineData("/api/policy/menu-policy/edit/{policyId}", "PUT", typeof(MenuPolicyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/count-where", "POST", typeof(MenuPolicyController), "CountWhere")]
        [InlineData("/api/policy/menu-policy/count-where", "POST", typeof(MenuPolicyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/get-where/{pageNumber}", "POST", typeof(MenuPolicyController), "GetWhere")]
        [InlineData("/api/policy/menu-policy/get-where/{pageNumber}", "POST", typeof(MenuPolicyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/add-or-edit", "POST", typeof(MenuPolicyController), "AddOrEdit")]
        [InlineData("/api/policy/menu-policy/add-or-edit", "POST", typeof(MenuPolicyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/add/{menuPolicy}", "POST", typeof(MenuPolicyController), "Add")]
        [InlineData("/api/policy/menu-policy/add/{menuPolicy}", "POST", typeof(MenuPolicyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/bulk-import", "POST", typeof(MenuPolicyController), "BulkImport")]
        [InlineData("/api/policy/menu-policy/bulk-import", "POST", typeof(MenuPolicyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/meta", "GET", typeof(MenuPolicyController), "GetEntityView")]
        [InlineData("/api/policy/menu-policy/meta", "GET", typeof(MenuPolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/count", "GET", typeof(MenuPolicyController), "Count")]
        [InlineData("/api/policy/menu-policy/count", "GET", typeof(MenuPolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/all", "GET", typeof(MenuPolicyController), "GetAll")]
        [InlineData("/api/policy/menu-policy/all", "GET", typeof(MenuPolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/export", "GET", typeof(MenuPolicyController), "Export")]
        [InlineData("/api/policy/menu-policy/export", "GET", typeof(MenuPolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/1", "GET", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/policy/menu-policy/1", "GET", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/get?policyIds=1", "GET", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/policy/menu-policy/get?policyIds=1", "GET", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy", "GET", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-policy", "GET", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/page/1", "GET", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-policy/page/1", "GET", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/count-filtered/{filterName}", "GET", typeof(MenuPolicyController), "CountFiltered")]
        [InlineData("/api/policy/menu-policy/count-filtered/{filterName}", "GET", typeof(MenuPolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MenuPolicyController), "GetFiltered")]
        [InlineData("/api/policy/menu-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MenuPolicyController), "GetFiltered")]
        [InlineData("/api/policy/menu-policy/first", "GET", typeof(MenuPolicyController), "GetFirst")]
        [InlineData("/api/policy/menu-policy/previous/1", "GET", typeof(MenuPolicyController), "GetPrevious")]
        [InlineData("/api/policy/menu-policy/next/1", "GET", typeof(MenuPolicyController), "GetNext")]
        [InlineData("/api/policy/menu-policy/last", "GET", typeof(MenuPolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/custom-fields", "GET", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/menu-policy/custom-fields", "GET", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/custom-fields/{resourceId}", "GET", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/menu-policy/custom-fields/{resourceId}", "GET", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/meta", "HEAD", typeof(MenuPolicyController), "GetEntityView")]
        [InlineData("/api/policy/menu-policy/meta", "HEAD", typeof(MenuPolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/count", "HEAD", typeof(MenuPolicyController), "Count")]
        [InlineData("/api/policy/menu-policy/count", "HEAD", typeof(MenuPolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/all", "HEAD", typeof(MenuPolicyController), "GetAll")]
        [InlineData("/api/policy/menu-policy/all", "HEAD", typeof(MenuPolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/export", "HEAD", typeof(MenuPolicyController), "Export")]
        [InlineData("/api/policy/menu-policy/export", "HEAD", typeof(MenuPolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/1", "HEAD", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/policy/menu-policy/1", "HEAD", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/get?policyIds=1", "HEAD", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/policy/menu-policy/get?policyIds=1", "HEAD", typeof(MenuPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy", "HEAD", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-policy", "HEAD", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/page/1", "HEAD", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/menu-policy/page/1", "HEAD", typeof(MenuPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/count-filtered/{filterName}", "HEAD", typeof(MenuPolicyController), "CountFiltered")]
        [InlineData("/api/policy/menu-policy/count-filtered/{filterName}", "HEAD", typeof(MenuPolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MenuPolicyController), "GetFiltered")]
        [InlineData("/api/policy/menu-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MenuPolicyController), "GetFiltered")]
        [InlineData("/api/policy/menu-policy/first", "HEAD", typeof(MenuPolicyController), "GetFirst")]
        [InlineData("/api/policy/menu-policy/previous/1", "HEAD", typeof(MenuPolicyController), "GetPrevious")]
        [InlineData("/api/policy/menu-policy/next/1", "HEAD", typeof(MenuPolicyController), "GetNext")]
        [InlineData("/api/policy/menu-policy/last", "HEAD", typeof(MenuPolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/custom-fields", "HEAD", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/menu-policy/custom-fields", "HEAD", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/menu-policy/custom-fields/{resourceId}", "HEAD", typeof(MenuPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/menu-policy/custom-fields/{resourceId}", "HEAD", typeof(MenuPolicyController), "GetCustomFields")]

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

        public MenuPolicyRouteTests()
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