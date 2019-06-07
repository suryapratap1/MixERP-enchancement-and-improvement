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
    public class IdentificationTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/delete/{identificationTypeCode}", "DELETE", typeof(IdentificationTypeController), "Delete")]
        [InlineData("/api/core/identification-type/delete/{identificationTypeCode}", "DELETE", typeof(IdentificationTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/edit/{identificationTypeCode}", "PUT", typeof(IdentificationTypeController), "Edit")]
        [InlineData("/api/core/identification-type/edit/{identificationTypeCode}", "PUT", typeof(IdentificationTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/count-where", "POST", typeof(IdentificationTypeController), "CountWhere")]
        [InlineData("/api/core/identification-type/count-where", "POST", typeof(IdentificationTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/get-where/{pageNumber}", "POST", typeof(IdentificationTypeController), "GetWhere")]
        [InlineData("/api/core/identification-type/get-where/{pageNumber}", "POST", typeof(IdentificationTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/add-or-edit", "POST", typeof(IdentificationTypeController), "AddOrEdit")]
        [InlineData("/api/core/identification-type/add-or-edit", "POST", typeof(IdentificationTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/add/{identificationType}", "POST", typeof(IdentificationTypeController), "Add")]
        [InlineData("/api/core/identification-type/add/{identificationType}", "POST", typeof(IdentificationTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/bulk-import", "POST", typeof(IdentificationTypeController), "BulkImport")]
        [InlineData("/api/core/identification-type/bulk-import", "POST", typeof(IdentificationTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/meta", "GET", typeof(IdentificationTypeController), "GetEntityView")]
        [InlineData("/api/core/identification-type/meta", "GET", typeof(IdentificationTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/count", "GET", typeof(IdentificationTypeController), "Count")]
        [InlineData("/api/core/identification-type/count", "GET", typeof(IdentificationTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/all", "GET", typeof(IdentificationTypeController), "GetAll")]
        [InlineData("/api/core/identification-type/all", "GET", typeof(IdentificationTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/export", "GET", typeof(IdentificationTypeController), "Export")]
        [InlineData("/api/core/identification-type/export", "GET", typeof(IdentificationTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/1", "GET", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/core/identification-type/1", "GET", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/get?identificationTypeCodes=1", "GET", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/core/identification-type/get?identificationTypeCodes=1", "GET", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type", "GET", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/identification-type", "GET", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/page/1", "GET", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/identification-type/page/1", "GET", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/count-filtered/{filterName}", "GET", typeof(IdentificationTypeController), "CountFiltered")]
        [InlineData("/api/core/identification-type/count-filtered/{filterName}", "GET", typeof(IdentificationTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(IdentificationTypeController), "GetFiltered")]
        [InlineData("/api/core/identification-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(IdentificationTypeController), "GetFiltered")]
        [InlineData("/api/core/identification-type/first", "GET", typeof(IdentificationTypeController), "GetFirst")]
        [InlineData("/api/core/identification-type/previous/1", "GET", typeof(IdentificationTypeController), "GetPrevious")]
        [InlineData("/api/core/identification-type/next/1", "GET", typeof(IdentificationTypeController), "GetNext")]
        [InlineData("/api/core/identification-type/last", "GET", typeof(IdentificationTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/identification-type/custom-fields", "GET", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/core/identification-type/custom-fields", "GET", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/custom-fields/{resourceId}", "GET", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/core/identification-type/custom-fields/{resourceId}", "GET", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/meta", "HEAD", typeof(IdentificationTypeController), "GetEntityView")]
        [InlineData("/api/core/identification-type/meta", "HEAD", typeof(IdentificationTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/count", "HEAD", typeof(IdentificationTypeController), "Count")]
        [InlineData("/api/core/identification-type/count", "HEAD", typeof(IdentificationTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/all", "HEAD", typeof(IdentificationTypeController), "GetAll")]
        [InlineData("/api/core/identification-type/all", "HEAD", typeof(IdentificationTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/export", "HEAD", typeof(IdentificationTypeController), "Export")]
        [InlineData("/api/core/identification-type/export", "HEAD", typeof(IdentificationTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/1", "HEAD", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/core/identification-type/1", "HEAD", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/get?identificationTypeCodes=1", "HEAD", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/core/identification-type/get?identificationTypeCodes=1", "HEAD", typeof(IdentificationTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type", "HEAD", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/identification-type", "HEAD", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/page/1", "HEAD", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/identification-type/page/1", "HEAD", typeof(IdentificationTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/count-filtered/{filterName}", "HEAD", typeof(IdentificationTypeController), "CountFiltered")]
        [InlineData("/api/core/identification-type/count-filtered/{filterName}", "HEAD", typeof(IdentificationTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(IdentificationTypeController), "GetFiltered")]
        [InlineData("/api/core/identification-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(IdentificationTypeController), "GetFiltered")]
        [InlineData("/api/core/identification-type/first", "HEAD", typeof(IdentificationTypeController), "GetFirst")]
        [InlineData("/api/core/identification-type/previous/1", "HEAD", typeof(IdentificationTypeController), "GetPrevious")]
        [InlineData("/api/core/identification-type/next/1", "HEAD", typeof(IdentificationTypeController), "GetNext")]
        [InlineData("/api/core/identification-type/last", "HEAD", typeof(IdentificationTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/identification-type/custom-fields", "HEAD", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/core/identification-type/custom-fields", "HEAD", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/identification-type/custom-fields/{resourceId}", "HEAD", typeof(IdentificationTypeController), "GetCustomFields")]
        [InlineData("/api/core/identification-type/custom-fields/{resourceId}", "HEAD", typeof(IdentificationTypeController), "GetCustomFields")]

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

        public IdentificationTypeRouteTests()
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