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

namespace MixERP.Net.Api.Localization.Tests
{
    public class LocalizedResourceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/delete/{localizedResourceId}", "DELETE", typeof(LocalizedResourceController), "Delete")]
        [InlineData("/api/localization/localized-resource/delete/{localizedResourceId}", "DELETE", typeof(LocalizedResourceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/edit/{localizedResourceId}", "PUT", typeof(LocalizedResourceController), "Edit")]
        [InlineData("/api/localization/localized-resource/edit/{localizedResourceId}", "PUT", typeof(LocalizedResourceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/count-where", "POST", typeof(LocalizedResourceController), "CountWhere")]
        [InlineData("/api/localization/localized-resource/count-where", "POST", typeof(LocalizedResourceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/get-where/{pageNumber}", "POST", typeof(LocalizedResourceController), "GetWhere")]
        [InlineData("/api/localization/localized-resource/get-where/{pageNumber}", "POST", typeof(LocalizedResourceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/add-or-edit", "POST", typeof(LocalizedResourceController), "AddOrEdit")]
        [InlineData("/api/localization/localized-resource/add-or-edit", "POST", typeof(LocalizedResourceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/add/{localizedResource}", "POST", typeof(LocalizedResourceController), "Add")]
        [InlineData("/api/localization/localized-resource/add/{localizedResource}", "POST", typeof(LocalizedResourceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/bulk-import", "POST", typeof(LocalizedResourceController), "BulkImport")]
        [InlineData("/api/localization/localized-resource/bulk-import", "POST", typeof(LocalizedResourceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/meta", "GET", typeof(LocalizedResourceController), "GetEntityView")]
        [InlineData("/api/localization/localized-resource/meta", "GET", typeof(LocalizedResourceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/count", "GET", typeof(LocalizedResourceController), "Count")]
        [InlineData("/api/localization/localized-resource/count", "GET", typeof(LocalizedResourceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/all", "GET", typeof(LocalizedResourceController), "GetAll")]
        [InlineData("/api/localization/localized-resource/all", "GET", typeof(LocalizedResourceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/export", "GET", typeof(LocalizedResourceController), "Export")]
        [InlineData("/api/localization/localized-resource/export", "GET", typeof(LocalizedResourceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/1", "GET", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/localization/localized-resource/1", "GET", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/get?localizedResourceIds=1", "GET", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/localization/localized-resource/get?localizedResourceIds=1", "GET", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource", "GET", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/localized-resource", "GET", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/page/1", "GET", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/localized-resource/page/1", "GET", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/count-filtered/{filterName}", "GET", typeof(LocalizedResourceController), "CountFiltered")]
        [InlineData("/api/localization/localized-resource/count-filtered/{filterName}", "GET", typeof(LocalizedResourceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LocalizedResourceController), "GetFiltered")]
        [InlineData("/api/localization/localized-resource/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LocalizedResourceController), "GetFiltered")]
        [InlineData("/api/localization/localized-resource/first", "GET", typeof(LocalizedResourceController), "GetFirst")]
        [InlineData("/api/localization/localized-resource/previous/1", "GET", typeof(LocalizedResourceController), "GetPrevious")]
        [InlineData("/api/localization/localized-resource/next/1", "GET", typeof(LocalizedResourceController), "GetNext")]
        [InlineData("/api/localization/localized-resource/last", "GET", typeof(LocalizedResourceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/custom-fields", "GET", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/localization/localized-resource/custom-fields", "GET", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/custom-fields/{resourceId}", "GET", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/localization/localized-resource/custom-fields/{resourceId}", "GET", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/meta", "HEAD", typeof(LocalizedResourceController), "GetEntityView")]
        [InlineData("/api/localization/localized-resource/meta", "HEAD", typeof(LocalizedResourceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/count", "HEAD", typeof(LocalizedResourceController), "Count")]
        [InlineData("/api/localization/localized-resource/count", "HEAD", typeof(LocalizedResourceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/all", "HEAD", typeof(LocalizedResourceController), "GetAll")]
        [InlineData("/api/localization/localized-resource/all", "HEAD", typeof(LocalizedResourceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/export", "HEAD", typeof(LocalizedResourceController), "Export")]
        [InlineData("/api/localization/localized-resource/export", "HEAD", typeof(LocalizedResourceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/1", "HEAD", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/localization/localized-resource/1", "HEAD", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/get?localizedResourceIds=1", "HEAD", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/localization/localized-resource/get?localizedResourceIds=1", "HEAD", typeof(LocalizedResourceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource", "HEAD", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/localized-resource", "HEAD", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/page/1", "HEAD", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/localization/localized-resource/page/1", "HEAD", typeof(LocalizedResourceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/count-filtered/{filterName}", "HEAD", typeof(LocalizedResourceController), "CountFiltered")]
        [InlineData("/api/localization/localized-resource/count-filtered/{filterName}", "HEAD", typeof(LocalizedResourceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LocalizedResourceController), "GetFiltered")]
        [InlineData("/api/localization/localized-resource/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LocalizedResourceController), "GetFiltered")]
        [InlineData("/api/localization/localized-resource/first", "HEAD", typeof(LocalizedResourceController), "GetFirst")]
        [InlineData("/api/localization/localized-resource/previous/1", "HEAD", typeof(LocalizedResourceController), "GetPrevious")]
        [InlineData("/api/localization/localized-resource/next/1", "HEAD", typeof(LocalizedResourceController), "GetNext")]
        [InlineData("/api/localization/localized-resource/last", "HEAD", typeof(LocalizedResourceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/custom-fields", "HEAD", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/localization/localized-resource/custom-fields", "HEAD", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/localized-resource/custom-fields/{resourceId}", "HEAD", typeof(LocalizedResourceController), "GetCustomFields")]
        [InlineData("/api/localization/localized-resource/custom-fields/{resourceId}", "HEAD", typeof(LocalizedResourceController), "GetCustomFields")]

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

        public LocalizedResourceRouteTests()
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