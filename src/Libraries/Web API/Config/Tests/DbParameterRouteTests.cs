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

namespace MixERP.Net.Api.Config.Tests
{
    public class DbParameterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/delete/{key}", "DELETE", typeof(DbParameterController), "Delete")]
        [InlineData("/api/config/db-parameter/delete/{key}", "DELETE", typeof(DbParameterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/edit/{key}", "PUT", typeof(DbParameterController), "Edit")]
        [InlineData("/api/config/db-parameter/edit/{key}", "PUT", typeof(DbParameterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/count-where", "POST", typeof(DbParameterController), "CountWhere")]
        [InlineData("/api/config/db-parameter/count-where", "POST", typeof(DbParameterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/get-where/{pageNumber}", "POST", typeof(DbParameterController), "GetWhere")]
        [InlineData("/api/config/db-parameter/get-where/{pageNumber}", "POST", typeof(DbParameterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/add-or-edit", "POST", typeof(DbParameterController), "AddOrEdit")]
        [InlineData("/api/config/db-parameter/add-or-edit", "POST", typeof(DbParameterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/add/{dbParameter}", "POST", typeof(DbParameterController), "Add")]
        [InlineData("/api/config/db-parameter/add/{dbParameter}", "POST", typeof(DbParameterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/bulk-import", "POST", typeof(DbParameterController), "BulkImport")]
        [InlineData("/api/config/db-parameter/bulk-import", "POST", typeof(DbParameterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/meta", "GET", typeof(DbParameterController), "GetEntityView")]
        [InlineData("/api/config/db-parameter/meta", "GET", typeof(DbParameterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/count", "GET", typeof(DbParameterController), "Count")]
        [InlineData("/api/config/db-parameter/count", "GET", typeof(DbParameterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/all", "GET", typeof(DbParameterController), "GetAll")]
        [InlineData("/api/config/db-parameter/all", "GET", typeof(DbParameterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/export", "GET", typeof(DbParameterController), "Export")]
        [InlineData("/api/config/db-parameter/export", "GET", typeof(DbParameterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/1", "GET", typeof(DbParameterController), "Get")]
        [InlineData("/api/config/db-parameter/1", "GET", typeof(DbParameterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/get?keys=1", "GET", typeof(DbParameterController), "Get")]
        [InlineData("/api/config/db-parameter/get?keys=1", "GET", typeof(DbParameterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter", "GET", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter", "GET", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/page/1", "GET", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter/page/1", "GET", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/count-filtered/{filterName}", "GET", typeof(DbParameterController), "CountFiltered")]
        [InlineData("/api/config/db-parameter/count-filtered/{filterName}", "GET", typeof(DbParameterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DbParameterController), "GetFiltered")]
        [InlineData("/api/config/db-parameter/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DbParameterController), "GetFiltered")]
        [InlineData("/api/config/db-parameter/first", "GET", typeof(DbParameterController), "GetFirst")]
        [InlineData("/api/config/db-parameter/previous/1", "GET", typeof(DbParameterController), "GetPrevious")]
        [InlineData("/api/config/db-parameter/next/1", "GET", typeof(DbParameterController), "GetNext")]
        [InlineData("/api/config/db-parameter/last", "GET", typeof(DbParameterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/db-parameter/custom-fields", "GET", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/config/db-parameter/custom-fields", "GET", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/custom-fields/{resourceId}", "GET", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/config/db-parameter/custom-fields/{resourceId}", "GET", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/meta", "HEAD", typeof(DbParameterController), "GetEntityView")]
        [InlineData("/api/config/db-parameter/meta", "HEAD", typeof(DbParameterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/count", "HEAD", typeof(DbParameterController), "Count")]
        [InlineData("/api/config/db-parameter/count", "HEAD", typeof(DbParameterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/all", "HEAD", typeof(DbParameterController), "GetAll")]
        [InlineData("/api/config/db-parameter/all", "HEAD", typeof(DbParameterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/export", "HEAD", typeof(DbParameterController), "Export")]
        [InlineData("/api/config/db-parameter/export", "HEAD", typeof(DbParameterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/1", "HEAD", typeof(DbParameterController), "Get")]
        [InlineData("/api/config/db-parameter/1", "HEAD", typeof(DbParameterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/get?keys=1", "HEAD", typeof(DbParameterController), "Get")]
        [InlineData("/api/config/db-parameter/get?keys=1", "HEAD", typeof(DbParameterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter", "HEAD", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter", "HEAD", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/page/1", "HEAD", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/config/db-parameter/page/1", "HEAD", typeof(DbParameterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/count-filtered/{filterName}", "HEAD", typeof(DbParameterController), "CountFiltered")]
        [InlineData("/api/config/db-parameter/count-filtered/{filterName}", "HEAD", typeof(DbParameterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DbParameterController), "GetFiltered")]
        [InlineData("/api/config/db-parameter/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DbParameterController), "GetFiltered")]
        [InlineData("/api/config/db-parameter/first", "HEAD", typeof(DbParameterController), "GetFirst")]
        [InlineData("/api/config/db-parameter/previous/1", "HEAD", typeof(DbParameterController), "GetPrevious")]
        [InlineData("/api/config/db-parameter/next/1", "HEAD", typeof(DbParameterController), "GetNext")]
        [InlineData("/api/config/db-parameter/last", "HEAD", typeof(DbParameterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/db-parameter/custom-fields", "HEAD", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/config/db-parameter/custom-fields", "HEAD", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/db-parameter/custom-fields/{resourceId}", "HEAD", typeof(DbParameterController), "GetCustomFields")]
        [InlineData("/api/config/db-parameter/custom-fields/{resourceId}", "HEAD", typeof(DbParameterController), "GetCustomFields")]

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

        public DbParameterRouteTests()
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