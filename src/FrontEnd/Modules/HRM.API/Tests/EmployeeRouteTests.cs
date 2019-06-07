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
    public class EmployeeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/delete/{employeeId}", "DELETE", typeof(EmployeeController), "Delete")]
        [InlineData("/api/hrm/employee/delete/{employeeId}", "DELETE", typeof(EmployeeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/edit/{employeeId}", "PUT", typeof(EmployeeController), "Edit")]
        [InlineData("/api/hrm/employee/edit/{employeeId}", "PUT", typeof(EmployeeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/count-where", "POST", typeof(EmployeeController), "CountWhere")]
        [InlineData("/api/hrm/employee/count-where", "POST", typeof(EmployeeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/get-where/{pageNumber}", "POST", typeof(EmployeeController), "GetWhere")]
        [InlineData("/api/hrm/employee/get-where/{pageNumber}", "POST", typeof(EmployeeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/add-or-edit", "POST", typeof(EmployeeController), "AddOrEdit")]
        [InlineData("/api/hrm/employee/add-or-edit", "POST", typeof(EmployeeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/add/{employee}", "POST", typeof(EmployeeController), "Add")]
        [InlineData("/api/hrm/employee/add/{employee}", "POST", typeof(EmployeeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/bulk-import", "POST", typeof(EmployeeController), "BulkImport")]
        [InlineData("/api/hrm/employee/bulk-import", "POST", typeof(EmployeeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/meta", "GET", typeof(EmployeeController), "GetEntityView")]
        [InlineData("/api/hrm/employee/meta", "GET", typeof(EmployeeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/count", "GET", typeof(EmployeeController), "Count")]
        [InlineData("/api/hrm/employee/count", "GET", typeof(EmployeeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/all", "GET", typeof(EmployeeController), "GetAll")]
        [InlineData("/api/hrm/employee/all", "GET", typeof(EmployeeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/export", "GET", typeof(EmployeeController), "Export")]
        [InlineData("/api/hrm/employee/export", "GET", typeof(EmployeeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/1", "GET", typeof(EmployeeController), "Get")]
        [InlineData("/api/hrm/employee/1", "GET", typeof(EmployeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/get?employeeIds=1", "GET", typeof(EmployeeController), "Get")]
        [InlineData("/api/hrm/employee/get?employeeIds=1", "GET", typeof(EmployeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee", "GET", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee", "GET", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/page/1", "GET", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee/page/1", "GET", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/count-filtered/{filterName}", "GET", typeof(EmployeeController), "CountFiltered")]
        [InlineData("/api/hrm/employee/count-filtered/{filterName}", "GET", typeof(EmployeeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeController), "GetFiltered")]
        [InlineData("/api/hrm/employee/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeController), "GetFiltered")]
        [InlineData("/api/hrm/employee/first", "GET", typeof(EmployeeController), "GetFirst")]
        [InlineData("/api/hrm/employee/previous/1", "GET", typeof(EmployeeController), "GetPrevious")]
        [InlineData("/api/hrm/employee/next/1", "GET", typeof(EmployeeController), "GetNext")]
        [InlineData("/api/hrm/employee/last", "GET", typeof(EmployeeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee/custom-fields", "GET", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee/custom-fields", "GET", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/custom-fields/{resourceId}", "GET", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee/custom-fields/{resourceId}", "GET", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/meta", "HEAD", typeof(EmployeeController), "GetEntityView")]
        [InlineData("/api/hrm/employee/meta", "HEAD", typeof(EmployeeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/count", "HEAD", typeof(EmployeeController), "Count")]
        [InlineData("/api/hrm/employee/count", "HEAD", typeof(EmployeeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/all", "HEAD", typeof(EmployeeController), "GetAll")]
        [InlineData("/api/hrm/employee/all", "HEAD", typeof(EmployeeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/export", "HEAD", typeof(EmployeeController), "Export")]
        [InlineData("/api/hrm/employee/export", "HEAD", typeof(EmployeeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/1", "HEAD", typeof(EmployeeController), "Get")]
        [InlineData("/api/hrm/employee/1", "HEAD", typeof(EmployeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/get?employeeIds=1", "HEAD", typeof(EmployeeController), "Get")]
        [InlineData("/api/hrm/employee/get?employeeIds=1", "HEAD", typeof(EmployeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee", "HEAD", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee", "HEAD", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/page/1", "HEAD", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee/page/1", "HEAD", typeof(EmployeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/count-filtered/{filterName}", "HEAD", typeof(EmployeeController), "CountFiltered")]
        [InlineData("/api/hrm/employee/count-filtered/{filterName}", "HEAD", typeof(EmployeeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeController), "GetFiltered")]
        [InlineData("/api/hrm/employee/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeController), "GetFiltered")]
        [InlineData("/api/hrm/employee/first", "HEAD", typeof(EmployeeController), "GetFirst")]
        [InlineData("/api/hrm/employee/previous/1", "HEAD", typeof(EmployeeController), "GetPrevious")]
        [InlineData("/api/hrm/employee/next/1", "HEAD", typeof(EmployeeController), "GetNext")]
        [InlineData("/api/hrm/employee/last", "HEAD", typeof(EmployeeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee/custom-fields", "HEAD", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee/custom-fields", "HEAD", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee/custom-fields/{resourceId}", "HEAD", typeof(EmployeeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee/custom-fields/{resourceId}", "HEAD", typeof(EmployeeController), "GetCustomFields")]

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

        public EmployeeRouteTests()
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