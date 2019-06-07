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
    public class FrequencyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/frequency/delete/{frequencyId}", "DELETE", typeof(FrequencyController), "Delete")]
        [InlineData("/api/core/frequency/delete/{frequencyId}", "DELETE", typeof(FrequencyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/edit/{frequencyId}", "PUT", typeof(FrequencyController), "Edit")]
        [InlineData("/api/core/frequency/edit/{frequencyId}", "PUT", typeof(FrequencyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/count-where", "POST", typeof(FrequencyController), "CountWhere")]
        [InlineData("/api/core/frequency/count-where", "POST", typeof(FrequencyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/get-where/{pageNumber}", "POST", typeof(FrequencyController), "GetWhere")]
        [InlineData("/api/core/frequency/get-where/{pageNumber}", "POST", typeof(FrequencyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/add-or-edit", "POST", typeof(FrequencyController), "AddOrEdit")]
        [InlineData("/api/core/frequency/add-or-edit", "POST", typeof(FrequencyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/add/{frequency}", "POST", typeof(FrequencyController), "Add")]
        [InlineData("/api/core/frequency/add/{frequency}", "POST", typeof(FrequencyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/bulk-import", "POST", typeof(FrequencyController), "BulkImport")]
        [InlineData("/api/core/frequency/bulk-import", "POST", typeof(FrequencyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/meta", "GET", typeof(FrequencyController), "GetEntityView")]
        [InlineData("/api/core/frequency/meta", "GET", typeof(FrequencyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/count", "GET", typeof(FrequencyController), "Count")]
        [InlineData("/api/core/frequency/count", "GET", typeof(FrequencyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/all", "GET", typeof(FrequencyController), "GetAll")]
        [InlineData("/api/core/frequency/all", "GET", typeof(FrequencyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/export", "GET", typeof(FrequencyController), "Export")]
        [InlineData("/api/core/frequency/export", "GET", typeof(FrequencyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/1", "GET", typeof(FrequencyController), "Get")]
        [InlineData("/api/core/frequency/1", "GET", typeof(FrequencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/get?frequencyIds=1", "GET", typeof(FrequencyController), "Get")]
        [InlineData("/api/core/frequency/get?frequencyIds=1", "GET", typeof(FrequencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency", "GET", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency", "GET", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/page/1", "GET", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency/page/1", "GET", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/count-filtered/{filterName}", "GET", typeof(FrequencyController), "CountFiltered")]
        [InlineData("/api/core/frequency/count-filtered/{filterName}", "GET", typeof(FrequencyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/get-filtered/{pageNumber}/{filterName}", "GET", typeof(FrequencyController), "GetFiltered")]
        [InlineData("/api/core/frequency/get-filtered/{pageNumber}/{filterName}", "GET", typeof(FrequencyController), "GetFiltered")]
        [InlineData("/api/core/frequency/first", "GET", typeof(FrequencyController), "GetFirst")]
        [InlineData("/api/core/frequency/previous/1", "GET", typeof(FrequencyController), "GetPrevious")]
        [InlineData("/api/core/frequency/next/1", "GET", typeof(FrequencyController), "GetNext")]
        [InlineData("/api/core/frequency/last", "GET", typeof(FrequencyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/frequency/custom-fields", "GET", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/core/frequency/custom-fields", "GET", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/custom-fields/{resourceId}", "GET", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/core/frequency/custom-fields/{resourceId}", "GET", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/meta", "HEAD", typeof(FrequencyController), "GetEntityView")]
        [InlineData("/api/core/frequency/meta", "HEAD", typeof(FrequencyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/count", "HEAD", typeof(FrequencyController), "Count")]
        [InlineData("/api/core/frequency/count", "HEAD", typeof(FrequencyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/all", "HEAD", typeof(FrequencyController), "GetAll")]
        [InlineData("/api/core/frequency/all", "HEAD", typeof(FrequencyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/export", "HEAD", typeof(FrequencyController), "Export")]
        [InlineData("/api/core/frequency/export", "HEAD", typeof(FrequencyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/1", "HEAD", typeof(FrequencyController), "Get")]
        [InlineData("/api/core/frequency/1", "HEAD", typeof(FrequencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/get?frequencyIds=1", "HEAD", typeof(FrequencyController), "Get")]
        [InlineData("/api/core/frequency/get?frequencyIds=1", "HEAD", typeof(FrequencyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency", "HEAD", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency", "HEAD", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/page/1", "HEAD", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency/page/1", "HEAD", typeof(FrequencyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/count-filtered/{filterName}", "HEAD", typeof(FrequencyController), "CountFiltered")]
        [InlineData("/api/core/frequency/count-filtered/{filterName}", "HEAD", typeof(FrequencyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(FrequencyController), "GetFiltered")]
        [InlineData("/api/core/frequency/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(FrequencyController), "GetFiltered")]
        [InlineData("/api/core/frequency/first", "HEAD", typeof(FrequencyController), "GetFirst")]
        [InlineData("/api/core/frequency/previous/1", "HEAD", typeof(FrequencyController), "GetPrevious")]
        [InlineData("/api/core/frequency/next/1", "HEAD", typeof(FrequencyController), "GetNext")]
        [InlineData("/api/core/frequency/last", "HEAD", typeof(FrequencyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/frequency/custom-fields", "HEAD", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/core/frequency/custom-fields", "HEAD", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/frequency/custom-fields/{resourceId}", "HEAD", typeof(FrequencyController), "GetCustomFields")]
        [InlineData("/api/core/frequency/custom-fields/{resourceId}", "HEAD", typeof(FrequencyController), "GetCustomFields")]

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

        public FrequencyRouteTests()
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