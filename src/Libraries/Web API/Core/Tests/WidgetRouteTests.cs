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
    public class WidgetRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/widget/delete/{widgetName}", "DELETE", typeof(WidgetController), "Delete")]
        [InlineData("/api/core/widget/delete/{widgetName}", "DELETE", typeof(WidgetController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/widget/edit/{widgetName}", "PUT", typeof(WidgetController), "Edit")]
        [InlineData("/api/core/widget/edit/{widgetName}", "PUT", typeof(WidgetController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/widget/count-where", "POST", typeof(WidgetController), "CountWhere")]
        [InlineData("/api/core/widget/count-where", "POST", typeof(WidgetController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/widget/get-where/{pageNumber}", "POST", typeof(WidgetController), "GetWhere")]
        [InlineData("/api/core/widget/get-where/{pageNumber}", "POST", typeof(WidgetController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/widget/add-or-edit", "POST", typeof(WidgetController), "AddOrEdit")]
        [InlineData("/api/core/widget/add-or-edit", "POST", typeof(WidgetController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/widget/add/{widget}", "POST", typeof(WidgetController), "Add")]
        [InlineData("/api/core/widget/add/{widget}", "POST", typeof(WidgetController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/widget/bulk-import", "POST", typeof(WidgetController), "BulkImport")]
        [InlineData("/api/core/widget/bulk-import", "POST", typeof(WidgetController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/widget/meta", "GET", typeof(WidgetController), "GetEntityView")]
        [InlineData("/api/core/widget/meta", "GET", typeof(WidgetController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/widget/count", "GET", typeof(WidgetController), "Count")]
        [InlineData("/api/core/widget/count", "GET", typeof(WidgetController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget/all", "GET", typeof(WidgetController), "GetAll")]
        [InlineData("/api/core/widget/all", "GET", typeof(WidgetController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/widget/export", "GET", typeof(WidgetController), "Export")]
        [InlineData("/api/core/widget/export", "GET", typeof(WidgetController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/widget/1", "GET", typeof(WidgetController), "Get")]
        [InlineData("/api/core/widget/1", "GET", typeof(WidgetController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget/get?widgetNames=1", "GET", typeof(WidgetController), "Get")]
        [InlineData("/api/core/widget/get?widgetNames=1", "GET", typeof(WidgetController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget", "GET", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/core/widget", "GET", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget/page/1", "GET", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/core/widget/page/1", "GET", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget/count-filtered/{filterName}", "GET", typeof(WidgetController), "CountFiltered")]
        [InlineData("/api/core/widget/count-filtered/{filterName}", "GET", typeof(WidgetController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetController), "GetFiltered")]
        [InlineData("/api/core/widget/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetController), "GetFiltered")]
        [InlineData("/api/core/widget/first", "GET", typeof(WidgetController), "GetFirst")]
        [InlineData("/api/core/widget/previous/1", "GET", typeof(WidgetController), "GetPrevious")]
        [InlineData("/api/core/widget/next/1", "GET", typeof(WidgetController), "GetNext")]
        [InlineData("/api/core/widget/last", "GET", typeof(WidgetController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/widget/custom-fields", "GET", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/core/widget/custom-fields", "GET", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget/custom-fields/{resourceId}", "GET", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/core/widget/custom-fields/{resourceId}", "GET", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget/meta", "HEAD", typeof(WidgetController), "GetEntityView")]
        [InlineData("/api/core/widget/meta", "HEAD", typeof(WidgetController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/widget/count", "HEAD", typeof(WidgetController), "Count")]
        [InlineData("/api/core/widget/count", "HEAD", typeof(WidgetController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget/all", "HEAD", typeof(WidgetController), "GetAll")]
        [InlineData("/api/core/widget/all", "HEAD", typeof(WidgetController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/widget/export", "HEAD", typeof(WidgetController), "Export")]
        [InlineData("/api/core/widget/export", "HEAD", typeof(WidgetController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/widget/1", "HEAD", typeof(WidgetController), "Get")]
        [InlineData("/api/core/widget/1", "HEAD", typeof(WidgetController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget/get?widgetNames=1", "HEAD", typeof(WidgetController), "Get")]
        [InlineData("/api/core/widget/get?widgetNames=1", "HEAD", typeof(WidgetController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget", "HEAD", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/core/widget", "HEAD", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget/page/1", "HEAD", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/core/widget/page/1", "HEAD", typeof(WidgetController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget/count-filtered/{filterName}", "HEAD", typeof(WidgetController), "CountFiltered")]
        [InlineData("/api/core/widget/count-filtered/{filterName}", "HEAD", typeof(WidgetController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetController), "GetFiltered")]
        [InlineData("/api/core/widget/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetController), "GetFiltered")]
        [InlineData("/api/core/widget/first", "HEAD", typeof(WidgetController), "GetFirst")]
        [InlineData("/api/core/widget/previous/1", "HEAD", typeof(WidgetController), "GetPrevious")]
        [InlineData("/api/core/widget/next/1", "HEAD", typeof(WidgetController), "GetNext")]
        [InlineData("/api/core/widget/last", "HEAD", typeof(WidgetController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/widget/custom-fields", "HEAD", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/core/widget/custom-fields", "HEAD", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget/custom-fields/{resourceId}", "HEAD", typeof(WidgetController), "GetCustomFields")]
        [InlineData("/api/core/widget/custom-fields/{resourceId}", "HEAD", typeof(WidgetController), "GetCustomFields")]

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

        public WidgetRouteTests()
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