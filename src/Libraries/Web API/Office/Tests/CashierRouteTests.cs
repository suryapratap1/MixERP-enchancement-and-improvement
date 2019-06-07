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
    public class CashierRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/cashier/delete/{cashierId}", "DELETE", typeof(CashierController), "Delete")]
        [InlineData("/api/office/cashier/delete/{cashierId}", "DELETE", typeof(CashierController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/edit/{cashierId}", "PUT", typeof(CashierController), "Edit")]
        [InlineData("/api/office/cashier/edit/{cashierId}", "PUT", typeof(CashierController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/count-where", "POST", typeof(CashierController), "CountWhere")]
        [InlineData("/api/office/cashier/count-where", "POST", typeof(CashierController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/get-where/{pageNumber}", "POST", typeof(CashierController), "GetWhere")]
        [InlineData("/api/office/cashier/get-where/{pageNumber}", "POST", typeof(CashierController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/add-or-edit", "POST", typeof(CashierController), "AddOrEdit")]
        [InlineData("/api/office/cashier/add-or-edit", "POST", typeof(CashierController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/add/{cashier}", "POST", typeof(CashierController), "Add")]
        [InlineData("/api/office/cashier/add/{cashier}", "POST", typeof(CashierController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/bulk-import", "POST", typeof(CashierController), "BulkImport")]
        [InlineData("/api/office/cashier/bulk-import", "POST", typeof(CashierController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/meta", "GET", typeof(CashierController), "GetEntityView")]
        [InlineData("/api/office/cashier/meta", "GET", typeof(CashierController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/count", "GET", typeof(CashierController), "Count")]
        [InlineData("/api/office/cashier/count", "GET", typeof(CashierController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/all", "GET", typeof(CashierController), "GetAll")]
        [InlineData("/api/office/cashier/all", "GET", typeof(CashierController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/export", "GET", typeof(CashierController), "Export")]
        [InlineData("/api/office/cashier/export", "GET", typeof(CashierController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/1", "GET", typeof(CashierController), "Get")]
        [InlineData("/api/office/cashier/1", "GET", typeof(CashierController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/get?cashierIds=1", "GET", typeof(CashierController), "Get")]
        [InlineData("/api/office/cashier/get?cashierIds=1", "GET", typeof(CashierController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cashier", "GET", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/office/cashier", "GET", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/page/1", "GET", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/office/cashier/page/1", "GET", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/count-filtered/{filterName}", "GET", typeof(CashierController), "CountFiltered")]
        [InlineData("/api/office/cashier/count-filtered/{filterName}", "GET", typeof(CashierController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CashierController), "GetFiltered")]
        [InlineData("/api/office/cashier/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CashierController), "GetFiltered")]
        [InlineData("/api/office/cashier/first", "GET", typeof(CashierController), "GetFirst")]
        [InlineData("/api/office/cashier/previous/1", "GET", typeof(CashierController), "GetPrevious")]
        [InlineData("/api/office/cashier/next/1", "GET", typeof(CashierController), "GetNext")]
        [InlineData("/api/office/cashier/last", "GET", typeof(CashierController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/cashier/custom-fields", "GET", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/office/cashier/custom-fields", "GET", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/custom-fields/{resourceId}", "GET", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/office/cashier/custom-fields/{resourceId}", "GET", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/meta", "HEAD", typeof(CashierController), "GetEntityView")]
        [InlineData("/api/office/cashier/meta", "HEAD", typeof(CashierController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/count", "HEAD", typeof(CashierController), "Count")]
        [InlineData("/api/office/cashier/count", "HEAD", typeof(CashierController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/all", "HEAD", typeof(CashierController), "GetAll")]
        [InlineData("/api/office/cashier/all", "HEAD", typeof(CashierController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/export", "HEAD", typeof(CashierController), "Export")]
        [InlineData("/api/office/cashier/export", "HEAD", typeof(CashierController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/1", "HEAD", typeof(CashierController), "Get")]
        [InlineData("/api/office/cashier/1", "HEAD", typeof(CashierController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/get?cashierIds=1", "HEAD", typeof(CashierController), "Get")]
        [InlineData("/api/office/cashier/get?cashierIds=1", "HEAD", typeof(CashierController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cashier", "HEAD", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/office/cashier", "HEAD", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/page/1", "HEAD", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/office/cashier/page/1", "HEAD", typeof(CashierController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/count-filtered/{filterName}", "HEAD", typeof(CashierController), "CountFiltered")]
        [InlineData("/api/office/cashier/count-filtered/{filterName}", "HEAD", typeof(CashierController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CashierController), "GetFiltered")]
        [InlineData("/api/office/cashier/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CashierController), "GetFiltered")]
        [InlineData("/api/office/cashier/first", "HEAD", typeof(CashierController), "GetFirst")]
        [InlineData("/api/office/cashier/previous/1", "HEAD", typeof(CashierController), "GetPrevious")]
        [InlineData("/api/office/cashier/next/1", "HEAD", typeof(CashierController), "GetNext")]
        [InlineData("/api/office/cashier/last", "HEAD", typeof(CashierController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/cashier/custom-fields", "HEAD", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/office/cashier/custom-fields", "HEAD", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cashier/custom-fields/{resourceId}", "HEAD", typeof(CashierController), "GetCustomFields")]
        [InlineData("/api/office/cashier/custom-fields/{resourceId}", "HEAD", typeof(CashierController), "GetCustomFields")]

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

        public CashierRouteTests()
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