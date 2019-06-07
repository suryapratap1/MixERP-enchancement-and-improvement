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
    public class IncomeTaxSetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/delete/{incomeTaxSetupId}", "DELETE", typeof(IncomeTaxSetupController), "Delete")]
        [InlineData("/api/core/income-tax-setup/delete/{incomeTaxSetupId}", "DELETE", typeof(IncomeTaxSetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/edit/{incomeTaxSetupId}", "PUT", typeof(IncomeTaxSetupController), "Edit")]
        [InlineData("/api/core/income-tax-setup/edit/{incomeTaxSetupId}", "PUT", typeof(IncomeTaxSetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/count-where", "POST", typeof(IncomeTaxSetupController), "CountWhere")]
        [InlineData("/api/core/income-tax-setup/count-where", "POST", typeof(IncomeTaxSetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/get-where/{pageNumber}", "POST", typeof(IncomeTaxSetupController), "GetWhere")]
        [InlineData("/api/core/income-tax-setup/get-where/{pageNumber}", "POST", typeof(IncomeTaxSetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/add-or-edit", "POST", typeof(IncomeTaxSetupController), "AddOrEdit")]
        [InlineData("/api/core/income-tax-setup/add-or-edit", "POST", typeof(IncomeTaxSetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/add/{incomeTaxSetup}", "POST", typeof(IncomeTaxSetupController), "Add")]
        [InlineData("/api/core/income-tax-setup/add/{incomeTaxSetup}", "POST", typeof(IncomeTaxSetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/bulk-import", "POST", typeof(IncomeTaxSetupController), "BulkImport")]
        [InlineData("/api/core/income-tax-setup/bulk-import", "POST", typeof(IncomeTaxSetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/meta", "GET", typeof(IncomeTaxSetupController), "GetEntityView")]
        [InlineData("/api/core/income-tax-setup/meta", "GET", typeof(IncomeTaxSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/count", "GET", typeof(IncomeTaxSetupController), "Count")]
        [InlineData("/api/core/income-tax-setup/count", "GET", typeof(IncomeTaxSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/all", "GET", typeof(IncomeTaxSetupController), "GetAll")]
        [InlineData("/api/core/income-tax-setup/all", "GET", typeof(IncomeTaxSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/export", "GET", typeof(IncomeTaxSetupController), "Export")]
        [InlineData("/api/core/income-tax-setup/export", "GET", typeof(IncomeTaxSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/1", "GET", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/core/income-tax-setup/1", "GET", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/get?incomeTaxSetupIds=1", "GET", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/core/income-tax-setup/get?incomeTaxSetupIds=1", "GET", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup", "GET", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/income-tax-setup", "GET", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/page/1", "GET", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/income-tax-setup/page/1", "GET", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/count-filtered/{filterName}", "GET", typeof(IncomeTaxSetupController), "CountFiltered")]
        [InlineData("/api/core/income-tax-setup/count-filtered/{filterName}", "GET", typeof(IncomeTaxSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(IncomeTaxSetupController), "GetFiltered")]
        [InlineData("/api/core/income-tax-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(IncomeTaxSetupController), "GetFiltered")]
        [InlineData("/api/core/income-tax-setup/first", "GET", typeof(IncomeTaxSetupController), "GetFirst")]
        [InlineData("/api/core/income-tax-setup/previous/1", "GET", typeof(IncomeTaxSetupController), "GetPrevious")]
        [InlineData("/api/core/income-tax-setup/next/1", "GET", typeof(IncomeTaxSetupController), "GetNext")]
        [InlineData("/api/core/income-tax-setup/last", "GET", typeof(IncomeTaxSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/custom-fields", "GET", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/core/income-tax-setup/custom-fields", "GET", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/custom-fields/{resourceId}", "GET", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/core/income-tax-setup/custom-fields/{resourceId}", "GET", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/meta", "HEAD", typeof(IncomeTaxSetupController), "GetEntityView")]
        [InlineData("/api/core/income-tax-setup/meta", "HEAD", typeof(IncomeTaxSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/count", "HEAD", typeof(IncomeTaxSetupController), "Count")]
        [InlineData("/api/core/income-tax-setup/count", "HEAD", typeof(IncomeTaxSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/all", "HEAD", typeof(IncomeTaxSetupController), "GetAll")]
        [InlineData("/api/core/income-tax-setup/all", "HEAD", typeof(IncomeTaxSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/export", "HEAD", typeof(IncomeTaxSetupController), "Export")]
        [InlineData("/api/core/income-tax-setup/export", "HEAD", typeof(IncomeTaxSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/1", "HEAD", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/core/income-tax-setup/1", "HEAD", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/get?incomeTaxSetupIds=1", "HEAD", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/core/income-tax-setup/get?incomeTaxSetupIds=1", "HEAD", typeof(IncomeTaxSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup", "HEAD", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/income-tax-setup", "HEAD", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/page/1", "HEAD", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/income-tax-setup/page/1", "HEAD", typeof(IncomeTaxSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/count-filtered/{filterName}", "HEAD", typeof(IncomeTaxSetupController), "CountFiltered")]
        [InlineData("/api/core/income-tax-setup/count-filtered/{filterName}", "HEAD", typeof(IncomeTaxSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(IncomeTaxSetupController), "GetFiltered")]
        [InlineData("/api/core/income-tax-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(IncomeTaxSetupController), "GetFiltered")]
        [InlineData("/api/core/income-tax-setup/first", "HEAD", typeof(IncomeTaxSetupController), "GetFirst")]
        [InlineData("/api/core/income-tax-setup/previous/1", "HEAD", typeof(IncomeTaxSetupController), "GetPrevious")]
        [InlineData("/api/core/income-tax-setup/next/1", "HEAD", typeof(IncomeTaxSetupController), "GetNext")]
        [InlineData("/api/core/income-tax-setup/last", "HEAD", typeof(IncomeTaxSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/custom-fields", "HEAD", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/core/income-tax-setup/custom-fields", "HEAD", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/income-tax-setup/custom-fields/{resourceId}", "HEAD", typeof(IncomeTaxSetupController), "GetCustomFields")]
        [InlineData("/api/core/income-tax-setup/custom-fields/{resourceId}", "HEAD", typeof(IncomeTaxSetupController), "GetCustomFields")]

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

        public IncomeTaxSetupRouteTests()
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