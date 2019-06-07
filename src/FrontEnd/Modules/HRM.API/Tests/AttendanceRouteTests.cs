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
    public class AttendanceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/delete/{attendanceId}", "DELETE", typeof(AttendanceController), "Delete")]
        [InlineData("/api/hrm/attendance/delete/{attendanceId}", "DELETE", typeof(AttendanceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/edit/{attendanceId}", "PUT", typeof(AttendanceController), "Edit")]
        [InlineData("/api/hrm/attendance/edit/{attendanceId}", "PUT", typeof(AttendanceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/count-where", "POST", typeof(AttendanceController), "CountWhere")]
        [InlineData("/api/hrm/attendance/count-where", "POST", typeof(AttendanceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/get-where/{pageNumber}", "POST", typeof(AttendanceController), "GetWhere")]
        [InlineData("/api/hrm/attendance/get-where/{pageNumber}", "POST", typeof(AttendanceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/add-or-edit", "POST", typeof(AttendanceController), "AddOrEdit")]
        [InlineData("/api/hrm/attendance/add-or-edit", "POST", typeof(AttendanceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/add/{attendance}", "POST", typeof(AttendanceController), "Add")]
        [InlineData("/api/hrm/attendance/add/{attendance}", "POST", typeof(AttendanceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/bulk-import", "POST", typeof(AttendanceController), "BulkImport")]
        [InlineData("/api/hrm/attendance/bulk-import", "POST", typeof(AttendanceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/meta", "GET", typeof(AttendanceController), "GetEntityView")]
        [InlineData("/api/hrm/attendance/meta", "GET", typeof(AttendanceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/count", "GET", typeof(AttendanceController), "Count")]
        [InlineData("/api/hrm/attendance/count", "GET", typeof(AttendanceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/all", "GET", typeof(AttendanceController), "GetAll")]
        [InlineData("/api/hrm/attendance/all", "GET", typeof(AttendanceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/export", "GET", typeof(AttendanceController), "Export")]
        [InlineData("/api/hrm/attendance/export", "GET", typeof(AttendanceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/1", "GET", typeof(AttendanceController), "Get")]
        [InlineData("/api/hrm/attendance/1", "GET", typeof(AttendanceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/get?attendanceIds=1", "GET", typeof(AttendanceController), "Get")]
        [InlineData("/api/hrm/attendance/get?attendanceIds=1", "GET", typeof(AttendanceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance", "GET", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/attendance", "GET", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/page/1", "GET", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/attendance/page/1", "GET", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/count-filtered/{filterName}", "GET", typeof(AttendanceController), "CountFiltered")]
        [InlineData("/api/hrm/attendance/count-filtered/{filterName}", "GET", typeof(AttendanceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttendanceController), "GetFiltered")]
        [InlineData("/api/hrm/attendance/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttendanceController), "GetFiltered")]
        [InlineData("/api/hrm/attendance/first", "GET", typeof(AttendanceController), "GetFirst")]
        [InlineData("/api/hrm/attendance/previous/1", "GET", typeof(AttendanceController), "GetPrevious")]
        [InlineData("/api/hrm/attendance/next/1", "GET", typeof(AttendanceController), "GetNext")]
        [InlineData("/api/hrm/attendance/last", "GET", typeof(AttendanceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/attendance/custom-fields", "GET", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/hrm/attendance/custom-fields", "GET", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/custom-fields/{resourceId}", "GET", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/hrm/attendance/custom-fields/{resourceId}", "GET", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/meta", "HEAD", typeof(AttendanceController), "GetEntityView")]
        [InlineData("/api/hrm/attendance/meta", "HEAD", typeof(AttendanceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/count", "HEAD", typeof(AttendanceController), "Count")]
        [InlineData("/api/hrm/attendance/count", "HEAD", typeof(AttendanceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/all", "HEAD", typeof(AttendanceController), "GetAll")]
        [InlineData("/api/hrm/attendance/all", "HEAD", typeof(AttendanceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/export", "HEAD", typeof(AttendanceController), "Export")]
        [InlineData("/api/hrm/attendance/export", "HEAD", typeof(AttendanceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/1", "HEAD", typeof(AttendanceController), "Get")]
        [InlineData("/api/hrm/attendance/1", "HEAD", typeof(AttendanceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/get?attendanceIds=1", "HEAD", typeof(AttendanceController), "Get")]
        [InlineData("/api/hrm/attendance/get?attendanceIds=1", "HEAD", typeof(AttendanceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance", "HEAD", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/attendance", "HEAD", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/page/1", "HEAD", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/attendance/page/1", "HEAD", typeof(AttendanceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/count-filtered/{filterName}", "HEAD", typeof(AttendanceController), "CountFiltered")]
        [InlineData("/api/hrm/attendance/count-filtered/{filterName}", "HEAD", typeof(AttendanceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttendanceController), "GetFiltered")]
        [InlineData("/api/hrm/attendance/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttendanceController), "GetFiltered")]
        [InlineData("/api/hrm/attendance/first", "HEAD", typeof(AttendanceController), "GetFirst")]
        [InlineData("/api/hrm/attendance/previous/1", "HEAD", typeof(AttendanceController), "GetPrevious")]
        [InlineData("/api/hrm/attendance/next/1", "HEAD", typeof(AttendanceController), "GetNext")]
        [InlineData("/api/hrm/attendance/last", "HEAD", typeof(AttendanceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/attendance/custom-fields", "HEAD", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/hrm/attendance/custom-fields", "HEAD", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/attendance/custom-fields/{resourceId}", "HEAD", typeof(AttendanceController), "GetCustomFields")]
        [InlineData("/api/hrm/attendance/custom-fields/{resourceId}", "HEAD", typeof(AttendanceController), "GetCustomFields")]

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

        public AttendanceRouteTests()
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