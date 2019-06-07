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
    public class LeaveBenefitRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/delete/{leaveBenefitId}", "DELETE", typeof(LeaveBenefitController), "Delete")]
        [InlineData("/api/hrm/leave-benefit/delete/{leaveBenefitId}", "DELETE", typeof(LeaveBenefitController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/edit/{leaveBenefitId}", "PUT", typeof(LeaveBenefitController), "Edit")]
        [InlineData("/api/hrm/leave-benefit/edit/{leaveBenefitId}", "PUT", typeof(LeaveBenefitController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/count-where", "POST", typeof(LeaveBenefitController), "CountWhere")]
        [InlineData("/api/hrm/leave-benefit/count-where", "POST", typeof(LeaveBenefitController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/get-where/{pageNumber}", "POST", typeof(LeaveBenefitController), "GetWhere")]
        [InlineData("/api/hrm/leave-benefit/get-where/{pageNumber}", "POST", typeof(LeaveBenefitController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/add-or-edit", "POST", typeof(LeaveBenefitController), "AddOrEdit")]
        [InlineData("/api/hrm/leave-benefit/add-or-edit", "POST", typeof(LeaveBenefitController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/add/{leaveBenefit}", "POST", typeof(LeaveBenefitController), "Add")]
        [InlineData("/api/hrm/leave-benefit/add/{leaveBenefit}", "POST", typeof(LeaveBenefitController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/bulk-import", "POST", typeof(LeaveBenefitController), "BulkImport")]
        [InlineData("/api/hrm/leave-benefit/bulk-import", "POST", typeof(LeaveBenefitController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/meta", "GET", typeof(LeaveBenefitController), "GetEntityView")]
        [InlineData("/api/hrm/leave-benefit/meta", "GET", typeof(LeaveBenefitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/count", "GET", typeof(LeaveBenefitController), "Count")]
        [InlineData("/api/hrm/leave-benefit/count", "GET", typeof(LeaveBenefitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/all", "GET", typeof(LeaveBenefitController), "GetAll")]
        [InlineData("/api/hrm/leave-benefit/all", "GET", typeof(LeaveBenefitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/export", "GET", typeof(LeaveBenefitController), "Export")]
        [InlineData("/api/hrm/leave-benefit/export", "GET", typeof(LeaveBenefitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/1", "GET", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/hrm/leave-benefit/1", "GET", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/get?leaveBenefitIds=1", "GET", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/hrm/leave-benefit/get?leaveBenefitIds=1", "GET", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit", "GET", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-benefit", "GET", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/page/1", "GET", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-benefit/page/1", "GET", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/count-filtered/{filterName}", "GET", typeof(LeaveBenefitController), "CountFiltered")]
        [InlineData("/api/hrm/leave-benefit/count-filtered/{filterName}", "GET", typeof(LeaveBenefitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LeaveBenefitController), "GetFiltered")]
        [InlineData("/api/hrm/leave-benefit/get-filtered/{pageNumber}/{filterName}", "GET", typeof(LeaveBenefitController), "GetFiltered")]
        [InlineData("/api/hrm/leave-benefit/first", "GET", typeof(LeaveBenefitController), "GetFirst")]
        [InlineData("/api/hrm/leave-benefit/previous/1", "GET", typeof(LeaveBenefitController), "GetPrevious")]
        [InlineData("/api/hrm/leave-benefit/next/1", "GET", typeof(LeaveBenefitController), "GetNext")]
        [InlineData("/api/hrm/leave-benefit/last", "GET", typeof(LeaveBenefitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/custom-fields", "GET", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-benefit/custom-fields", "GET", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/custom-fields/{resourceId}", "GET", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-benefit/custom-fields/{resourceId}", "GET", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/meta", "HEAD", typeof(LeaveBenefitController), "GetEntityView")]
        [InlineData("/api/hrm/leave-benefit/meta", "HEAD", typeof(LeaveBenefitController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/count", "HEAD", typeof(LeaveBenefitController), "Count")]
        [InlineData("/api/hrm/leave-benefit/count", "HEAD", typeof(LeaveBenefitController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/all", "HEAD", typeof(LeaveBenefitController), "GetAll")]
        [InlineData("/api/hrm/leave-benefit/all", "HEAD", typeof(LeaveBenefitController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/export", "HEAD", typeof(LeaveBenefitController), "Export")]
        [InlineData("/api/hrm/leave-benefit/export", "HEAD", typeof(LeaveBenefitController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/1", "HEAD", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/hrm/leave-benefit/1", "HEAD", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/get?leaveBenefitIds=1", "HEAD", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/hrm/leave-benefit/get?leaveBenefitIds=1", "HEAD", typeof(LeaveBenefitController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit", "HEAD", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-benefit", "HEAD", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/page/1", "HEAD", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/hrm/leave-benefit/page/1", "HEAD", typeof(LeaveBenefitController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/count-filtered/{filterName}", "HEAD", typeof(LeaveBenefitController), "CountFiltered")]
        [InlineData("/api/hrm/leave-benefit/count-filtered/{filterName}", "HEAD", typeof(LeaveBenefitController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LeaveBenefitController), "GetFiltered")]
        [InlineData("/api/hrm/leave-benefit/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(LeaveBenefitController), "GetFiltered")]
        [InlineData("/api/hrm/leave-benefit/first", "HEAD", typeof(LeaveBenefitController), "GetFirst")]
        [InlineData("/api/hrm/leave-benefit/previous/1", "HEAD", typeof(LeaveBenefitController), "GetPrevious")]
        [InlineData("/api/hrm/leave-benefit/next/1", "HEAD", typeof(LeaveBenefitController), "GetNext")]
        [InlineData("/api/hrm/leave-benefit/last", "HEAD", typeof(LeaveBenefitController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/custom-fields", "HEAD", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-benefit/custom-fields", "HEAD", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/leave-benefit/custom-fields/{resourceId}", "HEAD", typeof(LeaveBenefitController), "GetCustomFields")]
        [InlineData("/api/hrm/leave-benefit/custom-fields/{resourceId}", "HEAD", typeof(LeaveBenefitController), "GetCustomFields")]

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

        public LeaveBenefitRouteTests()
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