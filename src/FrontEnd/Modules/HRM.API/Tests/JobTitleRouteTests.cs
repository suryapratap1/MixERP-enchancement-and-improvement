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
    public class JobTitleRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/delete/{jobTitleId}", "DELETE", typeof(JobTitleController), "Delete")]
        [InlineData("/api/hrm/job-title/delete/{jobTitleId}", "DELETE", typeof(JobTitleController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/edit/{jobTitleId}", "PUT", typeof(JobTitleController), "Edit")]
        [InlineData("/api/hrm/job-title/edit/{jobTitleId}", "PUT", typeof(JobTitleController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/count-where", "POST", typeof(JobTitleController), "CountWhere")]
        [InlineData("/api/hrm/job-title/count-where", "POST", typeof(JobTitleController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/get-where/{pageNumber}", "POST", typeof(JobTitleController), "GetWhere")]
        [InlineData("/api/hrm/job-title/get-where/{pageNumber}", "POST", typeof(JobTitleController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/add-or-edit", "POST", typeof(JobTitleController), "AddOrEdit")]
        [InlineData("/api/hrm/job-title/add-or-edit", "POST", typeof(JobTitleController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/add/{jobTitle}", "POST", typeof(JobTitleController), "Add")]
        [InlineData("/api/hrm/job-title/add/{jobTitle}", "POST", typeof(JobTitleController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/bulk-import", "POST", typeof(JobTitleController), "BulkImport")]
        [InlineData("/api/hrm/job-title/bulk-import", "POST", typeof(JobTitleController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/meta", "GET", typeof(JobTitleController), "GetEntityView")]
        [InlineData("/api/hrm/job-title/meta", "GET", typeof(JobTitleController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/count", "GET", typeof(JobTitleController), "Count")]
        [InlineData("/api/hrm/job-title/count", "GET", typeof(JobTitleController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/all", "GET", typeof(JobTitleController), "GetAll")]
        [InlineData("/api/hrm/job-title/all", "GET", typeof(JobTitleController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/export", "GET", typeof(JobTitleController), "Export")]
        [InlineData("/api/hrm/job-title/export", "GET", typeof(JobTitleController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/1", "GET", typeof(JobTitleController), "Get")]
        [InlineData("/api/hrm/job-title/1", "GET", typeof(JobTitleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/get?jobTitleIds=1", "GET", typeof(JobTitleController), "Get")]
        [InlineData("/api/hrm/job-title/get?jobTitleIds=1", "GET", typeof(JobTitleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title", "GET", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/hrm/job-title", "GET", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/page/1", "GET", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/hrm/job-title/page/1", "GET", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/count-filtered/{filterName}", "GET", typeof(JobTitleController), "CountFiltered")]
        [InlineData("/api/hrm/job-title/count-filtered/{filterName}", "GET", typeof(JobTitleController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/get-filtered/{pageNumber}/{filterName}", "GET", typeof(JobTitleController), "GetFiltered")]
        [InlineData("/api/hrm/job-title/get-filtered/{pageNumber}/{filterName}", "GET", typeof(JobTitleController), "GetFiltered")]
        [InlineData("/api/hrm/job-title/first", "GET", typeof(JobTitleController), "GetFirst")]
        [InlineData("/api/hrm/job-title/previous/1", "GET", typeof(JobTitleController), "GetPrevious")]
        [InlineData("/api/hrm/job-title/next/1", "GET", typeof(JobTitleController), "GetNext")]
        [InlineData("/api/hrm/job-title/last", "GET", typeof(JobTitleController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/job-title/custom-fields", "GET", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/hrm/job-title/custom-fields", "GET", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/custom-fields/{resourceId}", "GET", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/hrm/job-title/custom-fields/{resourceId}", "GET", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/meta", "HEAD", typeof(JobTitleController), "GetEntityView")]
        [InlineData("/api/hrm/job-title/meta", "HEAD", typeof(JobTitleController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/count", "HEAD", typeof(JobTitleController), "Count")]
        [InlineData("/api/hrm/job-title/count", "HEAD", typeof(JobTitleController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/all", "HEAD", typeof(JobTitleController), "GetAll")]
        [InlineData("/api/hrm/job-title/all", "HEAD", typeof(JobTitleController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/export", "HEAD", typeof(JobTitleController), "Export")]
        [InlineData("/api/hrm/job-title/export", "HEAD", typeof(JobTitleController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/1", "HEAD", typeof(JobTitleController), "Get")]
        [InlineData("/api/hrm/job-title/1", "HEAD", typeof(JobTitleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/get?jobTitleIds=1", "HEAD", typeof(JobTitleController), "Get")]
        [InlineData("/api/hrm/job-title/get?jobTitleIds=1", "HEAD", typeof(JobTitleController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title", "HEAD", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/hrm/job-title", "HEAD", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/page/1", "HEAD", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/hrm/job-title/page/1", "HEAD", typeof(JobTitleController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/count-filtered/{filterName}", "HEAD", typeof(JobTitleController), "CountFiltered")]
        [InlineData("/api/hrm/job-title/count-filtered/{filterName}", "HEAD", typeof(JobTitleController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(JobTitleController), "GetFiltered")]
        [InlineData("/api/hrm/job-title/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(JobTitleController), "GetFiltered")]
        [InlineData("/api/hrm/job-title/first", "HEAD", typeof(JobTitleController), "GetFirst")]
        [InlineData("/api/hrm/job-title/previous/1", "HEAD", typeof(JobTitleController), "GetPrevious")]
        [InlineData("/api/hrm/job-title/next/1", "HEAD", typeof(JobTitleController), "GetNext")]
        [InlineData("/api/hrm/job-title/last", "HEAD", typeof(JobTitleController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/job-title/custom-fields", "HEAD", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/hrm/job-title/custom-fields", "HEAD", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/job-title/custom-fields/{resourceId}", "HEAD", typeof(JobTitleController), "GetCustomFields")]
        [InlineData("/api/hrm/job-title/custom-fields/{resourceId}", "HEAD", typeof(JobTitleController), "GetCustomFields")]

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

        public JobTitleRouteTests()
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