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
    public class FrequencySetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/delete/{frequencySetupId}", "DELETE", typeof(FrequencySetupController), "Delete")]
        [InlineData("/api/core/frequency-setup/delete/{frequencySetupId}", "DELETE", typeof(FrequencySetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/edit/{frequencySetupId}", "PUT", typeof(FrequencySetupController), "Edit")]
        [InlineData("/api/core/frequency-setup/edit/{frequencySetupId}", "PUT", typeof(FrequencySetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/count-where", "POST", typeof(FrequencySetupController), "CountWhere")]
        [InlineData("/api/core/frequency-setup/count-where", "POST", typeof(FrequencySetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/get-where/{pageNumber}", "POST", typeof(FrequencySetupController), "GetWhere")]
        [InlineData("/api/core/frequency-setup/get-where/{pageNumber}", "POST", typeof(FrequencySetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/add-or-edit", "POST", typeof(FrequencySetupController), "AddOrEdit")]
        [InlineData("/api/core/frequency-setup/add-or-edit", "POST", typeof(FrequencySetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/add/{frequencySetup}", "POST", typeof(FrequencySetupController), "Add")]
        [InlineData("/api/core/frequency-setup/add/{frequencySetup}", "POST", typeof(FrequencySetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/bulk-import", "POST", typeof(FrequencySetupController), "BulkImport")]
        [InlineData("/api/core/frequency-setup/bulk-import", "POST", typeof(FrequencySetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/meta", "GET", typeof(FrequencySetupController), "GetEntityView")]
        [InlineData("/api/core/frequency-setup/meta", "GET", typeof(FrequencySetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/count", "GET", typeof(FrequencySetupController), "Count")]
        [InlineData("/api/core/frequency-setup/count", "GET", typeof(FrequencySetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/all", "GET", typeof(FrequencySetupController), "GetAll")]
        [InlineData("/api/core/frequency-setup/all", "GET", typeof(FrequencySetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/export", "GET", typeof(FrequencySetupController), "Export")]
        [InlineData("/api/core/frequency-setup/export", "GET", typeof(FrequencySetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/1", "GET", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/core/frequency-setup/1", "GET", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/get?frequencySetupIds=1", "GET", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/core/frequency-setup/get?frequencySetupIds=1", "GET", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup", "GET", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency-setup", "GET", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/page/1", "GET", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency-setup/page/1", "GET", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/count-filtered/{filterName}", "GET", typeof(FrequencySetupController), "CountFiltered")]
        [InlineData("/api/core/frequency-setup/count-filtered/{filterName}", "GET", typeof(FrequencySetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(FrequencySetupController), "GetFiltered")]
        [InlineData("/api/core/frequency-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(FrequencySetupController), "GetFiltered")]
        [InlineData("/api/core/frequency-setup/first", "GET", typeof(FrequencySetupController), "GetFirst")]
        [InlineData("/api/core/frequency-setup/previous/1", "GET", typeof(FrequencySetupController), "GetPrevious")]
        [InlineData("/api/core/frequency-setup/next/1", "GET", typeof(FrequencySetupController), "GetNext")]
        [InlineData("/api/core/frequency-setup/last", "GET", typeof(FrequencySetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/custom-fields", "GET", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/core/frequency-setup/custom-fields", "GET", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/custom-fields/{resourceId}", "GET", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/core/frequency-setup/custom-fields/{resourceId}", "GET", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/meta", "HEAD", typeof(FrequencySetupController), "GetEntityView")]
        [InlineData("/api/core/frequency-setup/meta", "HEAD", typeof(FrequencySetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/count", "HEAD", typeof(FrequencySetupController), "Count")]
        [InlineData("/api/core/frequency-setup/count", "HEAD", typeof(FrequencySetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/all", "HEAD", typeof(FrequencySetupController), "GetAll")]
        [InlineData("/api/core/frequency-setup/all", "HEAD", typeof(FrequencySetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/export", "HEAD", typeof(FrequencySetupController), "Export")]
        [InlineData("/api/core/frequency-setup/export", "HEAD", typeof(FrequencySetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/1", "HEAD", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/core/frequency-setup/1", "HEAD", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/get?frequencySetupIds=1", "HEAD", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/core/frequency-setup/get?frequencySetupIds=1", "HEAD", typeof(FrequencySetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup", "HEAD", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency-setup", "HEAD", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/page/1", "HEAD", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/core/frequency-setup/page/1", "HEAD", typeof(FrequencySetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/count-filtered/{filterName}", "HEAD", typeof(FrequencySetupController), "CountFiltered")]
        [InlineData("/api/core/frequency-setup/count-filtered/{filterName}", "HEAD", typeof(FrequencySetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(FrequencySetupController), "GetFiltered")]
        [InlineData("/api/core/frequency-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(FrequencySetupController), "GetFiltered")]
        [InlineData("/api/core/frequency-setup/first", "HEAD", typeof(FrequencySetupController), "GetFirst")]
        [InlineData("/api/core/frequency-setup/previous/1", "HEAD", typeof(FrequencySetupController), "GetPrevious")]
        [InlineData("/api/core/frequency-setup/next/1", "HEAD", typeof(FrequencySetupController), "GetNext")]
        [InlineData("/api/core/frequency-setup/last", "HEAD", typeof(FrequencySetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/custom-fields", "HEAD", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/core/frequency-setup/custom-fields", "HEAD", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/frequency-setup/custom-fields/{resourceId}", "HEAD", typeof(FrequencySetupController), "GetCustomFields")]
        [InlineData("/api/core/frequency-setup/custom-fields/{resourceId}", "HEAD", typeof(FrequencySetupController), "GetCustomFields")]

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

        public FrequencySetupRouteTests()
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