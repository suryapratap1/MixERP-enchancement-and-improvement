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
    public class ItemGroupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/item-group/delete/{itemGroupId}", "DELETE", typeof(ItemGroupController), "Delete")]
        [InlineData("/api/core/item-group/delete/{itemGroupId}", "DELETE", typeof(ItemGroupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/edit/{itemGroupId}", "PUT", typeof(ItemGroupController), "Edit")]
        [InlineData("/api/core/item-group/edit/{itemGroupId}", "PUT", typeof(ItemGroupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/count-where", "POST", typeof(ItemGroupController), "CountWhere")]
        [InlineData("/api/core/item-group/count-where", "POST", typeof(ItemGroupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/get-where/{pageNumber}", "POST", typeof(ItemGroupController), "GetWhere")]
        [InlineData("/api/core/item-group/get-where/{pageNumber}", "POST", typeof(ItemGroupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/add-or-edit", "POST", typeof(ItemGroupController), "AddOrEdit")]
        [InlineData("/api/core/item-group/add-or-edit", "POST", typeof(ItemGroupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/add/{itemGroup}", "POST", typeof(ItemGroupController), "Add")]
        [InlineData("/api/core/item-group/add/{itemGroup}", "POST", typeof(ItemGroupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/bulk-import", "POST", typeof(ItemGroupController), "BulkImport")]
        [InlineData("/api/core/item-group/bulk-import", "POST", typeof(ItemGroupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/meta", "GET", typeof(ItemGroupController), "GetEntityView")]
        [InlineData("/api/core/item-group/meta", "GET", typeof(ItemGroupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/count", "GET", typeof(ItemGroupController), "Count")]
        [InlineData("/api/core/item-group/count", "GET", typeof(ItemGroupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/all", "GET", typeof(ItemGroupController), "GetAll")]
        [InlineData("/api/core/item-group/all", "GET", typeof(ItemGroupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/export", "GET", typeof(ItemGroupController), "Export")]
        [InlineData("/api/core/item-group/export", "GET", typeof(ItemGroupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/1", "GET", typeof(ItemGroupController), "Get")]
        [InlineData("/api/core/item-group/1", "GET", typeof(ItemGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/get?itemGroupIds=1", "GET", typeof(ItemGroupController), "Get")]
        [InlineData("/api/core/item-group/get?itemGroupIds=1", "GET", typeof(ItemGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-group", "GET", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/item-group", "GET", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/page/1", "GET", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/item-group/page/1", "GET", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/count-filtered/{filterName}", "GET", typeof(ItemGroupController), "CountFiltered")]
        [InlineData("/api/core/item-group/count-filtered/{filterName}", "GET", typeof(ItemGroupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemGroupController), "GetFiltered")]
        [InlineData("/api/core/item-group/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemGroupController), "GetFiltered")]
        [InlineData("/api/core/item-group/first", "GET", typeof(ItemGroupController), "GetFirst")]
        [InlineData("/api/core/item-group/previous/1", "GET", typeof(ItemGroupController), "GetPrevious")]
        [InlineData("/api/core/item-group/next/1", "GET", typeof(ItemGroupController), "GetNext")]
        [InlineData("/api/core/item-group/last", "GET", typeof(ItemGroupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-group/custom-fields", "GET", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/core/item-group/custom-fields", "GET", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/custom-fields/{resourceId}", "GET", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/core/item-group/custom-fields/{resourceId}", "GET", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/meta", "HEAD", typeof(ItemGroupController), "GetEntityView")]
        [InlineData("/api/core/item-group/meta", "HEAD", typeof(ItemGroupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/count", "HEAD", typeof(ItemGroupController), "Count")]
        [InlineData("/api/core/item-group/count", "HEAD", typeof(ItemGroupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/all", "HEAD", typeof(ItemGroupController), "GetAll")]
        [InlineData("/api/core/item-group/all", "HEAD", typeof(ItemGroupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/export", "HEAD", typeof(ItemGroupController), "Export")]
        [InlineData("/api/core/item-group/export", "HEAD", typeof(ItemGroupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/1", "HEAD", typeof(ItemGroupController), "Get")]
        [InlineData("/api/core/item-group/1", "HEAD", typeof(ItemGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/get?itemGroupIds=1", "HEAD", typeof(ItemGroupController), "Get")]
        [InlineData("/api/core/item-group/get?itemGroupIds=1", "HEAD", typeof(ItemGroupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-group", "HEAD", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/item-group", "HEAD", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/page/1", "HEAD", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/core/item-group/page/1", "HEAD", typeof(ItemGroupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/count-filtered/{filterName}", "HEAD", typeof(ItemGroupController), "CountFiltered")]
        [InlineData("/api/core/item-group/count-filtered/{filterName}", "HEAD", typeof(ItemGroupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemGroupController), "GetFiltered")]
        [InlineData("/api/core/item-group/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemGroupController), "GetFiltered")]
        [InlineData("/api/core/item-group/first", "HEAD", typeof(ItemGroupController), "GetFirst")]
        [InlineData("/api/core/item-group/previous/1", "HEAD", typeof(ItemGroupController), "GetPrevious")]
        [InlineData("/api/core/item-group/next/1", "HEAD", typeof(ItemGroupController), "GetNext")]
        [InlineData("/api/core/item-group/last", "HEAD", typeof(ItemGroupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-group/custom-fields", "HEAD", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/core/item-group/custom-fields", "HEAD", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-group/custom-fields/{resourceId}", "HEAD", typeof(ItemGroupController), "GetCustomFields")]
        [InlineData("/api/core/item-group/custom-fields/{resourceId}", "HEAD", typeof(ItemGroupController), "GetCustomFields")]

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

        public ItemGroupRouteTests()
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