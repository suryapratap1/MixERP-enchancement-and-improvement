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
    public class SmtpRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/config/smtp/delete/{smtpId}", "DELETE", typeof(SmtpController), "Delete")]
        [InlineData("/api/config/smtp/delete/{smtpId}", "DELETE", typeof(SmtpController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/edit/{smtpId}", "PUT", typeof(SmtpController), "Edit")]
        [InlineData("/api/config/smtp/edit/{smtpId}", "PUT", typeof(SmtpController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/count-where", "POST", typeof(SmtpController), "CountWhere")]
        [InlineData("/api/config/smtp/count-where", "POST", typeof(SmtpController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/get-where/{pageNumber}", "POST", typeof(SmtpController), "GetWhere")]
        [InlineData("/api/config/smtp/get-where/{pageNumber}", "POST", typeof(SmtpController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/add-or-edit", "POST", typeof(SmtpController), "AddOrEdit")]
        [InlineData("/api/config/smtp/add-or-edit", "POST", typeof(SmtpController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/add/{smtp}", "POST", typeof(SmtpController), "Add")]
        [InlineData("/api/config/smtp/add/{smtp}", "POST", typeof(SmtpController), "Add")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/bulk-import", "POST", typeof(SmtpController), "BulkImport")]
        [InlineData("/api/config/smtp/bulk-import", "POST", typeof(SmtpController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/meta", "GET", typeof(SmtpController), "GetEntityView")]
        [InlineData("/api/config/smtp/meta", "GET", typeof(SmtpController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/count", "GET", typeof(SmtpController), "Count")]
        [InlineData("/api/config/smtp/count", "GET", typeof(SmtpController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/all", "GET", typeof(SmtpController), "GetAll")]
        [InlineData("/api/config/smtp/all", "GET", typeof(SmtpController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/export", "GET", typeof(SmtpController), "Export")]
        [InlineData("/api/config/smtp/export", "GET", typeof(SmtpController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/1", "GET", typeof(SmtpController), "Get")]
        [InlineData("/api/config/smtp/1", "GET", typeof(SmtpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/get?smtpIds=1", "GET", typeof(SmtpController), "Get")]
        [InlineData("/api/config/smtp/get?smtpIds=1", "GET", typeof(SmtpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/smtp", "GET", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/config/smtp", "GET", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/page/1", "GET", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/config/smtp/page/1", "GET", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/count-filtered/{filterName}", "GET", typeof(SmtpController), "CountFiltered")]
        [InlineData("/api/config/smtp/count-filtered/{filterName}", "GET", typeof(SmtpController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SmtpController), "GetFiltered")]
        [InlineData("/api/config/smtp/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SmtpController), "GetFiltered")]
        [InlineData("/api/config/smtp/first", "GET", typeof(SmtpController), "GetFirst")]
        [InlineData("/api/config/smtp/previous/1", "GET", typeof(SmtpController), "GetPrevious")]
        [InlineData("/api/config/smtp/next/1", "GET", typeof(SmtpController), "GetNext")]
        [InlineData("/api/config/smtp/last", "GET", typeof(SmtpController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/smtp/custom-fields", "GET", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/config/smtp/custom-fields", "GET", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/custom-fields/{resourceId}", "GET", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/config/smtp/custom-fields/{resourceId}", "GET", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/meta", "HEAD", typeof(SmtpController), "GetEntityView")]
        [InlineData("/api/config/smtp/meta", "HEAD", typeof(SmtpController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/count", "HEAD", typeof(SmtpController), "Count")]
        [InlineData("/api/config/smtp/count", "HEAD", typeof(SmtpController), "Count")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/all", "HEAD", typeof(SmtpController), "GetAll")]
        [InlineData("/api/config/smtp/all", "HEAD", typeof(SmtpController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/export", "HEAD", typeof(SmtpController), "Export")]
        [InlineData("/api/config/smtp/export", "HEAD", typeof(SmtpController), "Export")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/1", "HEAD", typeof(SmtpController), "Get")]
        [InlineData("/api/config/smtp/1", "HEAD", typeof(SmtpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/get?smtpIds=1", "HEAD", typeof(SmtpController), "Get")]
        [InlineData("/api/config/smtp/get?smtpIds=1", "HEAD", typeof(SmtpController), "Get")]
        [InlineData("/api/{apiVersionNumber}/config/smtp", "HEAD", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/config/smtp", "HEAD", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/page/1", "HEAD", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/config/smtp/page/1", "HEAD", typeof(SmtpController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/count-filtered/{filterName}", "HEAD", typeof(SmtpController), "CountFiltered")]
        [InlineData("/api/config/smtp/count-filtered/{filterName}", "HEAD", typeof(SmtpController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SmtpController), "GetFiltered")]
        [InlineData("/api/config/smtp/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SmtpController), "GetFiltered")]
        [InlineData("/api/config/smtp/first", "HEAD", typeof(SmtpController), "GetFirst")]
        [InlineData("/api/config/smtp/previous/1", "HEAD", typeof(SmtpController), "GetPrevious")]
        [InlineData("/api/config/smtp/next/1", "HEAD", typeof(SmtpController), "GetNext")]
        [InlineData("/api/config/smtp/last", "HEAD", typeof(SmtpController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/config/smtp/custom-fields", "HEAD", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/config/smtp/custom-fields", "HEAD", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/config/smtp/custom-fields/{resourceId}", "HEAD", typeof(SmtpController), "GetCustomFields")]
        [InlineData("/api/config/smtp/custom-fields/{resourceId}", "HEAD", typeof(SmtpController), "GetCustomFields")]

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

        public SmtpRouteTests()
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