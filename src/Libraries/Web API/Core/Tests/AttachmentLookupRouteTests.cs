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
    public class AttachmentLookupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/delete/{attachmentLookupId}", "DELETE", typeof(AttachmentLookupController), "Delete")]
        [InlineData("/api/core/attachment-lookup/delete/{attachmentLookupId}", "DELETE", typeof(AttachmentLookupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/edit/{attachmentLookupId}", "PUT", typeof(AttachmentLookupController), "Edit")]
        [InlineData("/api/core/attachment-lookup/edit/{attachmentLookupId}", "PUT", typeof(AttachmentLookupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/count-where", "POST", typeof(AttachmentLookupController), "CountWhere")]
        [InlineData("/api/core/attachment-lookup/count-where", "POST", typeof(AttachmentLookupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/get-where/{pageNumber}", "POST", typeof(AttachmentLookupController), "GetWhere")]
        [InlineData("/api/core/attachment-lookup/get-where/{pageNumber}", "POST", typeof(AttachmentLookupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/add-or-edit", "POST", typeof(AttachmentLookupController), "AddOrEdit")]
        [InlineData("/api/core/attachment-lookup/add-or-edit", "POST", typeof(AttachmentLookupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/add/{attachmentLookup}", "POST", typeof(AttachmentLookupController), "Add")]
        [InlineData("/api/core/attachment-lookup/add/{attachmentLookup}", "POST", typeof(AttachmentLookupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/bulk-import", "POST", typeof(AttachmentLookupController), "BulkImport")]
        [InlineData("/api/core/attachment-lookup/bulk-import", "POST", typeof(AttachmentLookupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/meta", "GET", typeof(AttachmentLookupController), "GetEntityView")]
        [InlineData("/api/core/attachment-lookup/meta", "GET", typeof(AttachmentLookupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/count", "GET", typeof(AttachmentLookupController), "Count")]
        [InlineData("/api/core/attachment-lookup/count", "GET", typeof(AttachmentLookupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/all", "GET", typeof(AttachmentLookupController), "GetAll")]
        [InlineData("/api/core/attachment-lookup/all", "GET", typeof(AttachmentLookupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/export", "GET", typeof(AttachmentLookupController), "Export")]
        [InlineData("/api/core/attachment-lookup/export", "GET", typeof(AttachmentLookupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/1", "GET", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/core/attachment-lookup/1", "GET", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/get?attachmentLookupIds=1", "GET", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/core/attachment-lookup/get?attachmentLookupIds=1", "GET", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup", "GET", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment-lookup", "GET", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/page/1", "GET", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment-lookup/page/1", "GET", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/count-filtered/{filterName}", "GET", typeof(AttachmentLookupController), "CountFiltered")]
        [InlineData("/api/core/attachment-lookup/count-filtered/{filterName}", "GET", typeof(AttachmentLookupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttachmentLookupController), "GetFiltered")]
        [InlineData("/api/core/attachment-lookup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AttachmentLookupController), "GetFiltered")]
        [InlineData("/api/core/attachment-lookup/first", "GET", typeof(AttachmentLookupController), "GetFirst")]
        [InlineData("/api/core/attachment-lookup/previous/1", "GET", typeof(AttachmentLookupController), "GetPrevious")]
        [InlineData("/api/core/attachment-lookup/next/1", "GET", typeof(AttachmentLookupController), "GetNext")]
        [InlineData("/api/core/attachment-lookup/last", "GET", typeof(AttachmentLookupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/custom-fields", "GET", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/core/attachment-lookup/custom-fields", "GET", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/custom-fields/{resourceId}", "GET", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/core/attachment-lookup/custom-fields/{resourceId}", "GET", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/meta", "HEAD", typeof(AttachmentLookupController), "GetEntityView")]
        [InlineData("/api/core/attachment-lookup/meta", "HEAD", typeof(AttachmentLookupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/count", "HEAD", typeof(AttachmentLookupController), "Count")]
        [InlineData("/api/core/attachment-lookup/count", "HEAD", typeof(AttachmentLookupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/all", "HEAD", typeof(AttachmentLookupController), "GetAll")]
        [InlineData("/api/core/attachment-lookup/all", "HEAD", typeof(AttachmentLookupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/export", "HEAD", typeof(AttachmentLookupController), "Export")]
        [InlineData("/api/core/attachment-lookup/export", "HEAD", typeof(AttachmentLookupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/1", "HEAD", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/core/attachment-lookup/1", "HEAD", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/get?attachmentLookupIds=1", "HEAD", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/core/attachment-lookup/get?attachmentLookupIds=1", "HEAD", typeof(AttachmentLookupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup", "HEAD", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment-lookup", "HEAD", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/page/1", "HEAD", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/core/attachment-lookup/page/1", "HEAD", typeof(AttachmentLookupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/count-filtered/{filterName}", "HEAD", typeof(AttachmentLookupController), "CountFiltered")]
        [InlineData("/api/core/attachment-lookup/count-filtered/{filterName}", "HEAD", typeof(AttachmentLookupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttachmentLookupController), "GetFiltered")]
        [InlineData("/api/core/attachment-lookup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AttachmentLookupController), "GetFiltered")]
        [InlineData("/api/core/attachment-lookup/first", "HEAD", typeof(AttachmentLookupController), "GetFirst")]
        [InlineData("/api/core/attachment-lookup/previous/1", "HEAD", typeof(AttachmentLookupController), "GetPrevious")]
        [InlineData("/api/core/attachment-lookup/next/1", "HEAD", typeof(AttachmentLookupController), "GetNext")]
        [InlineData("/api/core/attachment-lookup/last", "HEAD", typeof(AttachmentLookupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/custom-fields", "HEAD", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/core/attachment-lookup/custom-fields", "HEAD", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/attachment-lookup/custom-fields/{resourceId}", "HEAD", typeof(AttachmentLookupController), "GetCustomFields")]
        [InlineData("/api/core/attachment-lookup/custom-fields/{resourceId}", "HEAD", typeof(AttachmentLookupController), "GetCustomFields")]

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

        public AttachmentLookupRouteTests()
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