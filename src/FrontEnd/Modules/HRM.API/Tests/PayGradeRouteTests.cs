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
    public class PayGradeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/delete/{payGradeId}", "DELETE", typeof(PayGradeController), "Delete")]
        [InlineData("/api/hrm/pay-grade/delete/{payGradeId}", "DELETE", typeof(PayGradeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/edit/{payGradeId}", "PUT", typeof(PayGradeController), "Edit")]
        [InlineData("/api/hrm/pay-grade/edit/{payGradeId}", "PUT", typeof(PayGradeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/count-where", "POST", typeof(PayGradeController), "CountWhere")]
        [InlineData("/api/hrm/pay-grade/count-where", "POST", typeof(PayGradeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/get-where/{pageNumber}", "POST", typeof(PayGradeController), "GetWhere")]
        [InlineData("/api/hrm/pay-grade/get-where/{pageNumber}", "POST", typeof(PayGradeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/add-or-edit", "POST", typeof(PayGradeController), "AddOrEdit")]
        [InlineData("/api/hrm/pay-grade/add-or-edit", "POST", typeof(PayGradeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/add/{payGrade}", "POST", typeof(PayGradeController), "Add")]
        [InlineData("/api/hrm/pay-grade/add/{payGrade}", "POST", typeof(PayGradeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/bulk-import", "POST", typeof(PayGradeController), "BulkImport")]
        [InlineData("/api/hrm/pay-grade/bulk-import", "POST", typeof(PayGradeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/meta", "GET", typeof(PayGradeController), "GetEntityView")]
        [InlineData("/api/hrm/pay-grade/meta", "GET", typeof(PayGradeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/count", "GET", typeof(PayGradeController), "Count")]
        [InlineData("/api/hrm/pay-grade/count", "GET", typeof(PayGradeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/all", "GET", typeof(PayGradeController), "GetAll")]
        [InlineData("/api/hrm/pay-grade/all", "GET", typeof(PayGradeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/export", "GET", typeof(PayGradeController), "Export")]
        [InlineData("/api/hrm/pay-grade/export", "GET", typeof(PayGradeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/1", "GET", typeof(PayGradeController), "Get")]
        [InlineData("/api/hrm/pay-grade/1", "GET", typeof(PayGradeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/get?payGradeIds=1", "GET", typeof(PayGradeController), "Get")]
        [InlineData("/api/hrm/pay-grade/get?payGradeIds=1", "GET", typeof(PayGradeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade", "GET", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/pay-grade", "GET", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/page/1", "GET", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/pay-grade/page/1", "GET", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/count-filtered/{filterName}", "GET", typeof(PayGradeController), "CountFiltered")]
        [InlineData("/api/hrm/pay-grade/count-filtered/{filterName}", "GET", typeof(PayGradeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PayGradeController), "GetFiltered")]
        [InlineData("/api/hrm/pay-grade/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PayGradeController), "GetFiltered")]
        [InlineData("/api/hrm/pay-grade/first", "GET", typeof(PayGradeController), "GetFirst")]
        [InlineData("/api/hrm/pay-grade/previous/1", "GET", typeof(PayGradeController), "GetPrevious")]
        [InlineData("/api/hrm/pay-grade/next/1", "GET", typeof(PayGradeController), "GetNext")]
        [InlineData("/api/hrm/pay-grade/last", "GET", typeof(PayGradeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/custom-fields", "GET", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/hrm/pay-grade/custom-fields", "GET", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/custom-fields/{resourceId}", "GET", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/hrm/pay-grade/custom-fields/{resourceId}", "GET", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/meta", "HEAD", typeof(PayGradeController), "GetEntityView")]
        [InlineData("/api/hrm/pay-grade/meta", "HEAD", typeof(PayGradeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/count", "HEAD", typeof(PayGradeController), "Count")]
        [InlineData("/api/hrm/pay-grade/count", "HEAD", typeof(PayGradeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/all", "HEAD", typeof(PayGradeController), "GetAll")]
        [InlineData("/api/hrm/pay-grade/all", "HEAD", typeof(PayGradeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/export", "HEAD", typeof(PayGradeController), "Export")]
        [InlineData("/api/hrm/pay-grade/export", "HEAD", typeof(PayGradeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/1", "HEAD", typeof(PayGradeController), "Get")]
        [InlineData("/api/hrm/pay-grade/1", "HEAD", typeof(PayGradeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/get?payGradeIds=1", "HEAD", typeof(PayGradeController), "Get")]
        [InlineData("/api/hrm/pay-grade/get?payGradeIds=1", "HEAD", typeof(PayGradeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade", "HEAD", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/pay-grade", "HEAD", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/page/1", "HEAD", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/hrm/pay-grade/page/1", "HEAD", typeof(PayGradeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/count-filtered/{filterName}", "HEAD", typeof(PayGradeController), "CountFiltered")]
        [InlineData("/api/hrm/pay-grade/count-filtered/{filterName}", "HEAD", typeof(PayGradeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PayGradeController), "GetFiltered")]
        [InlineData("/api/hrm/pay-grade/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PayGradeController), "GetFiltered")]
        [InlineData("/api/hrm/pay-grade/first", "HEAD", typeof(PayGradeController), "GetFirst")]
        [InlineData("/api/hrm/pay-grade/previous/1", "HEAD", typeof(PayGradeController), "GetPrevious")]
        [InlineData("/api/hrm/pay-grade/next/1", "HEAD", typeof(PayGradeController), "GetNext")]
        [InlineData("/api/hrm/pay-grade/last", "HEAD", typeof(PayGradeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/custom-fields", "HEAD", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/hrm/pay-grade/custom-fields", "HEAD", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/pay-grade/custom-fields/{resourceId}", "HEAD", typeof(PayGradeController), "GetCustomFields")]
        [InlineData("/api/hrm/pay-grade/custom-fields/{resourceId}", "HEAD", typeof(PayGradeController), "GetCustomFields")]

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

        public PayGradeRouteTests()
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