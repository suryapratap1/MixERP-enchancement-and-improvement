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
    public class StorePolicyDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/delete/{storePolicyDetailId}", "DELETE", typeof(StorePolicyDetailController), "Delete")]
        [InlineData("/api/policy/store-policy-detail/delete/{storePolicyDetailId}", "DELETE", typeof(StorePolicyDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/edit/{storePolicyDetailId}", "PUT", typeof(StorePolicyDetailController), "Edit")]
        [InlineData("/api/policy/store-policy-detail/edit/{storePolicyDetailId}", "PUT", typeof(StorePolicyDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/count-where", "POST", typeof(StorePolicyDetailController), "CountWhere")]
        [InlineData("/api/policy/store-policy-detail/count-where", "POST", typeof(StorePolicyDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/get-where/{pageNumber}", "POST", typeof(StorePolicyDetailController), "GetWhere")]
        [InlineData("/api/policy/store-policy-detail/get-where/{pageNumber}", "POST", typeof(StorePolicyDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/add-or-edit", "POST", typeof(StorePolicyDetailController), "AddOrEdit")]
        [InlineData("/api/policy/store-policy-detail/add-or-edit", "POST", typeof(StorePolicyDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/add/{storePolicyDetail}", "POST", typeof(StorePolicyDetailController), "Add")]
        [InlineData("/api/policy/store-policy-detail/add/{storePolicyDetail}", "POST", typeof(StorePolicyDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/bulk-import", "POST", typeof(StorePolicyDetailController), "BulkImport")]
        [InlineData("/api/policy/store-policy-detail/bulk-import", "POST", typeof(StorePolicyDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/meta", "GET", typeof(StorePolicyDetailController), "GetEntityView")]
        [InlineData("/api/policy/store-policy-detail/meta", "GET", typeof(StorePolicyDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/count", "GET", typeof(StorePolicyDetailController), "Count")]
        [InlineData("/api/policy/store-policy-detail/count", "GET", typeof(StorePolicyDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/all", "GET", typeof(StorePolicyDetailController), "GetAll")]
        [InlineData("/api/policy/store-policy-detail/all", "GET", typeof(StorePolicyDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/export", "GET", typeof(StorePolicyDetailController), "Export")]
        [InlineData("/api/policy/store-policy-detail/export", "GET", typeof(StorePolicyDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/1", "GET", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/policy/store-policy-detail/1", "GET", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/get?storePolicyDetailIds=1", "GET", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/policy/store-policy-detail/get?storePolicyDetailIds=1", "GET", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail", "GET", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy-detail", "GET", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/page/1", "GET", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy-detail/page/1", "GET", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/count-filtered/{filterName}", "GET", typeof(StorePolicyDetailController), "CountFiltered")]
        [InlineData("/api/policy/store-policy-detail/count-filtered/{filterName}", "GET", typeof(StorePolicyDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StorePolicyDetailController), "GetFiltered")]
        [InlineData("/api/policy/store-policy-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StorePolicyDetailController), "GetFiltered")]
        [InlineData("/api/policy/store-policy-detail/first", "GET", typeof(StorePolicyDetailController), "GetFirst")]
        [InlineData("/api/policy/store-policy-detail/previous/1", "GET", typeof(StorePolicyDetailController), "GetPrevious")]
        [InlineData("/api/policy/store-policy-detail/next/1", "GET", typeof(StorePolicyDetailController), "GetNext")]
        [InlineData("/api/policy/store-policy-detail/last", "GET", typeof(StorePolicyDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/custom-fields", "GET", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy-detail/custom-fields", "GET", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/custom-fields/{resourceId}", "GET", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy-detail/custom-fields/{resourceId}", "GET", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/meta", "HEAD", typeof(StorePolicyDetailController), "GetEntityView")]
        [InlineData("/api/policy/store-policy-detail/meta", "HEAD", typeof(StorePolicyDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/count", "HEAD", typeof(StorePolicyDetailController), "Count")]
        [InlineData("/api/policy/store-policy-detail/count", "HEAD", typeof(StorePolicyDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/all", "HEAD", typeof(StorePolicyDetailController), "GetAll")]
        [InlineData("/api/policy/store-policy-detail/all", "HEAD", typeof(StorePolicyDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/export", "HEAD", typeof(StorePolicyDetailController), "Export")]
        [InlineData("/api/policy/store-policy-detail/export", "HEAD", typeof(StorePolicyDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/1", "HEAD", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/policy/store-policy-detail/1", "HEAD", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/get?storePolicyDetailIds=1", "HEAD", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/policy/store-policy-detail/get?storePolicyDetailIds=1", "HEAD", typeof(StorePolicyDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail", "HEAD", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy-detail", "HEAD", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/page/1", "HEAD", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/policy/store-policy-detail/page/1", "HEAD", typeof(StorePolicyDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/count-filtered/{filterName}", "HEAD", typeof(StorePolicyDetailController), "CountFiltered")]
        [InlineData("/api/policy/store-policy-detail/count-filtered/{filterName}", "HEAD", typeof(StorePolicyDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StorePolicyDetailController), "GetFiltered")]
        [InlineData("/api/policy/store-policy-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StorePolicyDetailController), "GetFiltered")]
        [InlineData("/api/policy/store-policy-detail/first", "HEAD", typeof(StorePolicyDetailController), "GetFirst")]
        [InlineData("/api/policy/store-policy-detail/previous/1", "HEAD", typeof(StorePolicyDetailController), "GetPrevious")]
        [InlineData("/api/policy/store-policy-detail/next/1", "HEAD", typeof(StorePolicyDetailController), "GetNext")]
        [InlineData("/api/policy/store-policy-detail/last", "HEAD", typeof(StorePolicyDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/custom-fields", "HEAD", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy-detail/custom-fields", "HEAD", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/store-policy-detail/custom-fields/{resourceId}", "HEAD", typeof(StorePolicyDetailController), "GetCustomFields")]
        [InlineData("/api/policy/store-policy-detail/custom-fields/{resourceId}", "HEAD", typeof(StorePolicyDetailController), "GetCustomFields")]

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

        public StorePolicyDetailRouteTests()
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