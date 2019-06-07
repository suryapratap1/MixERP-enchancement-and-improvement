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
    public class OfficeHourRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/delete/{officeHourId}", "DELETE", typeof(OfficeHourController), "Delete")]
        [InlineData("/api/hrm/office-hour/delete/{officeHourId}", "DELETE", typeof(OfficeHourController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/edit/{officeHourId}", "PUT", typeof(OfficeHourController), "Edit")]
        [InlineData("/api/hrm/office-hour/edit/{officeHourId}", "PUT", typeof(OfficeHourController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/count-where", "POST", typeof(OfficeHourController), "CountWhere")]
        [InlineData("/api/hrm/office-hour/count-where", "POST", typeof(OfficeHourController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/get-where/{pageNumber}", "POST", typeof(OfficeHourController), "GetWhere")]
        [InlineData("/api/hrm/office-hour/get-where/{pageNumber}", "POST", typeof(OfficeHourController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/add-or-edit", "POST", typeof(OfficeHourController), "AddOrEdit")]
        [InlineData("/api/hrm/office-hour/add-or-edit", "POST", typeof(OfficeHourController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/add/{officeHour}", "POST", typeof(OfficeHourController), "Add")]
        [InlineData("/api/hrm/office-hour/add/{officeHour}", "POST", typeof(OfficeHourController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/bulk-import", "POST", typeof(OfficeHourController), "BulkImport")]
        [InlineData("/api/hrm/office-hour/bulk-import", "POST", typeof(OfficeHourController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/meta", "GET", typeof(OfficeHourController), "GetEntityView")]
        [InlineData("/api/hrm/office-hour/meta", "GET", typeof(OfficeHourController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/count", "GET", typeof(OfficeHourController), "Count")]
        [InlineData("/api/hrm/office-hour/count", "GET", typeof(OfficeHourController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/all", "GET", typeof(OfficeHourController), "GetAll")]
        [InlineData("/api/hrm/office-hour/all", "GET", typeof(OfficeHourController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/export", "GET", typeof(OfficeHourController), "Export")]
        [InlineData("/api/hrm/office-hour/export", "GET", typeof(OfficeHourController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/1", "GET", typeof(OfficeHourController), "Get")]
        [InlineData("/api/hrm/office-hour/1", "GET", typeof(OfficeHourController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/get?officeHourIds=1", "GET", typeof(OfficeHourController), "Get")]
        [InlineData("/api/hrm/office-hour/get?officeHourIds=1", "GET", typeof(OfficeHourController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour", "GET", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/hrm/office-hour", "GET", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/page/1", "GET", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/hrm/office-hour/page/1", "GET", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/count-filtered/{filterName}", "GET", typeof(OfficeHourController), "CountFiltered")]
        [InlineData("/api/hrm/office-hour/count-filtered/{filterName}", "GET", typeof(OfficeHourController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/get-filtered/{pageNumber}/{filterName}", "GET", typeof(OfficeHourController), "GetFiltered")]
        [InlineData("/api/hrm/office-hour/get-filtered/{pageNumber}/{filterName}", "GET", typeof(OfficeHourController), "GetFiltered")]
        [InlineData("/api/hrm/office-hour/first", "GET", typeof(OfficeHourController), "GetFirst")]
        [InlineData("/api/hrm/office-hour/previous/1", "GET", typeof(OfficeHourController), "GetPrevious")]
        [InlineData("/api/hrm/office-hour/next/1", "GET", typeof(OfficeHourController), "GetNext")]
        [InlineData("/api/hrm/office-hour/last", "GET", typeof(OfficeHourController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/custom-fields", "GET", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/hrm/office-hour/custom-fields", "GET", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/custom-fields/{resourceId}", "GET", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/hrm/office-hour/custom-fields/{resourceId}", "GET", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/meta", "HEAD", typeof(OfficeHourController), "GetEntityView")]
        [InlineData("/api/hrm/office-hour/meta", "HEAD", typeof(OfficeHourController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/count", "HEAD", typeof(OfficeHourController), "Count")]
        [InlineData("/api/hrm/office-hour/count", "HEAD", typeof(OfficeHourController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/all", "HEAD", typeof(OfficeHourController), "GetAll")]
        [InlineData("/api/hrm/office-hour/all", "HEAD", typeof(OfficeHourController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/export", "HEAD", typeof(OfficeHourController), "Export")]
        [InlineData("/api/hrm/office-hour/export", "HEAD", typeof(OfficeHourController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/1", "HEAD", typeof(OfficeHourController), "Get")]
        [InlineData("/api/hrm/office-hour/1", "HEAD", typeof(OfficeHourController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/get?officeHourIds=1", "HEAD", typeof(OfficeHourController), "Get")]
        [InlineData("/api/hrm/office-hour/get?officeHourIds=1", "HEAD", typeof(OfficeHourController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour", "HEAD", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/hrm/office-hour", "HEAD", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/page/1", "HEAD", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/hrm/office-hour/page/1", "HEAD", typeof(OfficeHourController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/count-filtered/{filterName}", "HEAD", typeof(OfficeHourController), "CountFiltered")]
        [InlineData("/api/hrm/office-hour/count-filtered/{filterName}", "HEAD", typeof(OfficeHourController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(OfficeHourController), "GetFiltered")]
        [InlineData("/api/hrm/office-hour/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(OfficeHourController), "GetFiltered")]
        [InlineData("/api/hrm/office-hour/first", "HEAD", typeof(OfficeHourController), "GetFirst")]
        [InlineData("/api/hrm/office-hour/previous/1", "HEAD", typeof(OfficeHourController), "GetPrevious")]
        [InlineData("/api/hrm/office-hour/next/1", "HEAD", typeof(OfficeHourController), "GetNext")]
        [InlineData("/api/hrm/office-hour/last", "HEAD", typeof(OfficeHourController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/custom-fields", "HEAD", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/hrm/office-hour/custom-fields", "HEAD", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/office-hour/custom-fields/{resourceId}", "HEAD", typeof(OfficeHourController), "GetCustomFields")]
        [InlineData("/api/hrm/office-hour/custom-fields/{resourceId}", "HEAD", typeof(OfficeHourController), "GetCustomFields")]

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

        public OfficeHourRouteTests()
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