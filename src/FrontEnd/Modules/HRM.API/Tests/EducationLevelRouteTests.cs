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
    public class EducationLevelRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/delete/{educationLevelId}", "DELETE", typeof(EducationLevelController), "Delete")]
        [InlineData("/api/hrm/education-level/delete/{educationLevelId}", "DELETE", typeof(EducationLevelController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/edit/{educationLevelId}", "PUT", typeof(EducationLevelController), "Edit")]
        [InlineData("/api/hrm/education-level/edit/{educationLevelId}", "PUT", typeof(EducationLevelController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/count-where", "POST", typeof(EducationLevelController), "CountWhere")]
        [InlineData("/api/hrm/education-level/count-where", "POST", typeof(EducationLevelController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/get-where/{pageNumber}", "POST", typeof(EducationLevelController), "GetWhere")]
        [InlineData("/api/hrm/education-level/get-where/{pageNumber}", "POST", typeof(EducationLevelController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/add-or-edit", "POST", typeof(EducationLevelController), "AddOrEdit")]
        [InlineData("/api/hrm/education-level/add-or-edit", "POST", typeof(EducationLevelController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/add/{educationLevel}", "POST", typeof(EducationLevelController), "Add")]
        [InlineData("/api/hrm/education-level/add/{educationLevel}", "POST", typeof(EducationLevelController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/bulk-import", "POST", typeof(EducationLevelController), "BulkImport")]
        [InlineData("/api/hrm/education-level/bulk-import", "POST", typeof(EducationLevelController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/meta", "GET", typeof(EducationLevelController), "GetEntityView")]
        [InlineData("/api/hrm/education-level/meta", "GET", typeof(EducationLevelController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/count", "GET", typeof(EducationLevelController), "Count")]
        [InlineData("/api/hrm/education-level/count", "GET", typeof(EducationLevelController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/all", "GET", typeof(EducationLevelController), "GetAll")]
        [InlineData("/api/hrm/education-level/all", "GET", typeof(EducationLevelController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/export", "GET", typeof(EducationLevelController), "Export")]
        [InlineData("/api/hrm/education-level/export", "GET", typeof(EducationLevelController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/1", "GET", typeof(EducationLevelController), "Get")]
        [InlineData("/api/hrm/education-level/1", "GET", typeof(EducationLevelController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/get?educationLevelIds=1", "GET", typeof(EducationLevelController), "Get")]
        [InlineData("/api/hrm/education-level/get?educationLevelIds=1", "GET", typeof(EducationLevelController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level", "GET", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/hrm/education-level", "GET", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/page/1", "GET", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/hrm/education-level/page/1", "GET", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/count-filtered/{filterName}", "GET", typeof(EducationLevelController), "CountFiltered")]
        [InlineData("/api/hrm/education-level/count-filtered/{filterName}", "GET", typeof(EducationLevelController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EducationLevelController), "GetFiltered")]
        [InlineData("/api/hrm/education-level/get-filtered/{pageNumber}/{filterName}", "GET", typeof(EducationLevelController), "GetFiltered")]
        [InlineData("/api/hrm/education-level/first", "GET", typeof(EducationLevelController), "GetFirst")]
        [InlineData("/api/hrm/education-level/previous/1", "GET", typeof(EducationLevelController), "GetPrevious")]
        [InlineData("/api/hrm/education-level/next/1", "GET", typeof(EducationLevelController), "GetNext")]
        [InlineData("/api/hrm/education-level/last", "GET", typeof(EducationLevelController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/education-level/custom-fields", "GET", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/hrm/education-level/custom-fields", "GET", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/custom-fields/{resourceId}", "GET", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/hrm/education-level/custom-fields/{resourceId}", "GET", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/meta", "HEAD", typeof(EducationLevelController), "GetEntityView")]
        [InlineData("/api/hrm/education-level/meta", "HEAD", typeof(EducationLevelController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/count", "HEAD", typeof(EducationLevelController), "Count")]
        [InlineData("/api/hrm/education-level/count", "HEAD", typeof(EducationLevelController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/all", "HEAD", typeof(EducationLevelController), "GetAll")]
        [InlineData("/api/hrm/education-level/all", "HEAD", typeof(EducationLevelController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/export", "HEAD", typeof(EducationLevelController), "Export")]
        [InlineData("/api/hrm/education-level/export", "HEAD", typeof(EducationLevelController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/1", "HEAD", typeof(EducationLevelController), "Get")]
        [InlineData("/api/hrm/education-level/1", "HEAD", typeof(EducationLevelController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/get?educationLevelIds=1", "HEAD", typeof(EducationLevelController), "Get")]
        [InlineData("/api/hrm/education-level/get?educationLevelIds=1", "HEAD", typeof(EducationLevelController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level", "HEAD", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/hrm/education-level", "HEAD", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/page/1", "HEAD", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/hrm/education-level/page/1", "HEAD", typeof(EducationLevelController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/count-filtered/{filterName}", "HEAD", typeof(EducationLevelController), "CountFiltered")]
        [InlineData("/api/hrm/education-level/count-filtered/{filterName}", "HEAD", typeof(EducationLevelController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EducationLevelController), "GetFiltered")]
        [InlineData("/api/hrm/education-level/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(EducationLevelController), "GetFiltered")]
        [InlineData("/api/hrm/education-level/first", "HEAD", typeof(EducationLevelController), "GetFirst")]
        [InlineData("/api/hrm/education-level/previous/1", "HEAD", typeof(EducationLevelController), "GetPrevious")]
        [InlineData("/api/hrm/education-level/next/1", "HEAD", typeof(EducationLevelController), "GetNext")]
        [InlineData("/api/hrm/education-level/last", "HEAD", typeof(EducationLevelController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/education-level/custom-fields", "HEAD", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/hrm/education-level/custom-fields", "HEAD", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/education-level/custom-fields/{resourceId}", "HEAD", typeof(EducationLevelController), "GetCustomFields")]
        [InlineData("/api/hrm/education-level/custom-fields/{resourceId}", "HEAD", typeof(EducationLevelController), "GetCustomFields")]

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

        public EducationLevelRouteTests()
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