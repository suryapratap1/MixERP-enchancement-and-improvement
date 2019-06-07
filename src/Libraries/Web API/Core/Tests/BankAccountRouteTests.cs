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
    public class BankAccountRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/delete/{accountId}", "DELETE", typeof(BankAccountController), "Delete")]
        [InlineData("/api/core/bank-account/delete/{accountId}", "DELETE", typeof(BankAccountController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/edit/{accountId}", "PUT", typeof(BankAccountController), "Edit")]
        [InlineData("/api/core/bank-account/edit/{accountId}", "PUT", typeof(BankAccountController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/count-where", "POST", typeof(BankAccountController), "CountWhere")]
        [InlineData("/api/core/bank-account/count-where", "POST", typeof(BankAccountController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/get-where/{pageNumber}", "POST", typeof(BankAccountController), "GetWhere")]
        [InlineData("/api/core/bank-account/get-where/{pageNumber}", "POST", typeof(BankAccountController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/add-or-edit", "POST", typeof(BankAccountController), "AddOrEdit")]
        [InlineData("/api/core/bank-account/add-or-edit", "POST", typeof(BankAccountController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/add/{bankAccount}", "POST", typeof(BankAccountController), "Add")]
        [InlineData("/api/core/bank-account/add/{bankAccount}", "POST", typeof(BankAccountController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/bulk-import", "POST", typeof(BankAccountController), "BulkImport")]
        [InlineData("/api/core/bank-account/bulk-import", "POST", typeof(BankAccountController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/meta", "GET", typeof(BankAccountController), "GetEntityView")]
        [InlineData("/api/core/bank-account/meta", "GET", typeof(BankAccountController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/count", "GET", typeof(BankAccountController), "Count")]
        [InlineData("/api/core/bank-account/count", "GET", typeof(BankAccountController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/all", "GET", typeof(BankAccountController), "GetAll")]
        [InlineData("/api/core/bank-account/all", "GET", typeof(BankAccountController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/export", "GET", typeof(BankAccountController), "Export")]
        [InlineData("/api/core/bank-account/export", "GET", typeof(BankAccountController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/1", "GET", typeof(BankAccountController), "Get")]
        [InlineData("/api/core/bank-account/1", "GET", typeof(BankAccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/get?accountIds=1", "GET", typeof(BankAccountController), "Get")]
        [InlineData("/api/core/bank-account/get?accountIds=1", "GET", typeof(BankAccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account", "GET", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/core/bank-account", "GET", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/page/1", "GET", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/core/bank-account/page/1", "GET", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/count-filtered/{filterName}", "GET", typeof(BankAccountController), "CountFiltered")]
        [InlineData("/api/core/bank-account/count-filtered/{filterName}", "GET", typeof(BankAccountController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BankAccountController), "GetFiltered")]
        [InlineData("/api/core/bank-account/get-filtered/{pageNumber}/{filterName}", "GET", typeof(BankAccountController), "GetFiltered")]
        [InlineData("/api/core/bank-account/first", "GET", typeof(BankAccountController), "GetFirst")]
        [InlineData("/api/core/bank-account/previous/1", "GET", typeof(BankAccountController), "GetPrevious")]
        [InlineData("/api/core/bank-account/next/1", "GET", typeof(BankAccountController), "GetNext")]
        [InlineData("/api/core/bank-account/last", "GET", typeof(BankAccountController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/bank-account/custom-fields", "GET", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/core/bank-account/custom-fields", "GET", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/custom-fields/{resourceId}", "GET", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/core/bank-account/custom-fields/{resourceId}", "GET", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/meta", "HEAD", typeof(BankAccountController), "GetEntityView")]
        [InlineData("/api/core/bank-account/meta", "HEAD", typeof(BankAccountController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/count", "HEAD", typeof(BankAccountController), "Count")]
        [InlineData("/api/core/bank-account/count", "HEAD", typeof(BankAccountController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/all", "HEAD", typeof(BankAccountController), "GetAll")]
        [InlineData("/api/core/bank-account/all", "HEAD", typeof(BankAccountController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/export", "HEAD", typeof(BankAccountController), "Export")]
        [InlineData("/api/core/bank-account/export", "HEAD", typeof(BankAccountController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/1", "HEAD", typeof(BankAccountController), "Get")]
        [InlineData("/api/core/bank-account/1", "HEAD", typeof(BankAccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/get?accountIds=1", "HEAD", typeof(BankAccountController), "Get")]
        [InlineData("/api/core/bank-account/get?accountIds=1", "HEAD", typeof(BankAccountController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account", "HEAD", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/core/bank-account", "HEAD", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/page/1", "HEAD", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/core/bank-account/page/1", "HEAD", typeof(BankAccountController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/count-filtered/{filterName}", "HEAD", typeof(BankAccountController), "CountFiltered")]
        [InlineData("/api/core/bank-account/count-filtered/{filterName}", "HEAD", typeof(BankAccountController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BankAccountController), "GetFiltered")]
        [InlineData("/api/core/bank-account/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(BankAccountController), "GetFiltered")]
        [InlineData("/api/core/bank-account/first", "HEAD", typeof(BankAccountController), "GetFirst")]
        [InlineData("/api/core/bank-account/previous/1", "HEAD", typeof(BankAccountController), "GetPrevious")]
        [InlineData("/api/core/bank-account/next/1", "HEAD", typeof(BankAccountController), "GetNext")]
        [InlineData("/api/core/bank-account/last", "HEAD", typeof(BankAccountController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/bank-account/custom-fields", "HEAD", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/core/bank-account/custom-fields", "HEAD", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/bank-account/custom-fields/{resourceId}", "HEAD", typeof(BankAccountController), "GetCustomFields")]
        [InlineData("/api/core/bank-account/custom-fields/{resourceId}", "HEAD", typeof(BankAccountController), "GetCustomFields")]

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

        public BankAccountRouteTests()
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