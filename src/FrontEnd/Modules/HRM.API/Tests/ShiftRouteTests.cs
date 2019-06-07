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
    public class ShiftRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/delete/{shiftId}", "DELETE", typeof(ShiftController), "Delete")]
        [InlineData("/api/hrm/shift/delete/{shiftId}", "DELETE", typeof(ShiftController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/edit/{shiftId}", "PUT", typeof(ShiftController), "Edit")]
        [InlineData("/api/hrm/shift/edit/{shiftId}", "PUT", typeof(ShiftController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/count-where", "POST", typeof(ShiftController), "CountWhere")]
        [InlineData("/api/hrm/shift/count-where", "POST", typeof(ShiftController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/get-where/{pageNumber}", "POST", typeof(ShiftController), "GetWhere")]
        [InlineData("/api/hrm/shift/get-where/{pageNumber}", "POST", typeof(ShiftController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/add-or-edit", "POST", typeof(ShiftController), "AddOrEdit")]
        [InlineData("/api/hrm/shift/add-or-edit", "POST", typeof(ShiftController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/add/{shift}", "POST", typeof(ShiftController), "Add")]
        [InlineData("/api/hrm/shift/add/{shift}", "POST", typeof(ShiftController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/bulk-import", "POST", typeof(ShiftController), "BulkImport")]
        [InlineData("/api/hrm/shift/bulk-import", "POST", typeof(ShiftController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/meta", "GET", typeof(ShiftController), "GetEntityView")]
        [InlineData("/api/hrm/shift/meta", "GET", typeof(ShiftController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/count", "GET", typeof(ShiftController), "Count")]
        [InlineData("/api/hrm/shift/count", "GET", typeof(ShiftController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/all", "GET", typeof(ShiftController), "GetAll")]
        [InlineData("/api/hrm/shift/all", "GET", typeof(ShiftController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/export", "GET", typeof(ShiftController), "Export")]
        [InlineData("/api/hrm/shift/export", "GET", typeof(ShiftController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/1", "GET", typeof(ShiftController), "Get")]
        [InlineData("/api/hrm/shift/1", "GET", typeof(ShiftController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/get?shiftIds=1", "GET", typeof(ShiftController), "Get")]
        [InlineData("/api/hrm/shift/get?shiftIds=1", "GET", typeof(ShiftController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift", "GET", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/hrm/shift", "GET", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/page/1", "GET", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/hrm/shift/page/1", "GET", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/count-filtered/{filterName}", "GET", typeof(ShiftController), "CountFiltered")]
        [InlineData("/api/hrm/shift/count-filtered/{filterName}", "GET", typeof(ShiftController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShiftController), "GetFiltered")]
        [InlineData("/api/hrm/shift/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ShiftController), "GetFiltered")]
        [InlineData("/api/hrm/shift/first", "GET", typeof(ShiftController), "GetFirst")]
        [InlineData("/api/hrm/shift/previous/1", "GET", typeof(ShiftController), "GetPrevious")]
        [InlineData("/api/hrm/shift/next/1", "GET", typeof(ShiftController), "GetNext")]
        [InlineData("/api/hrm/shift/last", "GET", typeof(ShiftController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/shift/custom-fields", "GET", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/hrm/shift/custom-fields", "GET", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/custom-fields/{resourceId}", "GET", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/hrm/shift/custom-fields/{resourceId}", "GET", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/meta", "HEAD", typeof(ShiftController), "GetEntityView")]
        [InlineData("/api/hrm/shift/meta", "HEAD", typeof(ShiftController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/count", "HEAD", typeof(ShiftController), "Count")]
        [InlineData("/api/hrm/shift/count", "HEAD", typeof(ShiftController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/all", "HEAD", typeof(ShiftController), "GetAll")]
        [InlineData("/api/hrm/shift/all", "HEAD", typeof(ShiftController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/export", "HEAD", typeof(ShiftController), "Export")]
        [InlineData("/api/hrm/shift/export", "HEAD", typeof(ShiftController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/1", "HEAD", typeof(ShiftController), "Get")]
        [InlineData("/api/hrm/shift/1", "HEAD", typeof(ShiftController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/get?shiftIds=1", "HEAD", typeof(ShiftController), "Get")]
        [InlineData("/api/hrm/shift/get?shiftIds=1", "HEAD", typeof(ShiftController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift", "HEAD", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/hrm/shift", "HEAD", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/page/1", "HEAD", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/hrm/shift/page/1", "HEAD", typeof(ShiftController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/count-filtered/{filterName}", "HEAD", typeof(ShiftController), "CountFiltered")]
        [InlineData("/api/hrm/shift/count-filtered/{filterName}", "HEAD", typeof(ShiftController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShiftController), "GetFiltered")]
        [InlineData("/api/hrm/shift/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ShiftController), "GetFiltered")]
        [InlineData("/api/hrm/shift/first", "HEAD", typeof(ShiftController), "GetFirst")]
        [InlineData("/api/hrm/shift/previous/1", "HEAD", typeof(ShiftController), "GetPrevious")]
        [InlineData("/api/hrm/shift/next/1", "HEAD", typeof(ShiftController), "GetNext")]
        [InlineData("/api/hrm/shift/last", "HEAD", typeof(ShiftController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/shift/custom-fields", "HEAD", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/hrm/shift/custom-fields", "HEAD", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/shift/custom-fields/{resourceId}", "HEAD", typeof(ShiftController), "GetCustomFields")]
        [InlineData("/api/hrm/shift/custom-fields/{resourceId}", "HEAD", typeof(ShiftController), "GetCustomFields")]

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

        public ShiftRouteTests()
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