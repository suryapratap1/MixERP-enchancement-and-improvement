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

namespace MixERP.Net.Api.HRM.Tests
{
    public class ResignationRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/delete/{resignationId}", "DELETE", typeof(ResignationController), "Delete")]
        [InlineData("/api/hrm/resignation/delete/{resignationId}", "DELETE", typeof(ResignationController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/edit/{resignationId}", "PUT", typeof(ResignationController), "Edit")]
        [InlineData("/api/hrm/resignation/edit/{resignationId}", "PUT", typeof(ResignationController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/verify/{resignationId}/{verificationStatusId}/{reason}", "PUT", typeof(ResignationController), "Verifiy")]
        [InlineData("/api/hrm/resignation/verify/{resignationId}/{verificationStatusId}/{reason}", "PUT", typeof(ResignationController), "Verifiy")]

        [InlineData("/api/{apiVersionNumber}/hrm/resignation/count-where", "POST", typeof(ResignationController), "CountWhere")]
        [InlineData("/api/hrm/resignation/count-where", "POST", typeof(ResignationController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/get-where/{pageNumber}", "POST", typeof(ResignationController), "GetWhere")]
        [InlineData("/api/hrm/resignation/get-where/{pageNumber}", "POST", typeof(ResignationController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/add-or-edit", "POST", typeof(ResignationController), "AddOrEdit")]
        [InlineData("/api/hrm/resignation/add-or-edit", "POST", typeof(ResignationController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/add/{resignation}", "POST", typeof(ResignationController), "Add")]
        [InlineData("/api/hrm/resignation/add/{resignation}", "POST", typeof(ResignationController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/bulk-import", "POST", typeof(ResignationController), "BulkImport")]
        [InlineData("/api/hrm/resignation/bulk-import", "POST", typeof(ResignationController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/meta", "GET", typeof(ResignationController), "GetEntityView")]
        [InlineData("/api/hrm/resignation/meta", "GET", typeof(ResignationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/count", "GET", typeof(ResignationController), "Count")]
        [InlineData("/api/hrm/resignation/count", "GET", typeof(ResignationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/all", "GET", typeof(ResignationController), "GetAll")]
        [InlineData("/api/hrm/resignation/all", "GET", typeof(ResignationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/export", "GET", typeof(ResignationController), "Export")]
        [InlineData("/api/hrm/resignation/export", "GET", typeof(ResignationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/1", "GET", typeof(ResignationController), "Get")]
        [InlineData("/api/hrm/resignation/1", "GET", typeof(ResignationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/get?resignationIds=1", "GET", typeof(ResignationController), "Get")]
        [InlineData("/api/hrm/resignation/get?resignationIds=1", "GET", typeof(ResignationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation", "GET", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/resignation", "GET", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/page/1", "GET", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/resignation/page/1", "GET", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/count-filtered/{filterName}", "GET", typeof(ResignationController), "CountFiltered")]
        [InlineData("/api/hrm/resignation/count-filtered/{filterName}", "GET", typeof(ResignationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ResignationController), "GetFiltered")]
        [InlineData("/api/hrm/resignation/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ResignationController), "GetFiltered")]
        [InlineData("/api/hrm/resignation/first", "GET", typeof(ResignationController), "GetFirst")]
        [InlineData("/api/hrm/resignation/previous/1", "GET", typeof(ResignationController), "GetPrevious")]
        [InlineData("/api/hrm/resignation/next/1", "GET", typeof(ResignationController), "GetNext")]
        [InlineData("/api/hrm/resignation/last", "GET", typeof(ResignationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/resignation/custom-fields", "GET", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/hrm/resignation/custom-fields", "GET", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/custom-fields/{resourceId}", "GET", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/hrm/resignation/custom-fields/{resourceId}", "GET", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/meta", "HEAD", typeof(ResignationController), "GetEntityView")]
        [InlineData("/api/hrm/resignation/meta", "HEAD", typeof(ResignationController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/count", "HEAD", typeof(ResignationController), "Count")]
        [InlineData("/api/hrm/resignation/count", "HEAD", typeof(ResignationController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/all", "HEAD", typeof(ResignationController), "GetAll")]
        [InlineData("/api/hrm/resignation/all", "HEAD", typeof(ResignationController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/export", "HEAD", typeof(ResignationController), "Export")]
        [InlineData("/api/hrm/resignation/export", "HEAD", typeof(ResignationController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/1", "HEAD", typeof(ResignationController), "Get")]
        [InlineData("/api/hrm/resignation/1", "HEAD", typeof(ResignationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/get?resignationIds=1", "HEAD", typeof(ResignationController), "Get")]
        [InlineData("/api/hrm/resignation/get?resignationIds=1", "HEAD", typeof(ResignationController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation", "HEAD", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/resignation", "HEAD", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/page/1", "HEAD", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/hrm/resignation/page/1", "HEAD", typeof(ResignationController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/count-filtered/{filterName}", "HEAD", typeof(ResignationController), "CountFiltered")]
        [InlineData("/api/hrm/resignation/count-filtered/{filterName}", "HEAD", typeof(ResignationController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ResignationController), "GetFiltered")]
        [InlineData("/api/hrm/resignation/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ResignationController), "GetFiltered")]
        [InlineData("/api/hrm/resignation/first", "HEAD", typeof(ResignationController), "GetFirst")]
        [InlineData("/api/hrm/resignation/previous/1", "HEAD", typeof(ResignationController), "GetPrevious")]
        [InlineData("/api/hrm/resignation/next/1", "HEAD", typeof(ResignationController), "GetNext")]
        [InlineData("/api/hrm/resignation/last", "HEAD", typeof(ResignationController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/resignation/custom-fields", "HEAD", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/hrm/resignation/custom-fields", "HEAD", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/resignation/custom-fields/{resourceId}", "HEAD", typeof(ResignationController), "GetCustomFields")]
        [InlineData("/api/hrm/resignation/custom-fields/{resourceId}", "HEAD", typeof(ResignationController), "GetCustomFields")]

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

        public ResignationRouteTests()
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