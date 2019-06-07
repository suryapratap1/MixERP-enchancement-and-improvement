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
    public class ItemRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/item/delete/{itemId}", "DELETE", typeof(ItemController), "Delete")]
        [InlineData("/api/core/item/delete/{itemId}", "DELETE", typeof(ItemController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/item/edit/{itemId}", "PUT", typeof(ItemController), "Edit")]
        [InlineData("/api/core/item/edit/{itemId}", "PUT", typeof(ItemController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/item/count-where", "POST", typeof(ItemController), "CountWhere")]
        [InlineData("/api/core/item/count-where", "POST", typeof(ItemController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item/get-where/{pageNumber}", "POST", typeof(ItemController), "GetWhere")]
        [InlineData("/api/core/item/get-where/{pageNumber}", "POST", typeof(ItemController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item/add-or-edit", "POST", typeof(ItemController), "AddOrEdit")]
        [InlineData("/api/core/item/add-or-edit", "POST", typeof(ItemController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/item/add/{item}", "POST", typeof(ItemController), "Add")]
        [InlineData("/api/core/item/add/{item}", "POST", typeof(ItemController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/item/bulk-import", "POST", typeof(ItemController), "BulkImport")]
        [InlineData("/api/core/item/bulk-import", "POST", typeof(ItemController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/item/meta", "GET", typeof(ItemController), "GetEntityView")]
        [InlineData("/api/core/item/meta", "GET", typeof(ItemController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item/count", "GET", typeof(ItemController), "Count")]
        [InlineData("/api/core/item/count", "GET", typeof(ItemController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item/all", "GET", typeof(ItemController), "GetAll")]
        [InlineData("/api/core/item/all", "GET", typeof(ItemController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item/export", "GET", typeof(ItemController), "Export")]
        [InlineData("/api/core/item/export", "GET", typeof(ItemController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item/1", "GET", typeof(ItemController), "Get")]
        [InlineData("/api/core/item/1", "GET", typeof(ItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item/get?itemIds=1", "GET", typeof(ItemController), "Get")]
        [InlineData("/api/core/item/get?itemIds=1", "GET", typeof(ItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item", "GET", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/core/item", "GET", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item/page/1", "GET", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/core/item/page/1", "GET", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item/count-filtered/{filterName}", "GET", typeof(ItemController), "CountFiltered")]
        [InlineData("/api/core/item/count-filtered/{filterName}", "GET", typeof(ItemController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemController), "GetFiltered")]
        [InlineData("/api/core/item/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemController), "GetFiltered")]
        [InlineData("/api/core/item/first", "GET", typeof(ItemController), "GetFirst")]
        [InlineData("/api/core/item/previous/1", "GET", typeof(ItemController), "GetPrevious")]
        [InlineData("/api/core/item/next/1", "GET", typeof(ItemController), "GetNext")]
        [InlineData("/api/core/item/last", "GET", typeof(ItemController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item/custom-fields", "GET", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/core/item/custom-fields", "GET", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item/custom-fields/{resourceId}", "GET", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/core/item/custom-fields/{resourceId}", "GET", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item/meta", "HEAD", typeof(ItemController), "GetEntityView")]
        [InlineData("/api/core/item/meta", "HEAD", typeof(ItemController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item/count", "HEAD", typeof(ItemController), "Count")]
        [InlineData("/api/core/item/count", "HEAD", typeof(ItemController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item/all", "HEAD", typeof(ItemController), "GetAll")]
        [InlineData("/api/core/item/all", "HEAD", typeof(ItemController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item/export", "HEAD", typeof(ItemController), "Export")]
        [InlineData("/api/core/item/export", "HEAD", typeof(ItemController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item/1", "HEAD", typeof(ItemController), "Get")]
        [InlineData("/api/core/item/1", "HEAD", typeof(ItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item/get?itemIds=1", "HEAD", typeof(ItemController), "Get")]
        [InlineData("/api/core/item/get?itemIds=1", "HEAD", typeof(ItemController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item", "HEAD", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/core/item", "HEAD", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item/page/1", "HEAD", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/core/item/page/1", "HEAD", typeof(ItemController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item/count-filtered/{filterName}", "HEAD", typeof(ItemController), "CountFiltered")]
        [InlineData("/api/core/item/count-filtered/{filterName}", "HEAD", typeof(ItemController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemController), "GetFiltered")]
        [InlineData("/api/core/item/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemController), "GetFiltered")]
        [InlineData("/api/core/item/first", "HEAD", typeof(ItemController), "GetFirst")]
        [InlineData("/api/core/item/previous/1", "HEAD", typeof(ItemController), "GetPrevious")]
        [InlineData("/api/core/item/next/1", "HEAD", typeof(ItemController), "GetNext")]
        [InlineData("/api/core/item/last", "HEAD", typeof(ItemController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item/custom-fields", "HEAD", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/core/item/custom-fields", "HEAD", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item/custom-fields/{resourceId}", "HEAD", typeof(ItemController), "GetCustomFields")]
        [InlineData("/api/core/item/custom-fields/{resourceId}", "HEAD", typeof(ItemController), "GetCustomFields")]

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

        public ItemRouteTests()
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