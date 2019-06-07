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
    public class CultureRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/localization/culture/delete/{cultureCode}", "DELETE", typeof(CultureController), "Delete")]
        [InlineData("/api/localization/culture/delete/{cultureCode}", "DELETE", typeof(CultureController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/edit/{cultureCode}", "PUT", typeof(CultureController), "Edit")]
        [InlineData("/api/localization/culture/edit/{cultureCode}", "PUT", typeof(CultureController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/count-where", "POST", typeof(CultureController), "CountWhere")]
        [InlineData("/api/localization/culture/count-where", "POST", typeof(CultureController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/get-where/{pageNumber}", "POST", typeof(CultureController), "GetWhere")]
        [InlineData("/api/localization/culture/get-where/{pageNumber}", "POST", typeof(CultureController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/add-or-edit", "POST", typeof(CultureController), "AddOrEdit")]
        [InlineData("/api/localization/culture/add-or-edit", "POST", typeof(CultureController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/add/{culture}", "POST", typeof(CultureController), "Add")]
        [InlineData("/api/localization/culture/add/{culture}", "POST", typeof(CultureController), "Add")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/bulk-import", "POST", typeof(CultureController), "BulkImport")]
        [InlineData("/api/localization/culture/bulk-import", "POST", typeof(CultureController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/meta", "GET", typeof(CultureController), "GetEntityView")]
        [InlineData("/api/localization/culture/meta", "GET", typeof(CultureController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/count", "GET", typeof(CultureController), "Count")]
        [InlineData("/api/localization/culture/count", "GET", typeof(CultureController), "Count")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/all", "GET", typeof(CultureController), "GetAll")]
        [InlineData("/api/localization/culture/all", "GET", typeof(CultureController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/export", "GET", typeof(CultureController), "Export")]
        [InlineData("/api/localization/culture/export", "GET", typeof(CultureController), "Export")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/1", "GET", typeof(CultureController), "Get")]
        [InlineData("/api/localization/culture/1", "GET", typeof(CultureController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/get?cultureCodes=1", "GET", typeof(CultureController), "Get")]
        [InlineData("/api/localization/culture/get?cultureCodes=1", "GET", typeof(CultureController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/culture", "GET", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/localization/culture", "GET", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/page/1", "GET", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/localization/culture/page/1", "GET", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/count-filtered/{filterName}", "GET", typeof(CultureController), "CountFiltered")]
        [InlineData("/api/localization/culture/count-filtered/{filterName}", "GET", typeof(CultureController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CultureController), "GetFiltered")]
        [InlineData("/api/localization/culture/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CultureController), "GetFiltered")]
        [InlineData("/api/localization/culture/first", "GET", typeof(CultureController), "GetFirst")]
        [InlineData("/api/localization/culture/previous/1", "GET", typeof(CultureController), "GetPrevious")]
        [InlineData("/api/localization/culture/next/1", "GET", typeof(CultureController), "GetNext")]
        [InlineData("/api/localization/culture/last", "GET", typeof(CultureController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/localization/culture/custom-fields", "GET", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/localization/culture/custom-fields", "GET", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/custom-fields/{resourceId}", "GET", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/localization/culture/custom-fields/{resourceId}", "GET", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/meta", "HEAD", typeof(CultureController), "GetEntityView")]
        [InlineData("/api/localization/culture/meta", "HEAD", typeof(CultureController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/count", "HEAD", typeof(CultureController), "Count")]
        [InlineData("/api/localization/culture/count", "HEAD", typeof(CultureController), "Count")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/all", "HEAD", typeof(CultureController), "GetAll")]
        [InlineData("/api/localization/culture/all", "HEAD", typeof(CultureController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/export", "HEAD", typeof(CultureController), "Export")]
        [InlineData("/api/localization/culture/export", "HEAD", typeof(CultureController), "Export")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/1", "HEAD", typeof(CultureController), "Get")]
        [InlineData("/api/localization/culture/1", "HEAD", typeof(CultureController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/get?cultureCodes=1", "HEAD", typeof(CultureController), "Get")]
        [InlineData("/api/localization/culture/get?cultureCodes=1", "HEAD", typeof(CultureController), "Get")]
        [InlineData("/api/{apiVersionNumber}/localization/culture", "HEAD", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/localization/culture", "HEAD", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/page/1", "HEAD", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/localization/culture/page/1", "HEAD", typeof(CultureController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/count-filtered/{filterName}", "HEAD", typeof(CultureController), "CountFiltered")]
        [InlineData("/api/localization/culture/count-filtered/{filterName}", "HEAD", typeof(CultureController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CultureController), "GetFiltered")]
        [InlineData("/api/localization/culture/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CultureController), "GetFiltered")]
        [InlineData("/api/localization/culture/first", "HEAD", typeof(CultureController), "GetFirst")]
        [InlineData("/api/localization/culture/previous/1", "HEAD", typeof(CultureController), "GetPrevious")]
        [InlineData("/api/localization/culture/next/1", "HEAD", typeof(CultureController), "GetNext")]
        [InlineData("/api/localization/culture/last", "HEAD", typeof(CultureController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/localization/culture/custom-fields", "HEAD", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/localization/culture/custom-fields", "HEAD", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/localization/culture/custom-fields/{resourceId}", "HEAD", typeof(CultureController), "GetCustomFields")]
        [InlineData("/api/localization/culture/custom-fields/{resourceId}", "HEAD", typeof(CultureController), "GetCustomFields")]

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

        public CultureRouteTests()
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