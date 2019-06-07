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
    public class EmployeeSocialNetworkDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/delete/{employeeSocialNetworkDetailId}", "DELETE", typeof(EmployeeSocialNetworkDetailController), "Delete")]
        [InlineData("/api/hrm/employee-social-network-detail/delete/{employeeSocialNetworkDetailId}", "DELETE", typeof(EmployeeSocialNetworkDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/edit/{employeeSocialNetworkDetailId}", "PUT", typeof(EmployeeSocialNetworkDetailController), "Edit")]
        [InlineData("/api/hrm/employee-social-network-detail/edit/{employeeSocialNetworkDetailId}", "PUT", typeof(EmployeeSocialNetworkDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/count-where", "POST", typeof(EmployeeSocialNetworkDetailController), "CountWhere")]
        [InlineData("/api/hrm/employee-social-network-detail/count-where", "POST", typeof(EmployeeSocialNetworkDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/get-where/{pageNumber}", "POST", typeof(EmployeeSocialNetworkDetailController), "GetWhere")]
        [InlineData("/api/hrm/employee-social-network-detail/get-where/{pageNumber}", "POST", typeof(EmployeeSocialNetworkDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/add-or-edit", "POST", typeof(EmployeeSocialNetworkDetailController), "AddOrEdit")]
        [InlineData("/api/hrm/employee-social-network-detail/add-or-edit", "POST", typeof(EmployeeSocialNetworkDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/add/{employeeSocialNetworkDetail}", "POST", typeof(EmployeeSocialNetworkDetailController), "Add")]
        [InlineData("/api/hrm/employee-social-network-detail/add/{employeeSocialNetworkDetail}", "POST", typeof(EmployeeSocialNetworkDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/bulk-import", "POST", typeof(EmployeeSocialNetworkDetailController), "BulkImport")]
        [InlineData("/api/hrm/employee-social-network-detail/bulk-import", "POST", typeof(EmployeeSocialNetworkDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/meta", "GET", typeof(EmployeeSocialNetworkDetailController), "GetEntityView")]
        [InlineData("/api/hrm/employee-social-network-detail/meta", "GET", typeof(EmployeeSocialNetworkDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/count", "GET", typeof(EmployeeSocialNetworkDetailController), "Count")]
        [InlineData("/api/hrm/employee-social-network-detail/count", "GET", typeof(EmployeeSocialNetworkDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/all", "GET", typeof(EmployeeSocialNetworkDetailController), "GetAll")]
        [InlineData("/api/hrm/employee-social-network-detail/all", "GET", typeof(EmployeeSocialNetworkDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/export", "GET", typeof(EmployeeSocialNetworkDetailController), "Export")]
        [InlineData("/api/hrm/employee-social-network-detail/export", "GET", typeof(EmployeeSocialNetworkDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/1", "GET", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/hrm/employee-social-network-detail/1", "GET", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/get?employeeSocialNetworkDetailIds=1", "GET", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/hrm/employee-social-network-detail/get?employeeSocialNetworkDetailIds=1", "GET", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail", "GET", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-social-network-detail", "GET", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/page/1", "GET", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-social-network-detail/page/1", "GET", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/count-filtered/{filterName}", "GET", typeof(EmployeeSocialNetworkDetailController), "CountFiltered")]
        [InlineData("/api/hrm/employee-social-network-detail/count-filtered/{filterName}", "GET", typeof(EmployeeSocialNetworkDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeSocialNetworkDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-social-network-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EmployeeSocialNetworkDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-social-network-detail/first", "GET", typeof(EmployeeSocialNetworkDetailController), "GetFirst")]
        [InlineData("/api/hrm/employee-social-network-detail/previous/1", "GET", typeof(EmployeeSocialNetworkDetailController), "GetPrevious")]
        [InlineData("/api/hrm/employee-social-network-detail/next/1", "GET", typeof(EmployeeSocialNetworkDetailController), "GetNext")]
        [InlineData("/api/hrm/employee-social-network-detail/last", "GET", typeof(EmployeeSocialNetworkDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/custom-fields", "GET", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-social-network-detail/custom-fields", "GET", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/custom-fields/{resourceId}", "GET", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-social-network-detail/custom-fields/{resourceId}", "GET", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/meta", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetEntityView")]
        [InlineData("/api/hrm/employee-social-network-detail/meta", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/count", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Count")]
        [InlineData("/api/hrm/employee-social-network-detail/count", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/all", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetAll")]
        [InlineData("/api/hrm/employee-social-network-detail/all", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/export", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Export")]
        [InlineData("/api/hrm/employee-social-network-detail/export", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/hrm/employee-social-network-detail/1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/get?employeeSocialNetworkDetailIds=1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/hrm/employee-social-network-detail/get?employeeSocialNetworkDetailIds=1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-social-network-detail", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/page/1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/hrm/employee-social-network-detail/page/1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/count-filtered/{filterName}", "HEAD", typeof(EmployeeSocialNetworkDetailController), "CountFiltered")]
        [InlineData("/api/hrm/employee-social-network-detail/count-filtered/{filterName}", "HEAD", typeof(EmployeeSocialNetworkDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-social-network-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetFiltered")]
        [InlineData("/api/hrm/employee-social-network-detail/first", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetFirst")]
        [InlineData("/api/hrm/employee-social-network-detail/previous/1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetPrevious")]
        [InlineData("/api/hrm/employee-social-network-detail/next/1", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetNext")]
        [InlineData("/api/hrm/employee-social-network-detail/last", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/custom-fields", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-social-network-detail/custom-fields", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/employee-social-network-detail/custom-fields/{resourceId}", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]
        [InlineData("/api/hrm/employee-social-network-detail/custom-fields/{resourceId}", "HEAD", typeof(EmployeeSocialNetworkDetailController), "GetCustomFields")]

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

        public EmployeeSocialNetworkDetailRouteTests()
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