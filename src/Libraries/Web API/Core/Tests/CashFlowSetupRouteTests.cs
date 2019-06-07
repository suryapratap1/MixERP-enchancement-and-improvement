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
    public class CashFlowSetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/delete/{cashFlowSetupId}", "DELETE", typeof(CashFlowSetupController), "Delete")]
        [InlineData("/api/core/cash-flow-setup/delete/{cashFlowSetupId}", "DELETE", typeof(CashFlowSetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/edit/{cashFlowSetupId}", "PUT", typeof(CashFlowSetupController), "Edit")]
        [InlineData("/api/core/cash-flow-setup/edit/{cashFlowSetupId}", "PUT", typeof(CashFlowSetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/count-where", "POST", typeof(CashFlowSetupController), "CountWhere")]
        [InlineData("/api/core/cash-flow-setup/count-where", "POST", typeof(CashFlowSetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/get-where/{pageNumber}", "POST", typeof(CashFlowSetupController), "GetWhere")]
        [InlineData("/api/core/cash-flow-setup/get-where/{pageNumber}", "POST", typeof(CashFlowSetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/add-or-edit", "POST", typeof(CashFlowSetupController), "AddOrEdit")]
        [InlineData("/api/core/cash-flow-setup/add-or-edit", "POST", typeof(CashFlowSetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/add/{cashFlowSetup}", "POST", typeof(CashFlowSetupController), "Add")]
        [InlineData("/api/core/cash-flow-setup/add/{cashFlowSetup}", "POST", typeof(CashFlowSetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/bulk-import", "POST", typeof(CashFlowSetupController), "BulkImport")]
        [InlineData("/api/core/cash-flow-setup/bulk-import", "POST", typeof(CashFlowSetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/meta", "GET", typeof(CashFlowSetupController), "GetEntityView")]
        [InlineData("/api/core/cash-flow-setup/meta", "GET", typeof(CashFlowSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/count", "GET", typeof(CashFlowSetupController), "Count")]
        [InlineData("/api/core/cash-flow-setup/count", "GET", typeof(CashFlowSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/all", "GET", typeof(CashFlowSetupController), "GetAll")]
        [InlineData("/api/core/cash-flow-setup/all", "GET", typeof(CashFlowSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/export", "GET", typeof(CashFlowSetupController), "Export")]
        [InlineData("/api/core/cash-flow-setup/export", "GET", typeof(CashFlowSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/1", "GET", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/core/cash-flow-setup/1", "GET", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/get?cashFlowSetupIds=1", "GET", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/core/cash-flow-setup/get?cashFlowSetupIds=1", "GET", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup", "GET", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/cash-flow-setup", "GET", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/page/1", "GET", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/cash-flow-setup/page/1", "GET", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/count-filtered/{filterName}", "GET", typeof(CashFlowSetupController), "CountFiltered")]
        [InlineData("/api/core/cash-flow-setup/count-filtered/{filterName}", "GET", typeof(CashFlowSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CashFlowSetupController), "GetFiltered")]
        [InlineData("/api/core/cash-flow-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CashFlowSetupController), "GetFiltered")]
        [InlineData("/api/core/cash-flow-setup/first", "GET", typeof(CashFlowSetupController), "GetFirst")]
        [InlineData("/api/core/cash-flow-setup/previous/1", "GET", typeof(CashFlowSetupController), "GetPrevious")]
        [InlineData("/api/core/cash-flow-setup/next/1", "GET", typeof(CashFlowSetupController), "GetNext")]
        [InlineData("/api/core/cash-flow-setup/last", "GET", typeof(CashFlowSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/custom-fields", "GET", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/core/cash-flow-setup/custom-fields", "GET", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/custom-fields/{resourceId}", "GET", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/core/cash-flow-setup/custom-fields/{resourceId}", "GET", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/meta", "HEAD", typeof(CashFlowSetupController), "GetEntityView")]
        [InlineData("/api/core/cash-flow-setup/meta", "HEAD", typeof(CashFlowSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/count", "HEAD", typeof(CashFlowSetupController), "Count")]
        [InlineData("/api/core/cash-flow-setup/count", "HEAD", typeof(CashFlowSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/all", "HEAD", typeof(CashFlowSetupController), "GetAll")]
        [InlineData("/api/core/cash-flow-setup/all", "HEAD", typeof(CashFlowSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/export", "HEAD", typeof(CashFlowSetupController), "Export")]
        [InlineData("/api/core/cash-flow-setup/export", "HEAD", typeof(CashFlowSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/1", "HEAD", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/core/cash-flow-setup/1", "HEAD", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/get?cashFlowSetupIds=1", "HEAD", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/core/cash-flow-setup/get?cashFlowSetupIds=1", "HEAD", typeof(CashFlowSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup", "HEAD", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/cash-flow-setup", "HEAD", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/page/1", "HEAD", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/cash-flow-setup/page/1", "HEAD", typeof(CashFlowSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/count-filtered/{filterName}", "HEAD", typeof(CashFlowSetupController), "CountFiltered")]
        [InlineData("/api/core/cash-flow-setup/count-filtered/{filterName}", "HEAD", typeof(CashFlowSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CashFlowSetupController), "GetFiltered")]
        [InlineData("/api/core/cash-flow-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CashFlowSetupController), "GetFiltered")]
        [InlineData("/api/core/cash-flow-setup/first", "HEAD", typeof(CashFlowSetupController), "GetFirst")]
        [InlineData("/api/core/cash-flow-setup/previous/1", "HEAD", typeof(CashFlowSetupController), "GetPrevious")]
        [InlineData("/api/core/cash-flow-setup/next/1", "HEAD", typeof(CashFlowSetupController), "GetNext")]
        [InlineData("/api/core/cash-flow-setup/last", "HEAD", typeof(CashFlowSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/custom-fields", "HEAD", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/core/cash-flow-setup/custom-fields", "HEAD", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/cash-flow-setup/custom-fields/{resourceId}", "HEAD", typeof(CashFlowSetupController), "GetCustomFields")]
        [InlineData("/api/core/cash-flow-setup/custom-fields/{resourceId}", "HEAD", typeof(CashFlowSetupController), "GetCustomFields")]

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

        public CashFlowSetupRouteTests()
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