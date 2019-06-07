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
    public class WidgetGroupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/delete/{widgetGroupName}", "DELETE", typeof(WidgetGroupController), "Delete")]
        [InlineData("/api/core/widget-group/delete/{widgetGroupName}", "DELETE", typeof(WidgetGroupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/edit/{widgetGroupName}", "PUT", typeof(WidgetGroupController), "Edit")]
        [InlineData("/api/core/widget-group/edit/{widgetGroupName}", "PUT", typeof(WidgetGroupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/count-where", "POST", typeof(WidgetGroupController), "CountWhere")]
        [InlineData("/api/core/widget-group/count-where", "POST", typeof(WidgetGroupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/get-where/{pageNumber}", "POST", typeof(WidgetGroupController), "GetWhere")]
        [InlineData("/api/core/widget-group/get-where/{pageNumber}", "POST", typeof(WidgetGroupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/add-or-edit", "POST", typeof(WidgetGroupController), "AddOrEdit")]
        [InlineData("/api/core/widget-group/add-or-edit", "POST", typeof(WidgetGroupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/add/{widgetGroup}", "POST", typeof(WidgetGroupController), "Add")]
        [InlineData("/api/core/widget-group/add/{widgetGroup}", "POST", typeof(WidgetGroupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/bulk-import", "POST", typeof(WidgetGroupController), "BulkImport")]
        [InlineData("/api/core/widget-group/bulk-import", "POST", typeof(WidgetGroupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/meta", "GET", typeof(WidgetGroupController), "GetEntityView")]
        [InlineData("/api/core/widget-group/meta", "GET", typeof(WidgetGroupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/count", "GET", typeof(WidgetGroupController), "Count")]
        [InlineData("/api/core/widget-group/count", "GET", typeof(WidgetGroupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/all", "GET", typeof(WidgetGroupController), "GetAll")]
        [InlineData("/api/core/widget-group/all", "GET", typeof(WidgetGroupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/export", "GET", typeof(WidgetGroupController), "Export")]
        [InlineData("/api/core/widget-group/export", "GET", typeof(WidgetGroupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/1", "GET", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/core/widget-group/1", "GET", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/get?widgetGroupNames=1", "GET", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/core/widget-group/get?widgetGroupNames=1", "GET", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group", "GET", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-group", "GET", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/page/1", "GET", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-group/page/1", "GET", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/count-filtered/{filterName}", "GET", typeof(WidgetGroupController), "CountFiltered")]
        [InlineData("/api/core/widget-group/count-filtered/{filterName}", "GET", typeof(WidgetGroupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetGroupController), "GetFiltered")]
        [InlineData("/api/core/widget-group/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetGroupController), "GetFiltered")]
        [InlineData("/api/core/widget-group/first", "GET", typeof(WidgetGroupController), "GetFirst")]
        [InlineData("/api/core/widget-group/previous/1", "GET", typeof(WidgetGroupController), "GetPrevious")]
        [InlineData("/api/core/widget-group/next/1", "GET", typeof(WidgetGroupController), "GetNext")]
        [InlineData("/api/core/widget-group/last", "GET", typeof(WidgetGroupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/widget-group/custom-fields", "GET", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/core/widget-group/custom-fields", "GET", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/custom-fields/{resourceId}", "GET", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/core/widget-group/custom-fields/{resourceId}", "GET", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/meta", "HEAD", typeof(WidgetGroupController), "GetEntityView")]
        [InlineData("/api/core/widget-group/meta", "HEAD", typeof(WidgetGroupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/count", "HEAD", typeof(WidgetGroupController), "Count")]
        [InlineData("/api/core/widget-group/count", "HEAD", typeof(WidgetGroupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/all", "HEAD", typeof(WidgetGroupController), "GetAll")]
        [InlineData("/api/core/widget-group/all", "HEAD", typeof(WidgetGroupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/export", "HEAD", typeof(WidgetGroupController), "Export")]
        [InlineData("/api/core/widget-group/export", "HEAD", typeof(WidgetGroupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/1", "HEAD", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/core/widget-group/1", "HEAD", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/get?widgetGroupNames=1", "HEAD", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/core/widget-group/get?widgetGroupNames=1", "HEAD", typeof(WidgetGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group", "HEAD", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-group", "HEAD", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/page/1", "HEAD", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-group/page/1", "HEAD", typeof(WidgetGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/count-filtered/{filterName}", "HEAD", typeof(WidgetGroupController), "CountFiltered")]
        [InlineData("/api/core/widget-group/count-filtered/{filterName}", "HEAD", typeof(WidgetGroupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetGroupController), "GetFiltered")]
        [InlineData("/api/core/widget-group/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetGroupController), "GetFiltered")]
        [InlineData("/api/core/widget-group/first", "HEAD", typeof(WidgetGroupController), "GetFirst")]
        [InlineData("/api/core/widget-group/previous/1", "HEAD", typeof(WidgetGroupController), "GetPrevious")]
        [InlineData("/api/core/widget-group/next/1", "HEAD", typeof(WidgetGroupController), "GetNext")]
        [InlineData("/api/core/widget-group/last", "HEAD", typeof(WidgetGroupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/widget-group/custom-fields", "HEAD", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/core/widget-group/custom-fields", "HEAD", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-group/custom-fields/{resourceId}", "HEAD", typeof(WidgetGroupController), "GetCustomFields")]
        [InlineData("/api/core/widget-group/custom-fields/{resourceId}", "HEAD", typeof(WidgetGroupController), "GetCustomFields")]

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

        public WidgetGroupRouteTests()
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