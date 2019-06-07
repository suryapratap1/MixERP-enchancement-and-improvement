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
    public class ExitRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/delete/{exitId}", "DELETE", typeof(ExitController), "Delete")]
        [InlineData("/api/hrm/exit/delete/{exitId}", "DELETE", typeof(ExitController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/edit/{exitId}", "PUT", typeof(ExitController), "Edit")]
        [InlineData("/api/hrm/exit/edit/{exitId}", "PUT", typeof(ExitController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/verify/{exitId}/{verificationStatusId}/{reason}", "PUT", typeof(ExitController), "Verifiy")]
        [InlineData("/api/hrm/exit/verify/{exitId}/{verificationStatusId}/{reason}", "PUT", typeof(ExitController), "Verifiy")]

        [InlineData("/api/{apiVersionNumber}/hrm/exit/count-where", "POST", typeof(ExitController), "CountWhere")]
        [InlineData("/api/hrm/exit/count-where", "POST", typeof(ExitController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/get-where/{pageNumber}", "POST", typeof(ExitController), "GetWhere")]
        [InlineData("/api/hrm/exit/get-where/{pageNumber}", "POST", typeof(ExitController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/add-or-edit", "POST", typeof(ExitController), "AddOrEdit")]
        [InlineData("/api/hrm/exit/add-or-edit", "POST", typeof(ExitController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/add/{exit}", "POST", typeof(ExitController), "Add")]
        [InlineData("/api/hrm/exit/add/{exit}", "POST", typeof(ExitController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/bulk-import", "POST", typeof(ExitController), "BulkImport")]
        [InlineData("/api/hrm/exit/bulk-import", "POST", typeof(ExitController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/meta", "GET", typeof(ExitController), "GetEntityView")]
        [InlineData("/api/hrm/exit/meta", "GET", typeof(ExitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/count", "GET", typeof(ExitController), "Count")]
        [InlineData("/api/hrm/exit/count", "GET", typeof(ExitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/all", "GET", typeof(ExitController), "GetAll")]
        [InlineData("/api/hrm/exit/all", "GET", typeof(ExitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/export", "GET", typeof(ExitController), "Export")]
        [InlineData("/api/hrm/exit/export", "GET", typeof(ExitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/1", "GET", typeof(ExitController), "Get")]
        [InlineData("/api/hrm/exit/1", "GET", typeof(ExitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/get?exitIds=1", "GET", typeof(ExitController), "Get")]
        [InlineData("/api/hrm/exit/get?exitIds=1", "GET", typeof(ExitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit", "GET", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit", "GET", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/page/1", "GET", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit/page/1", "GET", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/count-filtered/{filterName}", "GET", typeof(ExitController), "CountFiltered")]
        [InlineData("/api/hrm/exit/count-filtered/{filterName}", "GET", typeof(ExitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ExitController), "GetFiltered")]
        [InlineData("/api/hrm/exit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ExitController), "GetFiltered")]
        [InlineData("/api/hrm/exit/first", "GET", typeof(ExitController), "GetFirst")]
        [InlineData("/api/hrm/exit/previous/1", "GET", typeof(ExitController), "GetPrevious")]
        [InlineData("/api/hrm/exit/next/1", "GET", typeof(ExitController), "GetNext")]
        [InlineData("/api/hrm/exit/last", "GET", typeof(ExitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/exit/custom-fields", "GET", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/hrm/exit/custom-fields", "GET", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/custom-fields/{resourceId}", "GET", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/hrm/exit/custom-fields/{resourceId}", "GET", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/meta", "HEAD", typeof(ExitController), "GetEntityView")]
        [InlineData("/api/hrm/exit/meta", "HEAD", typeof(ExitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/count", "HEAD", typeof(ExitController), "Count")]
        [InlineData("/api/hrm/exit/count", "HEAD", typeof(ExitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/all", "HEAD", typeof(ExitController), "GetAll")]
        [InlineData("/api/hrm/exit/all", "HEAD", typeof(ExitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/export", "HEAD", typeof(ExitController), "Export")]
        [InlineData("/api/hrm/exit/export", "HEAD", typeof(ExitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/1", "HEAD", typeof(ExitController), "Get")]
        [InlineData("/api/hrm/exit/1", "HEAD", typeof(ExitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/get?exitIds=1", "HEAD", typeof(ExitController), "Get")]
        [InlineData("/api/hrm/exit/get?exitIds=1", "HEAD", typeof(ExitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit", "HEAD", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit", "HEAD", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/page/1", "HEAD", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit/page/1", "HEAD", typeof(ExitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/count-filtered/{filterName}", "HEAD", typeof(ExitController), "CountFiltered")]
        [InlineData("/api/hrm/exit/count-filtered/{filterName}", "HEAD", typeof(ExitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ExitController), "GetFiltered")]
        [InlineData("/api/hrm/exit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ExitController), "GetFiltered")]
        [InlineData("/api/hrm/exit/first", "HEAD", typeof(ExitController), "GetFirst")]
        [InlineData("/api/hrm/exit/previous/1", "HEAD", typeof(ExitController), "GetPrevious")]
        [InlineData("/api/hrm/exit/next/1", "HEAD", typeof(ExitController), "GetNext")]
        [InlineData("/api/hrm/exit/last", "HEAD", typeof(ExitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/exit/custom-fields", "HEAD", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/hrm/exit/custom-fields", "HEAD", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit/custom-fields/{resourceId}", "HEAD", typeof(ExitController), "GetCustomFields")]
        [InlineData("/api/hrm/exit/custom-fields/{resourceId}", "HEAD", typeof(ExitController), "GetCustomFields")]

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

        public ExitRouteTests()
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