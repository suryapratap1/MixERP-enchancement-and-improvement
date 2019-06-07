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
    public class EmploymentStatusCodeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/delete/{employmentStatusCodeId}", "DELETE", typeof(EmploymentStatusCodeController), "Delete")]
        [InlineData("/api/hrm/employment-status-code/delete/{employmentStatusCodeId}", "DELETE", typeof(EmploymentStatusCodeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/edit/{employmentStatusCodeId}", "PUT", typeof(EmploymentStatusCodeController), "Edit")]
        [InlineData("/api/hrm/employment-status-code/edit/{employmentStatusCodeId}", "PUT", typeof(EmploymentStatusCodeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/count-where", "POST", typeof(EmploymentStatusCodeController), "CountWhere")]
        [InlineData("/api/hrm/employment-status-code/count-where", "POST", typeof(EmploymentStatusCodeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/get-where/{pageNumber}", "POST", typeof(EmploymentStatusCodeController), "GetWhere")]
        [InlineData("/api/hrm/employment-status-code/get-where/{pageNumber}", "POST", typeof(EmploymentStatusCodeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/add-or-edit", "POST", typeof(EmploymentStatusCodeController), "AddOrEdit")]
        [InlineData("/api/hrm/employment-status-code/add-or-edit", "POST", typeof(EmploymentStatusCodeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/add/{employmentStatusCode}", "POST", typeof(EmploymentStatusCodeController), "Add")]
        [InlineData("/api/hrm/employment-status-code/add/{employmentStatusCode}", "POST", typeof(EmploymentStatusCodeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/bulk-import", "POST", typeof(EmploymentStatusCodeController), "BulkImport")]
        [InlineData("/api/hrm/employment-status-code/bulk-import", "POST", typeof(EmploymentStatusCodeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/meta", "GET", typeof(EmploymentStatusCodeController), "GetEntityView")]
        [InlineData("/api/hrm/employment-status-code/meta", "GET", typeof(EmploymentStatusCodeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/count", "GET", typeof(EmploymentStatusCodeController), "Count")]
        [InlineData("/api/hrm/employment-status-code/count", "GET", typeof(EmploymentStatusCodeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/all", "GET", typeof(EmploymentStatusCodeController), "GetAll")]
        [InlineData("/api/hrm/employment-status-code/all", "GET", typeof(EmploymentStatusCodeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/export", "GET", typeof(EmploymentStatusCodeController), "Export")]
        [InlineData("/api/hrm/employment-status-code/export", "GET", typeof(EmploymentStatusCodeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/1", "GET", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/hrm/employment-status-code/1", "GET", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/get?employmentStatusCodeIds=1", "GET", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/hrm/employment-status-code/get?employmentStatusCodeIds=1", "GET", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code", "GET", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status-code", "GET", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/page/1", "GET", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status-code/page/1", "GET", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/count-filtered/{filterName}", "GET", typeof(EmploymentStatusCodeController), "CountFiltered")]
        [InlineData("/api/hrm/employment-status-code/count-filtered/{filterName}", "GET", typeof(EmploymentStatusCodeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmploymentStatusCodeController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status-code/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmploymentStatusCodeController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status-code/first", "GET", typeof(EmploymentStatusCodeController), "GetFirst")]
        [InlineData("/api/hrm/employment-status-code/previous/1", "GET", typeof(EmploymentStatusCodeController), "GetPrevious")]
        [InlineData("/api/hrm/employment-status-code/next/1", "GET", typeof(EmploymentStatusCodeController), "GetNext")]
        [InlineData("/api/hrm/employment-status-code/last", "GET", typeof(EmploymentStatusCodeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/custom-fields", "GET", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status-code/custom-fields", "GET", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/custom-fields/{resourceId}", "GET", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status-code/custom-fields/{resourceId}", "GET", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/meta", "HEAD", typeof(EmploymentStatusCodeController), "GetEntityView")]
        [InlineData("/api/hrm/employment-status-code/meta", "HEAD", typeof(EmploymentStatusCodeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/count", "HEAD", typeof(EmploymentStatusCodeController), "Count")]
        [InlineData("/api/hrm/employment-status-code/count", "HEAD", typeof(EmploymentStatusCodeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/all", "HEAD", typeof(EmploymentStatusCodeController), "GetAll")]
        [InlineData("/api/hrm/employment-status-code/all", "HEAD", typeof(EmploymentStatusCodeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/export", "HEAD", typeof(EmploymentStatusCodeController), "Export")]
        [InlineData("/api/hrm/employment-status-code/export", "HEAD", typeof(EmploymentStatusCodeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/1", "HEAD", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/hrm/employment-status-code/1", "HEAD", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/get?employmentStatusCodeIds=1", "HEAD", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/hrm/employment-status-code/get?employmentStatusCodeIds=1", "HEAD", typeof(EmploymentStatusCodeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code", "HEAD", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status-code", "HEAD", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/page/1", "HEAD", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employment-status-code/page/1", "HEAD", typeof(EmploymentStatusCodeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/count-filtered/{filterName}", "HEAD", typeof(EmploymentStatusCodeController), "CountFiltered")]
        [InlineData("/api/hrm/employment-status-code/count-filtered/{filterName}", "HEAD", typeof(EmploymentStatusCodeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmploymentStatusCodeController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status-code/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmploymentStatusCodeController), "GetFiltered")]
        [InlineData("/api/hrm/employment-status-code/first", "HEAD", typeof(EmploymentStatusCodeController), "GetFirst")]
        [InlineData("/api/hrm/employment-status-code/previous/1", "HEAD", typeof(EmploymentStatusCodeController), "GetPrevious")]
        [InlineData("/api/hrm/employment-status-code/next/1", "HEAD", typeof(EmploymentStatusCodeController), "GetNext")]
        [InlineData("/api/hrm/employment-status-code/last", "HEAD", typeof(EmploymentStatusCodeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/custom-fields", "HEAD", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status-code/custom-fields", "HEAD", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employment-status-code/custom-fields/{resourceId}", "HEAD", typeof(EmploymentStatusCodeController), "GetCustomFields")]
        [InlineData("/api/hrm/employment-status-code/custom-fields/{resourceId}", "HEAD", typeof(EmploymentStatusCodeController), "GetCustomFields")]

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

        public EmploymentStatusCodeRouteTests()
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