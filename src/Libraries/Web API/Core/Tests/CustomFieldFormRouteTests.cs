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
    public class CustomFieldFormRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/delete/{formName}", "DELETE", typeof(CustomFieldFormController), "Delete")]
        [InlineData("/api/core/custom-field-form/delete/{formName}", "DELETE", typeof(CustomFieldFormController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/edit/{formName}", "PUT", typeof(CustomFieldFormController), "Edit")]
        [InlineData("/api/core/custom-field-form/edit/{formName}", "PUT", typeof(CustomFieldFormController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/count-where", "POST", typeof(CustomFieldFormController), "CountWhere")]
        [InlineData("/api/core/custom-field-form/count-where", "POST", typeof(CustomFieldFormController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/get-where/{pageNumber}", "POST", typeof(CustomFieldFormController), "GetWhere")]
        [InlineData("/api/core/custom-field-form/get-where/{pageNumber}", "POST", typeof(CustomFieldFormController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/add-or-edit", "POST", typeof(CustomFieldFormController), "AddOrEdit")]
        [InlineData("/api/core/custom-field-form/add-or-edit", "POST", typeof(CustomFieldFormController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/add/{customFieldForm}", "POST", typeof(CustomFieldFormController), "Add")]
        [InlineData("/api/core/custom-field-form/add/{customFieldForm}", "POST", typeof(CustomFieldFormController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/bulk-import", "POST", typeof(CustomFieldFormController), "BulkImport")]
        [InlineData("/api/core/custom-field-form/bulk-import", "POST", typeof(CustomFieldFormController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/meta", "GET", typeof(CustomFieldFormController), "GetEntityView")]
        [InlineData("/api/core/custom-field-form/meta", "GET", typeof(CustomFieldFormController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/count", "GET", typeof(CustomFieldFormController), "Count")]
        [InlineData("/api/core/custom-field-form/count", "GET", typeof(CustomFieldFormController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/all", "GET", typeof(CustomFieldFormController), "GetAll")]
        [InlineData("/api/core/custom-field-form/all", "GET", typeof(CustomFieldFormController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/export", "GET", typeof(CustomFieldFormController), "Export")]
        [InlineData("/api/core/custom-field-form/export", "GET", typeof(CustomFieldFormController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/1", "GET", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/core/custom-field-form/1", "GET", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/get?formNames=1", "GET", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/core/custom-field-form/get?formNames=1", "GET", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form", "GET", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-form", "GET", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/page/1", "GET", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-form/page/1", "GET", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/count-filtered/{filterName}", "GET", typeof(CustomFieldFormController), "CountFiltered")]
        [InlineData("/api/core/custom-field-form/count-filtered/{filterName}", "GET", typeof(CustomFieldFormController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CustomFieldFormController), "GetFiltered")]
        [InlineData("/api/core/custom-field-form/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CustomFieldFormController), "GetFiltered")]
        [InlineData("/api/core/custom-field-form/first", "GET", typeof(CustomFieldFormController), "GetFirst")]
        [InlineData("/api/core/custom-field-form/previous/1", "GET", typeof(CustomFieldFormController), "GetPrevious")]
        [InlineData("/api/core/custom-field-form/next/1", "GET", typeof(CustomFieldFormController), "GetNext")]
        [InlineData("/api/core/custom-field-form/last", "GET", typeof(CustomFieldFormController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/custom-fields", "GET", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-form/custom-fields", "GET", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/custom-fields/{resourceId}", "GET", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-form/custom-fields/{resourceId}", "GET", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/meta", "HEAD", typeof(CustomFieldFormController), "GetEntityView")]
        [InlineData("/api/core/custom-field-form/meta", "HEAD", typeof(CustomFieldFormController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/count", "HEAD", typeof(CustomFieldFormController), "Count")]
        [InlineData("/api/core/custom-field-form/count", "HEAD", typeof(CustomFieldFormController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/all", "HEAD", typeof(CustomFieldFormController), "GetAll")]
        [InlineData("/api/core/custom-field-form/all", "HEAD", typeof(CustomFieldFormController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/export", "HEAD", typeof(CustomFieldFormController), "Export")]
        [InlineData("/api/core/custom-field-form/export", "HEAD", typeof(CustomFieldFormController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/1", "HEAD", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/core/custom-field-form/1", "HEAD", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/get?formNames=1", "HEAD", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/core/custom-field-form/get?formNames=1", "HEAD", typeof(CustomFieldFormController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form", "HEAD", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-form", "HEAD", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/page/1", "HEAD", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/core/custom-field-form/page/1", "HEAD", typeof(CustomFieldFormController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/count-filtered/{filterName}", "HEAD", typeof(CustomFieldFormController), "CountFiltered")]
        [InlineData("/api/core/custom-field-form/count-filtered/{filterName}", "HEAD", typeof(CustomFieldFormController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CustomFieldFormController), "GetFiltered")]
        [InlineData("/api/core/custom-field-form/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CustomFieldFormController), "GetFiltered")]
        [InlineData("/api/core/custom-field-form/first", "HEAD", typeof(CustomFieldFormController), "GetFirst")]
        [InlineData("/api/core/custom-field-form/previous/1", "HEAD", typeof(CustomFieldFormController), "GetPrevious")]
        [InlineData("/api/core/custom-field-form/next/1", "HEAD", typeof(CustomFieldFormController), "GetNext")]
        [InlineData("/api/core/custom-field-form/last", "HEAD", typeof(CustomFieldFormController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/custom-fields", "HEAD", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-form/custom-fields", "HEAD", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/custom-field-form/custom-fields/{resourceId}", "HEAD", typeof(CustomFieldFormController), "GetCustomFields")]
        [InlineData("/api/core/custom-field-form/custom-fields/{resourceId}", "HEAD", typeof(CustomFieldFormController), "GetCustomFields")]

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

        public CustomFieldFormRouteTests()
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