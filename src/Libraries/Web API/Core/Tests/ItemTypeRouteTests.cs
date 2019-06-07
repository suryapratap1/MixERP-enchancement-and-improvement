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
    public class ItemTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/item-type/delete/{itemTypeId}", "DELETE", typeof(ItemTypeController), "Delete")]
        [InlineData("/api/core/item-type/delete/{itemTypeId}", "DELETE", typeof(ItemTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/edit/{itemTypeId}", "PUT", typeof(ItemTypeController), "Edit")]
        [InlineData("/api/core/item-type/edit/{itemTypeId}", "PUT", typeof(ItemTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/count-where", "POST", typeof(ItemTypeController), "CountWhere")]
        [InlineData("/api/core/item-type/count-where", "POST", typeof(ItemTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/get-where/{pageNumber}", "POST", typeof(ItemTypeController), "GetWhere")]
        [InlineData("/api/core/item-type/get-where/{pageNumber}", "POST", typeof(ItemTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/add-or-edit", "POST", typeof(ItemTypeController), "AddOrEdit")]
        [InlineData("/api/core/item-type/add-or-edit", "POST", typeof(ItemTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/add/{itemType}", "POST", typeof(ItemTypeController), "Add")]
        [InlineData("/api/core/item-type/add/{itemType}", "POST", typeof(ItemTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/bulk-import", "POST", typeof(ItemTypeController), "BulkImport")]
        [InlineData("/api/core/item-type/bulk-import", "POST", typeof(ItemTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/meta", "GET", typeof(ItemTypeController), "GetEntityView")]
        [InlineData("/api/core/item-type/meta", "GET", typeof(ItemTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/count", "GET", typeof(ItemTypeController), "Count")]
        [InlineData("/api/core/item-type/count", "GET", typeof(ItemTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/all", "GET", typeof(ItemTypeController), "GetAll")]
        [InlineData("/api/core/item-type/all", "GET", typeof(ItemTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/export", "GET", typeof(ItemTypeController), "Export")]
        [InlineData("/api/core/item-type/export", "GET", typeof(ItemTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/1", "GET", typeof(ItemTypeController), "Get")]
        [InlineData("/api/core/item-type/1", "GET", typeof(ItemTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/get?itemTypeIds=1", "GET", typeof(ItemTypeController), "Get")]
        [InlineData("/api/core/item-type/get?itemTypeIds=1", "GET", typeof(ItemTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-type", "GET", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/item-type", "GET", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/page/1", "GET", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/item-type/page/1", "GET", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/count-filtered/{filterName}", "GET", typeof(ItemTypeController), "CountFiltered")]
        [InlineData("/api/core/item-type/count-filtered/{filterName}", "GET", typeof(ItemTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemTypeController), "GetFiltered")]
        [InlineData("/api/core/item-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemTypeController), "GetFiltered")]
        [InlineData("/api/core/item-type/first", "GET", typeof(ItemTypeController), "GetFirst")]
        [InlineData("/api/core/item-type/previous/1", "GET", typeof(ItemTypeController), "GetPrevious")]
        [InlineData("/api/core/item-type/next/1", "GET", typeof(ItemTypeController), "GetNext")]
        [InlineData("/api/core/item-type/last", "GET", typeof(ItemTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-type/custom-fields", "GET", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/core/item-type/custom-fields", "GET", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/custom-fields/{resourceId}", "GET", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/core/item-type/custom-fields/{resourceId}", "GET", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/meta", "HEAD", typeof(ItemTypeController), "GetEntityView")]
        [InlineData("/api/core/item-type/meta", "HEAD", typeof(ItemTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/count", "HEAD", typeof(ItemTypeController), "Count")]
        [InlineData("/api/core/item-type/count", "HEAD", typeof(ItemTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/all", "HEAD", typeof(ItemTypeController), "GetAll")]
        [InlineData("/api/core/item-type/all", "HEAD", typeof(ItemTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/export", "HEAD", typeof(ItemTypeController), "Export")]
        [InlineData("/api/core/item-type/export", "HEAD", typeof(ItemTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/1", "HEAD", typeof(ItemTypeController), "Get")]
        [InlineData("/api/core/item-type/1", "HEAD", typeof(ItemTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/get?itemTypeIds=1", "HEAD", typeof(ItemTypeController), "Get")]
        [InlineData("/api/core/item-type/get?itemTypeIds=1", "HEAD", typeof(ItemTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-type", "HEAD", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/item-type", "HEAD", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/page/1", "HEAD", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/item-type/page/1", "HEAD", typeof(ItemTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/count-filtered/{filterName}", "HEAD", typeof(ItemTypeController), "CountFiltered")]
        [InlineData("/api/core/item-type/count-filtered/{filterName}", "HEAD", typeof(ItemTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemTypeController), "GetFiltered")]
        [InlineData("/api/core/item-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemTypeController), "GetFiltered")]
        [InlineData("/api/core/item-type/first", "HEAD", typeof(ItemTypeController), "GetFirst")]
        [InlineData("/api/core/item-type/previous/1", "HEAD", typeof(ItemTypeController), "GetPrevious")]
        [InlineData("/api/core/item-type/next/1", "HEAD", typeof(ItemTypeController), "GetNext")]
        [InlineData("/api/core/item-type/last", "HEAD", typeof(ItemTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-type/custom-fields", "HEAD", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/core/item-type/custom-fields", "HEAD", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-type/custom-fields/{resourceId}", "HEAD", typeof(ItemTypeController), "GetCustomFields")]
        [InlineData("/api/core/item-type/custom-fields/{resourceId}", "HEAD", typeof(ItemTypeController), "GetCustomFields")]

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

        public ItemTypeRouteTests()
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