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
    public class EmployeeQualificationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/delete/{employeeQualificationId}", "DELETE", typeof(EmployeeQualificationController), "Delete")]
        [InlineData("/api/hrm/employee-qualification/delete/{employeeQualificationId}", "DELETE", typeof(EmployeeQualificationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/edit/{employeeQualificationId}", "PUT", typeof(EmployeeQualificationController), "Edit")]
        [InlineData("/api/hrm/employee-qualification/edit/{employeeQualificationId}", "PUT", typeof(EmployeeQualificationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/count-where", "POST", typeof(EmployeeQualificationController), "CountWhere")]
        [InlineData("/api/hrm/employee-qualification/count-where", "POST", typeof(EmployeeQualificationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/get-where/{pageNumber}", "POST", typeof(EmployeeQualificationController), "GetWhere")]
        [InlineData("/api/hrm/employee-qualification/get-where/{pageNumber}", "POST", typeof(EmployeeQualificationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/add-or-edit", "POST", typeof(EmployeeQualificationController), "AddOrEdit")]
        [InlineData("/api/hrm/employee-qualification/add-or-edit", "POST", typeof(EmployeeQualificationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/add/{employeeQualification}", "POST", typeof(EmployeeQualificationController), "Add")]
        [InlineData("/api/hrm/employee-qualification/add/{employeeQualification}", "POST", typeof(EmployeeQualificationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/bulk-import", "POST", typeof(EmployeeQualificationController), "BulkImport")]
        [InlineData("/api/hrm/employee-qualification/bulk-import", "POST", typeof(EmployeeQualificationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/meta", "GET", typeof(EmployeeQualificationController), "GetEntityView")]
        [InlineData("/api/hrm/employee-qualification/meta", "GET", typeof(EmployeeQualificationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/count", "GET", typeof(EmployeeQualificationController), "Count")]
        [InlineData("/api/hrm/employee-qualification/count", "GET", typeof(EmployeeQualificationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/all", "GET", typeof(EmployeeQualificationController), "GetAll")]
        [InlineData("/api/hrm/employee-qualification/all", "GET", typeof(EmployeeQualificationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/export", "GET", typeof(EmployeeQualificationController), "Export")]
        [InlineData("/api/hrm/employee-qualification/export", "GET", typeof(EmployeeQualificationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/1", "GET", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/hrm/employee-qualification/1", "GET", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/get?employeeQualificationIds=1", "GET", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/hrm/employee-qualification/get?employeeQualificationIds=1", "GET", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification", "GET", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-qualification", "GET", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/page/1", "GET", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-qualification/page/1", "GET", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/count-filtered/{filterName}", "GET", typeof(EmployeeQualificationController), "CountFiltered")]
        [InlineData("/api/hrm/employee-qualification/count-filtered/{filterName}", "GET", typeof(EmployeeQualificationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeQualificationController), "GetFiltered")]
        [InlineData("/api/hrm/employee-qualification/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeQualificationController), "GetFiltered")]
        [InlineData("/api/hrm/employee-qualification/first", "GET", typeof(EmployeeQualificationController), "GetFirst")]
        [InlineData("/api/hrm/employee-qualification/previous/1", "GET", typeof(EmployeeQualificationController), "GetPrevious")]
        [InlineData("/api/hrm/employee-qualification/next/1", "GET", typeof(EmployeeQualificationController), "GetNext")]
        [InlineData("/api/hrm/employee-qualification/last", "GET", typeof(EmployeeQualificationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/custom-fields", "GET", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-qualification/custom-fields", "GET", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/custom-fields/{resourceId}", "GET", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-qualification/custom-fields/{resourceId}", "GET", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/meta", "HEAD", typeof(EmployeeQualificationController), "GetEntityView")]
        [InlineData("/api/hrm/employee-qualification/meta", "HEAD", typeof(EmployeeQualificationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/count", "HEAD", typeof(EmployeeQualificationController), "Count")]
        [InlineData("/api/hrm/employee-qualification/count", "HEAD", typeof(EmployeeQualificationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/all", "HEAD", typeof(EmployeeQualificationController), "GetAll")]
        [InlineData("/api/hrm/employee-qualification/all", "HEAD", typeof(EmployeeQualificationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/export", "HEAD", typeof(EmployeeQualificationController), "Export")]
        [InlineData("/api/hrm/employee-qualification/export", "HEAD", typeof(EmployeeQualificationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/1", "HEAD", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/hrm/employee-qualification/1", "HEAD", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/get?employeeQualificationIds=1", "HEAD", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/hrm/employee-qualification/get?employeeQualificationIds=1", "HEAD", typeof(EmployeeQualificationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification", "HEAD", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-qualification", "HEAD", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/page/1", "HEAD", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-qualification/page/1", "HEAD", typeof(EmployeeQualificationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/count-filtered/{filterName}", "HEAD", typeof(EmployeeQualificationController), "CountFiltered")]
        [InlineData("/api/hrm/employee-qualification/count-filtered/{filterName}", "HEAD", typeof(EmployeeQualificationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeQualificationController), "GetFiltered")]
        [InlineData("/api/hrm/employee-qualification/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeQualificationController), "GetFiltered")]
        [InlineData("/api/hrm/employee-qualification/first", "HEAD", typeof(EmployeeQualificationController), "GetFirst")]
        [InlineData("/api/hrm/employee-qualification/previous/1", "HEAD", typeof(EmployeeQualificationController), "GetPrevious")]
        [InlineData("/api/hrm/employee-qualification/next/1", "HEAD", typeof(EmployeeQualificationController), "GetNext")]
        [InlineData("/api/hrm/employee-qualification/last", "HEAD", typeof(EmployeeQualificationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/custom-fields", "HEAD", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-qualification/custom-fields", "HEAD", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-qualification/custom-fields/{resourceId}", "HEAD", typeof(EmployeeQualificationController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-qualification/custom-fields/{resourceId}", "HEAD", typeof(EmployeeQualificationController), "GetCustomFields")]

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

        public EmployeeQualificationRouteTests()
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