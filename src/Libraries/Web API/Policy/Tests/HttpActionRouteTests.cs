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

namespace MixERP.Net.Api.Policy.Tests
{
    public class HttpActionRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/delete/{httpActionCode}", "DELETE", typeof(HttpActionController), "Delete")]
        [InlineData("/api/policy/http-action/delete/{httpActionCode}", "DELETE", typeof(HttpActionController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/edit/{httpActionCode}", "PUT", typeof(HttpActionController), "Edit")]
        [InlineData("/api/policy/http-action/edit/{httpActionCode}", "PUT", typeof(HttpActionController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/count-where", "POST", typeof(HttpActionController), "CountWhere")]
        [InlineData("/api/policy/http-action/count-where", "POST", typeof(HttpActionController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/get-where/{pageNumber}", "POST", typeof(HttpActionController), "GetWhere")]
        [InlineData("/api/policy/http-action/get-where/{pageNumber}", "POST", typeof(HttpActionController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/add-or-edit", "POST", typeof(HttpActionController), "AddOrEdit")]
        [InlineData("/api/policy/http-action/add-or-edit", "POST", typeof(HttpActionController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/add/{httpAction}", "POST", typeof(HttpActionController), "Add")]
        [InlineData("/api/policy/http-action/add/{httpAction}", "POST", typeof(HttpActionController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/bulk-import", "POST", typeof(HttpActionController), "BulkImport")]
        [InlineData("/api/policy/http-action/bulk-import", "POST", typeof(HttpActionController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/meta", "GET", typeof(HttpActionController), "GetEntityView")]
        [InlineData("/api/policy/http-action/meta", "GET", typeof(HttpActionController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/count", "GET", typeof(HttpActionController), "Count")]
        [InlineData("/api/policy/http-action/count", "GET", typeof(HttpActionController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/all", "GET", typeof(HttpActionController), "GetAll")]
        [InlineData("/api/policy/http-action/all", "GET", typeof(HttpActionController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/export", "GET", typeof(HttpActionController), "Export")]
        [InlineData("/api/policy/http-action/export", "GET", typeof(HttpActionController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/1", "GET", typeof(HttpActionController), "Get")]
        [InlineData("/api/policy/http-action/1", "GET", typeof(HttpActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/get?httpActionCodes=1", "GET", typeof(HttpActionController), "Get")]
        [InlineData("/api/policy/http-action/get?httpActionCodes=1", "GET", typeof(HttpActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action", "GET", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/policy/http-action", "GET", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/page/1", "GET", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/policy/http-action/page/1", "GET", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/count-filtered/{filterName}", "GET", typeof(HttpActionController), "CountFiltered")]
        [InlineData("/api/policy/http-action/count-filtered/{filterName}", "GET", typeof(HttpActionController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/get-filtered/{pageNumber}/{filterName}", "GET", typeof(HttpActionController), "GetFiltered")]
        [InlineData("/api/policy/http-action/get-filtered/{pageNumber}/{filterName}", "GET", typeof(HttpActionController), "GetFiltered")]
        [InlineData("/api/policy/http-action/first", "GET", typeof(HttpActionController), "GetFirst")]
        [InlineData("/api/policy/http-action/previous/1", "GET", typeof(HttpActionController), "GetPrevious")]
        [InlineData("/api/policy/http-action/next/1", "GET", typeof(HttpActionController), "GetNext")]
        [InlineData("/api/policy/http-action/last", "GET", typeof(HttpActionController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/http-action/custom-fields", "GET", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/policy/http-action/custom-fields", "GET", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/custom-fields/{resourceId}", "GET", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/policy/http-action/custom-fields/{resourceId}", "GET", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/meta", "HEAD", typeof(HttpActionController), "GetEntityView")]
        [InlineData("/api/policy/http-action/meta", "HEAD", typeof(HttpActionController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/count", "HEAD", typeof(HttpActionController), "Count")]
        [InlineData("/api/policy/http-action/count", "HEAD", typeof(HttpActionController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/all", "HEAD", typeof(HttpActionController), "GetAll")]
        [InlineData("/api/policy/http-action/all", "HEAD", typeof(HttpActionController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/export", "HEAD", typeof(HttpActionController), "Export")]
        [InlineData("/api/policy/http-action/export", "HEAD", typeof(HttpActionController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/1", "HEAD", typeof(HttpActionController), "Get")]
        [InlineData("/api/policy/http-action/1", "HEAD", typeof(HttpActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/get?httpActionCodes=1", "HEAD", typeof(HttpActionController), "Get")]
        [InlineData("/api/policy/http-action/get?httpActionCodes=1", "HEAD", typeof(HttpActionController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action", "HEAD", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/policy/http-action", "HEAD", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/page/1", "HEAD", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/policy/http-action/page/1", "HEAD", typeof(HttpActionController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/count-filtered/{filterName}", "HEAD", typeof(HttpActionController), "CountFiltered")]
        [InlineData("/api/policy/http-action/count-filtered/{filterName}", "HEAD", typeof(HttpActionController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(HttpActionController), "GetFiltered")]
        [InlineData("/api/policy/http-action/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(HttpActionController), "GetFiltered")]
        [InlineData("/api/policy/http-action/first", "HEAD", typeof(HttpActionController), "GetFirst")]
        [InlineData("/api/policy/http-action/previous/1", "HEAD", typeof(HttpActionController), "GetPrevious")]
        [InlineData("/api/policy/http-action/next/1", "HEAD", typeof(HttpActionController), "GetNext")]
        [InlineData("/api/policy/http-action/last", "HEAD", typeof(HttpActionController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/http-action/custom-fields", "HEAD", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/policy/http-action/custom-fields", "HEAD", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/http-action/custom-fields/{resourceId}", "HEAD", typeof(HttpActionController), "GetCustomFields")]
        [InlineData("/api/policy/http-action/custom-fields/{resourceId}", "HEAD", typeof(HttpActionController), "GetCustomFields")]

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

        public HttpActionRouteTests()
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