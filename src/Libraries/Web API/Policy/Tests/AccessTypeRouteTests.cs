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
    public class AccessTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/delete/{accessTypeId}", "DELETE", typeof(AccessTypeController), "Delete")]
        [InlineData("/api/policy/access-type/delete/{accessTypeId}", "DELETE", typeof(AccessTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/edit/{accessTypeId}", "PUT", typeof(AccessTypeController), "Edit")]
        [InlineData("/api/policy/access-type/edit/{accessTypeId}", "PUT", typeof(AccessTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/count-where", "POST", typeof(AccessTypeController), "CountWhere")]
        [InlineData("/api/policy/access-type/count-where", "POST", typeof(AccessTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/get-where/{pageNumber}", "POST", typeof(AccessTypeController), "GetWhere")]
        [InlineData("/api/policy/access-type/get-where/{pageNumber}", "POST", typeof(AccessTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/add-or-edit", "POST", typeof(AccessTypeController), "AddOrEdit")]
        [InlineData("/api/policy/access-type/add-or-edit", "POST", typeof(AccessTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/add/{accessType}", "POST", typeof(AccessTypeController), "Add")]
        [InlineData("/api/policy/access-type/add/{accessType}", "POST", typeof(AccessTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/bulk-import", "POST", typeof(AccessTypeController), "BulkImport")]
        [InlineData("/api/policy/access-type/bulk-import", "POST", typeof(AccessTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/meta", "GET", typeof(AccessTypeController), "GetEntityView")]
        [InlineData("/api/policy/access-type/meta", "GET", typeof(AccessTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/count", "GET", typeof(AccessTypeController), "Count")]
        [InlineData("/api/policy/access-type/count", "GET", typeof(AccessTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/all", "GET", typeof(AccessTypeController), "GetAll")]
        [InlineData("/api/policy/access-type/all", "GET", typeof(AccessTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/export", "GET", typeof(AccessTypeController), "Export")]
        [InlineData("/api/policy/access-type/export", "GET", typeof(AccessTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/1", "GET", typeof(AccessTypeController), "Get")]
        [InlineData("/api/policy/access-type/1", "GET", typeof(AccessTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/get?accessTypeIds=1", "GET", typeof(AccessTypeController), "Get")]
        [InlineData("/api/policy/access-type/get?accessTypeIds=1", "GET", typeof(AccessTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type", "GET", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/policy/access-type", "GET", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/page/1", "GET", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/policy/access-type/page/1", "GET", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/count-filtered/{filterName}", "GET", typeof(AccessTypeController), "CountFiltered")]
        [InlineData("/api/policy/access-type/count-filtered/{filterName}", "GET", typeof(AccessTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AccessTypeController), "GetFiltered")]
        [InlineData("/api/policy/access-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AccessTypeController), "GetFiltered")]
        [InlineData("/api/policy/access-type/first", "GET", typeof(AccessTypeController), "GetFirst")]
        [InlineData("/api/policy/access-type/previous/1", "GET", typeof(AccessTypeController), "GetPrevious")]
        [InlineData("/api/policy/access-type/next/1", "GET", typeof(AccessTypeController), "GetNext")]
        [InlineData("/api/policy/access-type/last", "GET", typeof(AccessTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/access-type/custom-fields", "GET", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/policy/access-type/custom-fields", "GET", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/custom-fields/{resourceId}", "GET", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/policy/access-type/custom-fields/{resourceId}", "GET", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/meta", "HEAD", typeof(AccessTypeController), "GetEntityView")]
        [InlineData("/api/policy/access-type/meta", "HEAD", typeof(AccessTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/count", "HEAD", typeof(AccessTypeController), "Count")]
        [InlineData("/api/policy/access-type/count", "HEAD", typeof(AccessTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/all", "HEAD", typeof(AccessTypeController), "GetAll")]
        [InlineData("/api/policy/access-type/all", "HEAD", typeof(AccessTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/export", "HEAD", typeof(AccessTypeController), "Export")]
        [InlineData("/api/policy/access-type/export", "HEAD", typeof(AccessTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/1", "HEAD", typeof(AccessTypeController), "Get")]
        [InlineData("/api/policy/access-type/1", "HEAD", typeof(AccessTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/get?accessTypeIds=1", "HEAD", typeof(AccessTypeController), "Get")]
        [InlineData("/api/policy/access-type/get?accessTypeIds=1", "HEAD", typeof(AccessTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type", "HEAD", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/policy/access-type", "HEAD", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/page/1", "HEAD", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/policy/access-type/page/1", "HEAD", typeof(AccessTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/count-filtered/{filterName}", "HEAD", typeof(AccessTypeController), "CountFiltered")]
        [InlineData("/api/policy/access-type/count-filtered/{filterName}", "HEAD", typeof(AccessTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AccessTypeController), "GetFiltered")]
        [InlineData("/api/policy/access-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AccessTypeController), "GetFiltered")]
        [InlineData("/api/policy/access-type/first", "HEAD", typeof(AccessTypeController), "GetFirst")]
        [InlineData("/api/policy/access-type/previous/1", "HEAD", typeof(AccessTypeController), "GetPrevious")]
        [InlineData("/api/policy/access-type/next/1", "HEAD", typeof(AccessTypeController), "GetNext")]
        [InlineData("/api/policy/access-type/last", "HEAD", typeof(AccessTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/access-type/custom-fields", "HEAD", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/policy/access-type/custom-fields", "HEAD", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/access-type/custom-fields/{resourceId}", "HEAD", typeof(AccessTypeController), "GetCustomFields")]
        [InlineData("/api/policy/access-type/custom-fields/{resourceId}", "HEAD", typeof(AccessTypeController), "GetCustomFields")]

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

        public AccessTypeRouteTests()
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