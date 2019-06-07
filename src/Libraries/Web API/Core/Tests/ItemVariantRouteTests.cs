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
    public class ItemVariantRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/delete/{itemVariantId}", "DELETE", typeof(ItemVariantController), "Delete")]
        [InlineData("/api/core/item-variant/delete/{itemVariantId}", "DELETE", typeof(ItemVariantController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/edit/{itemVariantId}", "PUT", typeof(ItemVariantController), "Edit")]
        [InlineData("/api/core/item-variant/edit/{itemVariantId}", "PUT", typeof(ItemVariantController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/count-where", "POST", typeof(ItemVariantController), "CountWhere")]
        [InlineData("/api/core/item-variant/count-where", "POST", typeof(ItemVariantController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/get-where/{pageNumber}", "POST", typeof(ItemVariantController), "GetWhere")]
        [InlineData("/api/core/item-variant/get-where/{pageNumber}", "POST", typeof(ItemVariantController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/add-or-edit", "POST", typeof(ItemVariantController), "AddOrEdit")]
        [InlineData("/api/core/item-variant/add-or-edit", "POST", typeof(ItemVariantController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/add/{itemVariant}", "POST", typeof(ItemVariantController), "Add")]
        [InlineData("/api/core/item-variant/add/{itemVariant}", "POST", typeof(ItemVariantController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/bulk-import", "POST", typeof(ItemVariantController), "BulkImport")]
        [InlineData("/api/core/item-variant/bulk-import", "POST", typeof(ItemVariantController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/meta", "GET", typeof(ItemVariantController), "GetEntityView")]
        [InlineData("/api/core/item-variant/meta", "GET", typeof(ItemVariantController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/count", "GET", typeof(ItemVariantController), "Count")]
        [InlineData("/api/core/item-variant/count", "GET", typeof(ItemVariantController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/all", "GET", typeof(ItemVariantController), "GetAll")]
        [InlineData("/api/core/item-variant/all", "GET", typeof(ItemVariantController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/export", "GET", typeof(ItemVariantController), "Export")]
        [InlineData("/api/core/item-variant/export", "GET", typeof(ItemVariantController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/1", "GET", typeof(ItemVariantController), "Get")]
        [InlineData("/api/core/item-variant/1", "GET", typeof(ItemVariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/get?itemVariantIds=1", "GET", typeof(ItemVariantController), "Get")]
        [InlineData("/api/core/item-variant/get?itemVariantIds=1", "GET", typeof(ItemVariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant", "GET", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/core/item-variant", "GET", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/page/1", "GET", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/core/item-variant/page/1", "GET", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/count-filtered/{filterName}", "GET", typeof(ItemVariantController), "CountFiltered")]
        [InlineData("/api/core/item-variant/count-filtered/{filterName}", "GET", typeof(ItemVariantController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemVariantController), "GetFiltered")]
        [InlineData("/api/core/item-variant/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ItemVariantController), "GetFiltered")]
        [InlineData("/api/core/item-variant/first", "GET", typeof(ItemVariantController), "GetFirst")]
        [InlineData("/api/core/item-variant/previous/1", "GET", typeof(ItemVariantController), "GetPrevious")]
        [InlineData("/api/core/item-variant/next/1", "GET", typeof(ItemVariantController), "GetNext")]
        [InlineData("/api/core/item-variant/last", "GET", typeof(ItemVariantController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-variant/custom-fields", "GET", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/core/item-variant/custom-fields", "GET", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/custom-fields/{resourceId}", "GET", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/core/item-variant/custom-fields/{resourceId}", "GET", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/meta", "HEAD", typeof(ItemVariantController), "GetEntityView")]
        [InlineData("/api/core/item-variant/meta", "HEAD", typeof(ItemVariantController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/count", "HEAD", typeof(ItemVariantController), "Count")]
        [InlineData("/api/core/item-variant/count", "HEAD", typeof(ItemVariantController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/all", "HEAD", typeof(ItemVariantController), "GetAll")]
        [InlineData("/api/core/item-variant/all", "HEAD", typeof(ItemVariantController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/export", "HEAD", typeof(ItemVariantController), "Export")]
        [InlineData("/api/core/item-variant/export", "HEAD", typeof(ItemVariantController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/1", "HEAD", typeof(ItemVariantController), "Get")]
        [InlineData("/api/core/item-variant/1", "HEAD", typeof(ItemVariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/get?itemVariantIds=1", "HEAD", typeof(ItemVariantController), "Get")]
        [InlineData("/api/core/item-variant/get?itemVariantIds=1", "HEAD", typeof(ItemVariantController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant", "HEAD", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/core/item-variant", "HEAD", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/page/1", "HEAD", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/core/item-variant/page/1", "HEAD", typeof(ItemVariantController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/count-filtered/{filterName}", "HEAD", typeof(ItemVariantController), "CountFiltered")]
        [InlineData("/api/core/item-variant/count-filtered/{filterName}", "HEAD", typeof(ItemVariantController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemVariantController), "GetFiltered")]
        [InlineData("/api/core/item-variant/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ItemVariantController), "GetFiltered")]
        [InlineData("/api/core/item-variant/first", "HEAD", typeof(ItemVariantController), "GetFirst")]
        [InlineData("/api/core/item-variant/previous/1", "HEAD", typeof(ItemVariantController), "GetPrevious")]
        [InlineData("/api/core/item-variant/next/1", "HEAD", typeof(ItemVariantController), "GetNext")]
        [InlineData("/api/core/item-variant/last", "HEAD", typeof(ItemVariantController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/item-variant/custom-fields", "HEAD", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/core/item-variant/custom-fields", "HEAD", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/item-variant/custom-fields/{resourceId}", "HEAD", typeof(ItemVariantController), "GetCustomFields")]
        [InlineData("/api/core/item-variant/custom-fields/{resourceId}", "HEAD", typeof(ItemVariantController), "GetCustomFields")]

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

        public ItemVariantRouteTests()
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