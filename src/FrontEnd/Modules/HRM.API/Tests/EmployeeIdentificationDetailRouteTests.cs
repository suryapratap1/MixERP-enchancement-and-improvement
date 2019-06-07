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
    public class EmployeeIdentificationDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/delete/{employeeIdentificationDetailId}", "DELETE", typeof(EmployeeIdentificationDetailController), "Delete")]
        [InlineData("/api/hrm/employee-identification-detail/delete/{employeeIdentificationDetailId}", "DELETE", typeof(EmployeeIdentificationDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/edit/{employeeIdentificationDetailId}", "PUT", typeof(EmployeeIdentificationDetailController), "Edit")]
        [InlineData("/api/hrm/employee-identification-detail/edit/{employeeIdentificationDetailId}", "PUT", typeof(EmployeeIdentificationDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/count-where", "POST", typeof(EmployeeIdentificationDetailController), "CountWhere")]
        [InlineData("/api/hrm/employee-identification-detail/count-where", "POST", typeof(EmployeeIdentificationDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/get-where/{pageNumber}", "POST", typeof(EmployeeIdentificationDetailController), "GetWhere")]
        [InlineData("/api/hrm/employee-identification-detail/get-where/{pageNumber}", "POST", typeof(EmployeeIdentificationDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/add-or-edit", "POST", typeof(EmployeeIdentificationDetailController), "AddOrEdit")]
        [InlineData("/api/hrm/employee-identification-detail/add-or-edit", "POST", typeof(EmployeeIdentificationDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/add/{employeeIdentificationDetail}", "POST", typeof(EmployeeIdentificationDetailController), "Add")]
        [InlineData("/api/hrm/employee-identification-detail/add/{employeeIdentificationDetail}", "POST", typeof(EmployeeIdentificationDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/bulk-import", "POST", typeof(EmployeeIdentificationDetailController), "BulkImport")]
        [InlineData("/api/hrm/employee-identification-detail/bulk-import", "POST", typeof(EmployeeIdentificationDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/meta", "GET", typeof(EmployeeIdentificationDetailController), "GetEntityView")]
        [InlineData("/api/hrm/employee-identification-detail/meta", "GET", typeof(EmployeeIdentificationDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/count", "GET", typeof(EmployeeIdentificationDetailController), "Count")]
        [InlineData("/api/hrm/employee-identification-detail/count", "GET", typeof(EmployeeIdentificationDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/all", "GET", typeof(EmployeeIdentificationDetailController), "GetAll")]
        [InlineData("/api/hrm/employee-identification-detail/all", "GET", typeof(EmployeeIdentificationDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/export", "GET", typeof(EmployeeIdentificationDetailController), "Export")]
        [InlineData("/api/hrm/employee-identification-detail/export", "GET", typeof(EmployeeIdentificationDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/1", "GET", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/hrm/employee-identification-detail/1", "GET", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/get?employeeIdentificationDetailIds=1", "GET", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/hrm/employee-identification-detail/get?employeeIdentificationDetailIds=1", "GET", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail", "GET", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-identification-detail", "GET", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/page/1", "GET", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-identification-detail/page/1", "GET", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/count-filtered/{filterName}", "GET", typeof(EmployeeIdentificationDetailController), "CountFiltered")]
        [InlineData("/api/hrm/employee-identification-detail/count-filtered/{filterName}", "GET", typeof(EmployeeIdentificationDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeIdentificationDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-identification-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeIdentificationDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-identification-detail/first", "GET", typeof(EmployeeIdentificationDetailController), "GetFirst")]
        [InlineData("/api/hrm/employee-identification-detail/previous/1", "GET", typeof(EmployeeIdentificationDetailController), "GetPrevious")]
        [InlineData("/api/hrm/employee-identification-detail/next/1", "GET", typeof(EmployeeIdentificationDetailController), "GetNext")]
        [InlineData("/api/hrm/employee-identification-detail/last", "GET", typeof(EmployeeIdentificationDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/custom-fields", "GET", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-identification-detail/custom-fields", "GET", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/custom-fields/{resourceId}", "GET", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-identification-detail/custom-fields/{resourceId}", "GET", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/meta", "HEAD", typeof(EmployeeIdentificationDetailController), "GetEntityView")]
        [InlineData("/api/hrm/employee-identification-detail/meta", "HEAD", typeof(EmployeeIdentificationDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/count", "HEAD", typeof(EmployeeIdentificationDetailController), "Count")]
        [InlineData("/api/hrm/employee-identification-detail/count", "HEAD", typeof(EmployeeIdentificationDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/all", "HEAD", typeof(EmployeeIdentificationDetailController), "GetAll")]
        [InlineData("/api/hrm/employee-identification-detail/all", "HEAD", typeof(EmployeeIdentificationDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/export", "HEAD", typeof(EmployeeIdentificationDetailController), "Export")]
        [InlineData("/api/hrm/employee-identification-detail/export", "HEAD", typeof(EmployeeIdentificationDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/1", "HEAD", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/hrm/employee-identification-detail/1", "HEAD", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/get?employeeIdentificationDetailIds=1", "HEAD", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/hrm/employee-identification-detail/get?employeeIdentificationDetailIds=1", "HEAD", typeof(EmployeeIdentificationDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail", "HEAD", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-identification-detail", "HEAD", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/page/1", "HEAD", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-identification-detail/page/1", "HEAD", typeof(EmployeeIdentificationDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/count-filtered/{filterName}", "HEAD", typeof(EmployeeIdentificationDetailController), "CountFiltered")]
        [InlineData("/api/hrm/employee-identification-detail/count-filtered/{filterName}", "HEAD", typeof(EmployeeIdentificationDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeIdentificationDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-identification-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeIdentificationDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-identification-detail/first", "HEAD", typeof(EmployeeIdentificationDetailController), "GetFirst")]
        [InlineData("/api/hrm/employee-identification-detail/previous/1", "HEAD", typeof(EmployeeIdentificationDetailController), "GetPrevious")]
        [InlineData("/api/hrm/employee-identification-detail/next/1", "HEAD", typeof(EmployeeIdentificationDetailController), "GetNext")]
        [InlineData("/api/hrm/employee-identification-detail/last", "HEAD", typeof(EmployeeIdentificationDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/custom-fields", "HEAD", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-identification-detail/custom-fields", "HEAD", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-identification-detail/custom-fields/{resourceId}", "HEAD", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-identification-detail/custom-fields/{resourceId}", "HEAD", typeof(EmployeeIdentificationDetailController), "GetCustomFields")]

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

        public EmployeeIdentificationDetailRouteTests()
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