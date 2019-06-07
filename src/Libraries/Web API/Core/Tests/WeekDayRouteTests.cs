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

namespace MixERP.Net.Api.Core.Tests
{
    public class WeekDayRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/week-day/delete/{weekDayId}", "DELETE", typeof(WeekDayController), "Delete")]
        [InlineData("/api/core/week-day/delete/{weekDayId}", "DELETE", typeof(WeekDayController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/edit/{weekDayId}", "PUT", typeof(WeekDayController), "Edit")]
        [InlineData("/api/core/week-day/edit/{weekDayId}", "PUT", typeof(WeekDayController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/count-where", "POST", typeof(WeekDayController), "CountWhere")]
        [InlineData("/api/core/week-day/count-where", "POST", typeof(WeekDayController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/get-where/{pageNumber}", "POST", typeof(WeekDayController), "GetWhere")]
        [InlineData("/api/core/week-day/get-where/{pageNumber}", "POST", typeof(WeekDayController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/add-or-edit", "POST", typeof(WeekDayController), "AddOrEdit")]
        [InlineData("/api/core/week-day/add-or-edit", "POST", typeof(WeekDayController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/add/{weekDay}", "POST", typeof(WeekDayController), "Add")]
        [InlineData("/api/core/week-day/add/{weekDay}", "POST", typeof(WeekDayController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/bulk-import", "POST", typeof(WeekDayController), "BulkImport")]
        [InlineData("/api/core/week-day/bulk-import", "POST", typeof(WeekDayController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/meta", "GET", typeof(WeekDayController), "GetEntityView")]
        [InlineData("/api/core/week-day/meta", "GET", typeof(WeekDayController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/count", "GET", typeof(WeekDayController), "Count")]
        [InlineData("/api/core/week-day/count", "GET", typeof(WeekDayController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/all", "GET", typeof(WeekDayController), "GetAll")]
        [InlineData("/api/core/week-day/all", "GET", typeof(WeekDayController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/export", "GET", typeof(WeekDayController), "Export")]
        [InlineData("/api/core/week-day/export", "GET", typeof(WeekDayController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/1", "GET", typeof(WeekDayController), "Get")]
        [InlineData("/api/core/week-day/1", "GET", typeof(WeekDayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/get?weekDayIds=1", "GET", typeof(WeekDayController), "Get")]
        [InlineData("/api/core/week-day/get?weekDayIds=1", "GET", typeof(WeekDayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/week-day", "GET", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/core/week-day", "GET", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/page/1", "GET", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/core/week-day/page/1", "GET", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/count-filtered/{filterName}", "GET", typeof(WeekDayController), "CountFiltered")]
        [InlineData("/api/core/week-day/count-filtered/{filterName}", "GET", typeof(WeekDayController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WeekDayController), "GetFiltered")]
        [InlineData("/api/core/week-day/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WeekDayController), "GetFiltered")]
        [InlineData("/api/core/week-day/first", "GET", typeof(WeekDayController), "GetFirst")]
        [InlineData("/api/core/week-day/previous/1", "GET", typeof(WeekDayController), "GetPrevious")]
        [InlineData("/api/core/week-day/next/1", "GET", typeof(WeekDayController), "GetNext")]
        [InlineData("/api/core/week-day/last", "GET", typeof(WeekDayController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/week-day/custom-fields", "GET", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/core/week-day/custom-fields", "GET", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/custom-fields/{resourceId}", "GET", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/core/week-day/custom-fields/{resourceId}", "GET", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/meta", "HEAD", typeof(WeekDayController), "GetEntityView")]
        [InlineData("/api/core/week-day/meta", "HEAD", typeof(WeekDayController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/count", "HEAD", typeof(WeekDayController), "Count")]
        [InlineData("/api/core/week-day/count", "HEAD", typeof(WeekDayController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/all", "HEAD", typeof(WeekDayController), "GetAll")]
        [InlineData("/api/core/week-day/all", "HEAD", typeof(WeekDayController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/export", "HEAD", typeof(WeekDayController), "Export")]
        [InlineData("/api/core/week-day/export", "HEAD", typeof(WeekDayController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/1", "HEAD", typeof(WeekDayController), "Get")]
        [InlineData("/api/core/week-day/1", "HEAD", typeof(WeekDayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/get?weekDayIds=1", "HEAD", typeof(WeekDayController), "Get")]
        [InlineData("/api/core/week-day/get?weekDayIds=1", "HEAD", typeof(WeekDayController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/week-day", "HEAD", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/core/week-day", "HEAD", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/page/1", "HEAD", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/core/week-day/page/1", "HEAD", typeof(WeekDayController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/count-filtered/{filterName}", "HEAD", typeof(WeekDayController), "CountFiltered")]
        [InlineData("/api/core/week-day/count-filtered/{filterName}", "HEAD", typeof(WeekDayController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WeekDayController), "GetFiltered")]
        [InlineData("/api/core/week-day/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WeekDayController), "GetFiltered")]
        [InlineData("/api/core/week-day/first", "HEAD", typeof(WeekDayController), "GetFirst")]
        [InlineData("/api/core/week-day/previous/1", "HEAD", typeof(WeekDayController), "GetPrevious")]
        [InlineData("/api/core/week-day/next/1", "HEAD", typeof(WeekDayController), "GetNext")]
        [InlineData("/api/core/week-day/last", "HEAD", typeof(WeekDayController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/week-day/custom-fields", "HEAD", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/core/week-day/custom-fields", "HEAD", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/week-day/custom-fields/{resourceId}", "HEAD", typeof(WeekDayController), "GetCustomFields")]
        [InlineData("/api/core/week-day/custom-fields/{resourceId}", "HEAD", typeof(WeekDayController), "GetCustomFields")]

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

        public WeekDayRouteTests()
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