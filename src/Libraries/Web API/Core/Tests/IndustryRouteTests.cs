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
    public class IndustryRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/industry/delete/{industryId}", "DELETE", typeof(IndustryController), "Delete")]
        [InlineData("/api/core/industry/delete/{industryId}", "DELETE", typeof(IndustryController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/industry/edit/{industryId}", "PUT", typeof(IndustryController), "Edit")]
        [InlineData("/api/core/industry/edit/{industryId}", "PUT", typeof(IndustryController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/industry/count-where", "POST", typeof(IndustryController), "CountWhere")]
        [InlineData("/api/core/industry/count-where", "POST", typeof(IndustryController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/industry/get-where/{pageNumber}", "POST", typeof(IndustryController), "GetWhere")]
        [InlineData("/api/core/industry/get-where/{pageNumber}", "POST", typeof(IndustryController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/industry/add-or-edit", "POST", typeof(IndustryController), "AddOrEdit")]
        [InlineData("/api/core/industry/add-or-edit", "POST", typeof(IndustryController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/industry/add/{industry}", "POST", typeof(IndustryController), "Add")]
        [InlineData("/api/core/industry/add/{industry}", "POST", typeof(IndustryController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/industry/bulk-import", "POST", typeof(IndustryController), "BulkImport")]
        [InlineData("/api/core/industry/bulk-import", "POST", typeof(IndustryController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/industry/meta", "GET", typeof(IndustryController), "GetEntityView")]
        [InlineData("/api/core/industry/meta", "GET", typeof(IndustryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/industry/count", "GET", typeof(IndustryController), "Count")]
        [InlineData("/api/core/industry/count", "GET", typeof(IndustryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/industry/all", "GET", typeof(IndustryController), "GetAll")]
        [InlineData("/api/core/industry/all", "GET", typeof(IndustryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/industry/export", "GET", typeof(IndustryController), "Export")]
        [InlineData("/api/core/industry/export", "GET", typeof(IndustryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/industry/1", "GET", typeof(IndustryController), "Get")]
        [InlineData("/api/core/industry/1", "GET", typeof(IndustryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/industry/get?industryIds=1", "GET", typeof(IndustryController), "Get")]
        [InlineData("/api/core/industry/get?industryIds=1", "GET", typeof(IndustryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/industry", "GET", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/core/industry", "GET", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/industry/page/1", "GET", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/core/industry/page/1", "GET", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/industry/count-filtered/{filterName}", "GET", typeof(IndustryController), "CountFiltered")]
        [InlineData("/api/core/industry/count-filtered/{filterName}", "GET", typeof(IndustryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/industry/get-filtered/{pageNumber}/{filterName}", "GET", typeof(IndustryController), "GetFiltered")]
        [InlineData("/api/core/industry/get-filtered/{pageNumber}/{filterName}", "GET", typeof(IndustryController), "GetFiltered")]
        [InlineData("/api/core/industry/first", "GET", typeof(IndustryController), "GetFirst")]
        [InlineData("/api/core/industry/previous/1", "GET", typeof(IndustryController), "GetPrevious")]
        [InlineData("/api/core/industry/next/1", "GET", typeof(IndustryController), "GetNext")]
        [InlineData("/api/core/industry/last", "GET", typeof(IndustryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/industry/custom-fields", "GET", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/core/industry/custom-fields", "GET", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/industry/custom-fields/{resourceId}", "GET", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/core/industry/custom-fields/{resourceId}", "GET", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/industry/meta", "HEAD", typeof(IndustryController), "GetEntityView")]
        [InlineData("/api/core/industry/meta", "HEAD", typeof(IndustryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/industry/count", "HEAD", typeof(IndustryController), "Count")]
        [InlineData("/api/core/industry/count", "HEAD", typeof(IndustryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/industry/all", "HEAD", typeof(IndustryController), "GetAll")]
        [InlineData("/api/core/industry/all", "HEAD", typeof(IndustryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/industry/export", "HEAD", typeof(IndustryController), "Export")]
        [InlineData("/api/core/industry/export", "HEAD", typeof(IndustryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/industry/1", "HEAD", typeof(IndustryController), "Get")]
        [InlineData("/api/core/industry/1", "HEAD", typeof(IndustryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/industry/get?industryIds=1", "HEAD", typeof(IndustryController), "Get")]
        [InlineData("/api/core/industry/get?industryIds=1", "HEAD", typeof(IndustryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/industry", "HEAD", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/core/industry", "HEAD", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/industry/page/1", "HEAD", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/core/industry/page/1", "HEAD", typeof(IndustryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/industry/count-filtered/{filterName}", "HEAD", typeof(IndustryController), "CountFiltered")]
        [InlineData("/api/core/industry/count-filtered/{filterName}", "HEAD", typeof(IndustryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/industry/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(IndustryController), "GetFiltered")]
        [InlineData("/api/core/industry/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(IndustryController), "GetFiltered")]
        [InlineData("/api/core/industry/first", "HEAD", typeof(IndustryController), "GetFirst")]
        [InlineData("/api/core/industry/previous/1", "HEAD", typeof(IndustryController), "GetPrevious")]
        [InlineData("/api/core/industry/next/1", "HEAD", typeof(IndustryController), "GetNext")]
        [InlineData("/api/core/industry/last", "HEAD", typeof(IndustryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/industry/custom-fields", "HEAD", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/core/industry/custom-fields", "HEAD", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/industry/custom-fields/{resourceId}", "HEAD", typeof(IndustryController), "GetCustomFields")]
        [InlineData("/api/core/industry/custom-fields/{resourceId}", "HEAD", typeof(IndustryController), "GetCustomFields")]

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

        public IndustryRouteTests()
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