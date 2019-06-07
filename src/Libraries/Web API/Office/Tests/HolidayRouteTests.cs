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
    public class HolidayRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/holiday/delete/{holidayId}", "DELETE", typeof(HolidayController), "Delete")]
        [InlineData("/api/office/holiday/delete/{holidayId}", "DELETE", typeof(HolidayController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/edit/{holidayId}", "PUT", typeof(HolidayController), "Edit")]
        [InlineData("/api/office/holiday/edit/{holidayId}", "PUT", typeof(HolidayController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/count-where", "POST", typeof(HolidayController), "CountWhere")]
        [InlineData("/api/office/holiday/count-where", "POST", typeof(HolidayController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/get-where/{pageNumber}", "POST", typeof(HolidayController), "GetWhere")]
        [InlineData("/api/office/holiday/get-where/{pageNumber}", "POST", typeof(HolidayController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/add-or-edit", "POST", typeof(HolidayController), "AddOrEdit")]
        [InlineData("/api/office/holiday/add-or-edit", "POST", typeof(HolidayController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/add/{holiday}", "POST", typeof(HolidayController), "Add")]
        [InlineData("/api/office/holiday/add/{holiday}", "POST", typeof(HolidayController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/bulk-import", "POST", typeof(HolidayController), "BulkImport")]
        [InlineData("/api/office/holiday/bulk-import", "POST", typeof(HolidayController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/meta", "GET", typeof(HolidayController), "GetEntityView")]
        [InlineData("/api/office/holiday/meta", "GET", typeof(HolidayController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/count", "GET", typeof(HolidayController), "Count")]
        [InlineData("/api/office/holiday/count", "GET", typeof(HolidayController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/all", "GET", typeof(HolidayController), "GetAll")]
        [InlineData("/api/office/holiday/all", "GET", typeof(HolidayController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/export", "GET", typeof(HolidayController), "Export")]
        [InlineData("/api/office/holiday/export", "GET", typeof(HolidayController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/1", "GET", typeof(HolidayController), "Get")]
        [InlineData("/api/office/holiday/1", "GET", typeof(HolidayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/get?holidayIds=1", "GET", typeof(HolidayController), "Get")]
        [InlineData("/api/office/holiday/get?holidayIds=1", "GET", typeof(HolidayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/holiday", "GET", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/office/holiday", "GET", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/page/1", "GET", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/office/holiday/page/1", "GET", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/count-filtered/{filterName}", "GET", typeof(HolidayController), "CountFiltered")]
        [InlineData("/api/office/holiday/count-filtered/{filterName}", "GET", typeof(HolidayController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/get-filtered/{pageNumber}/{filterName}", "GET", typeof(HolidayController), "GetFiltered")]
        [InlineData("/api/office/holiday/get-filtered/{pageNumber}/{filterName}", "GET", typeof(HolidayController), "GetFiltered")]
        [InlineData("/api/office/holiday/first", "GET", typeof(HolidayController), "GetFirst")]
        [InlineData("/api/office/holiday/previous/1", "GET", typeof(HolidayController), "GetPrevious")]
        [InlineData("/api/office/holiday/next/1", "GET", typeof(HolidayController), "GetNext")]
        [InlineData("/api/office/holiday/last", "GET", typeof(HolidayController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/holiday/custom-fields", "GET", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/office/holiday/custom-fields", "GET", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/custom-fields/{resourceId}", "GET", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/office/holiday/custom-fields/{resourceId}", "GET", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/meta", "HEAD", typeof(HolidayController), "GetEntityView")]
        [InlineData("/api/office/holiday/meta", "HEAD", typeof(HolidayController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/count", "HEAD", typeof(HolidayController), "Count")]
        [InlineData("/api/office/holiday/count", "HEAD", typeof(HolidayController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/all", "HEAD", typeof(HolidayController), "GetAll")]
        [InlineData("/api/office/holiday/all", "HEAD", typeof(HolidayController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/export", "HEAD", typeof(HolidayController), "Export")]
        [InlineData("/api/office/holiday/export", "HEAD", typeof(HolidayController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/1", "HEAD", typeof(HolidayController), "Get")]
        [InlineData("/api/office/holiday/1", "HEAD", typeof(HolidayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/get?holidayIds=1", "HEAD", typeof(HolidayController), "Get")]
        [InlineData("/api/office/holiday/get?holidayIds=1", "HEAD", typeof(HolidayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/holiday", "HEAD", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/office/holiday", "HEAD", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/page/1", "HEAD", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/office/holiday/page/1", "HEAD", typeof(HolidayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/count-filtered/{filterName}", "HEAD", typeof(HolidayController), "CountFiltered")]
        [InlineData("/api/office/holiday/count-filtered/{filterName}", "HEAD", typeof(HolidayController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(HolidayController), "GetFiltered")]
        [InlineData("/api/office/holiday/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(HolidayController), "GetFiltered")]
        [InlineData("/api/office/holiday/first", "HEAD", typeof(HolidayController), "GetFirst")]
        [InlineData("/api/office/holiday/previous/1", "HEAD", typeof(HolidayController), "GetPrevious")]
        [InlineData("/api/office/holiday/next/1", "HEAD", typeof(HolidayController), "GetNext")]
        [InlineData("/api/office/holiday/last", "HEAD", typeof(HolidayController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/holiday/custom-fields", "HEAD", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/office/holiday/custom-fields", "HEAD", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/holiday/custom-fields/{resourceId}", "HEAD", typeof(HolidayController), "GetCustomFields")]
        [InlineData("/api/office/holiday/custom-fields/{resourceId}", "HEAD", typeof(HolidayController), "GetCustomFields")]

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

        public HolidayRouteTests()
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