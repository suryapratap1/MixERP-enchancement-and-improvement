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
    public class CounterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/counter/delete/{counterId}", "DELETE", typeof(CounterController), "Delete")]
        [InlineData("/api/office/counter/delete/{counterId}", "DELETE", typeof(CounterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/counter/edit/{counterId}", "PUT", typeof(CounterController), "Edit")]
        [InlineData("/api/office/counter/edit/{counterId}", "PUT", typeof(CounterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/counter/count-where", "POST", typeof(CounterController), "CountWhere")]
        [InlineData("/api/office/counter/count-where", "POST", typeof(CounterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/counter/get-where/{pageNumber}", "POST", typeof(CounterController), "GetWhere")]
        [InlineData("/api/office/counter/get-where/{pageNumber}", "POST", typeof(CounterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/counter/add-or-edit", "POST", typeof(CounterController), "AddOrEdit")]
        [InlineData("/api/office/counter/add-or-edit", "POST", typeof(CounterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/counter/add/{counter}", "POST", typeof(CounterController), "Add")]
        [InlineData("/api/office/counter/add/{counter}", "POST", typeof(CounterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/counter/bulk-import", "POST", typeof(CounterController), "BulkImport")]
        [InlineData("/api/office/counter/bulk-import", "POST", typeof(CounterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/counter/meta", "GET", typeof(CounterController), "GetEntityView")]
        [InlineData("/api/office/counter/meta", "GET", typeof(CounterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/counter/count", "GET", typeof(CounterController), "Count")]
        [InlineData("/api/office/counter/count", "GET", typeof(CounterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/counter/all", "GET", typeof(CounterController), "GetAll")]
        [InlineData("/api/office/counter/all", "GET", typeof(CounterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/counter/export", "GET", typeof(CounterController), "Export")]
        [InlineData("/api/office/counter/export", "GET", typeof(CounterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/counter/1", "GET", typeof(CounterController), "Get")]
        [InlineData("/api/office/counter/1", "GET", typeof(CounterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/counter/get?counterIds=1", "GET", typeof(CounterController), "Get")]
        [InlineData("/api/office/counter/get?counterIds=1", "GET", typeof(CounterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/counter", "GET", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/office/counter", "GET", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/counter/page/1", "GET", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/office/counter/page/1", "GET", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/counter/count-filtered/{filterName}", "GET", typeof(CounterController), "CountFiltered")]
        [InlineData("/api/office/counter/count-filtered/{filterName}", "GET", typeof(CounterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/counter/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CounterController), "GetFiltered")]
        [InlineData("/api/office/counter/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CounterController), "GetFiltered")]
        [InlineData("/api/office/counter/first", "GET", typeof(CounterController), "GetFirst")]
        [InlineData("/api/office/counter/previous/1", "GET", typeof(CounterController), "GetPrevious")]
        [InlineData("/api/office/counter/next/1", "GET", typeof(CounterController), "GetNext")]
        [InlineData("/api/office/counter/last", "GET", typeof(CounterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/counter/custom-fields", "GET", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/office/counter/custom-fields", "GET", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/counter/custom-fields/{resourceId}", "GET", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/office/counter/custom-fields/{resourceId}", "GET", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/counter/meta", "HEAD", typeof(CounterController), "GetEntityView")]
        [InlineData("/api/office/counter/meta", "HEAD", typeof(CounterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/counter/count", "HEAD", typeof(CounterController), "Count")]
        [InlineData("/api/office/counter/count", "HEAD", typeof(CounterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/counter/all", "HEAD", typeof(CounterController), "GetAll")]
        [InlineData("/api/office/counter/all", "HEAD", typeof(CounterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/counter/export", "HEAD", typeof(CounterController), "Export")]
        [InlineData("/api/office/counter/export", "HEAD", typeof(CounterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/counter/1", "HEAD", typeof(CounterController), "Get")]
        [InlineData("/api/office/counter/1", "HEAD", typeof(CounterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/counter/get?counterIds=1", "HEAD", typeof(CounterController), "Get")]
        [InlineData("/api/office/counter/get?counterIds=1", "HEAD", typeof(CounterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/counter", "HEAD", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/office/counter", "HEAD", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/counter/page/1", "HEAD", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/office/counter/page/1", "HEAD", typeof(CounterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/counter/count-filtered/{filterName}", "HEAD", typeof(CounterController), "CountFiltered")]
        [InlineData("/api/office/counter/count-filtered/{filterName}", "HEAD", typeof(CounterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/counter/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CounterController), "GetFiltered")]
        [InlineData("/api/office/counter/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CounterController), "GetFiltered")]
        [InlineData("/api/office/counter/first", "HEAD", typeof(CounterController), "GetFirst")]
        [InlineData("/api/office/counter/previous/1", "HEAD", typeof(CounterController), "GetPrevious")]
        [InlineData("/api/office/counter/next/1", "HEAD", typeof(CounterController), "GetNext")]
        [InlineData("/api/office/counter/last", "HEAD", typeof(CounterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/counter/custom-fields", "HEAD", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/office/counter/custom-fields", "HEAD", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/counter/custom-fields/{resourceId}", "HEAD", typeof(CounterController), "GetCustomFields")]
        [InlineData("/api/office/counter/custom-fields/{resourceId}", "HEAD", typeof(CounterController), "GetCustomFields")]

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

        public CounterRouteTests()
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