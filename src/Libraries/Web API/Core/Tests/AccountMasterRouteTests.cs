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
    public class AccountMasterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/account-master/delete/{accountMasterId}", "DELETE", typeof(AccountMasterController), "Delete")]
        [InlineData("/api/core/account-master/delete/{accountMasterId}", "DELETE", typeof(AccountMasterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/edit/{accountMasterId}", "PUT", typeof(AccountMasterController), "Edit")]
        [InlineData("/api/core/account-master/edit/{accountMasterId}", "PUT", typeof(AccountMasterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/count-where", "POST", typeof(AccountMasterController), "CountWhere")]
        [InlineData("/api/core/account-master/count-where", "POST", typeof(AccountMasterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/get-where/{pageNumber}", "POST", typeof(AccountMasterController), "GetWhere")]
        [InlineData("/api/core/account-master/get-where/{pageNumber}", "POST", typeof(AccountMasterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/add-or-edit", "POST", typeof(AccountMasterController), "AddOrEdit")]
        [InlineData("/api/core/account-master/add-or-edit", "POST", typeof(AccountMasterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/add/{accountMaster}", "POST", typeof(AccountMasterController), "Add")]
        [InlineData("/api/core/account-master/add/{accountMaster}", "POST", typeof(AccountMasterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/bulk-import", "POST", typeof(AccountMasterController), "BulkImport")]
        [InlineData("/api/core/account-master/bulk-import", "POST", typeof(AccountMasterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/meta", "GET", typeof(AccountMasterController), "GetEntityView")]
        [InlineData("/api/core/account-master/meta", "GET", typeof(AccountMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/count", "GET", typeof(AccountMasterController), "Count")]
        [InlineData("/api/core/account-master/count", "GET", typeof(AccountMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/all", "GET", typeof(AccountMasterController), "GetAll")]
        [InlineData("/api/core/account-master/all", "GET", typeof(AccountMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/export", "GET", typeof(AccountMasterController), "Export")]
        [InlineData("/api/core/account-master/export", "GET", typeof(AccountMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/1", "GET", typeof(AccountMasterController), "Get")]
        [InlineData("/api/core/account-master/1", "GET", typeof(AccountMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/get?accountMasterIds=1", "GET", typeof(AccountMasterController), "Get")]
        [InlineData("/api/core/account-master/get?accountMasterIds=1", "GET", typeof(AccountMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account-master", "GET", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/account-master", "GET", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/page/1", "GET", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/account-master/page/1", "GET", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/count-filtered/{filterName}", "GET", typeof(AccountMasterController), "CountFiltered")]
        [InlineData("/api/core/account-master/count-filtered/{filterName}", "GET", typeof(AccountMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AccountMasterController), "GetFiltered")]
        [InlineData("/api/core/account-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AccountMasterController), "GetFiltered")]
        [InlineData("/api/core/account-master/first", "GET", typeof(AccountMasterController), "GetFirst")]
        [InlineData("/api/core/account-master/previous/1", "GET", typeof(AccountMasterController), "GetPrevious")]
        [InlineData("/api/core/account-master/next/1", "GET", typeof(AccountMasterController), "GetNext")]
        [InlineData("/api/core/account-master/last", "GET", typeof(AccountMasterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/account-master/custom-fields", "GET", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/core/account-master/custom-fields", "GET", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/custom-fields/{resourceId}", "GET", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/core/account-master/custom-fields/{resourceId}", "GET", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/meta", "HEAD", typeof(AccountMasterController), "GetEntityView")]
        [InlineData("/api/core/account-master/meta", "HEAD", typeof(AccountMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/count", "HEAD", typeof(AccountMasterController), "Count")]
        [InlineData("/api/core/account-master/count", "HEAD", typeof(AccountMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/all", "HEAD", typeof(AccountMasterController), "GetAll")]
        [InlineData("/api/core/account-master/all", "HEAD", typeof(AccountMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/export", "HEAD", typeof(AccountMasterController), "Export")]
        [InlineData("/api/core/account-master/export", "HEAD", typeof(AccountMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/1", "HEAD", typeof(AccountMasterController), "Get")]
        [InlineData("/api/core/account-master/1", "HEAD", typeof(AccountMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/get?accountMasterIds=1", "HEAD", typeof(AccountMasterController), "Get")]
        [InlineData("/api/core/account-master/get?accountMasterIds=1", "HEAD", typeof(AccountMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/account-master", "HEAD", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/account-master", "HEAD", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/page/1", "HEAD", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/account-master/page/1", "HEAD", typeof(AccountMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/count-filtered/{filterName}", "HEAD", typeof(AccountMasterController), "CountFiltered")]
        [InlineData("/api/core/account-master/count-filtered/{filterName}", "HEAD", typeof(AccountMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AccountMasterController), "GetFiltered")]
        [InlineData("/api/core/account-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AccountMasterController), "GetFiltered")]
        [InlineData("/api/core/account-master/first", "HEAD", typeof(AccountMasterController), "GetFirst")]
        [InlineData("/api/core/account-master/previous/1", "HEAD", typeof(AccountMasterController), "GetPrevious")]
        [InlineData("/api/core/account-master/next/1", "HEAD", typeof(AccountMasterController), "GetNext")]
        [InlineData("/api/core/account-master/last", "HEAD", typeof(AccountMasterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/account-master/custom-fields", "HEAD", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/core/account-master/custom-fields", "HEAD", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/account-master/custom-fields/{resourceId}", "HEAD", typeof(AccountMasterController), "GetCustomFields")]
        [InlineData("/api/core/account-master/custom-fields/{resourceId}", "HEAD", typeof(AccountMasterController), "GetCustomFields")]

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

        public AccountMasterRouteTests()
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