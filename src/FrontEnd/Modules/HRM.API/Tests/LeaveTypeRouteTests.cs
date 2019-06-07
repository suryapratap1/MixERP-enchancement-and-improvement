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
    public class LeaveTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/delete/{leaveTypeId}", "DELETE", typeof(LeaveTypeController), "Delete")]
        [InlineData("/api/hrm/leave-type/delete/{leaveTypeId}", "DELETE", typeof(LeaveTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/edit/{leaveTypeId}", "PUT", typeof(LeaveTypeController), "Edit")]
        [InlineData("/api/hrm/leave-type/edit/{leaveTypeId}", "PUT", typeof(LeaveTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/count-where", "POST", typeof(LeaveTypeController), "CountWhere")]
        [InlineData("/api/hrm/leave-type/count-where", "POST", typeof(LeaveTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/get-where/{pageNumber}", "POST", typeof(LeaveTypeController), "GetWhere")]
        [InlineData("/api/hrm/leave-type/get-where/{pageNumber}", "POST", typeof(LeaveTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/add-or-edit", "POST", typeof(LeaveTypeController), "AddOrEdit")]
        [InlineData("/api/hrm/leave-type/add-or-edit", "POST", typeof(LeaveTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/add/{leaveType}", "POST", typeof(LeaveTypeController), "Add")]
        [InlineData("/api/hrm/leave-type/add/{leaveType}", "POST", typeof(LeaveTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/bulk-import", "POST", typeof(LeaveTypeController), "BulkImport")]
        [InlineData("/api/hrm/leave-type/bulk-import", "POST", typeof(LeaveTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/meta", "GET", typeof(LeaveTypeController), "GetEntityView")]
        [InlineData("/api/hrm/leave-type/meta", "GET", typeof(LeaveTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/count", "GET", typeof(LeaveTypeController), "Count")]
        [InlineData("/api/hrm/leave-type/count", "GET", typeof(LeaveTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/all", "GET", typeof(LeaveTypeController), "GetAll")]
        [InlineData("/api/hrm/leave-type/all", "GET", typeof(LeaveTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/export", "GET", typeof(LeaveTypeController), "Export")]
        [InlineData("/api/hrm/leave-type/export", "GET", typeof(LeaveTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/1", "GET", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/hrm/leave-type/1", "GET", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/get?leaveTypeIds=1", "GET", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/hrm/leave-type/get?leaveTypeIds=1", "GET", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type", "GET", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-type", "GET", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/page/1", "GET", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-type/page/1", "GET", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/count-filtered/{filterName}", "GET", typeof(LeaveTypeController), "CountFiltered")]
        [InlineData("/api/hrm/leave-type/count-filtered/{filterName}", "GET", typeof(LeaveTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LeaveTypeController), "GetFiltered")]
        [InlineData("/api/hrm/leave-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LeaveTypeController), "GetFiltered")]
        [InlineData("/api/hrm/leave-type/first", "GET", typeof(LeaveTypeController), "GetFirst")]
        [InlineData("/api/hrm/leave-type/previous/1", "GET", typeof(LeaveTypeController), "GetPrevious")]
        [InlineData("/api/hrm/leave-type/next/1", "GET", typeof(LeaveTypeController), "GetNext")]
        [InlineData("/api/hrm/leave-type/last", "GET", typeof(LeaveTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/custom-fields", "GET", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-type/custom-fields", "GET", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/custom-fields/{resourceId}", "GET", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-type/custom-fields/{resourceId}", "GET", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/meta", "HEAD", typeof(LeaveTypeController), "GetEntityView")]
        [InlineData("/api/hrm/leave-type/meta", "HEAD", typeof(LeaveTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/count", "HEAD", typeof(LeaveTypeController), "Count")]
        [InlineData("/api/hrm/leave-type/count", "HEAD", typeof(LeaveTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/all", "HEAD", typeof(LeaveTypeController), "GetAll")]
        [InlineData("/api/hrm/leave-type/all", "HEAD", typeof(LeaveTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/export", "HEAD", typeof(LeaveTypeController), "Export")]
        [InlineData("/api/hrm/leave-type/export", "HEAD", typeof(LeaveTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/1", "HEAD", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/hrm/leave-type/1", "HEAD", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/get?leaveTypeIds=1", "HEAD", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/hrm/leave-type/get?leaveTypeIds=1", "HEAD", typeof(LeaveTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type", "HEAD", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-type", "HEAD", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/page/1", "HEAD", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-type/page/1", "HEAD", typeof(LeaveTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/count-filtered/{filterName}", "HEAD", typeof(LeaveTypeController), "CountFiltered")]
        [InlineData("/api/hrm/leave-type/count-filtered/{filterName}", "HEAD", typeof(LeaveTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LeaveTypeController), "GetFiltered")]
        [InlineData("/api/hrm/leave-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LeaveTypeController), "GetFiltered")]
        [InlineData("/api/hrm/leave-type/first", "HEAD", typeof(LeaveTypeController), "GetFirst")]
        [InlineData("/api/hrm/leave-type/previous/1", "HEAD", typeof(LeaveTypeController), "GetPrevious")]
        [InlineData("/api/hrm/leave-type/next/1", "HEAD", typeof(LeaveTypeController), "GetNext")]
        [InlineData("/api/hrm/leave-type/last", "HEAD", typeof(LeaveTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/custom-fields", "HEAD", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-type/custom-fields", "HEAD", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-type/custom-fields/{resourceId}", "HEAD", typeof(LeaveTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-type/custom-fields/{resourceId}", "HEAD", typeof(LeaveTypeController), "GetCustomFields")]

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

        public LeaveTypeRouteTests()
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