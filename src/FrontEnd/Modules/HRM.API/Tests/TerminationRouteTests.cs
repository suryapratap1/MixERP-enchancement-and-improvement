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

namespace MixERP.Net.Api.HRM.Tests
{
    public class TerminationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/delete/{terminationId}", "DELETE", typeof(TerminationController), "Delete")]
        [InlineData("/api/hrm/termination/delete/{terminationId}", "DELETE", typeof(TerminationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/edit/{terminationId}", "PUT", typeof(TerminationController), "Edit")]
        [InlineData("/api/hrm/termination/edit/{terminationId}", "PUT", typeof(TerminationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/verify/{terminationId}/{verificationStatusId}/{reason}", "PUT", typeof(TerminationController), "Verifiy")]
        [InlineData("/api/hrm/termination/verify/{terminationId}/{verificationStatusId}/{reason}", "PUT", typeof(TerminationController), "Verifiy")]

        [InlineData("/api/{apiVersionNumber}/hrm/termination/count-where", "POST", typeof(TerminationController), "CountWhere")]
        [InlineData("/api/hrm/termination/count-where", "POST", typeof(TerminationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/get-where/{pageNumber}", "POST", typeof(TerminationController), "GetWhere")]
        [InlineData("/api/hrm/termination/get-where/{pageNumber}", "POST", typeof(TerminationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/add-or-edit", "POST", typeof(TerminationController), "AddOrEdit")]
        [InlineData("/api/hrm/termination/add-or-edit", "POST", typeof(TerminationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/add/{termination}", "POST", typeof(TerminationController), "Add")]
        [InlineData("/api/hrm/termination/add/{termination}", "POST", typeof(TerminationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/bulk-import", "POST", typeof(TerminationController), "BulkImport")]
        [InlineData("/api/hrm/termination/bulk-import", "POST", typeof(TerminationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/meta", "GET", typeof(TerminationController), "GetEntityView")]
        [InlineData("/api/hrm/termination/meta", "GET", typeof(TerminationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/count", "GET", typeof(TerminationController), "Count")]
        [InlineData("/api/hrm/termination/count", "GET", typeof(TerminationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/all", "GET", typeof(TerminationController), "GetAll")]
        [InlineData("/api/hrm/termination/all", "GET", typeof(TerminationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/export", "GET", typeof(TerminationController), "Export")]
        [InlineData("/api/hrm/termination/export", "GET", typeof(TerminationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/1", "GET", typeof(TerminationController), "Get")]
        [InlineData("/api/hrm/termination/1", "GET", typeof(TerminationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/get?terminationIds=1", "GET", typeof(TerminationController), "Get")]
        [InlineData("/api/hrm/termination/get?terminationIds=1", "GET", typeof(TerminationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination", "GET", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/termination", "GET", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/page/1", "GET", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/termination/page/1", "GET", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/count-filtered/{filterName}", "GET", typeof(TerminationController), "CountFiltered")]
        [InlineData("/api/hrm/termination/count-filtered/{filterName}", "GET", typeof(TerminationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TerminationController), "GetFiltered")]
        [InlineData("/api/hrm/termination/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TerminationController), "GetFiltered")]
        [InlineData("/api/hrm/termination/first", "GET", typeof(TerminationController), "GetFirst")]
        [InlineData("/api/hrm/termination/previous/1", "GET", typeof(TerminationController), "GetPrevious")]
        [InlineData("/api/hrm/termination/next/1", "GET", typeof(TerminationController), "GetNext")]
        [InlineData("/api/hrm/termination/last", "GET", typeof(TerminationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/termination/custom-fields", "GET", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/hrm/termination/custom-fields", "GET", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/custom-fields/{resourceId}", "GET", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/hrm/termination/custom-fields/{resourceId}", "GET", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/meta", "HEAD", typeof(TerminationController), "GetEntityView")]
        [InlineData("/api/hrm/termination/meta", "HEAD", typeof(TerminationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/count", "HEAD", typeof(TerminationController), "Count")]
        [InlineData("/api/hrm/termination/count", "HEAD", typeof(TerminationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/all", "HEAD", typeof(TerminationController), "GetAll")]
        [InlineData("/api/hrm/termination/all", "HEAD", typeof(TerminationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/export", "HEAD", typeof(TerminationController), "Export")]
        [InlineData("/api/hrm/termination/export", "HEAD", typeof(TerminationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/1", "HEAD", typeof(TerminationController), "Get")]
        [InlineData("/api/hrm/termination/1", "HEAD", typeof(TerminationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/get?terminationIds=1", "HEAD", typeof(TerminationController), "Get")]
        [InlineData("/api/hrm/termination/get?terminationIds=1", "HEAD", typeof(TerminationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination", "HEAD", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/termination", "HEAD", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/page/1", "HEAD", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/termination/page/1", "HEAD", typeof(TerminationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/count-filtered/{filterName}", "HEAD", typeof(TerminationController), "CountFiltered")]
        [InlineData("/api/hrm/termination/count-filtered/{filterName}", "HEAD", typeof(TerminationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TerminationController), "GetFiltered")]
        [InlineData("/api/hrm/termination/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TerminationController), "GetFiltered")]
        [InlineData("/api/hrm/termination/first", "HEAD", typeof(TerminationController), "GetFirst")]
        [InlineData("/api/hrm/termination/previous/1", "HEAD", typeof(TerminationController), "GetPrevious")]
        [InlineData("/api/hrm/termination/next/1", "HEAD", typeof(TerminationController), "GetNext")]
        [InlineData("/api/hrm/termination/last", "HEAD", typeof(TerminationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/termination/custom-fields", "HEAD", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/hrm/termination/custom-fields", "HEAD", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/termination/custom-fields/{resourceId}", "HEAD", typeof(TerminationController), "GetCustomFields")]
        [InlineData("/api/hrm/termination/custom-fields/{resourceId}", "HEAD", typeof(TerminationController), "GetCustomFields")]

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

        public TerminationRouteTests()
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