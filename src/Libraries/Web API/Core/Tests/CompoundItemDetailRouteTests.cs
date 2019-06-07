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
    public class CompoundItemDetailRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/delete/{compoundItemDetailId}", "DELETE", typeof(CompoundItemDetailController), "Delete")]
        [InlineData("/api/core/compound-item-detail/delete/{compoundItemDetailId}", "DELETE", typeof(CompoundItemDetailController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/edit/{compoundItemDetailId}", "PUT", typeof(CompoundItemDetailController), "Edit")]
        [InlineData("/api/core/compound-item-detail/edit/{compoundItemDetailId}", "PUT", typeof(CompoundItemDetailController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/count-where", "POST", typeof(CompoundItemDetailController), "CountWhere")]
        [InlineData("/api/core/compound-item-detail/count-where", "POST", typeof(CompoundItemDetailController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/get-where/{pageNumber}", "POST", typeof(CompoundItemDetailController), "GetWhere")]
        [InlineData("/api/core/compound-item-detail/get-where/{pageNumber}", "POST", typeof(CompoundItemDetailController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/add-or-edit", "POST", typeof(CompoundItemDetailController), "AddOrEdit")]
        [InlineData("/api/core/compound-item-detail/add-or-edit", "POST", typeof(CompoundItemDetailController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/add/{compoundItemDetail}", "POST", typeof(CompoundItemDetailController), "Add")]
        [InlineData("/api/core/compound-item-detail/add/{compoundItemDetail}", "POST", typeof(CompoundItemDetailController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/bulk-import", "POST", typeof(CompoundItemDetailController), "BulkImport")]
        [InlineData("/api/core/compound-item-detail/bulk-import", "POST", typeof(CompoundItemDetailController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/meta", "GET", typeof(CompoundItemDetailController), "GetEntityView")]
        [InlineData("/api/core/compound-item-detail/meta", "GET", typeof(CompoundItemDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/count", "GET", typeof(CompoundItemDetailController), "Count")]
        [InlineData("/api/core/compound-item-detail/count", "GET", typeof(CompoundItemDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/all", "GET", typeof(CompoundItemDetailController), "GetAll")]
        [InlineData("/api/core/compound-item-detail/all", "GET", typeof(CompoundItemDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/export", "GET", typeof(CompoundItemDetailController), "Export")]
        [InlineData("/api/core/compound-item-detail/export", "GET", typeof(CompoundItemDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/1", "GET", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/core/compound-item-detail/1", "GET", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/get?compoundItemDetailIds=1", "GET", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/core/compound-item-detail/get?compoundItemDetailIds=1", "GET", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail", "GET", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item-detail", "GET", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/page/1", "GET", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item-detail/page/1", "GET", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/count-filtered/{filterName}", "GET", typeof(CompoundItemDetailController), "CountFiltered")]
        [InlineData("/api/core/compound-item-detail/count-filtered/{filterName}", "GET", typeof(CompoundItemDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CompoundItemDetailController), "GetFiltered")]
        [InlineData("/api/core/compound-item-detail/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CompoundItemDetailController), "GetFiltered")]
        [InlineData("/api/core/compound-item-detail/first", "GET", typeof(CompoundItemDetailController), "GetFirst")]
        [InlineData("/api/core/compound-item-detail/previous/1", "GET", typeof(CompoundItemDetailController), "GetPrevious")]
        [InlineData("/api/core/compound-item-detail/next/1", "GET", typeof(CompoundItemDetailController), "GetNext")]
        [InlineData("/api/core/compound-item-detail/last", "GET", typeof(CompoundItemDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/custom-fields", "GET", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/core/compound-item-detail/custom-fields", "GET", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/custom-fields/{resourceId}", "GET", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/core/compound-item-detail/custom-fields/{resourceId}", "GET", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/meta", "HEAD", typeof(CompoundItemDetailController), "GetEntityView")]
        [InlineData("/api/core/compound-item-detail/meta", "HEAD", typeof(CompoundItemDetailController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/count", "HEAD", typeof(CompoundItemDetailController), "Count")]
        [InlineData("/api/core/compound-item-detail/count", "HEAD", typeof(CompoundItemDetailController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/all", "HEAD", typeof(CompoundItemDetailController), "GetAll")]
        [InlineData("/api/core/compound-item-detail/all", "HEAD", typeof(CompoundItemDetailController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/export", "HEAD", typeof(CompoundItemDetailController), "Export")]
        [InlineData("/api/core/compound-item-detail/export", "HEAD", typeof(CompoundItemDetailController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/1", "HEAD", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/core/compound-item-detail/1", "HEAD", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/get?compoundItemDetailIds=1", "HEAD", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/core/compound-item-detail/get?compoundItemDetailIds=1", "HEAD", typeof(CompoundItemDetailController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail", "HEAD", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item-detail", "HEAD", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/page/1", "HEAD", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-item-detail/page/1", "HEAD", typeof(CompoundItemDetailController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/count-filtered/{filterName}", "HEAD", typeof(CompoundItemDetailController), "CountFiltered")]
        [InlineData("/api/core/compound-item-detail/count-filtered/{filterName}", "HEAD", typeof(CompoundItemDetailController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CompoundItemDetailController), "GetFiltered")]
        [InlineData("/api/core/compound-item-detail/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CompoundItemDetailController), "GetFiltered")]
        [InlineData("/api/core/compound-item-detail/first", "HEAD", typeof(CompoundItemDetailController), "GetFirst")]
        [InlineData("/api/core/compound-item-detail/previous/1", "HEAD", typeof(CompoundItemDetailController), "GetPrevious")]
        [InlineData("/api/core/compound-item-detail/next/1", "HEAD", typeof(CompoundItemDetailController), "GetNext")]
        [InlineData("/api/core/compound-item-detail/last", "HEAD", typeof(CompoundItemDetailController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/custom-fields", "HEAD", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/core/compound-item-detail/custom-fields", "HEAD", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-item-detail/custom-fields/{resourceId}", "HEAD", typeof(CompoundItemDetailController), "GetCustomFields")]
        [InlineData("/api/core/compound-item-detail/custom-fields/{resourceId}", "HEAD", typeof(CompoundItemDetailController), "GetCustomFields")]

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

        public CompoundItemDetailRouteTests()
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