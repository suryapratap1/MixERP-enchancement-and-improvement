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
    public class NationalityRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/nationality/delete/{nationalityCode}", "DELETE", typeof(NationalityController), "Delete")]
        [InlineData("/api/core/nationality/delete/{nationalityCode}", "DELETE", typeof(NationalityController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/edit/{nationalityCode}", "PUT", typeof(NationalityController), "Edit")]
        [InlineData("/api/core/nationality/edit/{nationalityCode}", "PUT", typeof(NationalityController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/count-where", "POST", typeof(NationalityController), "CountWhere")]
        [InlineData("/api/core/nationality/count-where", "POST", typeof(NationalityController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/get-where/{pageNumber}", "POST", typeof(NationalityController), "GetWhere")]
        [InlineData("/api/core/nationality/get-where/{pageNumber}", "POST", typeof(NationalityController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/add-or-edit", "POST", typeof(NationalityController), "AddOrEdit")]
        [InlineData("/api/core/nationality/add-or-edit", "POST", typeof(NationalityController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/add/{nationality}", "POST", typeof(NationalityController), "Add")]
        [InlineData("/api/core/nationality/add/{nationality}", "POST", typeof(NationalityController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/bulk-import", "POST", typeof(NationalityController), "BulkImport")]
        [InlineData("/api/core/nationality/bulk-import", "POST", typeof(NationalityController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/meta", "GET", typeof(NationalityController), "GetEntityView")]
        [InlineData("/api/core/nationality/meta", "GET", typeof(NationalityController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/count", "GET", typeof(NationalityController), "Count")]
        [InlineData("/api/core/nationality/count", "GET", typeof(NationalityController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/all", "GET", typeof(NationalityController), "GetAll")]
        [InlineData("/api/core/nationality/all", "GET", typeof(NationalityController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/export", "GET", typeof(NationalityController), "Export")]
        [InlineData("/api/core/nationality/export", "GET", typeof(NationalityController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/1", "GET", typeof(NationalityController), "Get")]
        [InlineData("/api/core/nationality/1", "GET", typeof(NationalityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/get?nationalityCodes=1", "GET", typeof(NationalityController), "Get")]
        [InlineData("/api/core/nationality/get?nationalityCodes=1", "GET", typeof(NationalityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/nationality", "GET", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/core/nationality", "GET", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/page/1", "GET", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/core/nationality/page/1", "GET", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/count-filtered/{filterName}", "GET", typeof(NationalityController), "CountFiltered")]
        [InlineData("/api/core/nationality/count-filtered/{filterName}", "GET", typeof(NationalityController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NationalityController), "GetFiltered")]
        [InlineData("/api/core/nationality/get-filtered/{pageNumber}/{filterName}", "GET", typeof(NationalityController), "GetFiltered")]
        [InlineData("/api/core/nationality/first", "GET", typeof(NationalityController), "GetFirst")]
        [InlineData("/api/core/nationality/previous/1", "GET", typeof(NationalityController), "GetPrevious")]
        [InlineData("/api/core/nationality/next/1", "GET", typeof(NationalityController), "GetNext")]
        [InlineData("/api/core/nationality/last", "GET", typeof(NationalityController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/nationality/custom-fields", "GET", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/core/nationality/custom-fields", "GET", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/custom-fields/{resourceId}", "GET", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/core/nationality/custom-fields/{resourceId}", "GET", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/meta", "HEAD", typeof(NationalityController), "GetEntityView")]
        [InlineData("/api/core/nationality/meta", "HEAD", typeof(NationalityController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/count", "HEAD", typeof(NationalityController), "Count")]
        [InlineData("/api/core/nationality/count", "HEAD", typeof(NationalityController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/all", "HEAD", typeof(NationalityController), "GetAll")]
        [InlineData("/api/core/nationality/all", "HEAD", typeof(NationalityController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/export", "HEAD", typeof(NationalityController), "Export")]
        [InlineData("/api/core/nationality/export", "HEAD", typeof(NationalityController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/1", "HEAD", typeof(NationalityController), "Get")]
        [InlineData("/api/core/nationality/1", "HEAD", typeof(NationalityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/get?nationalityCodes=1", "HEAD", typeof(NationalityController), "Get")]
        [InlineData("/api/core/nationality/get?nationalityCodes=1", "HEAD", typeof(NationalityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/nationality", "HEAD", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/core/nationality", "HEAD", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/page/1", "HEAD", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/core/nationality/page/1", "HEAD", typeof(NationalityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/count-filtered/{filterName}", "HEAD", typeof(NationalityController), "CountFiltered")]
        [InlineData("/api/core/nationality/count-filtered/{filterName}", "HEAD", typeof(NationalityController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NationalityController), "GetFiltered")]
        [InlineData("/api/core/nationality/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(NationalityController), "GetFiltered")]
        [InlineData("/api/core/nationality/first", "HEAD", typeof(NationalityController), "GetFirst")]
        [InlineData("/api/core/nationality/previous/1", "HEAD", typeof(NationalityController), "GetPrevious")]
        [InlineData("/api/core/nationality/next/1", "HEAD", typeof(NationalityController), "GetNext")]
        [InlineData("/api/core/nationality/last", "HEAD", typeof(NationalityController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/nationality/custom-fields", "HEAD", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/core/nationality/custom-fields", "HEAD", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/nationality/custom-fields/{resourceId}", "HEAD", typeof(NationalityController), "GetCustomFields")]
        [InlineData("/api/core/nationality/custom-fields/{resourceId}", "HEAD", typeof(NationalityController), "GetCustomFields")]

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

        public NationalityRouteTests()
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