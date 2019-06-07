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
    public class CashRepositoryRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/delete/{cashRepositoryId}", "DELETE", typeof(CashRepositoryController), "Delete")]
        [InlineData("/api/office/cash-repository/delete/{cashRepositoryId}", "DELETE", typeof(CashRepositoryController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/edit/{cashRepositoryId}", "PUT", typeof(CashRepositoryController), "Edit")]
        [InlineData("/api/office/cash-repository/edit/{cashRepositoryId}", "PUT", typeof(CashRepositoryController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/count-where", "POST", typeof(CashRepositoryController), "CountWhere")]
        [InlineData("/api/office/cash-repository/count-where", "POST", typeof(CashRepositoryController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/get-where/{pageNumber}", "POST", typeof(CashRepositoryController), "GetWhere")]
        [InlineData("/api/office/cash-repository/get-where/{pageNumber}", "POST", typeof(CashRepositoryController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/add-or-edit", "POST", typeof(CashRepositoryController), "AddOrEdit")]
        [InlineData("/api/office/cash-repository/add-or-edit", "POST", typeof(CashRepositoryController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/add/{cashRepository}", "POST", typeof(CashRepositoryController), "Add")]
        [InlineData("/api/office/cash-repository/add/{cashRepository}", "POST", typeof(CashRepositoryController), "Add")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/bulk-import", "POST", typeof(CashRepositoryController), "BulkImport")]
        [InlineData("/api/office/cash-repository/bulk-import", "POST", typeof(CashRepositoryController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/meta", "GET", typeof(CashRepositoryController), "GetEntityView")]
        [InlineData("/api/office/cash-repository/meta", "GET", typeof(CashRepositoryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/count", "GET", typeof(CashRepositoryController), "Count")]
        [InlineData("/api/office/cash-repository/count", "GET", typeof(CashRepositoryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/all", "GET", typeof(CashRepositoryController), "GetAll")]
        [InlineData("/api/office/cash-repository/all", "GET", typeof(CashRepositoryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/export", "GET", typeof(CashRepositoryController), "Export")]
        [InlineData("/api/office/cash-repository/export", "GET", typeof(CashRepositoryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/1", "GET", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/office/cash-repository/1", "GET", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/get?cashRepositoryIds=1", "GET", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/office/cash-repository/get?cashRepositoryIds=1", "GET", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository", "GET", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/office/cash-repository", "GET", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/page/1", "GET", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/office/cash-repository/page/1", "GET", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/count-filtered/{filterName}", "GET", typeof(CashRepositoryController), "CountFiltered")]
        [InlineData("/api/office/cash-repository/count-filtered/{filterName}", "GET", typeof(CashRepositoryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CashRepositoryController), "GetFiltered")]
        [InlineData("/api/office/cash-repository/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CashRepositoryController), "GetFiltered")]
        [InlineData("/api/office/cash-repository/first", "GET", typeof(CashRepositoryController), "GetFirst")]
        [InlineData("/api/office/cash-repository/previous/1", "GET", typeof(CashRepositoryController), "GetPrevious")]
        [InlineData("/api/office/cash-repository/next/1", "GET", typeof(CashRepositoryController), "GetNext")]
        [InlineData("/api/office/cash-repository/last", "GET", typeof(CashRepositoryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/cash-repository/custom-fields", "GET", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/office/cash-repository/custom-fields", "GET", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/custom-fields/{resourceId}", "GET", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/office/cash-repository/custom-fields/{resourceId}", "GET", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/meta", "HEAD", typeof(CashRepositoryController), "GetEntityView")]
        [InlineData("/api/office/cash-repository/meta", "HEAD", typeof(CashRepositoryController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/count", "HEAD", typeof(CashRepositoryController), "Count")]
        [InlineData("/api/office/cash-repository/count", "HEAD", typeof(CashRepositoryController), "Count")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/all", "HEAD", typeof(CashRepositoryController), "GetAll")]
        [InlineData("/api/office/cash-repository/all", "HEAD", typeof(CashRepositoryController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/export", "HEAD", typeof(CashRepositoryController), "Export")]
        [InlineData("/api/office/cash-repository/export", "HEAD", typeof(CashRepositoryController), "Export")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/1", "HEAD", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/office/cash-repository/1", "HEAD", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/get?cashRepositoryIds=1", "HEAD", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/office/cash-repository/get?cashRepositoryIds=1", "HEAD", typeof(CashRepositoryController), "Get")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository", "HEAD", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/office/cash-repository", "HEAD", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/page/1", "HEAD", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/office/cash-repository/page/1", "HEAD", typeof(CashRepositoryController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/count-filtered/{filterName}", "HEAD", typeof(CashRepositoryController), "CountFiltered")]
        [InlineData("/api/office/cash-repository/count-filtered/{filterName}", "HEAD", typeof(CashRepositoryController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CashRepositoryController), "GetFiltered")]
        [InlineData("/api/office/cash-repository/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CashRepositoryController), "GetFiltered")]
        [InlineData("/api/office/cash-repository/first", "HEAD", typeof(CashRepositoryController), "GetFirst")]
        [InlineData("/api/office/cash-repository/previous/1", "HEAD", typeof(CashRepositoryController), "GetPrevious")]
        [InlineData("/api/office/cash-repository/next/1", "HEAD", typeof(CashRepositoryController), "GetNext")]
        [InlineData("/api/office/cash-repository/last", "HEAD", typeof(CashRepositoryController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/office/cash-repository/custom-fields", "HEAD", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/office/cash-repository/custom-fields", "HEAD", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/office/cash-repository/custom-fields/{resourceId}", "HEAD", typeof(CashRepositoryController), "GetCustomFields")]
        [InlineData("/api/office/cash-repository/custom-fields/{resourceId}", "HEAD", typeof(CashRepositoryController), "GetCustomFields")]

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

        public CashRepositoryRouteTests()
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