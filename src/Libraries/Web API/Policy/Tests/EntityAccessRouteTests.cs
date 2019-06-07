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
    public class EntityAccessRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/delete/{entityAccessId}", "DELETE", typeof(EntityAccessController), "Delete")]
        [InlineData("/api/policy/entity-access/delete/{entityAccessId}", "DELETE", typeof(EntityAccessController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/edit/{entityAccessId}", "PUT", typeof(EntityAccessController), "Edit")]
        [InlineData("/api/policy/entity-access/edit/{entityAccessId}", "PUT", typeof(EntityAccessController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/count-where", "POST", typeof(EntityAccessController), "CountWhere")]
        [InlineData("/api/policy/entity-access/count-where", "POST", typeof(EntityAccessController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/get-where/{pageNumber}", "POST", typeof(EntityAccessController), "GetWhere")]
        [InlineData("/api/policy/entity-access/get-where/{pageNumber}", "POST", typeof(EntityAccessController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/add-or-edit", "POST", typeof(EntityAccessController), "AddOrEdit")]
        [InlineData("/api/policy/entity-access/add-or-edit", "POST", typeof(EntityAccessController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/add/{entityAccess}", "POST", typeof(EntityAccessController), "Add")]
        [InlineData("/api/policy/entity-access/add/{entityAccess}", "POST", typeof(EntityAccessController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/bulk-import", "POST", typeof(EntityAccessController), "BulkImport")]
        [InlineData("/api/policy/entity-access/bulk-import", "POST", typeof(EntityAccessController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/meta", "GET", typeof(EntityAccessController), "GetEntityView")]
        [InlineData("/api/policy/entity-access/meta", "GET", typeof(EntityAccessController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/count", "GET", typeof(EntityAccessController), "Count")]
        [InlineData("/api/policy/entity-access/count", "GET", typeof(EntityAccessController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/all", "GET", typeof(EntityAccessController), "GetAll")]
        [InlineData("/api/policy/entity-access/all", "GET", typeof(EntityAccessController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/export", "GET", typeof(EntityAccessController), "Export")]
        [InlineData("/api/policy/entity-access/export", "GET", typeof(EntityAccessController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/1", "GET", typeof(EntityAccessController), "Get")]
        [InlineData("/api/policy/entity-access/1", "GET", typeof(EntityAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/get?entityAccessIds=1", "GET", typeof(EntityAccessController), "Get")]
        [InlineData("/api/policy/entity-access/get?entityAccessIds=1", "GET", typeof(EntityAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access", "GET", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/entity-access", "GET", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/page/1", "GET", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/entity-access/page/1", "GET", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/count-filtered/{filterName}", "GET", typeof(EntityAccessController), "CountFiltered")]
        [InlineData("/api/policy/entity-access/count-filtered/{filterName}", "GET", typeof(EntityAccessController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EntityAccessController), "GetFiltered")]
        [InlineData("/api/policy/entity-access/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EntityAccessController), "GetFiltered")]
        [InlineData("/api/policy/entity-access/first", "GET", typeof(EntityAccessController), "GetFirst")]
        [InlineData("/api/policy/entity-access/previous/1", "GET", typeof(EntityAccessController), "GetPrevious")]
        [InlineData("/api/policy/entity-access/next/1", "GET", typeof(EntityAccessController), "GetNext")]
        [InlineData("/api/policy/entity-access/last", "GET", typeof(EntityAccessController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/entity-access/custom-fields", "GET", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/policy/entity-access/custom-fields", "GET", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/custom-fields/{resourceId}", "GET", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/policy/entity-access/custom-fields/{resourceId}", "GET", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/meta", "HEAD", typeof(EntityAccessController), "GetEntityView")]
        [InlineData("/api/policy/entity-access/meta", "HEAD", typeof(EntityAccessController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/count", "HEAD", typeof(EntityAccessController), "Count")]
        [InlineData("/api/policy/entity-access/count", "HEAD", typeof(EntityAccessController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/all", "HEAD", typeof(EntityAccessController), "GetAll")]
        [InlineData("/api/policy/entity-access/all", "HEAD", typeof(EntityAccessController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/export", "HEAD", typeof(EntityAccessController), "Export")]
        [InlineData("/api/policy/entity-access/export", "HEAD", typeof(EntityAccessController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/1", "HEAD", typeof(EntityAccessController), "Get")]
        [InlineData("/api/policy/entity-access/1", "HEAD", typeof(EntityAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/get?entityAccessIds=1", "HEAD", typeof(EntityAccessController), "Get")]
        [InlineData("/api/policy/entity-access/get?entityAccessIds=1", "HEAD", typeof(EntityAccessController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access", "HEAD", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/entity-access", "HEAD", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/page/1", "HEAD", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/policy/entity-access/page/1", "HEAD", typeof(EntityAccessController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/count-filtered/{filterName}", "HEAD", typeof(EntityAccessController), "CountFiltered")]
        [InlineData("/api/policy/entity-access/count-filtered/{filterName}", "HEAD", typeof(EntityAccessController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EntityAccessController), "GetFiltered")]
        [InlineData("/api/policy/entity-access/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EntityAccessController), "GetFiltered")]
        [InlineData("/api/policy/entity-access/first", "HEAD", typeof(EntityAccessController), "GetFirst")]
        [InlineData("/api/policy/entity-access/previous/1", "HEAD", typeof(EntityAccessController), "GetPrevious")]
        [InlineData("/api/policy/entity-access/next/1", "HEAD", typeof(EntityAccessController), "GetNext")]
        [InlineData("/api/policy/entity-access/last", "HEAD", typeof(EntityAccessController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/entity-access/custom-fields", "HEAD", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/policy/entity-access/custom-fields", "HEAD", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/entity-access/custom-fields/{resourceId}", "HEAD", typeof(EntityAccessController), "GetCustomFields")]
        [InlineData("/api/policy/entity-access/custom-fields/{resourceId}", "HEAD", typeof(EntityAccessController), "GetCustomFields")]

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

        public EntityAccessRouteTests()
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