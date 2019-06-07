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
    public class AttributeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/attribute/delete/{attributeId}", "DELETE", typeof(CoreAttributeController), "Delete")]
        [InlineData("/api/core/attribute/delete/{attributeId}", "DELETE", typeof(CoreAttributeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/edit/{attributeId}", "PUT", typeof(CoreAttributeController), "Edit")]
        [InlineData("/api/core/attribute/edit/{attributeId}", "PUT", typeof(CoreAttributeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/count-where", "POST", typeof(CoreAttributeController), "CountWhere")]
        [InlineData("/api/core/attribute/count-where", "POST", typeof(CoreAttributeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/get-where/{pageNumber}", "POST", typeof(CoreAttributeController), "GetWhere")]
        [InlineData("/api/core/attribute/get-where/{pageNumber}", "POST", typeof(CoreAttributeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/add-or-edit", "POST", typeof(CoreAttributeController), "AddOrEdit")]
        [InlineData("/api/core/attribute/add-or-edit", "POST", typeof(CoreAttributeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/add/{attribute}", "POST", typeof(CoreAttributeController), "Add")]
        [InlineData("/api/core/attribute/add/{attribute}", "POST", typeof(CoreAttributeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/bulk-import", "POST", typeof(CoreAttributeController), "BulkImport")]
        [InlineData("/api/core/attribute/bulk-import", "POST", typeof(CoreAttributeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/meta", "GET", typeof(CoreAttributeController), "GetEntityView")]
        [InlineData("/api/core/attribute/meta", "GET", typeof(CoreAttributeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/count", "GET", typeof(CoreAttributeController), "Count")]
        [InlineData("/api/core/attribute/count", "GET", typeof(CoreAttributeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/all", "GET", typeof(CoreAttributeController), "GetAll")]
        [InlineData("/api/core/attribute/all", "GET", typeof(CoreAttributeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/export", "GET", typeof(CoreAttributeController), "Export")]
        [InlineData("/api/core/attribute/export", "GET", typeof(CoreAttributeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/1", "GET", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/core/attribute/1", "GET", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/get?attributeIds=1", "GET", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/core/attribute/get?attributeIds=1", "GET", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attribute", "GET", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/core/attribute", "GET", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/page/1", "GET", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/core/attribute/page/1", "GET", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/count-filtered/{filterName}", "GET", typeof(CoreAttributeController), "CountFiltered")]
        [InlineData("/api/core/attribute/count-filtered/{filterName}", "GET", typeof(CoreAttributeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CoreAttributeController), "GetFiltered")]
        [InlineData("/api/core/attribute/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CoreAttributeController), "GetFiltered")]
        [InlineData("/api/core/attribute/first", "GET", typeof(CoreAttributeController), "GetFirst")]
        [InlineData("/api/core/attribute/previous/1", "GET", typeof(CoreAttributeController), "GetPrevious")]
        [InlineData("/api/core/attribute/next/1", "GET", typeof(CoreAttributeController), "GetNext")]
        [InlineData("/api/core/attribute/last", "GET", typeof(CoreAttributeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/attribute/custom-fields", "GET", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/core/attribute/custom-fields", "GET", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/custom-fields/{resourceId}", "GET", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/core/attribute/custom-fields/{resourceId}", "GET", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/meta", "HEAD", typeof(CoreAttributeController), "GetEntityView")]
        [InlineData("/api/core/attribute/meta", "HEAD", typeof(CoreAttributeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/count", "HEAD", typeof(CoreAttributeController), "Count")]
        [InlineData("/api/core/attribute/count", "HEAD", typeof(CoreAttributeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/all", "HEAD", typeof(CoreAttributeController), "GetAll")]
        [InlineData("/api/core/attribute/all", "HEAD", typeof(CoreAttributeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/export", "HEAD", typeof(CoreAttributeController), "Export")]
        [InlineData("/api/core/attribute/export", "HEAD", typeof(CoreAttributeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/1", "HEAD", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/core/attribute/1", "HEAD", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/get?attributeIds=1", "HEAD", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/core/attribute/get?attributeIds=1", "HEAD", typeof(CoreAttributeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attribute", "HEAD", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/core/attribute", "HEAD", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/page/1", "HEAD", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/core/attribute/page/1", "HEAD", typeof(CoreAttributeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/count-filtered/{filterName}", "HEAD", typeof(CoreAttributeController), "CountFiltered")]
        [InlineData("/api/core/attribute/count-filtered/{filterName}", "HEAD", typeof(CoreAttributeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CoreAttributeController), "GetFiltered")]
        [InlineData("/api/core/attribute/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CoreAttributeController), "GetFiltered")]
        [InlineData("/api/core/attribute/first", "HEAD", typeof(CoreAttributeController), "GetFirst")]
        [InlineData("/api/core/attribute/previous/1", "HEAD", typeof(CoreAttributeController), "GetPrevious")]
        [InlineData("/api/core/attribute/next/1", "HEAD", typeof(CoreAttributeController), "GetNext")]
        [InlineData("/api/core/attribute/last", "HEAD", typeof(CoreAttributeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/attribute/custom-fields", "HEAD", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/core/attribute/custom-fields", "HEAD", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attribute/custom-fields/{resourceId}", "HEAD", typeof(CoreAttributeController), "GetCustomFields")]
        [InlineData("/api/core/attribute/custom-fields/{resourceId}", "HEAD", typeof(CoreAttributeController), "GetCustomFields")]

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

        public AttributeRouteTests()
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