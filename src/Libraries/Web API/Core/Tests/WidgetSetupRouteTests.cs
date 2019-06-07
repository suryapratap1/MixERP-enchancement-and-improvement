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
    public class WidgetSetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/delete/{widgetSetupId}", "DELETE", typeof(WidgetSetupController), "Delete")]
        [InlineData("/api/core/widget-setup/delete/{widgetSetupId}", "DELETE", typeof(WidgetSetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/edit/{widgetSetupId}", "PUT", typeof(WidgetSetupController), "Edit")]
        [InlineData("/api/core/widget-setup/edit/{widgetSetupId}", "PUT", typeof(WidgetSetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/count-where", "POST", typeof(WidgetSetupController), "CountWhere")]
        [InlineData("/api/core/widget-setup/count-where", "POST", typeof(WidgetSetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/get-where/{pageNumber}", "POST", typeof(WidgetSetupController), "GetWhere")]
        [InlineData("/api/core/widget-setup/get-where/{pageNumber}", "POST", typeof(WidgetSetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/add-or-edit", "POST", typeof(WidgetSetupController), "AddOrEdit")]
        [InlineData("/api/core/widget-setup/add-or-edit", "POST", typeof(WidgetSetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/add/{widgetSetup}", "POST", typeof(WidgetSetupController), "Add")]
        [InlineData("/api/core/widget-setup/add/{widgetSetup}", "POST", typeof(WidgetSetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/bulk-import", "POST", typeof(WidgetSetupController), "BulkImport")]
        [InlineData("/api/core/widget-setup/bulk-import", "POST", typeof(WidgetSetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/meta", "GET", typeof(WidgetSetupController), "GetEntityView")]
        [InlineData("/api/core/widget-setup/meta", "GET", typeof(WidgetSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/count", "GET", typeof(WidgetSetupController), "Count")]
        [InlineData("/api/core/widget-setup/count", "GET", typeof(WidgetSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/all", "GET", typeof(WidgetSetupController), "GetAll")]
        [InlineData("/api/core/widget-setup/all", "GET", typeof(WidgetSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/export", "GET", typeof(WidgetSetupController), "Export")]
        [InlineData("/api/core/widget-setup/export", "GET", typeof(WidgetSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/1", "GET", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/core/widget-setup/1", "GET", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/get?widgetSetupIds=1", "GET", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/core/widget-setup/get?widgetSetupIds=1", "GET", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup", "GET", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup", "GET", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/page/1", "GET", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup/page/1", "GET", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/count-filtered/{filterName}", "GET", typeof(WidgetSetupController), "CountFiltered")]
        [InlineData("/api/core/widget-setup/count-filtered/{filterName}", "GET", typeof(WidgetSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetSetupController), "GetFiltered")]
        [InlineData("/api/core/widget-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(WidgetSetupController), "GetFiltered")]
        [InlineData("/api/core/widget-setup/first", "GET", typeof(WidgetSetupController), "GetFirst")]
        [InlineData("/api/core/widget-setup/previous/1", "GET", typeof(WidgetSetupController), "GetPrevious")]
        [InlineData("/api/core/widget-setup/next/1", "GET", typeof(WidgetSetupController), "GetNext")]
        [InlineData("/api/core/widget-setup/last", "GET", typeof(WidgetSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/widget-setup/custom-fields", "GET", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/core/widget-setup/custom-fields", "GET", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/custom-fields/{resourceId}", "GET", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/core/widget-setup/custom-fields/{resourceId}", "GET", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/meta", "HEAD", typeof(WidgetSetupController), "GetEntityView")]
        [InlineData("/api/core/widget-setup/meta", "HEAD", typeof(WidgetSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/count", "HEAD", typeof(WidgetSetupController), "Count")]
        [InlineData("/api/core/widget-setup/count", "HEAD", typeof(WidgetSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/all", "HEAD", typeof(WidgetSetupController), "GetAll")]
        [InlineData("/api/core/widget-setup/all", "HEAD", typeof(WidgetSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/export", "HEAD", typeof(WidgetSetupController), "Export")]
        [InlineData("/api/core/widget-setup/export", "HEAD", typeof(WidgetSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/1", "HEAD", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/core/widget-setup/1", "HEAD", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/get?widgetSetupIds=1", "HEAD", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/core/widget-setup/get?widgetSetupIds=1", "HEAD", typeof(WidgetSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup", "HEAD", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup", "HEAD", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/page/1", "HEAD", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/widget-setup/page/1", "HEAD", typeof(WidgetSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/count-filtered/{filterName}", "HEAD", typeof(WidgetSetupController), "CountFiltered")]
        [InlineData("/api/core/widget-setup/count-filtered/{filterName}", "HEAD", typeof(WidgetSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetSetupController), "GetFiltered")]
        [InlineData("/api/core/widget-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(WidgetSetupController), "GetFiltered")]
        [InlineData("/api/core/widget-setup/first", "HEAD", typeof(WidgetSetupController), "GetFirst")]
        [InlineData("/api/core/widget-setup/previous/1", "HEAD", typeof(WidgetSetupController), "GetPrevious")]
        [InlineData("/api/core/widget-setup/next/1", "HEAD", typeof(WidgetSetupController), "GetNext")]
        [InlineData("/api/core/widget-setup/last", "HEAD", typeof(WidgetSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/widget-setup/custom-fields", "HEAD", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/core/widget-setup/custom-fields", "HEAD", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/widget-setup/custom-fields/{resourceId}", "HEAD", typeof(WidgetSetupController), "GetCustomFields")]
        [InlineData("/api/core/widget-setup/custom-fields/{resourceId}", "HEAD", typeof(WidgetSetupController), "GetCustomFields")]

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

        public WidgetSetupRouteTests()
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