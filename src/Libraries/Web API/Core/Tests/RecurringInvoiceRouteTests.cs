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
    public class RecurringInvoiceRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/delete/{recurringInvoiceId}", "DELETE", typeof(RecurringInvoiceController), "Delete")]
        [InlineData("/api/core/recurring-invoice/delete/{recurringInvoiceId}", "DELETE", typeof(RecurringInvoiceController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/edit/{recurringInvoiceId}", "PUT", typeof(RecurringInvoiceController), "Edit")]
        [InlineData("/api/core/recurring-invoice/edit/{recurringInvoiceId}", "PUT", typeof(RecurringInvoiceController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/count-where", "POST", typeof(RecurringInvoiceController), "CountWhere")]
        [InlineData("/api/core/recurring-invoice/count-where", "POST", typeof(RecurringInvoiceController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/get-where/{pageNumber}", "POST", typeof(RecurringInvoiceController), "GetWhere")]
        [InlineData("/api/core/recurring-invoice/get-where/{pageNumber}", "POST", typeof(RecurringInvoiceController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/add-or-edit", "POST", typeof(RecurringInvoiceController), "AddOrEdit")]
        [InlineData("/api/core/recurring-invoice/add-or-edit", "POST", typeof(RecurringInvoiceController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/add/{recurringInvoice}", "POST", typeof(RecurringInvoiceController), "Add")]
        [InlineData("/api/core/recurring-invoice/add/{recurringInvoice}", "POST", typeof(RecurringInvoiceController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/bulk-import", "POST", typeof(RecurringInvoiceController), "BulkImport")]
        [InlineData("/api/core/recurring-invoice/bulk-import", "POST", typeof(RecurringInvoiceController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/meta", "GET", typeof(RecurringInvoiceController), "GetEntityView")]
        [InlineData("/api/core/recurring-invoice/meta", "GET", typeof(RecurringInvoiceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/count", "GET", typeof(RecurringInvoiceController), "Count")]
        [InlineData("/api/core/recurring-invoice/count", "GET", typeof(RecurringInvoiceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/all", "GET", typeof(RecurringInvoiceController), "GetAll")]
        [InlineData("/api/core/recurring-invoice/all", "GET", typeof(RecurringInvoiceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/export", "GET", typeof(RecurringInvoiceController), "Export")]
        [InlineData("/api/core/recurring-invoice/export", "GET", typeof(RecurringInvoiceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/1", "GET", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/core/recurring-invoice/1", "GET", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/get?recurringInvoiceIds=1", "GET", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/core/recurring-invoice/get?recurringInvoiceIds=1", "GET", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice", "GET", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice", "GET", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/page/1", "GET", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice/page/1", "GET", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/count-filtered/{filterName}", "GET", typeof(RecurringInvoiceController), "CountFiltered")]
        [InlineData("/api/core/recurring-invoice/count-filtered/{filterName}", "GET", typeof(RecurringInvoiceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RecurringInvoiceController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RecurringInvoiceController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice/first", "GET", typeof(RecurringInvoiceController), "GetFirst")]
        [InlineData("/api/core/recurring-invoice/previous/1", "GET", typeof(RecurringInvoiceController), "GetPrevious")]
        [InlineData("/api/core/recurring-invoice/next/1", "GET", typeof(RecurringInvoiceController), "GetNext")]
        [InlineData("/api/core/recurring-invoice/last", "GET", typeof(RecurringInvoiceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/custom-fields", "GET", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice/custom-fields", "GET", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/custom-fields/{resourceId}", "GET", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice/custom-fields/{resourceId}", "GET", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/meta", "HEAD", typeof(RecurringInvoiceController), "GetEntityView")]
        [InlineData("/api/core/recurring-invoice/meta", "HEAD", typeof(RecurringInvoiceController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/count", "HEAD", typeof(RecurringInvoiceController), "Count")]
        [InlineData("/api/core/recurring-invoice/count", "HEAD", typeof(RecurringInvoiceController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/all", "HEAD", typeof(RecurringInvoiceController), "GetAll")]
        [InlineData("/api/core/recurring-invoice/all", "HEAD", typeof(RecurringInvoiceController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/export", "HEAD", typeof(RecurringInvoiceController), "Export")]
        [InlineData("/api/core/recurring-invoice/export", "HEAD", typeof(RecurringInvoiceController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/1", "HEAD", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/core/recurring-invoice/1", "HEAD", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/get?recurringInvoiceIds=1", "HEAD", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/core/recurring-invoice/get?recurringInvoiceIds=1", "HEAD", typeof(RecurringInvoiceController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice", "HEAD", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice", "HEAD", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/page/1", "HEAD", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/core/recurring-invoice/page/1", "HEAD", typeof(RecurringInvoiceController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/count-filtered/{filterName}", "HEAD", typeof(RecurringInvoiceController), "CountFiltered")]
        [InlineData("/api/core/recurring-invoice/count-filtered/{filterName}", "HEAD", typeof(RecurringInvoiceController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RecurringInvoiceController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RecurringInvoiceController), "GetFiltered")]
        [InlineData("/api/core/recurring-invoice/first", "HEAD", typeof(RecurringInvoiceController), "GetFirst")]
        [InlineData("/api/core/recurring-invoice/previous/1", "HEAD", typeof(RecurringInvoiceController), "GetPrevious")]
        [InlineData("/api/core/recurring-invoice/next/1", "HEAD", typeof(RecurringInvoiceController), "GetNext")]
        [InlineData("/api/core/recurring-invoice/last", "HEAD", typeof(RecurringInvoiceController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/custom-fields", "HEAD", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice/custom-fields", "HEAD", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurring-invoice/custom-fields/{resourceId}", "HEAD", typeof(RecurringInvoiceController), "GetCustomFields")]
        [InlineData("/api/core/recurring-invoice/custom-fields/{resourceId}", "HEAD", typeof(RecurringInvoiceController), "GetCustomFields")]

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

        public RecurringInvoiceRouteTests()
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