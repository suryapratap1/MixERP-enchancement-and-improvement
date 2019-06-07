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

namespace MixERP.Net.Api.Office.Tests
{
    public class UserRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/user/delete/{userId}", "DELETE", typeof(UserController), "Delete")]
        [InlineData("/api/office/user/delete/{userId}", "DELETE", typeof(UserController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/user/edit/{userId}", "PUT", typeof(UserController), "Edit")]
        [InlineData("/api/office/user/edit/{userId}", "PUT", typeof(UserController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/user/count-where", "POST", typeof(UserController), "CountWhere")]
        [InlineData("/api/office/user/count-where", "POST", typeof(UserController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/user/get-where/{pageNumber}", "POST", typeof(UserController), "GetWhere")]
        [InlineData("/api/office/user/get-where/{pageNumber}", "POST", typeof(UserController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/user/add-or-edit", "POST", typeof(UserController), "AddOrEdit")]
        [InlineData("/api/office/user/add-or-edit", "POST", typeof(UserController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/user/add/{user}", "POST", typeof(UserController), "Add")]
        [InlineData("/api/office/user/add/{user}", "POST", typeof(UserController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/user/bulk-import", "POST", typeof(UserController), "BulkImport")]
        [InlineData("/api/office/user/bulk-import", "POST", typeof(UserController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/user/meta", "GET", typeof(UserController), "GetEntityView")]
        [InlineData("/api/office/user/meta", "GET", typeof(UserController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/user/count", "GET", typeof(UserController), "Count")]
        [InlineData("/api/office/user/count", "GET", typeof(UserController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/user/all", "GET", typeof(UserController), "GetAll")]
        [InlineData("/api/office/user/all", "GET", typeof(UserController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/user/export", "GET", typeof(UserController), "Export")]
        [InlineData("/api/office/user/export", "GET", typeof(UserController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/user/1", "GET", typeof(UserController), "Get")]
        [InlineData("/api/office/user/1", "GET", typeof(UserController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user/get?userIds=1", "GET", typeof(UserController), "Get")]
        [InlineData("/api/office/user/get?userIds=1", "GET", typeof(UserController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user", "GET", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/office/user", "GET", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user/page/1", "GET", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/office/user/page/1", "GET", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user/count-filtered/{filterName}", "GET", typeof(UserController), "CountFiltered")]
        [InlineData("/api/office/user/count-filtered/{filterName}", "GET", typeof(UserController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/user/get-filtered/{pageNumber}/{filterName}", "GET", typeof(UserController), "GetFiltered")]
        [InlineData("/api/office/user/get-filtered/{pageNumber}/{filterName}", "GET", typeof(UserController), "GetFiltered")]
        [InlineData("/api/office/user/first", "GET", typeof(UserController), "GetFirst")]
        [InlineData("/api/office/user/previous/1", "GET", typeof(UserController), "GetPrevious")]
        [InlineData("/api/office/user/next/1", "GET", typeof(UserController), "GetNext")]
        [InlineData("/api/office/user/last", "GET", typeof(UserController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/user/custom-fields", "GET", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/office/user/custom-fields", "GET", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/user/custom-fields/{resourceId}", "GET", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/office/user/custom-fields/{resourceId}", "GET", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/user/meta", "HEAD", typeof(UserController), "GetEntityView")]
        [InlineData("/api/office/user/meta", "HEAD", typeof(UserController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/user/count", "HEAD", typeof(UserController), "Count")]
        [InlineData("/api/office/user/count", "HEAD", typeof(UserController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/user/all", "HEAD", typeof(UserController), "GetAll")]
        [InlineData("/api/office/user/all", "HEAD", typeof(UserController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/user/export", "HEAD", typeof(UserController), "Export")]
        [InlineData("/api/office/user/export", "HEAD", typeof(UserController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/user/1", "HEAD", typeof(UserController), "Get")]
        [InlineData("/api/office/user/1", "HEAD", typeof(UserController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user/get?userIds=1", "HEAD", typeof(UserController), "Get")]
        [InlineData("/api/office/user/get?userIds=1", "HEAD", typeof(UserController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/user", "HEAD", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/office/user", "HEAD", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user/page/1", "HEAD", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/office/user/page/1", "HEAD", typeof(UserController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/user/count-filtered/{filterName}", "HEAD", typeof(UserController), "CountFiltered")]
        [InlineData("/api/office/user/count-filtered/{filterName}", "HEAD", typeof(UserController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/user/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(UserController), "GetFiltered")]
        [InlineData("/api/office/user/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(UserController), "GetFiltered")]
        [InlineData("/api/office/user/first", "HEAD", typeof(UserController), "GetFirst")]
        [InlineData("/api/office/user/previous/1", "HEAD", typeof(UserController), "GetPrevious")]
        [InlineData("/api/office/user/next/1", "HEAD", typeof(UserController), "GetNext")]
        [InlineData("/api/office/user/last", "HEAD", typeof(UserController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/user/custom-fields", "HEAD", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/office/user/custom-fields", "HEAD", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/user/custom-fields/{resourceId}", "HEAD", typeof(UserController), "GetCustomFields")]
        [InlineData("/api/office/user/custom-fields/{resourceId}", "HEAD", typeof(UserController), "GetCustomFields")]

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

        public UserRouteTests()
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