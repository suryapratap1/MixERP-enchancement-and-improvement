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
    public class CustomFieldDataTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/delete/{dataType}", "DELETE", typeof(CustomFieldDataTypeController), "Delete")]
        [InlineData("/api/core/custom-field-data-type/delete/{dataType}", "DELETE", typeof(CustomFieldDataTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/edit/{dataType}", "PUT", typeof(CustomFieldDataTypeController), "Edit")]
        [InlineData("/api/core/custom-field-data-type/edit/{dataType}", "PUT", typeof(CustomFieldDataTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/count-where", "POST", typeof(CustomFieldDataTypeController), "CountWhere")]
        [InlineData("/api/core/custom-field-data-type/count-where", "POST", typeof(CustomFieldDataTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/get-where/{pageNumber}", "POST", typeof(CustomFieldDataTypeController), "GetWhere")]
        [InlineData("/api/core/custom-field-data-type/get-where/{pageNumber}", "POST", typeof(CustomFieldDataTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/add-or-edit", "POST", typeof(CustomFieldDataTypeController), "AddOrEdit")]
        [InlineData("/api/core/custom-field-data-type/add-or-edit", "POST", typeof(CustomFieldDataTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/add/{customFieldDataType}", "POST", typeof(CustomFieldDataTypeController), "Add")]
        [InlineData("/api/core/custom-field-data-type/add/{customFieldDataType}", "POST", typeof(CustomFieldDataTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/bulk-import", "POST", typeof(CustomFieldDataTypeController), "BulkImport")]
        [InlineData("/api/core/custom-field-data-type/bulk-import", "POST", typeof(CustomFieldDataTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/meta", "GET", typeof(CustomFieldDataTypeController), "GetEntityView")]
        [InlineData("/api/core/custom-field-data-type/meta", "GET", typeof(CustomFieldDataTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/count", "GET", typeof(CustomFieldDataTypeController), "Count")]
        [InlineData("/api/core/custom-field-data-type/count", "GET", typeof(CustomFieldDataTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/all", "GET", typeof(CustomFieldDataTypeController), "GetAll")]
        [InlineData("/api/core/custom-field-data-type/all", "GET", typeof(CustomFieldDataTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/export", "GET", typeof(CustomFieldDataTypeController), "Export")]
        [InlineData("/api/core/custom-field-data-type/export", "GET", typeof(CustomFieldDataTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/1", "GET", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/core/custom-field-data-type/1", "GET", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/get?dataTypes=1", "GET", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/core/custom-field-data-type/get?dataTypes=1", "GET", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type", "GET", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-data-type", "GET", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/page/1", "GET", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-data-type/page/1", "GET", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/count-filtered/{filterName}", "GET", typeof(CustomFieldDataTypeController), "CountFiltered")]
        [InlineData("/api/core/custom-field-data-type/count-filtered/{filterName}", "GET", typeof(CustomFieldDataTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CustomFieldDataTypeController), "GetFiltered")]
        [InlineData("/api/core/custom-field-data-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CustomFieldDataTypeController), "GetFiltered")]
        [InlineData("/api/core/custom-field-data-type/first", "GET", typeof(CustomFieldDataTypeController), "GetFirst")]
        [InlineData("/api/core/custom-field-data-type/previous/1", "GET", typeof(CustomFieldDataTypeController), "GetPrevious")]
        [InlineData("/api/core/custom-field-data-type/next/1", "GET", typeof(CustomFieldDataTypeController), "GetNext")]
        [InlineData("/api/core/custom-field-data-type/last", "GET", typeof(CustomFieldDataTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/custom-fields", "GET", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-data-type/custom-fields", "GET", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/custom-fields/{resourceId}", "GET", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-data-type/custom-fields/{resourceId}", "GET", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/meta", "HEAD", typeof(CustomFieldDataTypeController), "GetEntityView")]
        [InlineData("/api/core/custom-field-data-type/meta", "HEAD", typeof(CustomFieldDataTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/count", "HEAD", typeof(CustomFieldDataTypeController), "Count")]
        [InlineData("/api/core/custom-field-data-type/count", "HEAD", typeof(CustomFieldDataTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/all", "HEAD", typeof(CustomFieldDataTypeController), "GetAll")]
        [InlineData("/api/core/custom-field-data-type/all", "HEAD", typeof(CustomFieldDataTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/export", "HEAD", typeof(CustomFieldDataTypeController), "Export")]
        [InlineData("/api/core/custom-field-data-type/export", "HEAD", typeof(CustomFieldDataTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/1", "HEAD", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/core/custom-field-data-type/1", "HEAD", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/get?dataTypes=1", "HEAD", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/core/custom-field-data-type/get?dataTypes=1", "HEAD", typeof(CustomFieldDataTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type", "HEAD", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-data-type", "HEAD", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/page/1", "HEAD", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-data-type/page/1", "HEAD", typeof(CustomFieldDataTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/count-filtered/{filterName}", "HEAD", typeof(CustomFieldDataTypeController), "CountFiltered")]
        [InlineData("/api/core/custom-field-data-type/count-filtered/{filterName}", "HEAD", typeof(CustomFieldDataTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CustomFieldDataTypeController), "GetFiltered")]
        [InlineData("/api/core/custom-field-data-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CustomFieldDataTypeController), "GetFiltered")]
        [InlineData("/api/core/custom-field-data-type/first", "HEAD", typeof(CustomFieldDataTypeController), "GetFirst")]
        [InlineData("/api/core/custom-field-data-type/previous/1", "HEAD", typeof(CustomFieldDataTypeController), "GetPrevious")]
        [InlineData("/api/core/custom-field-data-type/next/1", "HEAD", typeof(CustomFieldDataTypeController), "GetNext")]
        [InlineData("/api/core/custom-field-data-type/last", "HEAD", typeof(CustomFieldDataTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/custom-fields", "HEAD", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-data-type/custom-fields", "HEAD", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-data-type/custom-fields/{resourceId}", "HEAD", typeof(CustomFieldDataTypeController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-data-type/custom-fields/{resourceId}", "HEAD", typeof(CustomFieldDataTypeController), "GetCustomFields")]

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

        public CustomFieldDataTypeRouteTests()
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