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
    public class VerificationStatusRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/delete/{verificationStatusId}", "DELETE", typeof(VerificationStatusController), "Delete")]
        [InlineData("/api/core/verification-status/delete/{verificationStatusId}", "DELETE", typeof(VerificationStatusController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/edit/{verificationStatusId}", "PUT", typeof(VerificationStatusController), "Edit")]
        [InlineData("/api/core/verification-status/edit/{verificationStatusId}", "PUT", typeof(VerificationStatusController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/count-where", "POST", typeof(VerificationStatusController), "CountWhere")]
        [InlineData("/api/core/verification-status/count-where", "POST", typeof(VerificationStatusController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/get-where/{pageNumber}", "POST", typeof(VerificationStatusController), "GetWhere")]
        [InlineData("/api/core/verification-status/get-where/{pageNumber}", "POST", typeof(VerificationStatusController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/add-or-edit", "POST", typeof(VerificationStatusController), "AddOrEdit")]
        [InlineData("/api/core/verification-status/add-or-edit", "POST", typeof(VerificationStatusController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/add/{verificationStatus}", "POST", typeof(VerificationStatusController), "Add")]
        [InlineData("/api/core/verification-status/add/{verificationStatus}", "POST", typeof(VerificationStatusController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/bulk-import", "POST", typeof(VerificationStatusController), "BulkImport")]
        [InlineData("/api/core/verification-status/bulk-import", "POST", typeof(VerificationStatusController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/meta", "GET", typeof(VerificationStatusController), "GetEntityView")]
        [InlineData("/api/core/verification-status/meta", "GET", typeof(VerificationStatusController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/count", "GET", typeof(VerificationStatusController), "Count")]
        [InlineData("/api/core/verification-status/count", "GET", typeof(VerificationStatusController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/all", "GET", typeof(VerificationStatusController), "GetAll")]
        [InlineData("/api/core/verification-status/all", "GET", typeof(VerificationStatusController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/export", "GET", typeof(VerificationStatusController), "Export")]
        [InlineData("/api/core/verification-status/export", "GET", typeof(VerificationStatusController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/1", "GET", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/core/verification-status/1", "GET", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/get?verificationStatusIds=1", "GET", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/core/verification-status/get?verificationStatusIds=1", "GET", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status", "GET", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/verification-status", "GET", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/page/1", "GET", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/verification-status/page/1", "GET", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/count-filtered/{filterName}", "GET", typeof(VerificationStatusController), "CountFiltered")]
        [InlineData("/api/core/verification-status/count-filtered/{filterName}", "GET", typeof(VerificationStatusController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/get-filtered/{pageNumber}/{filterName}", "GET", typeof(VerificationStatusController), "GetFiltered")]
        [InlineData("/api/core/verification-status/get-filtered/{pageNumber}/{filterName}", "GET", typeof(VerificationStatusController), "GetFiltered")]
        [InlineData("/api/core/verification-status/first", "GET", typeof(VerificationStatusController), "GetFirst")]
        [InlineData("/api/core/verification-status/previous/1", "GET", typeof(VerificationStatusController), "GetPrevious")]
        [InlineData("/api/core/verification-status/next/1", "GET", typeof(VerificationStatusController), "GetNext")]
        [InlineData("/api/core/verification-status/last", "GET", typeof(VerificationStatusController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/verification-status/custom-fields", "GET", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/core/verification-status/custom-fields", "GET", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/custom-fields/{resourceId}", "GET", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/core/verification-status/custom-fields/{resourceId}", "GET", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/meta", "HEAD", typeof(VerificationStatusController), "GetEntityView")]
        [InlineData("/api/core/verification-status/meta", "HEAD", typeof(VerificationStatusController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/count", "HEAD", typeof(VerificationStatusController), "Count")]
        [InlineData("/api/core/verification-status/count", "HEAD", typeof(VerificationStatusController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/all", "HEAD", typeof(VerificationStatusController), "GetAll")]
        [InlineData("/api/core/verification-status/all", "HEAD", typeof(VerificationStatusController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/export", "HEAD", typeof(VerificationStatusController), "Export")]
        [InlineData("/api/core/verification-status/export", "HEAD", typeof(VerificationStatusController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/1", "HEAD", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/core/verification-status/1", "HEAD", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/get?verificationStatusIds=1", "HEAD", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/core/verification-status/get?verificationStatusIds=1", "HEAD", typeof(VerificationStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status", "HEAD", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/verification-status", "HEAD", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/page/1", "HEAD", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/verification-status/page/1", "HEAD", typeof(VerificationStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/count-filtered/{filterName}", "HEAD", typeof(VerificationStatusController), "CountFiltered")]
        [InlineData("/api/core/verification-status/count-filtered/{filterName}", "HEAD", typeof(VerificationStatusController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(VerificationStatusController), "GetFiltered")]
        [InlineData("/api/core/verification-status/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(VerificationStatusController), "GetFiltered")]
        [InlineData("/api/core/verification-status/first", "HEAD", typeof(VerificationStatusController), "GetFirst")]
        [InlineData("/api/core/verification-status/previous/1", "HEAD", typeof(VerificationStatusController), "GetPrevious")]
        [InlineData("/api/core/verification-status/next/1", "HEAD", typeof(VerificationStatusController), "GetNext")]
        [InlineData("/api/core/verification-status/last", "HEAD", typeof(VerificationStatusController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/verification-status/custom-fields", "HEAD", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/core/verification-status/custom-fields", "HEAD", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/verification-status/custom-fields/{resourceId}", "HEAD", typeof(VerificationStatusController), "GetCustomFields")]
        [InlineData("/api/core/verification-status/custom-fields/{resourceId}", "HEAD", typeof(VerificationStatusController), "GetCustomFields")]

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

        public VerificationStatusRouteTests()
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