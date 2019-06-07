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
    public class EmployeeTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/delete/{employeeTypeId}", "DELETE", typeof(EmployeeTypeController), "Delete")]
        [InlineData("/api/hrm/employee-type/delete/{employeeTypeId}", "DELETE", typeof(EmployeeTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/edit/{employeeTypeId}", "PUT", typeof(EmployeeTypeController), "Edit")]
        [InlineData("/api/hrm/employee-type/edit/{employeeTypeId}", "PUT", typeof(EmployeeTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/count-where", "POST", typeof(EmployeeTypeController), "CountWhere")]
        [InlineData("/api/hrm/employee-type/count-where", "POST", typeof(EmployeeTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/get-where/{pageNumber}", "POST", typeof(EmployeeTypeController), "GetWhere")]
        [InlineData("/api/hrm/employee-type/get-where/{pageNumber}", "POST", typeof(EmployeeTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/add-or-edit", "POST", typeof(EmployeeTypeController), "AddOrEdit")]
        [InlineData("/api/hrm/employee-type/add-or-edit", "POST", typeof(EmployeeTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/add/{employeeType}", "POST", typeof(EmployeeTypeController), "Add")]
        [InlineData("/api/hrm/employee-type/add/{employeeType}", "POST", typeof(EmployeeTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/bulk-import", "POST", typeof(EmployeeTypeController), "BulkImport")]
        [InlineData("/api/hrm/employee-type/bulk-import", "POST", typeof(EmployeeTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/meta", "GET", typeof(EmployeeTypeController), "GetEntityView")]
        [InlineData("/api/hrm/employee-type/meta", "GET", typeof(EmployeeTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/count", "GET", typeof(EmployeeTypeController), "Count")]
        [InlineData("/api/hrm/employee-type/count", "GET", typeof(EmployeeTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/all", "GET", typeof(EmployeeTypeController), "GetAll")]
        [InlineData("/api/hrm/employee-type/all", "GET", typeof(EmployeeTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/export", "GET", typeof(EmployeeTypeController), "Export")]
        [InlineData("/api/hrm/employee-type/export", "GET", typeof(EmployeeTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/1", "GET", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/hrm/employee-type/1", "GET", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/get?employeeTypeIds=1", "GET", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/hrm/employee-type/get?employeeTypeIds=1", "GET", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type", "GET", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-type", "GET", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/page/1", "GET", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-type/page/1", "GET", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/count-filtered/{filterName}", "GET", typeof(EmployeeTypeController), "CountFiltered")]
        [InlineData("/api/hrm/employee-type/count-filtered/{filterName}", "GET", typeof(EmployeeTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeTypeController), "GetFiltered")]
        [InlineData("/api/hrm/employee-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeTypeController), "GetFiltered")]
        [InlineData("/api/hrm/employee-type/first", "GET", typeof(EmployeeTypeController), "GetFirst")]
        [InlineData("/api/hrm/employee-type/previous/1", "GET", typeof(EmployeeTypeController), "GetPrevious")]
        [InlineData("/api/hrm/employee-type/next/1", "GET", typeof(EmployeeTypeController), "GetNext")]
        [InlineData("/api/hrm/employee-type/last", "GET", typeof(EmployeeTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/custom-fields", "GET", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-type/custom-fields", "GET", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/custom-fields/{resourceId}", "GET", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-type/custom-fields/{resourceId}", "GET", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/meta", "HEAD", typeof(EmployeeTypeController), "GetEntityView")]
        [InlineData("/api/hrm/employee-type/meta", "HEAD", typeof(EmployeeTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/count", "HEAD", typeof(EmployeeTypeController), "Count")]
        [InlineData("/api/hrm/employee-type/count", "HEAD", typeof(EmployeeTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/all", "HEAD", typeof(EmployeeTypeController), "GetAll")]
        [InlineData("/api/hrm/employee-type/all", "HEAD", typeof(EmployeeTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/export", "HEAD", typeof(EmployeeTypeController), "Export")]
        [InlineData("/api/hrm/employee-type/export", "HEAD", typeof(EmployeeTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/1", "HEAD", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/hrm/employee-type/1", "HEAD", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/get?employeeTypeIds=1", "HEAD", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/hrm/employee-type/get?employeeTypeIds=1", "HEAD", typeof(EmployeeTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type", "HEAD", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-type", "HEAD", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/page/1", "HEAD", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-type/page/1", "HEAD", typeof(EmployeeTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/count-filtered/{filterName}", "HEAD", typeof(EmployeeTypeController), "CountFiltered")]
        [InlineData("/api/hrm/employee-type/count-filtered/{filterName}", "HEAD", typeof(EmployeeTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeTypeController), "GetFiltered")]
        [InlineData("/api/hrm/employee-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeTypeController), "GetFiltered")]
        [InlineData("/api/hrm/employee-type/first", "HEAD", typeof(EmployeeTypeController), "GetFirst")]
        [InlineData("/api/hrm/employee-type/previous/1", "HEAD", typeof(EmployeeTypeController), "GetPrevious")]
        [InlineData("/api/hrm/employee-type/next/1", "HEAD", typeof(EmployeeTypeController), "GetNext")]
        [InlineData("/api/hrm/employee-type/last", "HEAD", typeof(EmployeeTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/custom-fields", "HEAD", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-type/custom-fields", "HEAD", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-type/custom-fields/{resourceId}", "HEAD", typeof(EmployeeTypeController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-type/custom-fields/{resourceId}", "HEAD", typeof(EmployeeTypeController), "GetCustomFields")]

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

        public EmployeeTypeRouteTests()
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