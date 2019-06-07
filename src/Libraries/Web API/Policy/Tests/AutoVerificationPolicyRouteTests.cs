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

namespace MixERP.Net.Api.Policy.Tests
{
    public class AutoVerificationPolicyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/delete/{policyId}", "DELETE", typeof(AutoVerificationPolicyController), "Delete")]
        [InlineData("/api/policy/auto-verification-policy/delete/{policyId}", "DELETE", typeof(AutoVerificationPolicyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/edit/{policyId}", "PUT", typeof(AutoVerificationPolicyController), "Edit")]
        [InlineData("/api/policy/auto-verification-policy/edit/{policyId}", "PUT", typeof(AutoVerificationPolicyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/count-where", "POST", typeof(AutoVerificationPolicyController), "CountWhere")]
        [InlineData("/api/policy/auto-verification-policy/count-where", "POST", typeof(AutoVerificationPolicyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/get-where/{pageNumber}", "POST", typeof(AutoVerificationPolicyController), "GetWhere")]
        [InlineData("/api/policy/auto-verification-policy/get-where/{pageNumber}", "POST", typeof(AutoVerificationPolicyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/add-or-edit", "POST", typeof(AutoVerificationPolicyController), "AddOrEdit")]
        [InlineData("/api/policy/auto-verification-policy/add-or-edit", "POST", typeof(AutoVerificationPolicyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/add/{autoVerificationPolicy}", "POST", typeof(AutoVerificationPolicyController), "Add")]
        [InlineData("/api/policy/auto-verification-policy/add/{autoVerificationPolicy}", "POST", typeof(AutoVerificationPolicyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/bulk-import", "POST", typeof(AutoVerificationPolicyController), "BulkImport")]
        [InlineData("/api/policy/auto-verification-policy/bulk-import", "POST", typeof(AutoVerificationPolicyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/meta", "GET", typeof(AutoVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/policy/auto-verification-policy/meta", "GET", typeof(AutoVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/count", "GET", typeof(AutoVerificationPolicyController), "Count")]
        [InlineData("/api/policy/auto-verification-policy/count", "GET", typeof(AutoVerificationPolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/all", "GET", typeof(AutoVerificationPolicyController), "GetAll")]
        [InlineData("/api/policy/auto-verification-policy/all", "GET", typeof(AutoVerificationPolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/export", "GET", typeof(AutoVerificationPolicyController), "Export")]
        [InlineData("/api/policy/auto-verification-policy/export", "GET", typeof(AutoVerificationPolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/1", "GET", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/policy/auto-verification-policy/1", "GET", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/get?policyIds=1", "GET", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/policy/auto-verification-policy/get?policyIds=1", "GET", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy", "GET", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/auto-verification-policy", "GET", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/page/1", "GET", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/auto-verification-policy/page/1", "GET", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/count-filtered/{filterName}", "GET", typeof(AutoVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/policy/auto-verification-policy/count-filtered/{filterName}", "GET", typeof(AutoVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AutoVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/auto-verification-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(AutoVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/auto-verification-policy/first", "GET", typeof(AutoVerificationPolicyController), "GetFirst")]
        [InlineData("/api/policy/auto-verification-policy/previous/1", "GET", typeof(AutoVerificationPolicyController), "GetPrevious")]
        [InlineData("/api/policy/auto-verification-policy/next/1", "GET", typeof(AutoVerificationPolicyController), "GetNext")]
        [InlineData("/api/policy/auto-verification-policy/last", "GET", typeof(AutoVerificationPolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/custom-fields", "GET", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/auto-verification-policy/custom-fields", "GET", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/custom-fields/{resourceId}", "GET", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/auto-verification-policy/custom-fields/{resourceId}", "GET", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/meta", "HEAD", typeof(AutoVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/policy/auto-verification-policy/meta", "HEAD", typeof(AutoVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/count", "HEAD", typeof(AutoVerificationPolicyController), "Count")]
        [InlineData("/api/policy/auto-verification-policy/count", "HEAD", typeof(AutoVerificationPolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/all", "HEAD", typeof(AutoVerificationPolicyController), "GetAll")]
        [InlineData("/api/policy/auto-verification-policy/all", "HEAD", typeof(AutoVerificationPolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/export", "HEAD", typeof(AutoVerificationPolicyController), "Export")]
        [InlineData("/api/policy/auto-verification-policy/export", "HEAD", typeof(AutoVerificationPolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/1", "HEAD", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/policy/auto-verification-policy/1", "HEAD", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/get?policyIds=1", "HEAD", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/policy/auto-verification-policy/get?policyIds=1", "HEAD", typeof(AutoVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy", "HEAD", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/auto-verification-policy", "HEAD", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/page/1", "HEAD", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/auto-verification-policy/page/1", "HEAD", typeof(AutoVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/count-filtered/{filterName}", "HEAD", typeof(AutoVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/policy/auto-verification-policy/count-filtered/{filterName}", "HEAD", typeof(AutoVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AutoVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/auto-verification-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(AutoVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/auto-verification-policy/first", "HEAD", typeof(AutoVerificationPolicyController), "GetFirst")]
        [InlineData("/api/policy/auto-verification-policy/previous/1", "HEAD", typeof(AutoVerificationPolicyController), "GetPrevious")]
        [InlineData("/api/policy/auto-verification-policy/next/1", "HEAD", typeof(AutoVerificationPolicyController), "GetNext")]
        [InlineData("/api/policy/auto-verification-policy/last", "HEAD", typeof(AutoVerificationPolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/custom-fields", "HEAD", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/auto-verification-policy/custom-fields", "HEAD", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/auto-verification-policy/custom-fields/{resourceId}", "HEAD", typeof(AutoVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/auto-verification-policy/custom-fields/{resourceId}", "HEAD", typeof(AutoVerificationPolicyController), "GetCustomFields")]

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

        public AutoVerificationPolicyRouteTests()
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