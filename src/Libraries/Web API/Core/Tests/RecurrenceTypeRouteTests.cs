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
    public class RecurrenceTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/delete/{recurrenceTypeId}", "DELETE", typeof(RecurrenceTypeController), "Delete")]
        [InlineData("/api/core/recurrence-type/delete/{recurrenceTypeId}", "DELETE", typeof(RecurrenceTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/edit/{recurrenceTypeId}", "PUT", typeof(RecurrenceTypeController), "Edit")]
        [InlineData("/api/core/recurrence-type/edit/{recurrenceTypeId}", "PUT", typeof(RecurrenceTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/count-where", "POST", typeof(RecurrenceTypeController), "CountWhere")]
        [InlineData("/api/core/recurrence-type/count-where", "POST", typeof(RecurrenceTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/get-where/{pageNumber}", "POST", typeof(RecurrenceTypeController), "GetWhere")]
        [InlineData("/api/core/recurrence-type/get-where/{pageNumber}", "POST", typeof(RecurrenceTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/add-or-edit", "POST", typeof(RecurrenceTypeController), "AddOrEdit")]
        [InlineData("/api/core/recurrence-type/add-or-edit", "POST", typeof(RecurrenceTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/add/{recurrenceType}", "POST", typeof(RecurrenceTypeController), "Add")]
        [InlineData("/api/core/recurrence-type/add/{recurrenceType}", "POST", typeof(RecurrenceTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/bulk-import", "POST", typeof(RecurrenceTypeController), "BulkImport")]
        [InlineData("/api/core/recurrence-type/bulk-import", "POST", typeof(RecurrenceTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/meta", "GET", typeof(RecurrenceTypeController), "GetEntityView")]
        [InlineData("/api/core/recurrence-type/meta", "GET", typeof(RecurrenceTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/count", "GET", typeof(RecurrenceTypeController), "Count")]
        [InlineData("/api/core/recurrence-type/count", "GET", typeof(RecurrenceTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/all", "GET", typeof(RecurrenceTypeController), "GetAll")]
        [InlineData("/api/core/recurrence-type/all", "GET", typeof(RecurrenceTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/export", "GET", typeof(RecurrenceTypeController), "Export")]
        [InlineData("/api/core/recurrence-type/export", "GET", typeof(RecurrenceTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/1", "GET", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/core/recurrence-type/1", "GET", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/get?recurrenceTypeIds=1", "GET", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/core/recurrence-type/get?recurrenceTypeIds=1", "GET", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type", "GET", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/recurrence-type", "GET", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/page/1", "GET", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/recurrence-type/page/1", "GET", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/count-filtered/{filterName}", "GET", typeof(RecurrenceTypeController), "CountFiltered")]
        [InlineData("/api/core/recurrence-type/count-filtered/{filterName}", "GET", typeof(RecurrenceTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RecurrenceTypeController), "GetFiltered")]
        [InlineData("/api/core/recurrence-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(RecurrenceTypeController), "GetFiltered")]
        [InlineData("/api/core/recurrence-type/first", "GET", typeof(RecurrenceTypeController), "GetFirst")]
        [InlineData("/api/core/recurrence-type/previous/1", "GET", typeof(RecurrenceTypeController), "GetPrevious")]
        [InlineData("/api/core/recurrence-type/next/1", "GET", typeof(RecurrenceTypeController), "GetNext")]
        [InlineData("/api/core/recurrence-type/last", "GET", typeof(RecurrenceTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/custom-fields", "GET", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/core/recurrence-type/custom-fields", "GET", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/custom-fields/{resourceId}", "GET", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/core/recurrence-type/custom-fields/{resourceId}", "GET", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/meta", "HEAD", typeof(RecurrenceTypeController), "GetEntityView")]
        [InlineData("/api/core/recurrence-type/meta", "HEAD", typeof(RecurrenceTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/count", "HEAD", typeof(RecurrenceTypeController), "Count")]
        [InlineData("/api/core/recurrence-type/count", "HEAD", typeof(RecurrenceTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/all", "HEAD", typeof(RecurrenceTypeController), "GetAll")]
        [InlineData("/api/core/recurrence-type/all", "HEAD", typeof(RecurrenceTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/export", "HEAD", typeof(RecurrenceTypeController), "Export")]
        [InlineData("/api/core/recurrence-type/export", "HEAD", typeof(RecurrenceTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/1", "HEAD", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/core/recurrence-type/1", "HEAD", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/get?recurrenceTypeIds=1", "HEAD", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/core/recurrence-type/get?recurrenceTypeIds=1", "HEAD", typeof(RecurrenceTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type", "HEAD", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/recurrence-type", "HEAD", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/page/1", "HEAD", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/recurrence-type/page/1", "HEAD", typeof(RecurrenceTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/count-filtered/{filterName}", "HEAD", typeof(RecurrenceTypeController), "CountFiltered")]
        [InlineData("/api/core/recurrence-type/count-filtered/{filterName}", "HEAD", typeof(RecurrenceTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RecurrenceTypeController), "GetFiltered")]
        [InlineData("/api/core/recurrence-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(RecurrenceTypeController), "GetFiltered")]
        [InlineData("/api/core/recurrence-type/first", "HEAD", typeof(RecurrenceTypeController), "GetFirst")]
        [InlineData("/api/core/recurrence-type/previous/1", "HEAD", typeof(RecurrenceTypeController), "GetPrevious")]
        [InlineData("/api/core/recurrence-type/next/1", "HEAD", typeof(RecurrenceTypeController), "GetNext")]
        [InlineData("/api/core/recurrence-type/last", "HEAD", typeof(RecurrenceTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/custom-fields", "HEAD", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/core/recurrence-type/custom-fields", "HEAD", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/recurrence-type/custom-fields/{resourceId}", "HEAD", typeof(RecurrenceTypeController), "GetCustomFields")]
        [InlineData("/api/core/recurrence-type/custom-fields/{resourceId}", "HEAD", typeof(RecurrenceTypeController), "GetCustomFields")]

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

        public RecurrenceTypeRouteTests()
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