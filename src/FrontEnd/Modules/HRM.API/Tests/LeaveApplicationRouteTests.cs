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
    public class LeaveApplicationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/delete/{leaveApplicationId}", "DELETE", typeof(LeaveApplicationController), "Delete")]
        [InlineData("/api/hrm/leave-application/delete/{leaveApplicationId}", "DELETE", typeof(LeaveApplicationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/edit/{leaveApplicationId}", "PUT", typeof(LeaveApplicationController), "Edit")]
        [InlineData("/api/hrm/leave-application/edit/{leaveApplicationId}", "PUT", typeof(LeaveApplicationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/verify/{leaveApplicationId}/{verificationStatusId}/{reason}", "PUT", typeof(LeaveApplicationController), "Verifiy")]
        [InlineData("/api/hrm/leave-application/verify/{leaveApplicationId}/{verificationStatusId}/{reason}", "PUT", typeof(LeaveApplicationController), "Verifiy")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/count-where", "POST", typeof(LeaveApplicationController), "CountWhere")]
        [InlineData("/api/hrm/leave-application/count-where", "POST", typeof(LeaveApplicationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/get-where/{pageNumber}", "POST", typeof(LeaveApplicationController), "GetWhere")]
        [InlineData("/api/hrm/leave-application/get-where/{pageNumber}", "POST", typeof(LeaveApplicationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/add-or-edit", "POST", typeof(LeaveApplicationController), "AddOrEdit")]
        [InlineData("/api/hrm/leave-application/add-or-edit", "POST", typeof(LeaveApplicationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/add/{leaveApplication}", "POST", typeof(LeaveApplicationController), "Add")]
        [InlineData("/api/hrm/leave-application/add/{leaveApplication}", "POST", typeof(LeaveApplicationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/bulk-import", "POST", typeof(LeaveApplicationController), "BulkImport")]
        [InlineData("/api/hrm/leave-application/bulk-import", "POST", typeof(LeaveApplicationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/meta", "GET", typeof(LeaveApplicationController), "GetEntityView")]
        [InlineData("/api/hrm/leave-application/meta", "GET", typeof(LeaveApplicationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/count", "GET", typeof(LeaveApplicationController), "Count")]
        [InlineData("/api/hrm/leave-application/count", "GET", typeof(LeaveApplicationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/all", "GET", typeof(LeaveApplicationController), "GetAll")]
        [InlineData("/api/hrm/leave-application/all", "GET", typeof(LeaveApplicationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/export", "GET", typeof(LeaveApplicationController), "Export")]
        [InlineData("/api/hrm/leave-application/export", "GET", typeof(LeaveApplicationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/1", "GET", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/hrm/leave-application/1", "GET", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/get?leaveApplicationIds=1", "GET", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/hrm/leave-application/get?leaveApplicationIds=1", "GET", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application", "GET", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-application", "GET", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/page/1", "GET", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-application/page/1", "GET", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/count-filtered/{filterName}", "GET", typeof(LeaveApplicationController), "CountFiltered")]
        [InlineData("/api/hrm/leave-application/count-filtered/{filterName}", "GET", typeof(LeaveApplicationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LeaveApplicationController), "GetFiltered")]
        [InlineData("/api/hrm/leave-application/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LeaveApplicationController), "GetFiltered")]
        [InlineData("/api/hrm/leave-application/first", "GET", typeof(LeaveApplicationController), "GetFirst")]
        [InlineData("/api/hrm/leave-application/previous/1", "GET", typeof(LeaveApplicationController), "GetPrevious")]
        [InlineData("/api/hrm/leave-application/next/1", "GET", typeof(LeaveApplicationController), "GetNext")]
        [InlineData("/api/hrm/leave-application/last", "GET", typeof(LeaveApplicationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/custom-fields", "GET", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-application/custom-fields", "GET", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/custom-fields/{resourceId}", "GET", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-application/custom-fields/{resourceId}", "GET", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/meta", "HEAD", typeof(LeaveApplicationController), "GetEntityView")]
        [InlineData("/api/hrm/leave-application/meta", "HEAD", typeof(LeaveApplicationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/count", "HEAD", typeof(LeaveApplicationController), "Count")]
        [InlineData("/api/hrm/leave-application/count", "HEAD", typeof(LeaveApplicationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/all", "HEAD", typeof(LeaveApplicationController), "GetAll")]
        [InlineData("/api/hrm/leave-application/all", "HEAD", typeof(LeaveApplicationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/export", "HEAD", typeof(LeaveApplicationController), "Export")]
        [InlineData("/api/hrm/leave-application/export", "HEAD", typeof(LeaveApplicationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/1", "HEAD", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/hrm/leave-application/1", "HEAD", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/get?leaveApplicationIds=1", "HEAD", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/hrm/leave-application/get?leaveApplicationIds=1", "HEAD", typeof(LeaveApplicationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application", "HEAD", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-application", "HEAD", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/page/1", "HEAD", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-application/page/1", "HEAD", typeof(LeaveApplicationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/count-filtered/{filterName}", "HEAD", typeof(LeaveApplicationController), "CountFiltered")]
        [InlineData("/api/hrm/leave-application/count-filtered/{filterName}", "HEAD", typeof(LeaveApplicationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LeaveApplicationController), "GetFiltered")]
        [InlineData("/api/hrm/leave-application/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LeaveApplicationController), "GetFiltered")]
        [InlineData("/api/hrm/leave-application/first", "HEAD", typeof(LeaveApplicationController), "GetFirst")]
        [InlineData("/api/hrm/leave-application/previous/1", "HEAD", typeof(LeaveApplicationController), "GetPrevious")]
        [InlineData("/api/hrm/leave-application/next/1", "HEAD", typeof(LeaveApplicationController), "GetNext")]
        [InlineData("/api/hrm/leave-application/last", "HEAD", typeof(LeaveApplicationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/custom-fields", "HEAD", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-application/custom-fields", "HEAD", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-application/custom-fields/{resourceId}", "HEAD", typeof(LeaveApplicationController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-application/custom-fields/{resourceId}", "HEAD", typeof(LeaveApplicationController), "GetCustomFields")]

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

        public LeaveApplicationRouteTests()
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