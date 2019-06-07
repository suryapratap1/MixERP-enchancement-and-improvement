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

namespace MixERP.Net.Api.Config.Tests
{
    public class AttachmentFactoryRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/delete/{key}", "DELETE", typeof(AttachmentFactoryController), "Delete")]
        [InlineData("/api/config/attachment-factory/delete/{key}", "DELETE", typeof(AttachmentFactoryController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/edit/{key}", "PUT", typeof(AttachmentFactoryController), "Edit")]
        [InlineData("/api/config/attachment-factory/edit/{key}", "PUT", typeof(AttachmentFactoryController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/count-where", "POST", typeof(AttachmentFactoryController), "CountWhere")]
        [InlineData("/api/config/attachment-factory/count-where", "POST", typeof(AttachmentFactoryController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/get-where/{pageNumber}", "POST", typeof(AttachmentFactoryController), "GetWhere")]
        [InlineData("/api/config/attachment-factory/get-where/{pageNumber}", "POST", typeof(AttachmentFactoryController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/add-or-edit", "POST", typeof(AttachmentFactoryController), "AddOrEdit")]
        [InlineData("/api/config/attachment-factory/add-or-edit", "POST", typeof(AttachmentFactoryController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/add/{attachmentFactory}", "POST", typeof(AttachmentFactoryController), "Add")]
        [InlineData("/api/config/attachment-factory/add/{attachmentFactory}", "POST", typeof(AttachmentFactoryController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/bulk-import", "POST", typeof(AttachmentFactoryController), "BulkImport")]
        [InlineData("/api/config/attachment-factory/bulk-import", "POST", typeof(AttachmentFactoryController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/meta", "GET", typeof(AttachmentFactoryController), "GetEntityView")]
        [InlineData("/api/config/attachment-factory/meta", "GET", typeof(AttachmentFactoryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/count", "GET", typeof(AttachmentFactoryController), "Count")]
        [InlineData("/api/config/attachment-factory/count", "GET", typeof(AttachmentFactoryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/all", "GET", typeof(AttachmentFactoryController), "GetAll")]
        [InlineData("/api/config/attachment-factory/all", "GET", typeof(AttachmentFactoryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/export", "GET", typeof(AttachmentFactoryController), "Export")]
        [InlineData("/api/config/attachment-factory/export", "GET", typeof(AttachmentFactoryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/1", "GET", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/config/attachment-factory/1", "GET", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/get?keys=1", "GET", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/config/attachment-factory/get?keys=1", "GET", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory", "GET", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/attachment-factory", "GET", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/page/1", "GET", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/attachment-factory/page/1", "GET", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/count-filtered/{filterName}", "GET", typeof(AttachmentFactoryController), "CountFiltered")]
        [InlineData("/api/config/attachment-factory/count-filtered/{filterName}", "GET", typeof(AttachmentFactoryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttachmentFactoryController), "GetFiltered")]
        [InlineData("/api/config/attachment-factory/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttachmentFactoryController), "GetFiltered")]
        [InlineData("/api/config/attachment-factory/first", "GET", typeof(AttachmentFactoryController), "GetFirst")]
        [InlineData("/api/config/attachment-factory/previous/1", "GET", typeof(AttachmentFactoryController), "GetPrevious")]
        [InlineData("/api/config/attachment-factory/next/1", "GET", typeof(AttachmentFactoryController), "GetNext")]
        [InlineData("/api/config/attachment-factory/last", "GET", typeof(AttachmentFactoryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/custom-fields", "GET", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/config/attachment-factory/custom-fields", "GET", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/custom-fields/{resourceId}", "GET", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/config/attachment-factory/custom-fields/{resourceId}", "GET", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/meta", "HEAD", typeof(AttachmentFactoryController), "GetEntityView")]
        [InlineData("/api/config/attachment-factory/meta", "HEAD", typeof(AttachmentFactoryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/count", "HEAD", typeof(AttachmentFactoryController), "Count")]
        [InlineData("/api/config/attachment-factory/count", "HEAD", typeof(AttachmentFactoryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/all", "HEAD", typeof(AttachmentFactoryController), "GetAll")]
        [InlineData("/api/config/attachment-factory/all", "HEAD", typeof(AttachmentFactoryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/export", "HEAD", typeof(AttachmentFactoryController), "Export")]
        [InlineData("/api/config/attachment-factory/export", "HEAD", typeof(AttachmentFactoryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/1", "HEAD", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/config/attachment-factory/1", "HEAD", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/get?keys=1", "HEAD", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/config/attachment-factory/get?keys=1", "HEAD", typeof(AttachmentFactoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory", "HEAD", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/attachment-factory", "HEAD", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/page/1", "HEAD", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/config/attachment-factory/page/1", "HEAD", typeof(AttachmentFactoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/count-filtered/{filterName}", "HEAD", typeof(AttachmentFactoryController), "CountFiltered")]
        [InlineData("/api/config/attachment-factory/count-filtered/{filterName}", "HEAD", typeof(AttachmentFactoryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttachmentFactoryController), "GetFiltered")]
        [InlineData("/api/config/attachment-factory/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttachmentFactoryController), "GetFiltered")]
        [InlineData("/api/config/attachment-factory/first", "HEAD", typeof(AttachmentFactoryController), "GetFirst")]
        [InlineData("/api/config/attachment-factory/previous/1", "HEAD", typeof(AttachmentFactoryController), "GetPrevious")]
        [InlineData("/api/config/attachment-factory/next/1", "HEAD", typeof(AttachmentFactoryController), "GetNext")]
        [InlineData("/api/config/attachment-factory/last", "HEAD", typeof(AttachmentFactoryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/custom-fields", "HEAD", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/config/attachment-factory/custom-fields", "HEAD", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/attachment-factory/custom-fields/{resourceId}", "HEAD", typeof(AttachmentFactoryController), "GetCustomFields")]
        [InlineData("/api/config/attachment-factory/custom-fields/{resourceId}", "HEAD", typeof(AttachmentFactoryController), "GetCustomFields")]

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

        public AttachmentFactoryRouteTests()
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