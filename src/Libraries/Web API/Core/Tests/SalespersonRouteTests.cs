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
    public class SalespersonRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/delete/{salespersonId}", "DELETE", typeof(SalespersonController), "Delete")]
        [InlineData("/api/core/salesperson/delete/{salespersonId}", "DELETE", typeof(SalespersonController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/edit/{salespersonId}", "PUT", typeof(SalespersonController), "Edit")]
        [InlineData("/api/core/salesperson/edit/{salespersonId}", "PUT", typeof(SalespersonController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/count-where", "POST", typeof(SalespersonController), "CountWhere")]
        [InlineData("/api/core/salesperson/count-where", "POST", typeof(SalespersonController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/get-where/{pageNumber}", "POST", typeof(SalespersonController), "GetWhere")]
        [InlineData("/api/core/salesperson/get-where/{pageNumber}", "POST", typeof(SalespersonController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/add-or-edit", "POST", typeof(SalespersonController), "AddOrEdit")]
        [InlineData("/api/core/salesperson/add-or-edit", "POST", typeof(SalespersonController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/add/{salesperson}", "POST", typeof(SalespersonController), "Add")]
        [InlineData("/api/core/salesperson/add/{salesperson}", "POST", typeof(SalespersonController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/bulk-import", "POST", typeof(SalespersonController), "BulkImport")]
        [InlineData("/api/core/salesperson/bulk-import", "POST", typeof(SalespersonController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/meta", "GET", typeof(SalespersonController), "GetEntityView")]
        [InlineData("/api/core/salesperson/meta", "GET", typeof(SalespersonController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/count", "GET", typeof(SalespersonController), "Count")]
        [InlineData("/api/core/salesperson/count", "GET", typeof(SalespersonController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/all", "GET", typeof(SalespersonController), "GetAll")]
        [InlineData("/api/core/salesperson/all", "GET", typeof(SalespersonController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/export", "GET", typeof(SalespersonController), "Export")]
        [InlineData("/api/core/salesperson/export", "GET", typeof(SalespersonController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/1", "GET", typeof(SalespersonController), "Get")]
        [InlineData("/api/core/salesperson/1", "GET", typeof(SalespersonController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/get?salespersonIds=1", "GET", typeof(SalespersonController), "Get")]
        [InlineData("/api/core/salesperson/get?salespersonIds=1", "GET", typeof(SalespersonController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson", "GET", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson", "GET", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/page/1", "GET", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson/page/1", "GET", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/count-filtered/{filterName}", "GET", typeof(SalespersonController), "CountFiltered")]
        [InlineData("/api/core/salesperson/count-filtered/{filterName}", "GET", typeof(SalespersonController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalespersonController), "GetFiltered")]
        [InlineData("/api/core/salesperson/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalespersonController), "GetFiltered")]
        [InlineData("/api/core/salesperson/first", "GET", typeof(SalespersonController), "GetFirst")]
        [InlineData("/api/core/salesperson/previous/1", "GET", typeof(SalespersonController), "GetPrevious")]
        [InlineData("/api/core/salesperson/next/1", "GET", typeof(SalespersonController), "GetNext")]
        [InlineData("/api/core/salesperson/last", "GET", typeof(SalespersonController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/salesperson/custom-fields", "GET", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/core/salesperson/custom-fields", "GET", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/custom-fields/{resourceId}", "GET", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/core/salesperson/custom-fields/{resourceId}", "GET", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/meta", "HEAD", typeof(SalespersonController), "GetEntityView")]
        [InlineData("/api/core/salesperson/meta", "HEAD", typeof(SalespersonController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/count", "HEAD", typeof(SalespersonController), "Count")]
        [InlineData("/api/core/salesperson/count", "HEAD", typeof(SalespersonController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/all", "HEAD", typeof(SalespersonController), "GetAll")]
        [InlineData("/api/core/salesperson/all", "HEAD", typeof(SalespersonController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/export", "HEAD", typeof(SalespersonController), "Export")]
        [InlineData("/api/core/salesperson/export", "HEAD", typeof(SalespersonController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/1", "HEAD", typeof(SalespersonController), "Get")]
        [InlineData("/api/core/salesperson/1", "HEAD", typeof(SalespersonController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/get?salespersonIds=1", "HEAD", typeof(SalespersonController), "Get")]
        [InlineData("/api/core/salesperson/get?salespersonIds=1", "HEAD", typeof(SalespersonController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson", "HEAD", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson", "HEAD", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/page/1", "HEAD", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/core/salesperson/page/1", "HEAD", typeof(SalespersonController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/count-filtered/{filterName}", "HEAD", typeof(SalespersonController), "CountFiltered")]
        [InlineData("/api/core/salesperson/count-filtered/{filterName}", "HEAD", typeof(SalespersonController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalespersonController), "GetFiltered")]
        [InlineData("/api/core/salesperson/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalespersonController), "GetFiltered")]
        [InlineData("/api/core/salesperson/first", "HEAD", typeof(SalespersonController), "GetFirst")]
        [InlineData("/api/core/salesperson/previous/1", "HEAD", typeof(SalespersonController), "GetPrevious")]
        [InlineData("/api/core/salesperson/next/1", "HEAD", typeof(SalespersonController), "GetNext")]
        [InlineData("/api/core/salesperson/last", "HEAD", typeof(SalespersonController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/salesperson/custom-fields", "HEAD", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/core/salesperson/custom-fields", "HEAD", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/salesperson/custom-fields/{resourceId}", "HEAD", typeof(SalespersonController), "GetCustomFields")]
        [InlineData("/api/core/salesperson/custom-fields/{resourceId}", "HEAD", typeof(SalespersonController), "GetCustomFields")]

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

        public SalespersonRouteTests()
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