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
    public class ScrudFactoryRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/delete/{key}", "DELETE", typeof(ScrudFactoryController), "Delete")]
        [InlineData("/api/config/scrud-factory/delete/{key}", "DELETE", typeof(ScrudFactoryController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/edit/{key}", "PUT", typeof(ScrudFactoryController), "Edit")]
        [InlineData("/api/config/scrud-factory/edit/{key}", "PUT", typeof(ScrudFactoryController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/count-where", "POST", typeof(ScrudFactoryController), "CountWhere")]
        [InlineData("/api/config/scrud-factory/count-where", "POST", typeof(ScrudFactoryController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/get-where/{pageNumber}", "POST", typeof(ScrudFactoryController), "GetWhere")]
        [InlineData("/api/config/scrud-factory/get-where/{pageNumber}", "POST", typeof(ScrudFactoryController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/add-or-edit", "POST", typeof(ScrudFactoryController), "AddOrEdit")]
        [InlineData("/api/config/scrud-factory/add-or-edit", "POST", typeof(ScrudFactoryController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/add/{scrudFactory}", "POST", typeof(ScrudFactoryController), "Add")]
        [InlineData("/api/config/scrud-factory/add/{scrudFactory}", "POST", typeof(ScrudFactoryController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/bulk-import", "POST", typeof(ScrudFactoryController), "BulkImport")]
        [InlineData("/api/config/scrud-factory/bulk-import", "POST", typeof(ScrudFactoryController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/meta", "GET", typeof(ScrudFactoryController), "GetEntityView")]
        [InlineData("/api/config/scrud-factory/meta", "GET", typeof(ScrudFactoryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/count", "GET", typeof(ScrudFactoryController), "Count")]
        [InlineData("/api/config/scrud-factory/count", "GET", typeof(ScrudFactoryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/all", "GET", typeof(ScrudFactoryController), "GetAll")]
        [InlineData("/api/config/scrud-factory/all", "GET", typeof(ScrudFactoryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/export", "GET", typeof(ScrudFactoryController), "Export")]
        [InlineData("/api/config/scrud-factory/export", "GET", typeof(ScrudFactoryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/1", "GET", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/config/scrud-factory/1", "GET", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/get?keys=1", "GET", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/config/scrud-factory/get?keys=1", "GET", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory", "GET", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/scrud-factory", "GET", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/page/1", "GET", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/scrud-factory/page/1", "GET", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/count-filtered/{filterName}", "GET", typeof(ScrudFactoryController), "CountFiltered")]
        [InlineData("/api/config/scrud-factory/count-filtered/{filterName}", "GET", typeof(ScrudFactoryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ScrudFactoryController), "GetFiltered")]
        [InlineData("/api/config/scrud-factory/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ScrudFactoryController), "GetFiltered")]
        [InlineData("/api/config/scrud-factory/first", "GET", typeof(ScrudFactoryController), "GetFirst")]
        [InlineData("/api/config/scrud-factory/previous/1", "GET", typeof(ScrudFactoryController), "GetPrevious")]
        [InlineData("/api/config/scrud-factory/next/1", "GET", typeof(ScrudFactoryController), "GetNext")]
        [InlineData("/api/config/scrud-factory/last", "GET", typeof(ScrudFactoryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/custom-fields", "GET", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/config/scrud-factory/custom-fields", "GET", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/custom-fields/{resourceId}", "GET", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/config/scrud-factory/custom-fields/{resourceId}", "GET", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/meta", "HEAD", typeof(ScrudFactoryController), "GetEntityView")]
        [InlineData("/api/config/scrud-factory/meta", "HEAD", typeof(ScrudFactoryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/count", "HEAD", typeof(ScrudFactoryController), "Count")]
        [InlineData("/api/config/scrud-factory/count", "HEAD", typeof(ScrudFactoryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/all", "HEAD", typeof(ScrudFactoryController), "GetAll")]
        [InlineData("/api/config/scrud-factory/all", "HEAD", typeof(ScrudFactoryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/export", "HEAD", typeof(ScrudFactoryController), "Export")]
        [InlineData("/api/config/scrud-factory/export", "HEAD", typeof(ScrudFactoryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/1", "HEAD", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/config/scrud-factory/1", "HEAD", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/get?keys=1", "HEAD", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/config/scrud-factory/get?keys=1", "HEAD", typeof(ScrudFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory", "HEAD", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/scrud-factory", "HEAD", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/page/1", "HEAD", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/scrud-factory/page/1", "HEAD", typeof(ScrudFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/count-filtered/{filterName}", "HEAD", typeof(ScrudFactoryController), "CountFiltered")]
        [InlineData("/api/config/scrud-factory/count-filtered/{filterName}", "HEAD", typeof(ScrudFactoryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ScrudFactoryController), "GetFiltered")]
        [InlineData("/api/config/scrud-factory/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ScrudFactoryController), "GetFiltered")]
        [InlineData("/api/config/scrud-factory/first", "HEAD", typeof(ScrudFactoryController), "GetFirst")]
        [InlineData("/api/config/scrud-factory/previous/1", "HEAD", typeof(ScrudFactoryController), "GetPrevious")]
        [InlineData("/api/config/scrud-factory/next/1", "HEAD", typeof(ScrudFactoryController), "GetNext")]
        [InlineData("/api/config/scrud-factory/last", "HEAD", typeof(ScrudFactoryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/custom-fields", "HEAD", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/config/scrud-factory/custom-fields", "HEAD", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/scrud-factory/custom-fields/{resourceId}", "HEAD", typeof(ScrudFactoryController), "GetCustomFields")]
        [InlineData("/api/config/scrud-factory/custom-fields/{resourceId}", "HEAD", typeof(ScrudFactoryController), "GetCustomFields")]

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

        public ScrudFactoryRouteTests()
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