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
    public class AttachmentRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/attachment/delete/{attachmentId}", "DELETE", typeof(AttachmentController), "Delete")]
        [InlineData("/api/core/attachment/delete/{attachmentId}", "DELETE", typeof(AttachmentController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/edit/{attachmentId}", "PUT", typeof(AttachmentController), "Edit")]
        [InlineData("/api/core/attachment/edit/{attachmentId}", "PUT", typeof(AttachmentController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/count-where", "POST", typeof(AttachmentController), "CountWhere")]
        [InlineData("/api/core/attachment/count-where", "POST", typeof(AttachmentController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/get-where/{pageNumber}", "POST", typeof(AttachmentController), "GetWhere")]
        [InlineData("/api/core/attachment/get-where/{pageNumber}", "POST", typeof(AttachmentController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/add-or-edit", "POST", typeof(AttachmentController), "AddOrEdit")]
        [InlineData("/api/core/attachment/add-or-edit", "POST", typeof(AttachmentController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/add/{attachment}", "POST", typeof(AttachmentController), "Add")]
        [InlineData("/api/core/attachment/add/{attachment}", "POST", typeof(AttachmentController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/bulk-import", "POST", typeof(AttachmentController), "BulkImport")]
        [InlineData("/api/core/attachment/bulk-import", "POST", typeof(AttachmentController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/meta", "GET", typeof(AttachmentController), "GetEntityView")]
        [InlineData("/api/core/attachment/meta", "GET", typeof(AttachmentController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/count", "GET", typeof(AttachmentController), "Count")]
        [InlineData("/api/core/attachment/count", "GET", typeof(AttachmentController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/all", "GET", typeof(AttachmentController), "GetAll")]
        [InlineData("/api/core/attachment/all", "GET", typeof(AttachmentController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/export", "GET", typeof(AttachmentController), "Export")]
        [InlineData("/api/core/attachment/export", "GET", typeof(AttachmentController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/1", "GET", typeof(AttachmentController), "Get")]
        [InlineData("/api/core/attachment/1", "GET", typeof(AttachmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/get?attachmentIds=1", "GET", typeof(AttachmentController), "Get")]
        [InlineData("/api/core/attachment/get?attachmentIds=1", "GET", typeof(AttachmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment", "GET", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment", "GET", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/page/1", "GET", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment/page/1", "GET", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/count-filtered/{filterName}", "GET", typeof(AttachmentController), "CountFiltered")]
        [InlineData("/api/core/attachment/count-filtered/{filterName}", "GET", typeof(AttachmentController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttachmentController), "GetFiltered")]
        [InlineData("/api/core/attachment/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttachmentController), "GetFiltered")]
        [InlineData("/api/core/attachment/first", "GET", typeof(AttachmentController), "GetFirst")]
        [InlineData("/api/core/attachment/previous/1", "GET", typeof(AttachmentController), "GetPrevious")]
        [InlineData("/api/core/attachment/next/1", "GET", typeof(AttachmentController), "GetNext")]
        [InlineData("/api/core/attachment/last", "GET", typeof(AttachmentController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/attachment/custom-fields", "GET", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/core/attachment/custom-fields", "GET", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/custom-fields/{resourceId}", "GET", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/core/attachment/custom-fields/{resourceId}", "GET", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/meta", "HEAD", typeof(AttachmentController), "GetEntityView")]
        [InlineData("/api/core/attachment/meta", "HEAD", typeof(AttachmentController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/count", "HEAD", typeof(AttachmentController), "Count")]
        [InlineData("/api/core/attachment/count", "HEAD", typeof(AttachmentController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/all", "HEAD", typeof(AttachmentController), "GetAll")]
        [InlineData("/api/core/attachment/all", "HEAD", typeof(AttachmentController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/export", "HEAD", typeof(AttachmentController), "Export")]
        [InlineData("/api/core/attachment/export", "HEAD", typeof(AttachmentController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/1", "HEAD", typeof(AttachmentController), "Get")]
        [InlineData("/api/core/attachment/1", "HEAD", typeof(AttachmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/get?attachmentIds=1", "HEAD", typeof(AttachmentController), "Get")]
        [InlineData("/api/core/attachment/get?attachmentIds=1", "HEAD", typeof(AttachmentController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment", "HEAD", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment", "HEAD", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/page/1", "HEAD", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment/page/1", "HEAD", typeof(AttachmentController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/count-filtered/{filterName}", "HEAD", typeof(AttachmentController), "CountFiltered")]
        [InlineData("/api/core/attachment/count-filtered/{filterName}", "HEAD", typeof(AttachmentController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttachmentController), "GetFiltered")]
        [InlineData("/api/core/attachment/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttachmentController), "GetFiltered")]
        [InlineData("/api/core/attachment/first", "HEAD", typeof(AttachmentController), "GetFirst")]
        [InlineData("/api/core/attachment/previous/1", "HEAD", typeof(AttachmentController), "GetPrevious")]
        [InlineData("/api/core/attachment/next/1", "HEAD", typeof(AttachmentController), "GetNext")]
        [InlineData("/api/core/attachment/last", "HEAD", typeof(AttachmentController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/attachment/custom-fields", "HEAD", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/core/attachment/custom-fields", "HEAD", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attachment/custom-fields/{resourceId}", "HEAD", typeof(AttachmentController), "GetCustomFields")]
        [InlineData("/api/core/attachment/custom-fields/{resourceId}", "HEAD", typeof(AttachmentController), "GetCustomFields")]

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

        public AttachmentRouteTests()
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