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
    public class SalespersonBonusSetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/delete/{salespersonBonusSetupId}", "DELETE", typeof(SalespersonBonusSetupController), "Delete")]
        [InlineData("/api/core/salesperson-bonus-setup/delete/{salespersonBonusSetupId}", "DELETE", typeof(SalespersonBonusSetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/edit/{salespersonBonusSetupId}", "PUT", typeof(SalespersonBonusSetupController), "Edit")]
        [InlineData("/api/core/salesperson-bonus-setup/edit/{salespersonBonusSetupId}", "PUT", typeof(SalespersonBonusSetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/count-where", "POST", typeof(SalespersonBonusSetupController), "CountWhere")]
        [InlineData("/api/core/salesperson-bonus-setup/count-where", "POST", typeof(SalespersonBonusSetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/get-where/{pageNumber}", "POST", typeof(SalespersonBonusSetupController), "GetWhere")]
        [InlineData("/api/core/salesperson-bonus-setup/get-where/{pageNumber}", "POST", typeof(SalespersonBonusSetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/add-or-edit", "POST", typeof(SalespersonBonusSetupController), "AddOrEdit")]
        [InlineData("/api/core/salesperson-bonus-setup/add-or-edit", "POST", typeof(SalespersonBonusSetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/add/{salespersonBonusSetup}", "POST", typeof(SalespersonBonusSetupController), "Add")]
        [InlineData("/api/core/salesperson-bonus-setup/add/{salespersonBonusSetup}", "POST", typeof(SalespersonBonusSetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/bulk-import", "POST", typeof(SalespersonBonusSetupController), "BulkImport")]
        [InlineData("/api/core/salesperson-bonus-setup/bulk-import", "POST", typeof(SalespersonBonusSetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/meta", "GET", typeof(SalespersonBonusSetupController), "GetEntityView")]
        [InlineData("/api/core/salesperson-bonus-setup/meta", "GET", typeof(SalespersonBonusSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/count", "GET", typeof(SalespersonBonusSetupController), "Count")]
        [InlineData("/api/core/salesperson-bonus-setup/count", "GET", typeof(SalespersonBonusSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/all", "GET", typeof(SalespersonBonusSetupController), "GetAll")]
        [InlineData("/api/core/salesperson-bonus-setup/all", "GET", typeof(SalespersonBonusSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/export", "GET", typeof(SalespersonBonusSetupController), "Export")]
        [InlineData("/api/core/salesperson-bonus-setup/export", "GET", typeof(SalespersonBonusSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/1", "GET", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup/1", "GET", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/get?salespersonBonusSetupIds=1", "GET", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup/get?salespersonBonusSetupIds=1", "GET", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup", "GET", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup", "GET", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/page/1", "GET", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup/page/1", "GET", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/count-filtered/{filterName}", "GET", typeof(SalespersonBonusSetupController), "CountFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup/count-filtered/{filterName}", "GET", typeof(SalespersonBonusSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalespersonBonusSetupController), "GetFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalespersonBonusSetupController), "GetFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup/first", "GET", typeof(SalespersonBonusSetupController), "GetFirst")]
        [InlineData("/api/core/salesperson-bonus-setup/previous/1", "GET", typeof(SalespersonBonusSetupController), "GetPrevious")]
        [InlineData("/api/core/salesperson-bonus-setup/next/1", "GET", typeof(SalespersonBonusSetupController), "GetNext")]
        [InlineData("/api/core/salesperson-bonus-setup/last", "GET", typeof(SalespersonBonusSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/custom-fields", "GET", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/core/salesperson-bonus-setup/custom-fields", "GET", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/custom-fields/{resourceId}", "GET", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/core/salesperson-bonus-setup/custom-fields/{resourceId}", "GET", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/meta", "HEAD", typeof(SalespersonBonusSetupController), "GetEntityView")]
        [InlineData("/api/core/salesperson-bonus-setup/meta", "HEAD", typeof(SalespersonBonusSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/count", "HEAD", typeof(SalespersonBonusSetupController), "Count")]
        [InlineData("/api/core/salesperson-bonus-setup/count", "HEAD", typeof(SalespersonBonusSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/all", "HEAD", typeof(SalespersonBonusSetupController), "GetAll")]
        [InlineData("/api/core/salesperson-bonus-setup/all", "HEAD", typeof(SalespersonBonusSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/export", "HEAD", typeof(SalespersonBonusSetupController), "Export")]
        [InlineData("/api/core/salesperson-bonus-setup/export", "HEAD", typeof(SalespersonBonusSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/1", "HEAD", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup/1", "HEAD", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/get?salespersonBonusSetupIds=1", "HEAD", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/core/salesperson-bonus-setup/get?salespersonBonusSetupIds=1", "HEAD", typeof(SalespersonBonusSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup", "HEAD", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup", "HEAD", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/page/1", "HEAD", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson-bonus-setup/page/1", "HEAD", typeof(SalespersonBonusSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/count-filtered/{filterName}", "HEAD", typeof(SalespersonBonusSetupController), "CountFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup/count-filtered/{filterName}", "HEAD", typeof(SalespersonBonusSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalespersonBonusSetupController), "GetFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalespersonBonusSetupController), "GetFiltered")]
        [InlineData("/api/core/salesperson-bonus-setup/first", "HEAD", typeof(SalespersonBonusSetupController), "GetFirst")]
        [InlineData("/api/core/salesperson-bonus-setup/previous/1", "HEAD", typeof(SalespersonBonusSetupController), "GetPrevious")]
        [InlineData("/api/core/salesperson-bonus-setup/next/1", "HEAD", typeof(SalespersonBonusSetupController), "GetNext")]
        [InlineData("/api/core/salesperson-bonus-setup/last", "HEAD", typeof(SalespersonBonusSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/custom-fields", "HEAD", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/core/salesperson-bonus-setup/custom-fields", "HEAD", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson-bonus-setup/custom-fields/{resourceId}", "HEAD", typeof(SalespersonBonusSetupController), "GetCustomFields")]
        [InlineData("/api/core/salesperson-bonus-setup/custom-fields/{resourceId}", "HEAD", typeof(SalespersonBonusSetupController), "GetCustomFields")]

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

        public SalespersonBonusSetupRouteTests()
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