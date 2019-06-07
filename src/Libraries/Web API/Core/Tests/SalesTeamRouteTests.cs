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
    public class SalesTeamRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/delete/{salesTeamId}", "DELETE", typeof(SalesTeamController), "Delete")]
        [InlineData("/api/core/sales-team/delete/{salesTeamId}", "DELETE", typeof(SalesTeamController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/edit/{salesTeamId}", "PUT", typeof(SalesTeamController), "Edit")]
        [InlineData("/api/core/sales-team/edit/{salesTeamId}", "PUT", typeof(SalesTeamController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/count-where", "POST", typeof(SalesTeamController), "CountWhere")]
        [InlineData("/api/core/sales-team/count-where", "POST", typeof(SalesTeamController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/get-where/{pageNumber}", "POST", typeof(SalesTeamController), "GetWhere")]
        [InlineData("/api/core/sales-team/get-where/{pageNumber}", "POST", typeof(SalesTeamController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/add-or-edit", "POST", typeof(SalesTeamController), "AddOrEdit")]
        [InlineData("/api/core/sales-team/add-or-edit", "POST", typeof(SalesTeamController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/add/{salesTeam}", "POST", typeof(SalesTeamController), "Add")]
        [InlineData("/api/core/sales-team/add/{salesTeam}", "POST", typeof(SalesTeamController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/bulk-import", "POST", typeof(SalesTeamController), "BulkImport")]
        [InlineData("/api/core/sales-team/bulk-import", "POST", typeof(SalesTeamController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/meta", "GET", typeof(SalesTeamController), "GetEntityView")]
        [InlineData("/api/core/sales-team/meta", "GET", typeof(SalesTeamController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/count", "GET", typeof(SalesTeamController), "Count")]
        [InlineData("/api/core/sales-team/count", "GET", typeof(SalesTeamController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/all", "GET", typeof(SalesTeamController), "GetAll")]
        [InlineData("/api/core/sales-team/all", "GET", typeof(SalesTeamController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/export", "GET", typeof(SalesTeamController), "Export")]
        [InlineData("/api/core/sales-team/export", "GET", typeof(SalesTeamController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/1", "GET", typeof(SalesTeamController), "Get")]
        [InlineData("/api/core/sales-team/1", "GET", typeof(SalesTeamController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/get?salesTeamIds=1", "GET", typeof(SalesTeamController), "Get")]
        [InlineData("/api/core/sales-team/get?salesTeamIds=1", "GET", typeof(SalesTeamController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team", "GET", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-team", "GET", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/page/1", "GET", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-team/page/1", "GET", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/count-filtered/{filterName}", "GET", typeof(SalesTeamController), "CountFiltered")]
        [InlineData("/api/core/sales-team/count-filtered/{filterName}", "GET", typeof(SalesTeamController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTeamController), "GetFiltered")]
        [InlineData("/api/core/sales-team/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SalesTeamController), "GetFiltered")]
        [InlineData("/api/core/sales-team/first", "GET", typeof(SalesTeamController), "GetFirst")]
        [InlineData("/api/core/sales-team/previous/1", "GET", typeof(SalesTeamController), "GetPrevious")]
        [InlineData("/api/core/sales-team/next/1", "GET", typeof(SalesTeamController), "GetNext")]
        [InlineData("/api/core/sales-team/last", "GET", typeof(SalesTeamController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-team/custom-fields", "GET", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/core/sales-team/custom-fields", "GET", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/custom-fields/{resourceId}", "GET", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/core/sales-team/custom-fields/{resourceId}", "GET", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/meta", "HEAD", typeof(SalesTeamController), "GetEntityView")]
        [InlineData("/api/core/sales-team/meta", "HEAD", typeof(SalesTeamController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/count", "HEAD", typeof(SalesTeamController), "Count")]
        [InlineData("/api/core/sales-team/count", "HEAD", typeof(SalesTeamController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/all", "HEAD", typeof(SalesTeamController), "GetAll")]
        [InlineData("/api/core/sales-team/all", "HEAD", typeof(SalesTeamController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/export", "HEAD", typeof(SalesTeamController), "Export")]
        [InlineData("/api/core/sales-team/export", "HEAD", typeof(SalesTeamController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/1", "HEAD", typeof(SalesTeamController), "Get")]
        [InlineData("/api/core/sales-team/1", "HEAD", typeof(SalesTeamController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/get?salesTeamIds=1", "HEAD", typeof(SalesTeamController), "Get")]
        [InlineData("/api/core/sales-team/get?salesTeamIds=1", "HEAD", typeof(SalesTeamController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team", "HEAD", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-team", "HEAD", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/page/1", "HEAD", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/core/sales-team/page/1", "HEAD", typeof(SalesTeamController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/count-filtered/{filterName}", "HEAD", typeof(SalesTeamController), "CountFiltered")]
        [InlineData("/api/core/sales-team/count-filtered/{filterName}", "HEAD", typeof(SalesTeamController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTeamController), "GetFiltered")]
        [InlineData("/api/core/sales-team/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SalesTeamController), "GetFiltered")]
        [InlineData("/api/core/sales-team/first", "HEAD", typeof(SalesTeamController), "GetFirst")]
        [InlineData("/api/core/sales-team/previous/1", "HEAD", typeof(SalesTeamController), "GetPrevious")]
        [InlineData("/api/core/sales-team/next/1", "HEAD", typeof(SalesTeamController), "GetNext")]
        [InlineData("/api/core/sales-team/last", "HEAD", typeof(SalesTeamController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/sales-team/custom-fields", "HEAD", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/core/sales-team/custom-fields", "HEAD", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/sales-team/custom-fields/{resourceId}", "HEAD", typeof(SalesTeamController), "GetCustomFields")]
        [InlineData("/api/core/sales-team/custom-fields/{resourceId}", "HEAD", typeof(SalesTeamController), "GetCustomFields")]

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

        public SalesTeamRouteTests()
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