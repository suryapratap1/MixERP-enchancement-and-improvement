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

namespace MixERP.Net.Api.Office.Tests
{
    public class DepartmentRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/department/delete/{departmentId}", "DELETE", typeof(DepartmentController), "Delete")]
        [InlineData("/api/office/department/delete/{departmentId}", "DELETE", typeof(DepartmentController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/department/edit/{departmentId}", "PUT", typeof(DepartmentController), "Edit")]
        [InlineData("/api/office/department/edit/{departmentId}", "PUT", typeof(DepartmentController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/department/count-where", "POST", typeof(DepartmentController), "CountWhere")]
        [InlineData("/api/office/department/count-where", "POST", typeof(DepartmentController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/department/get-where/{pageNumber}", "POST", typeof(DepartmentController), "GetWhere")]
        [InlineData("/api/office/department/get-where/{pageNumber}", "POST", typeof(DepartmentController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/department/add-or-edit", "POST", typeof(DepartmentController), "AddOrEdit")]
        [InlineData("/api/office/department/add-or-edit", "POST", typeof(DepartmentController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/department/add/{department}", "POST", typeof(DepartmentController), "Add")]
        [InlineData("/api/office/department/add/{department}", "POST", typeof(DepartmentController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/department/bulk-import", "POST", typeof(DepartmentController), "BulkImport")]
        [InlineData("/api/office/department/bulk-import", "POST", typeof(DepartmentController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/department/meta", "GET", typeof(DepartmentController), "GetEntityView")]
        [InlineData("/api/office/department/meta", "GET", typeof(DepartmentController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/department/count", "GET", typeof(DepartmentController), "Count")]
        [InlineData("/api/office/department/count", "GET", typeof(DepartmentController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/department/all", "GET", typeof(DepartmentController), "GetAll")]
        [InlineData("/api/office/department/all", "GET", typeof(DepartmentController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/department/export", "GET", typeof(DepartmentController), "Export")]
        [InlineData("/api/office/department/export", "GET", typeof(DepartmentController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/department/1", "GET", typeof(DepartmentController), "Get")]
        [InlineData("/api/office/department/1", "GET", typeof(DepartmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/department/get?departmentIds=1", "GET", typeof(DepartmentController), "Get")]
        [InlineData("/api/office/department/get?departmentIds=1", "GET", typeof(DepartmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/department", "GET", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/office/department", "GET", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/department/page/1", "GET", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/office/department/page/1", "GET", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/department/count-filtered/{filterName}", "GET", typeof(DepartmentController), "CountFiltered")]
        [InlineData("/api/office/department/count-filtered/{filterName}", "GET", typeof(DepartmentController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/department/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DepartmentController), "GetFiltered")]
        [InlineData("/api/office/department/get-filtered/{pageNumber}/{filterName}", "GET", typeof(DepartmentController), "GetFiltered")]
        [InlineData("/api/office/department/first", "GET", typeof(DepartmentController), "GetFirst")]
        [InlineData("/api/office/department/previous/1", "GET", typeof(DepartmentController), "GetPrevious")]
        [InlineData("/api/office/department/next/1", "GET", typeof(DepartmentController), "GetNext")]
        [InlineData("/api/office/department/last", "GET", typeof(DepartmentController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/department/custom-fields", "GET", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/office/department/custom-fields", "GET", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/department/custom-fields/{resourceId}", "GET", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/office/department/custom-fields/{resourceId}", "GET", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/department/meta", "HEAD", typeof(DepartmentController), "GetEntityView")]
        [InlineData("/api/office/department/meta", "HEAD", typeof(DepartmentController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/department/count", "HEAD", typeof(DepartmentController), "Count")]
        [InlineData("/api/office/department/count", "HEAD", typeof(DepartmentController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/department/all", "HEAD", typeof(DepartmentController), "GetAll")]
        [InlineData("/api/office/department/all", "HEAD", typeof(DepartmentController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/department/export", "HEAD", typeof(DepartmentController), "Export")]
        [InlineData("/api/office/department/export", "HEAD", typeof(DepartmentController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/department/1", "HEAD", typeof(DepartmentController), "Get")]
        [InlineData("/api/office/department/1", "HEAD", typeof(DepartmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/department/get?departmentIds=1", "HEAD", typeof(DepartmentController), "Get")]
        [InlineData("/api/office/department/get?departmentIds=1", "HEAD", typeof(DepartmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/department", "HEAD", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/office/department", "HEAD", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/department/page/1", "HEAD", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/office/department/page/1", "HEAD", typeof(DepartmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/department/count-filtered/{filterName}", "HEAD", typeof(DepartmentController), "CountFiltered")]
        [InlineData("/api/office/department/count-filtered/{filterName}", "HEAD", typeof(DepartmentController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/department/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DepartmentController), "GetFiltered")]
        [InlineData("/api/office/department/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(DepartmentController), "GetFiltered")]
        [InlineData("/api/office/department/first", "HEAD", typeof(DepartmentController), "GetFirst")]
        [InlineData("/api/office/department/previous/1", "HEAD", typeof(DepartmentController), "GetPrevious")]
        [InlineData("/api/office/department/next/1", "HEAD", typeof(DepartmentController), "GetNext")]
        [InlineData("/api/office/department/last", "HEAD", typeof(DepartmentController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/department/custom-fields", "HEAD", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/office/department/custom-fields", "HEAD", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/department/custom-fields/{resourceId}", "HEAD", typeof(DepartmentController), "GetCustomFields")]
        [InlineData("/api/office/department/custom-fields/{resourceId}", "HEAD", typeof(DepartmentController), "GetCustomFields")]

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

        public DepartmentRouteTests()
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