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
    public class RecurringInvoiceSetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/delete/{recurringInvoiceSetupId}", "DELETE", typeof(RecurringInvoiceSetupController), "Delete")]
        [InlineData("/api/core/recurring-invoice-setup/delete/{recurringInvoiceSetupId}", "DELETE", typeof(RecurringInvoiceSetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/edit/{recurringInvoiceSetupId}", "PUT", typeof(RecurringInvoiceSetupController), "Edit")]
        [InlineData("/api/core/recurring-invoice-setup/edit/{recurringInvoiceSetupId}", "PUT", typeof(RecurringInvoiceSetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/count-where", "POST", typeof(RecurringInvoiceSetupController), "CountWhere")]
        [InlineData("/api/core/recurring-invoice-setup/count-where", "POST", typeof(RecurringInvoiceSetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/get-where/{pageNumber}", "POST", typeof(RecurringInvoiceSetupController), "GetWhere")]
        [InlineData("/api/core/recurring-invoice-setup/get-where/{pageNumber}", "POST", typeof(RecurringInvoiceSetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/add-or-edit", "POST", typeof(RecurringInvoiceSetupController), "AddOrEdit")]
        [InlineData("/api/core/recurring-invoice-setup/add-or-edit", "POST", typeof(RecurringInvoiceSetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/add/{recurringInvoiceSetup}", "POST", typeof(RecurringInvoiceSetupController), "Add")]
        [InlineData("/api/core/recurring-invoice-setup/add/{recurringInvoiceSetup}", "POST", typeof(RecurringInvoiceSetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/bulk-import", "POST", typeof(RecurringInvoiceSetupController), "BulkImport")]
        [InlineData("/api/core/recurring-invoice-setup/bulk-import", "POST", typeof(RecurringInvoiceSetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/meta", "GET", typeof(RecurringInvoiceSetupController), "GetEntityView")]
        [InlineData("/api/core/recurring-invoice-setup/meta", "GET", typeof(RecurringInvoiceSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/count", "GET", typeof(RecurringInvoiceSetupController), "Count")]
        [InlineData("/api/core/recurring-invoice-setup/count", "GET", typeof(RecurringInvoiceSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/all", "GET", typeof(RecurringInvoiceSetupController), "GetAll")]
        [InlineData("/api/core/recurring-invoice-setup/all", "GET", typeof(RecurringInvoiceSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/export", "GET", typeof(RecurringInvoiceSetupController), "Export")]
        [InlineData("/api/core/recurring-invoice-setup/export", "GET", typeof(RecurringInvoiceSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/1", "GET", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/core/recurring-invoice-setup/1", "GET", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/get?recurringInvoiceSetupIds=1", "GET", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/core/recurring-invoice-setup/get?recurringInvoiceSetupIds=1", "GET", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup", "GET", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice-setup", "GET", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/page/1", "GET", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice-setup/page/1", "GET", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/count-filtered/{filterName}", "GET", typeof(RecurringInvoiceSetupController), "CountFiltered")]
        [InlineData("/api/core/recurring-invoice-setup/count-filtered/{filterName}", "GET", typeof(RecurringInvoiceSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RecurringInvoiceSetupController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RecurringInvoiceSetupController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice-setup/first", "GET", typeof(RecurringInvoiceSetupController), "GetFirst")]
        [InlineData("/api/core/recurring-invoice-setup/previous/1", "GET", typeof(RecurringInvoiceSetupController), "GetPrevious")]
        [InlineData("/api/core/recurring-invoice-setup/next/1", "GET", typeof(RecurringInvoiceSetupController), "GetNext")]
        [InlineData("/api/core/recurring-invoice-setup/last", "GET", typeof(RecurringInvoiceSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/custom-fields", "GET", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice-setup/custom-fields", "GET", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/custom-fields/{resourceId}", "GET", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice-setup/custom-fields/{resourceId}", "GET", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/meta", "HEAD", typeof(RecurringInvoiceSetupController), "GetEntityView")]
        [InlineData("/api/core/recurring-invoice-setup/meta", "HEAD", typeof(RecurringInvoiceSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/count", "HEAD", typeof(RecurringInvoiceSetupController), "Count")]
        [InlineData("/api/core/recurring-invoice-setup/count", "HEAD", typeof(RecurringInvoiceSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/all", "HEAD", typeof(RecurringInvoiceSetupController), "GetAll")]
        [InlineData("/api/core/recurring-invoice-setup/all", "HEAD", typeof(RecurringInvoiceSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/export", "HEAD", typeof(RecurringInvoiceSetupController), "Export")]
        [InlineData("/api/core/recurring-invoice-setup/export", "HEAD", typeof(RecurringInvoiceSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/1", "HEAD", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/core/recurring-invoice-setup/1", "HEAD", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/get?recurringInvoiceSetupIds=1", "HEAD", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/core/recurring-invoice-setup/get?recurringInvoiceSetupIds=1", "HEAD", typeof(RecurringInvoiceSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup", "HEAD", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice-setup", "HEAD", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/page/1", "HEAD", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice-setup/page/1", "HEAD", typeof(RecurringInvoiceSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/count-filtered/{filterName}", "HEAD", typeof(RecurringInvoiceSetupController), "CountFiltered")]
        [InlineData("/api/core/recurring-invoice-setup/count-filtered/{filterName}", "HEAD", typeof(RecurringInvoiceSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RecurringInvoiceSetupController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RecurringInvoiceSetupController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice-setup/first", "HEAD", typeof(RecurringInvoiceSetupController), "GetFirst")]
        [InlineData("/api/core/recurring-invoice-setup/previous/1", "HEAD", typeof(RecurringInvoiceSetupController), "GetPrevious")]
        [InlineData("/api/core/recurring-invoice-setup/next/1", "HEAD", typeof(RecurringInvoiceSetupController), "GetNext")]
        [InlineData("/api/core/recurring-invoice-setup/last", "HEAD", typeof(RecurringInvoiceSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/custom-fields", "HEAD", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice-setup/custom-fields", "HEAD", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice-setup/custom-fields/{resourceId}", "HEAD", typeof(RecurringInvoiceSetupController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice-setup/custom-fields/{resourceId}", "HEAD", typeof(RecurringInvoiceSetupController), "GetCustomFields")]

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

        public RecurringInvoiceSetupRouteTests()
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