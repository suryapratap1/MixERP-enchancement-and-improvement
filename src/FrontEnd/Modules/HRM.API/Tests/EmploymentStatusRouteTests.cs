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
    public class EmploymentStatusRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/delete/{employmentStatusId}", "DELETE", typeof(EmploymentStatusController), "Delete")]
        [InlineData("/api/hrm/employment-status/delete/{employmentStatusId}", "DELETE", typeof(EmploymentStatusController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/edit/{employmentStatusId}", "PUT", typeof(EmploymentStatusController), "Edit")]
        [InlineData("/api/hrm/employment-status/edit/{employmentStatusId}", "PUT", typeof(EmploymentStatusController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/count-where", "POST", typeof(EmploymentStatusController), "CountWhere")]
        [InlineData("/api/hrm/employment-status/count-where", "POST", typeof(EmploymentStatusController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/get-where/{pageNumber}", "POST", typeof(EmploymentStatusController), "GetWhere")]
        [InlineData("/api/hrm/employment-status/get-where/{pageNumber}", "POST", typeof(EmploymentStatusController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/add-or-edit", "POST", typeof(EmploymentStatusController), "AddOrEdit")]
        [InlineData("/api/hrm/employment-status/add-or-edit", "POST", typeof(EmploymentStatusController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/add/{employmentStatus}", "POST", typeof(EmploymentStatusController), "Add")]
        [InlineData("/api/hrm/employment-status/add/{employmentStatus}", "POST", typeof(EmploymentStatusController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/bulk-import", "POST", typeof(EmploymentStatusController), "BulkImport")]
        [InlineData("/api/hrm/employment-status/bulk-import", "POST", typeof(EmploymentStatusController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/meta", "GET", typeof(EmploymentStatusController), "GetEntityView")]
        [InlineData("/api/hrm/employment-status/meta", "GET", typeof(EmploymentStatusController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/count", "GET", typeof(EmploymentStatusController), "Count")]
        [InlineData("/api/hrm/employment-status/count", "GET", typeof(EmploymentStatusController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/all", "GET", typeof(EmploymentStatusController), "GetAll")]
        [InlineData("/api/hrm/employment-status/all", "GET", typeof(EmploymentStatusController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/export", "GET", typeof(EmploymentStatusController), "Export")]
        [InlineData("/api/hrm/employment-status/export", "GET", typeof(EmploymentStatusController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/1", "GET", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/hrm/employment-status/1", "GET", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/get?employmentStatusIds=1", "GET", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/hrm/employment-status/get?employmentStatusIds=1", "GET", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status", "GET", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status", "GET", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/page/1", "GET", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status/page/1", "GET", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/count-filtered/{filterName}", "GET", typeof(EmploymentStatusController), "CountFiltered")]
        [InlineData("/api/hrm/employment-status/count-filtered/{filterName}", "GET", typeof(EmploymentStatusController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmploymentStatusController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmploymentStatusController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status/first", "GET", typeof(EmploymentStatusController), "GetFirst")]
        [InlineData("/api/hrm/employment-status/previous/1", "GET", typeof(EmploymentStatusController), "GetPrevious")]
        [InlineData("/api/hrm/employment-status/next/1", "GET", typeof(EmploymentStatusController), "GetNext")]
        [InlineData("/api/hrm/employment-status/last", "GET", typeof(EmploymentStatusController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/custom-fields", "GET", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status/custom-fields", "GET", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/custom-fields/{resourceId}", "GET", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status/custom-fields/{resourceId}", "GET", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/meta", "HEAD", typeof(EmploymentStatusController), "GetEntityView")]
        [InlineData("/api/hrm/employment-status/meta", "HEAD", typeof(EmploymentStatusController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/count", "HEAD", typeof(EmploymentStatusController), "Count")]
        [InlineData("/api/hrm/employment-status/count", "HEAD", typeof(EmploymentStatusController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/all", "HEAD", typeof(EmploymentStatusController), "GetAll")]
        [InlineData("/api/hrm/employment-status/all", "HEAD", typeof(EmploymentStatusController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/export", "HEAD", typeof(EmploymentStatusController), "Export")]
        [InlineData("/api/hrm/employment-status/export", "HEAD", typeof(EmploymentStatusController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/1", "HEAD", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/hrm/employment-status/1", "HEAD", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/get?employmentStatusIds=1", "HEAD", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/hrm/employment-status/get?employmentStatusIds=1", "HEAD", typeof(EmploymentStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status", "HEAD", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status", "HEAD", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/page/1", "HEAD", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status/page/1", "HEAD", typeof(EmploymentStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/count-filtered/{filterName}", "HEAD", typeof(EmploymentStatusController), "CountFiltered")]
        [InlineData("/api/hrm/employment-status/count-filtered/{filterName}", "HEAD", typeof(EmploymentStatusController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmploymentStatusController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmploymentStatusController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status/first", "HEAD", typeof(EmploymentStatusController), "GetFirst")]
        [InlineData("/api/hrm/employment-status/previous/1", "HEAD", typeof(EmploymentStatusController), "GetPrevious")]
        [InlineData("/api/hrm/employment-status/next/1", "HEAD", typeof(EmploymentStatusController), "GetNext")]
        [InlineData("/api/hrm/employment-status/last", "HEAD", typeof(EmploymentStatusController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/custom-fields", "HEAD", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status/custom-fields", "HEAD", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status/custom-fields/{resourceId}", "HEAD", typeof(EmploymentStatusController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status/custom-fields/{resourceId}", "HEAD", typeof(EmploymentStatusController), "GetCustomFields")]

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

        public EmploymentStatusRouteTests()
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