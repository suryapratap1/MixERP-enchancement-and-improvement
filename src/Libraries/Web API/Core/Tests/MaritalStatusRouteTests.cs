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
    public class MaritalStatusRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/delete/{maritalStatusId}", "DELETE", typeof(MaritalStatusController), "Delete")]
        [InlineData("/api/core/marital-status/delete/{maritalStatusId}", "DELETE", typeof(MaritalStatusController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/edit/{maritalStatusId}", "PUT", typeof(MaritalStatusController), "Edit")]
        [InlineData("/api/core/marital-status/edit/{maritalStatusId}", "PUT", typeof(MaritalStatusController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/count-where", "POST", typeof(MaritalStatusController), "CountWhere")]
        [InlineData("/api/core/marital-status/count-where", "POST", typeof(MaritalStatusController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/get-where/{pageNumber}", "POST", typeof(MaritalStatusController), "GetWhere")]
        [InlineData("/api/core/marital-status/get-where/{pageNumber}", "POST", typeof(MaritalStatusController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/add-or-edit", "POST", typeof(MaritalStatusController), "AddOrEdit")]
        [InlineData("/api/core/marital-status/add-or-edit", "POST", typeof(MaritalStatusController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/add/{maritalStatus}", "POST", typeof(MaritalStatusController), "Add")]
        [InlineData("/api/core/marital-status/add/{maritalStatus}", "POST", typeof(MaritalStatusController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/bulk-import", "POST", typeof(MaritalStatusController), "BulkImport")]
        [InlineData("/api/core/marital-status/bulk-import", "POST", typeof(MaritalStatusController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/meta", "GET", typeof(MaritalStatusController), "GetEntityView")]
        [InlineData("/api/core/marital-status/meta", "GET", typeof(MaritalStatusController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/count", "GET", typeof(MaritalStatusController), "Count")]
        [InlineData("/api/core/marital-status/count", "GET", typeof(MaritalStatusController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/all", "GET", typeof(MaritalStatusController), "GetAll")]
        [InlineData("/api/core/marital-status/all", "GET", typeof(MaritalStatusController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/export", "GET", typeof(MaritalStatusController), "Export")]
        [InlineData("/api/core/marital-status/export", "GET", typeof(MaritalStatusController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/1", "GET", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/core/marital-status/1", "GET", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/get?maritalStatusIds=1", "GET", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/core/marital-status/get?maritalStatusIds=1", "GET", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status", "GET", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/marital-status", "GET", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/page/1", "GET", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/marital-status/page/1", "GET", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/count-filtered/{filterName}", "GET", typeof(MaritalStatusController), "CountFiltered")]
        [InlineData("/api/core/marital-status/count-filtered/{filterName}", "GET", typeof(MaritalStatusController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MaritalStatusController), "GetFiltered")]
        [InlineData("/api/core/marital-status/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MaritalStatusController), "GetFiltered")]
        [InlineData("/api/core/marital-status/first", "GET", typeof(MaritalStatusController), "GetFirst")]
        [InlineData("/api/core/marital-status/previous/1", "GET", typeof(MaritalStatusController), "GetPrevious")]
        [InlineData("/api/core/marital-status/next/1", "GET", typeof(MaritalStatusController), "GetNext")]
        [InlineData("/api/core/marital-status/last", "GET", typeof(MaritalStatusController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/marital-status/custom-fields", "GET", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/core/marital-status/custom-fields", "GET", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/custom-fields/{resourceId}", "GET", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/core/marital-status/custom-fields/{resourceId}", "GET", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/meta", "HEAD", typeof(MaritalStatusController), "GetEntityView")]
        [InlineData("/api/core/marital-status/meta", "HEAD", typeof(MaritalStatusController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/count", "HEAD", typeof(MaritalStatusController), "Count")]
        [InlineData("/api/core/marital-status/count", "HEAD", typeof(MaritalStatusController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/all", "HEAD", typeof(MaritalStatusController), "GetAll")]
        [InlineData("/api/core/marital-status/all", "HEAD", typeof(MaritalStatusController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/export", "HEAD", typeof(MaritalStatusController), "Export")]
        [InlineData("/api/core/marital-status/export", "HEAD", typeof(MaritalStatusController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/1", "HEAD", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/core/marital-status/1", "HEAD", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/get?maritalStatusIds=1", "HEAD", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/core/marital-status/get?maritalStatusIds=1", "HEAD", typeof(MaritalStatusController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status", "HEAD", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/marital-status", "HEAD", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/page/1", "HEAD", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/core/marital-status/page/1", "HEAD", typeof(MaritalStatusController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/count-filtered/{filterName}", "HEAD", typeof(MaritalStatusController), "CountFiltered")]
        [InlineData("/api/core/marital-status/count-filtered/{filterName}", "HEAD", typeof(MaritalStatusController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MaritalStatusController), "GetFiltered")]
        [InlineData("/api/core/marital-status/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MaritalStatusController), "GetFiltered")]
        [InlineData("/api/core/marital-status/first", "HEAD", typeof(MaritalStatusController), "GetFirst")]
        [InlineData("/api/core/marital-status/previous/1", "HEAD", typeof(MaritalStatusController), "GetPrevious")]
        [InlineData("/api/core/marital-status/next/1", "HEAD", typeof(MaritalStatusController), "GetNext")]
        [InlineData("/api/core/marital-status/last", "HEAD", typeof(MaritalStatusController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/marital-status/custom-fields", "HEAD", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/core/marital-status/custom-fields", "HEAD", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/marital-status/custom-fields/{resourceId}", "HEAD", typeof(MaritalStatusController), "GetCustomFields")]
        [InlineData("/api/core/marital-status/custom-fields/{resourceId}", "HEAD", typeof(MaritalStatusController), "GetCustomFields")]

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

        public MaritalStatusRouteTests()
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