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
    public class CountryRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/country/delete/{countryId}", "DELETE", typeof(CountryController), "Delete")]
        [InlineData("/api/core/country/delete/{countryId}", "DELETE", typeof(CountryController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/country/edit/{countryId}", "PUT", typeof(CountryController), "Edit")]
        [InlineData("/api/core/country/edit/{countryId}", "PUT", typeof(CountryController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/country/count-where", "POST", typeof(CountryController), "CountWhere")]
        [InlineData("/api/core/country/count-where", "POST", typeof(CountryController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/country/get-where/{pageNumber}", "POST", typeof(CountryController), "GetWhere")]
        [InlineData("/api/core/country/get-where/{pageNumber}", "POST", typeof(CountryController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/country/add-or-edit", "POST", typeof(CountryController), "AddOrEdit")]
        [InlineData("/api/core/country/add-or-edit", "POST", typeof(CountryController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/country/add/{country}", "POST", typeof(CountryController), "Add")]
        [InlineData("/api/core/country/add/{country}", "POST", typeof(CountryController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/country/bulk-import", "POST", typeof(CountryController), "BulkImport")]
        [InlineData("/api/core/country/bulk-import", "POST", typeof(CountryController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/country/meta", "GET", typeof(CountryController), "GetEntityView")]
        [InlineData("/api/core/country/meta", "GET", typeof(CountryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/country/count", "GET", typeof(CountryController), "Count")]
        [InlineData("/api/core/country/count", "GET", typeof(CountryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/country/all", "GET", typeof(CountryController), "GetAll")]
        [InlineData("/api/core/country/all", "GET", typeof(CountryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/country/export", "GET", typeof(CountryController), "Export")]
        [InlineData("/api/core/country/export", "GET", typeof(CountryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/country/1", "GET", typeof(CountryController), "Get")]
        [InlineData("/api/core/country/1", "GET", typeof(CountryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/country/get?countryIds=1", "GET", typeof(CountryController), "Get")]
        [InlineData("/api/core/country/get?countryIds=1", "GET", typeof(CountryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/country", "GET", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/core/country", "GET", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/country/page/1", "GET", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/core/country/page/1", "GET", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/country/count-filtered/{filterName}", "GET", typeof(CountryController), "CountFiltered")]
        [InlineData("/api/core/country/count-filtered/{filterName}", "GET", typeof(CountryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/country/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CountryController), "GetFiltered")]
        [InlineData("/api/core/country/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CountryController), "GetFiltered")]
        [InlineData("/api/core/country/first", "GET", typeof(CountryController), "GetFirst")]
        [InlineData("/api/core/country/previous/1", "GET", typeof(CountryController), "GetPrevious")]
        [InlineData("/api/core/country/next/1", "GET", typeof(CountryController), "GetNext")]
        [InlineData("/api/core/country/last", "GET", typeof(CountryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/country/custom-fields", "GET", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/core/country/custom-fields", "GET", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/country/custom-fields/{resourceId}", "GET", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/core/country/custom-fields/{resourceId}", "GET", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/country/meta", "HEAD", typeof(CountryController), "GetEntityView")]
        [InlineData("/api/core/country/meta", "HEAD", typeof(CountryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/country/count", "HEAD", typeof(CountryController), "Count")]
        [InlineData("/api/core/country/count", "HEAD", typeof(CountryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/country/all", "HEAD", typeof(CountryController), "GetAll")]
        [InlineData("/api/core/country/all", "HEAD", typeof(CountryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/country/export", "HEAD", typeof(CountryController), "Export")]
        [InlineData("/api/core/country/export", "HEAD", typeof(CountryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/country/1", "HEAD", typeof(CountryController), "Get")]
        [InlineData("/api/core/country/1", "HEAD", typeof(CountryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/country/get?countryIds=1", "HEAD", typeof(CountryController), "Get")]
        [InlineData("/api/core/country/get?countryIds=1", "HEAD", typeof(CountryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/country", "HEAD", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/core/country", "HEAD", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/country/page/1", "HEAD", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/core/country/page/1", "HEAD", typeof(CountryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/country/count-filtered/{filterName}", "HEAD", typeof(CountryController), "CountFiltered")]
        [InlineData("/api/core/country/count-filtered/{filterName}", "HEAD", typeof(CountryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/country/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CountryController), "GetFiltered")]
        [InlineData("/api/core/country/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CountryController), "GetFiltered")]
        [InlineData("/api/core/country/first", "HEAD", typeof(CountryController), "GetFirst")]
        [InlineData("/api/core/country/previous/1", "HEAD", typeof(CountryController), "GetPrevious")]
        [InlineData("/api/core/country/next/1", "HEAD", typeof(CountryController), "GetNext")]
        [InlineData("/api/core/country/last", "HEAD", typeof(CountryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/country/custom-fields", "HEAD", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/core/country/custom-fields", "HEAD", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/country/custom-fields/{resourceId}", "HEAD", typeof(CountryController), "GetCustomFields")]
        [InlineData("/api/core/country/custom-fields/{resourceId}", "HEAD", typeof(CountryController), "GetCustomFields")]

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

        public CountryRouteTests()
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