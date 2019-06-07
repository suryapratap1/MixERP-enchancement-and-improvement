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
    public class StoreTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/store-type/delete/{storeTypeId}", "DELETE", typeof(StoreTypeController), "Delete")]
        [InlineData("/api/office/store-type/delete/{storeTypeId}", "DELETE", typeof(StoreTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/edit/{storeTypeId}", "PUT", typeof(StoreTypeController), "Edit")]
        [InlineData("/api/office/store-type/edit/{storeTypeId}", "PUT", typeof(StoreTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/count-where", "POST", typeof(StoreTypeController), "CountWhere")]
        [InlineData("/api/office/store-type/count-where", "POST", typeof(StoreTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/get-where/{pageNumber}", "POST", typeof(StoreTypeController), "GetWhere")]
        [InlineData("/api/office/store-type/get-where/{pageNumber}", "POST", typeof(StoreTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/add-or-edit", "POST", typeof(StoreTypeController), "AddOrEdit")]
        [InlineData("/api/office/store-type/add-or-edit", "POST", typeof(StoreTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/add/{storeType}", "POST", typeof(StoreTypeController), "Add")]
        [InlineData("/api/office/store-type/add/{storeType}", "POST", typeof(StoreTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/bulk-import", "POST", typeof(StoreTypeController), "BulkImport")]
        [InlineData("/api/office/store-type/bulk-import", "POST", typeof(StoreTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/meta", "GET", typeof(StoreTypeController), "GetEntityView")]
        [InlineData("/api/office/store-type/meta", "GET", typeof(StoreTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/count", "GET", typeof(StoreTypeController), "Count")]
        [InlineData("/api/office/store-type/count", "GET", typeof(StoreTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/all", "GET", typeof(StoreTypeController), "GetAll")]
        [InlineData("/api/office/store-type/all", "GET", typeof(StoreTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/export", "GET", typeof(StoreTypeController), "Export")]
        [InlineData("/api/office/store-type/export", "GET", typeof(StoreTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/1", "GET", typeof(StoreTypeController), "Get")]
        [InlineData("/api/office/store-type/1", "GET", typeof(StoreTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/get?storeTypeIds=1", "GET", typeof(StoreTypeController), "Get")]
        [InlineData("/api/office/store-type/get?storeTypeIds=1", "GET", typeof(StoreTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store-type", "GET", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/office/store-type", "GET", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/page/1", "GET", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/office/store-type/page/1", "GET", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/count-filtered/{filterName}", "GET", typeof(StoreTypeController), "CountFiltered")]
        [InlineData("/api/office/store-type/count-filtered/{filterName}", "GET", typeof(StoreTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StoreTypeController), "GetFiltered")]
        [InlineData("/api/office/store-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(StoreTypeController), "GetFiltered")]
        [InlineData("/api/office/store-type/first", "GET", typeof(StoreTypeController), "GetFirst")]
        [InlineData("/api/office/store-type/previous/1", "GET", typeof(StoreTypeController), "GetPrevious")]
        [InlineData("/api/office/store-type/next/1", "GET", typeof(StoreTypeController), "GetNext")]
        [InlineData("/api/office/store-type/last", "GET", typeof(StoreTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/store-type/custom-fields", "GET", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/office/store-type/custom-fields", "GET", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/custom-fields/{resourceId}", "GET", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/office/store-type/custom-fields/{resourceId}", "GET", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/meta", "HEAD", typeof(StoreTypeController), "GetEntityView")]
        [InlineData("/api/office/store-type/meta", "HEAD", typeof(StoreTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/count", "HEAD", typeof(StoreTypeController), "Count")]
        [InlineData("/api/office/store-type/count", "HEAD", typeof(StoreTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/all", "HEAD", typeof(StoreTypeController), "GetAll")]
        [InlineData("/api/office/store-type/all", "HEAD", typeof(StoreTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/export", "HEAD", typeof(StoreTypeController), "Export")]
        [InlineData("/api/office/store-type/export", "HEAD", typeof(StoreTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/1", "HEAD", typeof(StoreTypeController), "Get")]
        [InlineData("/api/office/store-type/1", "HEAD", typeof(StoreTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/get?storeTypeIds=1", "HEAD", typeof(StoreTypeController), "Get")]
        [InlineData("/api/office/store-type/get?storeTypeIds=1", "HEAD", typeof(StoreTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/store-type", "HEAD", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/office/store-type", "HEAD", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/page/1", "HEAD", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/office/store-type/page/1", "HEAD", typeof(StoreTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/count-filtered/{filterName}", "HEAD", typeof(StoreTypeController), "CountFiltered")]
        [InlineData("/api/office/store-type/count-filtered/{filterName}", "HEAD", typeof(StoreTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StoreTypeController), "GetFiltered")]
        [InlineData("/api/office/store-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(StoreTypeController), "GetFiltered")]
        [InlineData("/api/office/store-type/first", "HEAD", typeof(StoreTypeController), "GetFirst")]
        [InlineData("/api/office/store-type/previous/1", "HEAD", typeof(StoreTypeController), "GetPrevious")]
        [InlineData("/api/office/store-type/next/1", "HEAD", typeof(StoreTypeController), "GetNext")]
        [InlineData("/api/office/store-type/last", "HEAD", typeof(StoreTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/store-type/custom-fields", "HEAD", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/office/store-type/custom-fields", "HEAD", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/store-type/custom-fields/{resourceId}", "HEAD", typeof(StoreTypeController), "GetCustomFields")]
        [InlineData("/api/office/store-type/custom-fields/{resourceId}", "HEAD", typeof(StoreTypeController), "GetCustomFields")]

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

        public StoreTypeRouteTests()
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