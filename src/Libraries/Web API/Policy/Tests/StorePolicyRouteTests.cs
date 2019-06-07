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
    public class StorePolicyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/delete/{storePolicyId}", "DELETE", typeof(StorePolicyController), "Delete")]
        [InlineData("/api/policy/store-policy/delete/{storePolicyId}", "DELETE", typeof(StorePolicyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/edit/{storePolicyId}", "PUT", typeof(StorePolicyController), "Edit")]
        [InlineData("/api/policy/store-policy/edit/{storePolicyId}", "PUT", typeof(StorePolicyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/count-where", "POST", typeof(StorePolicyController), "CountWhere")]
        [InlineData("/api/policy/store-policy/count-where", "POST", typeof(StorePolicyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/get-where/{pageNumber}", "POST", typeof(StorePolicyController), "GetWhere")]
        [InlineData("/api/policy/store-policy/get-where/{pageNumber}", "POST", typeof(StorePolicyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/add-or-edit", "POST", typeof(StorePolicyController), "AddOrEdit")]
        [InlineData("/api/policy/store-policy/add-or-edit", "POST", typeof(StorePolicyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/add/{storePolicy}", "POST", typeof(StorePolicyController), "Add")]
        [InlineData("/api/policy/store-policy/add/{storePolicy}", "POST", typeof(StorePolicyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/bulk-import", "POST", typeof(StorePolicyController), "BulkImport")]
        [InlineData("/api/policy/store-policy/bulk-import", "POST", typeof(StorePolicyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/meta", "GET", typeof(StorePolicyController), "GetEntityView")]
        [InlineData("/api/policy/store-policy/meta", "GET", typeof(StorePolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/count", "GET", typeof(StorePolicyController), "Count")]
        [InlineData("/api/policy/store-policy/count", "GET", typeof(StorePolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/all", "GET", typeof(StorePolicyController), "GetAll")]
        [InlineData("/api/policy/store-policy/all", "GET", typeof(StorePolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/export", "GET", typeof(StorePolicyController), "Export")]
        [InlineData("/api/policy/store-policy/export", "GET", typeof(StorePolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/1", "GET", typeof(StorePolicyController), "Get")]
        [InlineData("/api/policy/store-policy/1", "GET", typeof(StorePolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/get?storePolicyIds=1", "GET", typeof(StorePolicyController), "Get")]
        [InlineData("/api/policy/store-policy/get?storePolicyIds=1", "GET", typeof(StorePolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy", "GET", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy", "GET", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/page/1", "GET", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy/page/1", "GET", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/count-filtered/{filterName}", "GET", typeof(StorePolicyController), "CountFiltered")]
        [InlineData("/api/policy/store-policy/count-filtered/{filterName}", "GET", typeof(StorePolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StorePolicyController), "GetFiltered")]
        [InlineData("/api/policy/store-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StorePolicyController), "GetFiltered")]
        [InlineData("/api/policy/store-policy/first", "GET", typeof(StorePolicyController), "GetFirst")]
        [InlineData("/api/policy/store-policy/previous/1", "GET", typeof(StorePolicyController), "GetPrevious")]
        [InlineData("/api/policy/store-policy/next/1", "GET", typeof(StorePolicyController), "GetNext")]
        [InlineData("/api/policy/store-policy/last", "GET", typeof(StorePolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/store-policy/custom-fields", "GET", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy/custom-fields", "GET", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/custom-fields/{resourceId}", "GET", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy/custom-fields/{resourceId}", "GET", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/meta", "HEAD", typeof(StorePolicyController), "GetEntityView")]
        [InlineData("/api/policy/store-policy/meta", "HEAD", typeof(StorePolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/count", "HEAD", typeof(StorePolicyController), "Count")]
        [InlineData("/api/policy/store-policy/count", "HEAD", typeof(StorePolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/all", "HEAD", typeof(StorePolicyController), "GetAll")]
        [InlineData("/api/policy/store-policy/all", "HEAD", typeof(StorePolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/export", "HEAD", typeof(StorePolicyController), "Export")]
        [InlineData("/api/policy/store-policy/export", "HEAD", typeof(StorePolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/1", "HEAD", typeof(StorePolicyController), "Get")]
        [InlineData("/api/policy/store-policy/1", "HEAD", typeof(StorePolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/get?storePolicyIds=1", "HEAD", typeof(StorePolicyController), "Get")]
        [InlineData("/api/policy/store-policy/get?storePolicyIds=1", "HEAD", typeof(StorePolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy", "HEAD", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy", "HEAD", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/page/1", "HEAD", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy/page/1", "HEAD", typeof(StorePolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/count-filtered/{filterName}", "HEAD", typeof(StorePolicyController), "CountFiltered")]
        [InlineData("/api/policy/store-policy/count-filtered/{filterName}", "HEAD", typeof(StorePolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StorePolicyController), "GetFiltered")]
        [InlineData("/api/policy/store-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StorePolicyController), "GetFiltered")]
        [InlineData("/api/policy/store-policy/first", "HEAD", typeof(StorePolicyController), "GetFirst")]
        [InlineData("/api/policy/store-policy/previous/1", "HEAD", typeof(StorePolicyController), "GetPrevious")]
        [InlineData("/api/policy/store-policy/next/1", "HEAD", typeof(StorePolicyController), "GetNext")]
        [InlineData("/api/policy/store-policy/last", "HEAD", typeof(StorePolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/store-policy/custom-fields", "HEAD", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy/custom-fields", "HEAD", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy/custom-fields/{resourceId}", "HEAD", typeof(StorePolicyController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy/custom-fields/{resourceId}", "HEAD", typeof(StorePolicyController), "GetCustomFields")]

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

        public StorePolicyRouteTests()
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