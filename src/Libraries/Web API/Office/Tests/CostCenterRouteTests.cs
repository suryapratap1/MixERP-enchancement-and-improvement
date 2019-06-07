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
    public class CostCenterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/delete/{costCenterId}", "DELETE", typeof(CostCenterController), "Delete")]
        [InlineData("/api/office/cost-center/delete/{costCenterId}", "DELETE", typeof(CostCenterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/edit/{costCenterId}", "PUT", typeof(CostCenterController), "Edit")]
        [InlineData("/api/office/cost-center/edit/{costCenterId}", "PUT", typeof(CostCenterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/count-where", "POST", typeof(CostCenterController), "CountWhere")]
        [InlineData("/api/office/cost-center/count-where", "POST", typeof(CostCenterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/get-where/{pageNumber}", "POST", typeof(CostCenterController), "GetWhere")]
        [InlineData("/api/office/cost-center/get-where/{pageNumber}", "POST", typeof(CostCenterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/add-or-edit", "POST", typeof(CostCenterController), "AddOrEdit")]
        [InlineData("/api/office/cost-center/add-or-edit", "POST", typeof(CostCenterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/add/{costCenter}", "POST", typeof(CostCenterController), "Add")]
        [InlineData("/api/office/cost-center/add/{costCenter}", "POST", typeof(CostCenterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/bulk-import", "POST", typeof(CostCenterController), "BulkImport")]
        [InlineData("/api/office/cost-center/bulk-import", "POST", typeof(CostCenterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/meta", "GET", typeof(CostCenterController), "GetEntityView")]
        [InlineData("/api/office/cost-center/meta", "GET", typeof(CostCenterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/count", "GET", typeof(CostCenterController), "Count")]
        [InlineData("/api/office/cost-center/count", "GET", typeof(CostCenterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/all", "GET", typeof(CostCenterController), "GetAll")]
        [InlineData("/api/office/cost-center/all", "GET", typeof(CostCenterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/export", "GET", typeof(CostCenterController), "Export")]
        [InlineData("/api/office/cost-center/export", "GET", typeof(CostCenterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/1", "GET", typeof(CostCenterController), "Get")]
        [InlineData("/api/office/cost-center/1", "GET", typeof(CostCenterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/get?costCenterIds=1", "GET", typeof(CostCenterController), "Get")]
        [InlineData("/api/office/cost-center/get?costCenterIds=1", "GET", typeof(CostCenterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center", "GET", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/office/cost-center", "GET", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/page/1", "GET", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/office/cost-center/page/1", "GET", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/count-filtered/{filterName}", "GET", typeof(CostCenterController), "CountFiltered")]
        [InlineData("/api/office/cost-center/count-filtered/{filterName}", "GET", typeof(CostCenterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CostCenterController), "GetFiltered")]
        [InlineData("/api/office/cost-center/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CostCenterController), "GetFiltered")]
        [InlineData("/api/office/cost-center/first", "GET", typeof(CostCenterController), "GetFirst")]
        [InlineData("/api/office/cost-center/previous/1", "GET", typeof(CostCenterController), "GetPrevious")]
        [InlineData("/api/office/cost-center/next/1", "GET", typeof(CostCenterController), "GetNext")]
        [InlineData("/api/office/cost-center/last", "GET", typeof(CostCenterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/cost-center/custom-fields", "GET", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/office/cost-center/custom-fields", "GET", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/custom-fields/{resourceId}", "GET", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/office/cost-center/custom-fields/{resourceId}", "GET", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/meta", "HEAD", typeof(CostCenterController), "GetEntityView")]
        [InlineData("/api/office/cost-center/meta", "HEAD", typeof(CostCenterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/count", "HEAD", typeof(CostCenterController), "Count")]
        [InlineData("/api/office/cost-center/count", "HEAD", typeof(CostCenterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/all", "HEAD", typeof(CostCenterController), "GetAll")]
        [InlineData("/api/office/cost-center/all", "HEAD", typeof(CostCenterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/export", "HEAD", typeof(CostCenterController), "Export")]
        [InlineData("/api/office/cost-center/export", "HEAD", typeof(CostCenterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/1", "HEAD", typeof(CostCenterController), "Get")]
        [InlineData("/api/office/cost-center/1", "HEAD", typeof(CostCenterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/get?costCenterIds=1", "HEAD", typeof(CostCenterController), "Get")]
        [InlineData("/api/office/cost-center/get?costCenterIds=1", "HEAD", typeof(CostCenterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center", "HEAD", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/office/cost-center", "HEAD", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/page/1", "HEAD", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/office/cost-center/page/1", "HEAD", typeof(CostCenterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/count-filtered/{filterName}", "HEAD", typeof(CostCenterController), "CountFiltered")]
        [InlineData("/api/office/cost-center/count-filtered/{filterName}", "HEAD", typeof(CostCenterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CostCenterController), "GetFiltered")]
        [InlineData("/api/office/cost-center/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CostCenterController), "GetFiltered")]
        [InlineData("/api/office/cost-center/first", "HEAD", typeof(CostCenterController), "GetFirst")]
        [InlineData("/api/office/cost-center/previous/1", "HEAD", typeof(CostCenterController), "GetPrevious")]
        [InlineData("/api/office/cost-center/next/1", "HEAD", typeof(CostCenterController), "GetNext")]
        [InlineData("/api/office/cost-center/last", "HEAD", typeof(CostCenterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/cost-center/custom-fields", "HEAD", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/office/cost-center/custom-fields", "HEAD", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cost-center/custom-fields/{resourceId}", "HEAD", typeof(CostCenterController), "GetCustomFields")]
        [InlineData("/api/office/cost-center/custom-fields/{resourceId}", "HEAD", typeof(CostCenterController), "GetCustomFields")]

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

        public CostCenterRouteTests()
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