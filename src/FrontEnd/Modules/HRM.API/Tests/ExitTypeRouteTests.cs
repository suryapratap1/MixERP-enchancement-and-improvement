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
    public class ExitTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/delete/{exitTypeId}", "DELETE", typeof(ExitTypeController), "Delete")]
        [InlineData("/api/hrm/exit-type/delete/{exitTypeId}", "DELETE", typeof(ExitTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/edit/{exitTypeId}", "PUT", typeof(ExitTypeController), "Edit")]
        [InlineData("/api/hrm/exit-type/edit/{exitTypeId}", "PUT", typeof(ExitTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/count-where", "POST", typeof(ExitTypeController), "CountWhere")]
        [InlineData("/api/hrm/exit-type/count-where", "POST", typeof(ExitTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/get-where/{pageNumber}", "POST", typeof(ExitTypeController), "GetWhere")]
        [InlineData("/api/hrm/exit-type/get-where/{pageNumber}", "POST", typeof(ExitTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/add-or-edit", "POST", typeof(ExitTypeController), "AddOrEdit")]
        [InlineData("/api/hrm/exit-type/add-or-edit", "POST", typeof(ExitTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/add/{exitType}", "POST", typeof(ExitTypeController), "Add")]
        [InlineData("/api/hrm/exit-type/add/{exitType}", "POST", typeof(ExitTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/bulk-import", "POST", typeof(ExitTypeController), "BulkImport")]
        [InlineData("/api/hrm/exit-type/bulk-import", "POST", typeof(ExitTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/meta", "GET", typeof(ExitTypeController), "GetEntityView")]
        [InlineData("/api/hrm/exit-type/meta", "GET", typeof(ExitTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/count", "GET", typeof(ExitTypeController), "Count")]
        [InlineData("/api/hrm/exit-type/count", "GET", typeof(ExitTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/all", "GET", typeof(ExitTypeController), "GetAll")]
        [InlineData("/api/hrm/exit-type/all", "GET", typeof(ExitTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/export", "GET", typeof(ExitTypeController), "Export")]
        [InlineData("/api/hrm/exit-type/export", "GET", typeof(ExitTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/1", "GET", typeof(ExitTypeController), "Get")]
        [InlineData("/api/hrm/exit-type/1", "GET", typeof(ExitTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/get?exitTypeIds=1", "GET", typeof(ExitTypeController), "Get")]
        [InlineData("/api/hrm/exit-type/get?exitTypeIds=1", "GET", typeof(ExitTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type", "GET", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit-type", "GET", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/page/1", "GET", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit-type/page/1", "GET", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/count-filtered/{filterName}", "GET", typeof(ExitTypeController), "CountFiltered")]
        [InlineData("/api/hrm/exit-type/count-filtered/{filterName}", "GET", typeof(ExitTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ExitTypeController), "GetFiltered")]
        [InlineData("/api/hrm/exit-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ExitTypeController), "GetFiltered")]
        [InlineData("/api/hrm/exit-type/first", "GET", typeof(ExitTypeController), "GetFirst")]
        [InlineData("/api/hrm/exit-type/previous/1", "GET", typeof(ExitTypeController), "GetPrevious")]
        [InlineData("/api/hrm/exit-type/next/1", "GET", typeof(ExitTypeController), "GetNext")]
        [InlineData("/api/hrm/exit-type/last", "GET", typeof(ExitTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/custom-fields", "GET", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/exit-type/custom-fields", "GET", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/custom-fields/{resourceId}", "GET", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/exit-type/custom-fields/{resourceId}", "GET", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/meta", "HEAD", typeof(ExitTypeController), "GetEntityView")]
        [InlineData("/api/hrm/exit-type/meta", "HEAD", typeof(ExitTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/count", "HEAD", typeof(ExitTypeController), "Count")]
        [InlineData("/api/hrm/exit-type/count", "HEAD", typeof(ExitTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/all", "HEAD", typeof(ExitTypeController), "GetAll")]
        [InlineData("/api/hrm/exit-type/all", "HEAD", typeof(ExitTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/export", "HEAD", typeof(ExitTypeController), "Export")]
        [InlineData("/api/hrm/exit-type/export", "HEAD", typeof(ExitTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/1", "HEAD", typeof(ExitTypeController), "Get")]
        [InlineData("/api/hrm/exit-type/1", "HEAD", typeof(ExitTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/get?exitTypeIds=1", "HEAD", typeof(ExitTypeController), "Get")]
        [InlineData("/api/hrm/exit-type/get?exitTypeIds=1", "HEAD", typeof(ExitTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type", "HEAD", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit-type", "HEAD", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/page/1", "HEAD", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/exit-type/page/1", "HEAD", typeof(ExitTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/count-filtered/{filterName}", "HEAD", typeof(ExitTypeController), "CountFiltered")]
        [InlineData("/api/hrm/exit-type/count-filtered/{filterName}", "HEAD", typeof(ExitTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ExitTypeController), "GetFiltered")]
        [InlineData("/api/hrm/exit-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ExitTypeController), "GetFiltered")]
        [InlineData("/api/hrm/exit-type/first", "HEAD", typeof(ExitTypeController), "GetFirst")]
        [InlineData("/api/hrm/exit-type/previous/1", "HEAD", typeof(ExitTypeController), "GetPrevious")]
        [InlineData("/api/hrm/exit-type/next/1", "HEAD", typeof(ExitTypeController), "GetNext")]
        [InlineData("/api/hrm/exit-type/last", "HEAD", typeof(ExitTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/custom-fields", "HEAD", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/exit-type/custom-fields", "HEAD", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/exit-type/custom-fields/{resourceId}", "HEAD", typeof(ExitTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/exit-type/custom-fields/{resourceId}", "HEAD", typeof(ExitTypeController), "GetCustomFields")]

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

        public ExitTypeRouteTests()
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