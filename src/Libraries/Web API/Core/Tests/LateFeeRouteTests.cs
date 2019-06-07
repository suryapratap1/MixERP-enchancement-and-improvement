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
    public class LateFeeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/delete/{lateFeeId}", "DELETE", typeof(CoreLateFeeController), "Delete")]
        [InlineData("/api/core/late-fee/delete/{lateFeeId}", "DELETE", typeof(CoreLateFeeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/edit/{lateFeeId}", "PUT", typeof(CoreLateFeeController), "Edit")]
        [InlineData("/api/core/late-fee/edit/{lateFeeId}", "PUT", typeof(CoreLateFeeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/count-where", "POST", typeof(CoreLateFeeController), "CountWhere")]
        [InlineData("/api/core/late-fee/count-where", "POST", typeof(CoreLateFeeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/get-where/{pageNumber}", "POST", typeof(CoreLateFeeController), "GetWhere")]
        [InlineData("/api/core/late-fee/get-where/{pageNumber}", "POST", typeof(CoreLateFeeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/add-or-edit", "POST", typeof(CoreLateFeeController), "AddOrEdit")]
        [InlineData("/api/core/late-fee/add-or-edit", "POST", typeof(CoreLateFeeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/add/{lateFee}", "POST", typeof(CoreLateFeeController), "Add")]
        [InlineData("/api/core/late-fee/add/{lateFee}", "POST", typeof(CoreLateFeeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/bulk-import", "POST", typeof(CoreLateFeeController), "BulkImport")]
        [InlineData("/api/core/late-fee/bulk-import", "POST", typeof(CoreLateFeeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/meta", "GET", typeof(CoreLateFeeController), "GetEntityView")]
        [InlineData("/api/core/late-fee/meta", "GET", typeof(CoreLateFeeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/count", "GET", typeof(CoreLateFeeController), "Count")]
        [InlineData("/api/core/late-fee/count", "GET", typeof(CoreLateFeeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/all", "GET", typeof(CoreLateFeeController), "GetAll")]
        [InlineData("/api/core/late-fee/all", "GET", typeof(CoreLateFeeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/export", "GET", typeof(CoreLateFeeController), "Export")]
        [InlineData("/api/core/late-fee/export", "GET", typeof(CoreLateFeeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/1", "GET", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/core/late-fee/1", "GET", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/get?lateFeeIds=1", "GET", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/core/late-fee/get?lateFeeIds=1", "GET", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee", "GET", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/core/late-fee", "GET", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/page/1", "GET", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/core/late-fee/page/1", "GET", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/count-filtered/{filterName}", "GET", typeof(CoreLateFeeController), "CountFiltered")]
        [InlineData("/api/core/late-fee/count-filtered/{filterName}", "GET", typeof(CoreLateFeeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CoreLateFeeController), "GetFiltered")]
        [InlineData("/api/core/late-fee/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CoreLateFeeController), "GetFiltered")]
        [InlineData("/api/core/late-fee/first", "GET", typeof(CoreLateFeeController), "GetFirst")]
        [InlineData("/api/core/late-fee/previous/1", "GET", typeof(CoreLateFeeController), "GetPrevious")]
        [InlineData("/api/core/late-fee/next/1", "GET", typeof(CoreLateFeeController), "GetNext")]
        [InlineData("/api/core/late-fee/last", "GET", typeof(CoreLateFeeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/late-fee/custom-fields", "GET", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/core/late-fee/custom-fields", "GET", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/custom-fields/{resourceId}", "GET", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/core/late-fee/custom-fields/{resourceId}", "GET", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/meta", "HEAD", typeof(CoreLateFeeController), "GetEntityView")]
        [InlineData("/api/core/late-fee/meta", "HEAD", typeof(CoreLateFeeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/count", "HEAD", typeof(CoreLateFeeController), "Count")]
        [InlineData("/api/core/late-fee/count", "HEAD", typeof(CoreLateFeeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/all", "HEAD", typeof(CoreLateFeeController), "GetAll")]
        [InlineData("/api/core/late-fee/all", "HEAD", typeof(CoreLateFeeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/export", "HEAD", typeof(CoreLateFeeController), "Export")]
        [InlineData("/api/core/late-fee/export", "HEAD", typeof(CoreLateFeeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/1", "HEAD", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/core/late-fee/1", "HEAD", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/get?lateFeeIds=1", "HEAD", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/core/late-fee/get?lateFeeIds=1", "HEAD", typeof(CoreLateFeeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee", "HEAD", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/core/late-fee", "HEAD", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/page/1", "HEAD", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/core/late-fee/page/1", "HEAD", typeof(CoreLateFeeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/count-filtered/{filterName}", "HEAD", typeof(CoreLateFeeController), "CountFiltered")]
        [InlineData("/api/core/late-fee/count-filtered/{filterName}", "HEAD", typeof(CoreLateFeeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CoreLateFeeController), "GetFiltered")]
        [InlineData("/api/core/late-fee/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CoreLateFeeController), "GetFiltered")]
        [InlineData("/api/core/late-fee/first", "HEAD", typeof(CoreLateFeeController), "GetFirst")]
        [InlineData("/api/core/late-fee/previous/1", "HEAD", typeof(CoreLateFeeController), "GetPrevious")]
        [InlineData("/api/core/late-fee/next/1", "HEAD", typeof(CoreLateFeeController), "GetNext")]
        [InlineData("/api/core/late-fee/last", "HEAD", typeof(CoreLateFeeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/late-fee/custom-fields", "HEAD", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/core/late-fee/custom-fields", "HEAD", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/late-fee/custom-fields/{resourceId}", "HEAD", typeof(CoreLateFeeController), "GetCustomFields")]
        [InlineData("/api/core/late-fee/custom-fields/{resourceId}", "HEAD", typeof(CoreLateFeeController), "GetCustomFields")]

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

        public LateFeeRouteTests()
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