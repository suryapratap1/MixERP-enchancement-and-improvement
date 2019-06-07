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
    public class AccountRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/account/delete/{accountId}", "DELETE", typeof(AccountController), "Delete")]
        [InlineData("/api/core/account/delete/{accountId}", "DELETE", typeof(AccountController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/account/edit/{accountId}", "PUT", typeof(AccountController), "Edit")]
        [InlineData("/api/core/account/edit/{accountId}", "PUT", typeof(AccountController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/account/count-where", "POST", typeof(AccountController), "CountWhere")]
        [InlineData("/api/core/account/count-where", "POST", typeof(AccountController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/account/get-where/{pageNumber}", "POST", typeof(AccountController), "GetWhere")]
        [InlineData("/api/core/account/get-where/{pageNumber}", "POST", typeof(AccountController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/account/add-or-edit", "POST", typeof(AccountController), "AddOrEdit")]
        [InlineData("/api/core/account/add-or-edit", "POST", typeof(AccountController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/account/add/{account}", "POST", typeof(AccountController), "Add")]
        [InlineData("/api/core/account/add/{account}", "POST", typeof(AccountController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/account/bulk-import", "POST", typeof(AccountController), "BulkImport")]
        [InlineData("/api/core/account/bulk-import", "POST", typeof(AccountController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/account/meta", "GET", typeof(AccountController), "GetEntityView")]
        [InlineData("/api/core/account/meta", "GET", typeof(AccountController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/account/count", "GET", typeof(AccountController), "Count")]
        [InlineData("/api/core/account/count", "GET", typeof(AccountController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/account/all", "GET", typeof(AccountController), "GetAll")]
        [InlineData("/api/core/account/all", "GET", typeof(AccountController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/account/export", "GET", typeof(AccountController), "Export")]
        [InlineData("/api/core/account/export", "GET", typeof(AccountController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/account/1", "GET", typeof(AccountController), "Get")]
        [InlineData("/api/core/account/1", "GET", typeof(AccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account/get?accountIds=1", "GET", typeof(AccountController), "Get")]
        [InlineData("/api/core/account/get?accountIds=1", "GET", typeof(AccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account", "GET", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/core/account", "GET", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account/page/1", "GET", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/core/account/page/1", "GET", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account/count-filtered/{filterName}", "GET", typeof(AccountController), "CountFiltered")]
        [InlineData("/api/core/account/count-filtered/{filterName}", "GET", typeof(AccountController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/account/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AccountController), "GetFiltered")]
        [InlineData("/api/core/account/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AccountController), "GetFiltered")]
        [InlineData("/api/core/account/first", "GET", typeof(AccountController), "GetFirst")]
        [InlineData("/api/core/account/previous/1", "GET", typeof(AccountController), "GetPrevious")]
        [InlineData("/api/core/account/next/1", "GET", typeof(AccountController), "GetNext")]
        [InlineData("/api/core/account/last", "GET", typeof(AccountController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/account/custom-fields", "GET", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/core/account/custom-fields", "GET", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/account/custom-fields/{resourceId}", "GET", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/core/account/custom-fields/{resourceId}", "GET", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/account/meta", "HEAD", typeof(AccountController), "GetEntityView")]
        [InlineData("/api/core/account/meta", "HEAD", typeof(AccountController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/account/count", "HEAD", typeof(AccountController), "Count")]
        [InlineData("/api/core/account/count", "HEAD", typeof(AccountController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/account/all", "HEAD", typeof(AccountController), "GetAll")]
        [InlineData("/api/core/account/all", "HEAD", typeof(AccountController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/account/export", "HEAD", typeof(AccountController), "Export")]
        [InlineData("/api/core/account/export", "HEAD", typeof(AccountController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/account/1", "HEAD", typeof(AccountController), "Get")]
        [InlineData("/api/core/account/1", "HEAD", typeof(AccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account/get?accountIds=1", "HEAD", typeof(AccountController), "Get")]
        [InlineData("/api/core/account/get?accountIds=1", "HEAD", typeof(AccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account", "HEAD", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/core/account", "HEAD", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account/page/1", "HEAD", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/core/account/page/1", "HEAD", typeof(AccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account/count-filtered/{filterName}", "HEAD", typeof(AccountController), "CountFiltered")]
        [InlineData("/api/core/account/count-filtered/{filterName}", "HEAD", typeof(AccountController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/account/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AccountController), "GetFiltered")]
        [InlineData("/api/core/account/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AccountController), "GetFiltered")]
        [InlineData("/api/core/account/first", "HEAD", typeof(AccountController), "GetFirst")]
        [InlineData("/api/core/account/previous/1", "HEAD", typeof(AccountController), "GetPrevious")]
        [InlineData("/api/core/account/next/1", "HEAD", typeof(AccountController), "GetNext")]
        [InlineData("/api/core/account/last", "HEAD", typeof(AccountController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/account/custom-fields", "HEAD", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/core/account/custom-fields", "HEAD", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/account/custom-fields/{resourceId}", "HEAD", typeof(AccountController), "GetCustomFields")]
        [InlineData("/api/core/account/custom-fields/{resourceId}", "HEAD", typeof(AccountController), "GetCustomFields")]

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

        public AccountRouteTests()
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