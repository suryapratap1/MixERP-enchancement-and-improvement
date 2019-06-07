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
    public class CompoundUnitRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/delete/{compoundUnitId}", "DELETE", typeof(CompoundUnitController), "Delete")]
        [InlineData("/api/core/compound-unit/delete/{compoundUnitId}", "DELETE", typeof(CompoundUnitController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/edit/{compoundUnitId}", "PUT", typeof(CompoundUnitController), "Edit")]
        [InlineData("/api/core/compound-unit/edit/{compoundUnitId}", "PUT", typeof(CompoundUnitController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/count-where", "POST", typeof(CompoundUnitController), "CountWhere")]
        [InlineData("/api/core/compound-unit/count-where", "POST", typeof(CompoundUnitController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/get-where/{pageNumber}", "POST", typeof(CompoundUnitController), "GetWhere")]
        [InlineData("/api/core/compound-unit/get-where/{pageNumber}", "POST", typeof(CompoundUnitController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/add-or-edit", "POST", typeof(CompoundUnitController), "AddOrEdit")]
        [InlineData("/api/core/compound-unit/add-or-edit", "POST", typeof(CompoundUnitController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/add/{compoundUnit}", "POST", typeof(CompoundUnitController), "Add")]
        [InlineData("/api/core/compound-unit/add/{compoundUnit}", "POST", typeof(CompoundUnitController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/bulk-import", "POST", typeof(CompoundUnitController), "BulkImport")]
        [InlineData("/api/core/compound-unit/bulk-import", "POST", typeof(CompoundUnitController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/meta", "GET", typeof(CompoundUnitController), "GetEntityView")]
        [InlineData("/api/core/compound-unit/meta", "GET", typeof(CompoundUnitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/count", "GET", typeof(CompoundUnitController), "Count")]
        [InlineData("/api/core/compound-unit/count", "GET", typeof(CompoundUnitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/all", "GET", typeof(CompoundUnitController), "GetAll")]
        [InlineData("/api/core/compound-unit/all", "GET", typeof(CompoundUnitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/export", "GET", typeof(CompoundUnitController), "Export")]
        [InlineData("/api/core/compound-unit/export", "GET", typeof(CompoundUnitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/1", "GET", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/core/compound-unit/1", "GET", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/get?compoundUnitIds=1", "GET", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/core/compound-unit/get?compoundUnitIds=1", "GET", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit", "GET", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-unit", "GET", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/page/1", "GET", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-unit/page/1", "GET", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/count-filtered/{filterName}", "GET", typeof(CompoundUnitController), "CountFiltered")]
        [InlineData("/api/core/compound-unit/count-filtered/{filterName}", "GET", typeof(CompoundUnitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CompoundUnitController), "GetFiltered")]
        [InlineData("/api/core/compound-unit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CompoundUnitController), "GetFiltered")]
        [InlineData("/api/core/compound-unit/first", "GET", typeof(CompoundUnitController), "GetFirst")]
        [InlineData("/api/core/compound-unit/previous/1", "GET", typeof(CompoundUnitController), "GetPrevious")]
        [InlineData("/api/core/compound-unit/next/1", "GET", typeof(CompoundUnitController), "GetNext")]
        [InlineData("/api/core/compound-unit/last", "GET", typeof(CompoundUnitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/compound-unit/custom-fields", "GET", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/core/compound-unit/custom-fields", "GET", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/custom-fields/{resourceId}", "GET", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/core/compound-unit/custom-fields/{resourceId}", "GET", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/meta", "HEAD", typeof(CompoundUnitController), "GetEntityView")]
        [InlineData("/api/core/compound-unit/meta", "HEAD", typeof(CompoundUnitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/count", "HEAD", typeof(CompoundUnitController), "Count")]
        [InlineData("/api/core/compound-unit/count", "HEAD", typeof(CompoundUnitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/all", "HEAD", typeof(CompoundUnitController), "GetAll")]
        [InlineData("/api/core/compound-unit/all", "HEAD", typeof(CompoundUnitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/export", "HEAD", typeof(CompoundUnitController), "Export")]
        [InlineData("/api/core/compound-unit/export", "HEAD", typeof(CompoundUnitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/1", "HEAD", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/core/compound-unit/1", "HEAD", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/get?compoundUnitIds=1", "HEAD", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/core/compound-unit/get?compoundUnitIds=1", "HEAD", typeof(CompoundUnitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit", "HEAD", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-unit", "HEAD", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/page/1", "HEAD", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/core/compound-unit/page/1", "HEAD", typeof(CompoundUnitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/count-filtered/{filterName}", "HEAD", typeof(CompoundUnitController), "CountFiltered")]
        [InlineData("/api/core/compound-unit/count-filtered/{filterName}", "HEAD", typeof(CompoundUnitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CompoundUnitController), "GetFiltered")]
        [InlineData("/api/core/compound-unit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CompoundUnitController), "GetFiltered")]
        [InlineData("/api/core/compound-unit/first", "HEAD", typeof(CompoundUnitController), "GetFirst")]
        [InlineData("/api/core/compound-unit/previous/1", "HEAD", typeof(CompoundUnitController), "GetPrevious")]
        [InlineData("/api/core/compound-unit/next/1", "HEAD", typeof(CompoundUnitController), "GetNext")]
        [InlineData("/api/core/compound-unit/last", "HEAD", typeof(CompoundUnitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/compound-unit/custom-fields", "HEAD", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/core/compound-unit/custom-fields", "HEAD", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/compound-unit/custom-fields/{resourceId}", "HEAD", typeof(CompoundUnitController), "GetCustomFields")]
        [InlineData("/api/core/compound-unit/custom-fields/{resourceId}", "HEAD", typeof(CompoundUnitController), "GetCustomFields")]

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

        public CompoundUnitRouteTests()
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