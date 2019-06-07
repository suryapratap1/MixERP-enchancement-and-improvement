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
    public class EmployeeExperienceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/delete/{employeeExperienceId}", "DELETE", typeof(EmployeeExperienceController), "Delete")]
        [InlineData("/api/hrm/employee-experience/delete/{employeeExperienceId}", "DELETE", typeof(EmployeeExperienceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/edit/{employeeExperienceId}", "PUT", typeof(EmployeeExperienceController), "Edit")]
        [InlineData("/api/hrm/employee-experience/edit/{employeeExperienceId}", "PUT", typeof(EmployeeExperienceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/count-where", "POST", typeof(EmployeeExperienceController), "CountWhere")]
        [InlineData("/api/hrm/employee-experience/count-where", "POST", typeof(EmployeeExperienceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/get-where/{pageNumber}", "POST", typeof(EmployeeExperienceController), "GetWhere")]
        [InlineData("/api/hrm/employee-experience/get-where/{pageNumber}", "POST", typeof(EmployeeExperienceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/add-or-edit", "POST", typeof(EmployeeExperienceController), "AddOrEdit")]
        [InlineData("/api/hrm/employee-experience/add-or-edit", "POST", typeof(EmployeeExperienceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/add/{employeeExperience}", "POST", typeof(EmployeeExperienceController), "Add")]
        [InlineData("/api/hrm/employee-experience/add/{employeeExperience}", "POST", typeof(EmployeeExperienceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/bulk-import", "POST", typeof(EmployeeExperienceController), "BulkImport")]
        [InlineData("/api/hrm/employee-experience/bulk-import", "POST", typeof(EmployeeExperienceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/meta", "GET", typeof(EmployeeExperienceController), "GetEntityView")]
        [InlineData("/api/hrm/employee-experience/meta", "GET", typeof(EmployeeExperienceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/count", "GET", typeof(EmployeeExperienceController), "Count")]
        [InlineData("/api/hrm/employee-experience/count", "GET", typeof(EmployeeExperienceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/all", "GET", typeof(EmployeeExperienceController), "GetAll")]
        [InlineData("/api/hrm/employee-experience/all", "GET", typeof(EmployeeExperienceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/export", "GET", typeof(EmployeeExperienceController), "Export")]
        [InlineData("/api/hrm/employee-experience/export", "GET", typeof(EmployeeExperienceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/1", "GET", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/hrm/employee-experience/1", "GET", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/get?employeeExperienceIds=1", "GET", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/hrm/employee-experience/get?employeeExperienceIds=1", "GET", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience", "GET", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-experience", "GET", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/page/1", "GET", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-experience/page/1", "GET", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/count-filtered/{filterName}", "GET", typeof(EmployeeExperienceController), "CountFiltered")]
        [InlineData("/api/hrm/employee-experience/count-filtered/{filterName}", "GET", typeof(EmployeeExperienceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeExperienceController), "GetFiltered")]
        [InlineData("/api/hrm/employee-experience/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeExperienceController), "GetFiltered")]
        [InlineData("/api/hrm/employee-experience/first", "GET", typeof(EmployeeExperienceController), "GetFirst")]
        [InlineData("/api/hrm/employee-experience/previous/1", "GET", typeof(EmployeeExperienceController), "GetPrevious")]
        [InlineData("/api/hrm/employee-experience/next/1", "GET", typeof(EmployeeExperienceController), "GetNext")]
        [InlineData("/api/hrm/employee-experience/last", "GET", typeof(EmployeeExperienceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/custom-fields", "GET", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-experience/custom-fields", "GET", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/custom-fields/{resourceId}", "GET", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-experience/custom-fields/{resourceId}", "GET", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/meta", "HEAD", typeof(EmployeeExperienceController), "GetEntityView")]
        [InlineData("/api/hrm/employee-experience/meta", "HEAD", typeof(EmployeeExperienceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/count", "HEAD", typeof(EmployeeExperienceController), "Count")]
        [InlineData("/api/hrm/employee-experience/count", "HEAD", typeof(EmployeeExperienceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/all", "HEAD", typeof(EmployeeExperienceController), "GetAll")]
        [InlineData("/api/hrm/employee-experience/all", "HEAD", typeof(EmployeeExperienceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/export", "HEAD", typeof(EmployeeExperienceController), "Export")]
        [InlineData("/api/hrm/employee-experience/export", "HEAD", typeof(EmployeeExperienceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/1", "HEAD", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/hrm/employee-experience/1", "HEAD", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/get?employeeExperienceIds=1", "HEAD", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/hrm/employee-experience/get?employeeExperienceIds=1", "HEAD", typeof(EmployeeExperienceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience", "HEAD", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-experience", "HEAD", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/page/1", "HEAD", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-experience/page/1", "HEAD", typeof(EmployeeExperienceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/count-filtered/{filterName}", "HEAD", typeof(EmployeeExperienceController), "CountFiltered")]
        [InlineData("/api/hrm/employee-experience/count-filtered/{filterName}", "HEAD", typeof(EmployeeExperienceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeExperienceController), "GetFiltered")]
        [InlineData("/api/hrm/employee-experience/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeExperienceController), "GetFiltered")]
        [InlineData("/api/hrm/employee-experience/first", "HEAD", typeof(EmployeeExperienceController), "GetFirst")]
        [InlineData("/api/hrm/employee-experience/previous/1", "HEAD", typeof(EmployeeExperienceController), "GetPrevious")]
        [InlineData("/api/hrm/employee-experience/next/1", "HEAD", typeof(EmployeeExperienceController), "GetNext")]
        [InlineData("/api/hrm/employee-experience/last", "HEAD", typeof(EmployeeExperienceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/custom-fields", "HEAD", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-experience/custom-fields", "HEAD", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-experience/custom-fields/{resourceId}", "HEAD", typeof(EmployeeExperienceController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-experience/custom-fields/{resourceId}", "HEAD", typeof(EmployeeExperienceController), "GetCustomFields")]

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

        public EmployeeExperienceRouteTests()
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