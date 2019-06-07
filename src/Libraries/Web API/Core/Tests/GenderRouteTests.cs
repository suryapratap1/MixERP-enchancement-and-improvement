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
    public class GenderRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/gender/delete/{genderCode}", "DELETE", typeof(GenderController), "Delete")]
        [InlineData("/api/core/gender/delete/{genderCode}", "DELETE", typeof(GenderController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/gender/edit/{genderCode}", "PUT", typeof(GenderController), "Edit")]
        [InlineData("/api/core/gender/edit/{genderCode}", "PUT", typeof(GenderController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/gender/count-where", "POST", typeof(GenderController), "CountWhere")]
        [InlineData("/api/core/gender/count-where", "POST", typeof(GenderController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/gender/get-where/{pageNumber}", "POST", typeof(GenderController), "GetWhere")]
        [InlineData("/api/core/gender/get-where/{pageNumber}", "POST", typeof(GenderController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/gender/add-or-edit", "POST", typeof(GenderController), "AddOrEdit")]
        [InlineData("/api/core/gender/add-or-edit", "POST", typeof(GenderController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/gender/add/{gender}", "POST", typeof(GenderController), "Add")]
        [InlineData("/api/core/gender/add/{gender}", "POST", typeof(GenderController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/gender/bulk-import", "POST", typeof(GenderController), "BulkImport")]
        [InlineData("/api/core/gender/bulk-import", "POST", typeof(GenderController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/gender/meta", "GET", typeof(GenderController), "GetEntityView")]
        [InlineData("/api/core/gender/meta", "GET", typeof(GenderController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/gender/count", "GET", typeof(GenderController), "Count")]
        [InlineData("/api/core/gender/count", "GET", typeof(GenderController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/gender/all", "GET", typeof(GenderController), "GetAll")]
        [InlineData("/api/core/gender/all", "GET", typeof(GenderController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/gender/export", "GET", typeof(GenderController), "Export")]
        [InlineData("/api/core/gender/export", "GET", typeof(GenderController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/gender/1", "GET", typeof(GenderController), "Get")]
        [InlineData("/api/core/gender/1", "GET", typeof(GenderController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/gender/get?genderCodes=1", "GET", typeof(GenderController), "Get")]
        [InlineData("/api/core/gender/get?genderCodes=1", "GET", typeof(GenderController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/gender", "GET", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/core/gender", "GET", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/gender/page/1", "GET", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/core/gender/page/1", "GET", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/gender/count-filtered/{filterName}", "GET", typeof(GenderController), "CountFiltered")]
        [InlineData("/api/core/gender/count-filtered/{filterName}", "GET", typeof(GenderController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/gender/get-filtered/{pageNumber}/{filterName}", "GET", typeof(GenderController), "GetFiltered")]
        [InlineData("/api/core/gender/get-filtered/{pageNumber}/{filterName}", "GET", typeof(GenderController), "GetFiltered")]
        [InlineData("/api/core/gender/first", "GET", typeof(GenderController), "GetFirst")]
        [InlineData("/api/core/gender/previous/1", "GET", typeof(GenderController), "GetPrevious")]
        [InlineData("/api/core/gender/next/1", "GET", typeof(GenderController), "GetNext")]
        [InlineData("/api/core/gender/last", "GET", typeof(GenderController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/gender/custom-fields", "GET", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/core/gender/custom-fields", "GET", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/gender/custom-fields/{resourceId}", "GET", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/core/gender/custom-fields/{resourceId}", "GET", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/gender/meta", "HEAD", typeof(GenderController), "GetEntityView")]
        [InlineData("/api/core/gender/meta", "HEAD", typeof(GenderController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/gender/count", "HEAD", typeof(GenderController), "Count")]
        [InlineData("/api/core/gender/count", "HEAD", typeof(GenderController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/gender/all", "HEAD", typeof(GenderController), "GetAll")]
        [InlineData("/api/core/gender/all", "HEAD", typeof(GenderController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/gender/export", "HEAD", typeof(GenderController), "Export")]
        [InlineData("/api/core/gender/export", "HEAD", typeof(GenderController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/gender/1", "HEAD", typeof(GenderController), "Get")]
        [InlineData("/api/core/gender/1", "HEAD", typeof(GenderController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/gender/get?genderCodes=1", "HEAD", typeof(GenderController), "Get")]
        [InlineData("/api/core/gender/get?genderCodes=1", "HEAD", typeof(GenderController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/gender", "HEAD", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/core/gender", "HEAD", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/gender/page/1", "HEAD", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/core/gender/page/1", "HEAD", typeof(GenderController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/gender/count-filtered/{filterName}", "HEAD", typeof(GenderController), "CountFiltered")]
        [InlineData("/api/core/gender/count-filtered/{filterName}", "HEAD", typeof(GenderController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/gender/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(GenderController), "GetFiltered")]
        [InlineData("/api/core/gender/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(GenderController), "GetFiltered")]
        [InlineData("/api/core/gender/first", "HEAD", typeof(GenderController), "GetFirst")]
        [InlineData("/api/core/gender/previous/1", "HEAD", typeof(GenderController), "GetPrevious")]
        [InlineData("/api/core/gender/next/1", "HEAD", typeof(GenderController), "GetNext")]
        [InlineData("/api/core/gender/last", "HEAD", typeof(GenderController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/gender/custom-fields", "HEAD", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/core/gender/custom-fields", "HEAD", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/gender/custom-fields/{resourceId}", "HEAD", typeof(GenderController), "GetCustomFields")]
        [InlineData("/api/core/gender/custom-fields/{resourceId}", "HEAD", typeof(GenderController), "GetCustomFields")]

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

        public GenderRouteTests()
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