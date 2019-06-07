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
    public class StoreRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/store/delete/{storeId}", "DELETE", typeof(StoreController), "Delete")]
        [InlineData("/api/office/store/delete/{storeId}", "DELETE", typeof(StoreController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/store/edit/{storeId}", "PUT", typeof(StoreController), "Edit")]
        [InlineData("/api/office/store/edit/{storeId}", "PUT", typeof(StoreController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/store/count-where", "POST", typeof(StoreController), "CountWhere")]
        [InlineData("/api/office/store/count-where", "POST", typeof(StoreController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/store/get-where/{pageNumber}", "POST", typeof(StoreController), "GetWhere")]
        [InlineData("/api/office/store/get-where/{pageNumber}", "POST", typeof(StoreController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/store/add-or-edit", "POST", typeof(StoreController), "AddOrEdit")]
        [InlineData("/api/office/store/add-or-edit", "POST", typeof(StoreController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/store/add/{store}", "POST", typeof(StoreController), "Add")]
        [InlineData("/api/office/store/add/{store}", "POST", typeof(StoreController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/store/bulk-import", "POST", typeof(StoreController), "BulkImport")]
        [InlineData("/api/office/store/bulk-import", "POST", typeof(StoreController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/store/meta", "GET", typeof(StoreController), "GetEntityView")]
        [InlineData("/api/office/store/meta", "GET", typeof(StoreController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/store/count", "GET", typeof(StoreController), "Count")]
        [InlineData("/api/office/store/count", "GET", typeof(StoreController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/store/all", "GET", typeof(StoreController), "GetAll")]
        [InlineData("/api/office/store/all", "GET", typeof(StoreController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/store/export", "GET", typeof(StoreController), "Export")]
        [InlineData("/api/office/store/export", "GET", typeof(StoreController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/store/1", "GET", typeof(StoreController), "Get")]
        [InlineData("/api/office/store/1", "GET", typeof(StoreController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store/get?storeIds=1", "GET", typeof(StoreController), "Get")]
        [InlineData("/api/office/store/get?storeIds=1", "GET", typeof(StoreController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store", "GET", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/office/store", "GET", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store/page/1", "GET", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/office/store/page/1", "GET", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store/count-filtered/{filterName}", "GET", typeof(StoreController), "CountFiltered")]
        [InlineData("/api/office/store/count-filtered/{filterName}", "GET", typeof(StoreController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/store/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StoreController), "GetFiltered")]
        [InlineData("/api/office/store/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StoreController), "GetFiltered")]
        [InlineData("/api/office/store/first", "GET", typeof(StoreController), "GetFirst")]
        [InlineData("/api/office/store/previous/1", "GET", typeof(StoreController), "GetPrevious")]
        [InlineData("/api/office/store/next/1", "GET", typeof(StoreController), "GetNext")]
        [InlineData("/api/office/store/last", "GET", typeof(StoreController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/store/custom-fields", "GET", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/office/store/custom-fields", "GET", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/store/custom-fields/{resourceId}", "GET", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/office/store/custom-fields/{resourceId}", "GET", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/store/meta", "HEAD", typeof(StoreController), "GetEntityView")]
        [InlineData("/api/office/store/meta", "HEAD", typeof(StoreController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/store/count", "HEAD", typeof(StoreController), "Count")]
        [InlineData("/api/office/store/count", "HEAD", typeof(StoreController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/store/all", "HEAD", typeof(StoreController), "GetAll")]
        [InlineData("/api/office/store/all", "HEAD", typeof(StoreController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/store/export", "HEAD", typeof(StoreController), "Export")]
        [InlineData("/api/office/store/export", "HEAD", typeof(StoreController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/store/1", "HEAD", typeof(StoreController), "Get")]
        [InlineData("/api/office/store/1", "HEAD", typeof(StoreController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store/get?storeIds=1", "HEAD", typeof(StoreController), "Get")]
        [InlineData("/api/office/store/get?storeIds=1", "HEAD", typeof(StoreController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store", "HEAD", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/office/store", "HEAD", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store/page/1", "HEAD", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/office/store/page/1", "HEAD", typeof(StoreController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store/count-filtered/{filterName}", "HEAD", typeof(StoreController), "CountFiltered")]
        [InlineData("/api/office/store/count-filtered/{filterName}", "HEAD", typeof(StoreController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/store/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StoreController), "GetFiltered")]
        [InlineData("/api/office/store/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StoreController), "GetFiltered")]
        [InlineData("/api/office/store/first", "HEAD", typeof(StoreController), "GetFirst")]
        [InlineData("/api/office/store/previous/1", "HEAD", typeof(StoreController), "GetPrevious")]
        [InlineData("/api/office/store/next/1", "HEAD", typeof(StoreController), "GetNext")]
        [InlineData("/api/office/store/last", "HEAD", typeof(StoreController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/store/custom-fields", "HEAD", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/office/store/custom-fields", "HEAD", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/store/custom-fields/{resourceId}", "HEAD", typeof(StoreController), "GetCustomFields")]
        [InlineData("/api/office/store/custom-fields/{resourceId}", "HEAD", typeof(StoreController), "GetCustomFields")]

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

        public StoreRouteTests()
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