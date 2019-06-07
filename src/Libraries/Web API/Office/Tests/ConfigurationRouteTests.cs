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
    public class ConfigurationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/configuration/delete/{configurationId}", "DELETE", typeof(ConfigurationController), "Delete")]
        [InlineData("/api/office/configuration/delete/{configurationId}", "DELETE", typeof(ConfigurationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/edit/{configurationId}", "PUT", typeof(ConfigurationController), "Edit")]
        [InlineData("/api/office/configuration/edit/{configurationId}", "PUT", typeof(ConfigurationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/count-where", "POST", typeof(ConfigurationController), "CountWhere")]
        [InlineData("/api/office/configuration/count-where", "POST", typeof(ConfigurationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/get-where/{pageNumber}", "POST", typeof(ConfigurationController), "GetWhere")]
        [InlineData("/api/office/configuration/get-where/{pageNumber}", "POST", typeof(ConfigurationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/add-or-edit", "POST", typeof(ConfigurationController), "AddOrEdit")]
        [InlineData("/api/office/configuration/add-or-edit", "POST", typeof(ConfigurationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/add/{configuration}", "POST", typeof(ConfigurationController), "Add")]
        [InlineData("/api/office/configuration/add/{configuration}", "POST", typeof(ConfigurationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/bulk-import", "POST", typeof(ConfigurationController), "BulkImport")]
        [InlineData("/api/office/configuration/bulk-import", "POST", typeof(ConfigurationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/meta", "GET", typeof(ConfigurationController), "GetEntityView")]
        [InlineData("/api/office/configuration/meta", "GET", typeof(ConfigurationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/count", "GET", typeof(ConfigurationController), "Count")]
        [InlineData("/api/office/configuration/count", "GET", typeof(ConfigurationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/all", "GET", typeof(ConfigurationController), "GetAll")]
        [InlineData("/api/office/configuration/all", "GET", typeof(ConfigurationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/export", "GET", typeof(ConfigurationController), "Export")]
        [InlineData("/api/office/configuration/export", "GET", typeof(ConfigurationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/1", "GET", typeof(ConfigurationController), "Get")]
        [InlineData("/api/office/configuration/1", "GET", typeof(ConfigurationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/get?configurationIds=1", "GET", typeof(ConfigurationController), "Get")]
        [InlineData("/api/office/configuration/get?configurationIds=1", "GET", typeof(ConfigurationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/configuration", "GET", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/office/configuration", "GET", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/page/1", "GET", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/office/configuration/page/1", "GET", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/count-filtered/{filterName}", "GET", typeof(ConfigurationController), "CountFiltered")]
        [InlineData("/api/office/configuration/count-filtered/{filterName}", "GET", typeof(ConfigurationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ConfigurationController), "GetFiltered")]
        [InlineData("/api/office/configuration/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ConfigurationController), "GetFiltered")]
        [InlineData("/api/office/configuration/first", "GET", typeof(ConfigurationController), "GetFirst")]
        [InlineData("/api/office/configuration/previous/1", "GET", typeof(ConfigurationController), "GetPrevious")]
        [InlineData("/api/office/configuration/next/1", "GET", typeof(ConfigurationController), "GetNext")]
        [InlineData("/api/office/configuration/last", "GET", typeof(ConfigurationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/configuration/custom-fields", "GET", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/office/configuration/custom-fields", "GET", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/custom-fields/{resourceId}", "GET", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/office/configuration/custom-fields/{resourceId}", "GET", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/meta", "HEAD", typeof(ConfigurationController), "GetEntityView")]
        [InlineData("/api/office/configuration/meta", "HEAD", typeof(ConfigurationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/count", "HEAD", typeof(ConfigurationController), "Count")]
        [InlineData("/api/office/configuration/count", "HEAD", typeof(ConfigurationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/all", "HEAD", typeof(ConfigurationController), "GetAll")]
        [InlineData("/api/office/configuration/all", "HEAD", typeof(ConfigurationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/export", "HEAD", typeof(ConfigurationController), "Export")]
        [InlineData("/api/office/configuration/export", "HEAD", typeof(ConfigurationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/1", "HEAD", typeof(ConfigurationController), "Get")]
        [InlineData("/api/office/configuration/1", "HEAD", typeof(ConfigurationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/get?configurationIds=1", "HEAD", typeof(ConfigurationController), "Get")]
        [InlineData("/api/office/configuration/get?configurationIds=1", "HEAD", typeof(ConfigurationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/configuration", "HEAD", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/office/configuration", "HEAD", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/page/1", "HEAD", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/office/configuration/page/1", "HEAD", typeof(ConfigurationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/count-filtered/{filterName}", "HEAD", typeof(ConfigurationController), "CountFiltered")]
        [InlineData("/api/office/configuration/count-filtered/{filterName}", "HEAD", typeof(ConfigurationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ConfigurationController), "GetFiltered")]
        [InlineData("/api/office/configuration/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ConfigurationController), "GetFiltered")]
        [InlineData("/api/office/configuration/first", "HEAD", typeof(ConfigurationController), "GetFirst")]
        [InlineData("/api/office/configuration/previous/1", "HEAD", typeof(ConfigurationController), "GetPrevious")]
        [InlineData("/api/office/configuration/next/1", "HEAD", typeof(ConfigurationController), "GetNext")]
        [InlineData("/api/office/configuration/last", "HEAD", typeof(ConfigurationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/configuration/custom-fields", "HEAD", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/office/configuration/custom-fields", "HEAD", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/configuration/custom-fields/{resourceId}", "HEAD", typeof(ConfigurationController), "GetCustomFields")]
        [InlineData("/api/office/configuration/custom-fields/{resourceId}", "HEAD", typeof(ConfigurationController), "GetCustomFields")]

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

        public ConfigurationRouteTests()
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