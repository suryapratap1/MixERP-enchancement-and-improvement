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
    public class VoucherVerificationPolicyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/delete/{policyId}", "DELETE", typeof(VoucherVerificationPolicyController), "Delete")]
        [InlineData("/api/policy/voucher-verification-policy/delete/{policyId}", "DELETE", typeof(VoucherVerificationPolicyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/edit/{policyId}", "PUT", typeof(VoucherVerificationPolicyController), "Edit")]
        [InlineData("/api/policy/voucher-verification-policy/edit/{policyId}", "PUT", typeof(VoucherVerificationPolicyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/count-where", "POST", typeof(VoucherVerificationPolicyController), "CountWhere")]
        [InlineData("/api/policy/voucher-verification-policy/count-where", "POST", typeof(VoucherVerificationPolicyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/get-where/{pageNumber}", "POST", typeof(VoucherVerificationPolicyController), "GetWhere")]
        [InlineData("/api/policy/voucher-verification-policy/get-where/{pageNumber}", "POST", typeof(VoucherVerificationPolicyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/add-or-edit", "POST", typeof(VoucherVerificationPolicyController), "AddOrEdit")]
        [InlineData("/api/policy/voucher-verification-policy/add-or-edit", "POST", typeof(VoucherVerificationPolicyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/add/{voucherVerificationPolicy}", "POST", typeof(VoucherVerificationPolicyController), "Add")]
        [InlineData("/api/policy/voucher-verification-policy/add/{voucherVerificationPolicy}", "POST", typeof(VoucherVerificationPolicyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/bulk-import", "POST", typeof(VoucherVerificationPolicyController), "BulkImport")]
        [InlineData("/api/policy/voucher-verification-policy/bulk-import", "POST", typeof(VoucherVerificationPolicyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/meta", "GET", typeof(VoucherVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/policy/voucher-verification-policy/meta", "GET", typeof(VoucherVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/count", "GET", typeof(VoucherVerificationPolicyController), "Count")]
        [InlineData("/api/policy/voucher-verification-policy/count", "GET", typeof(VoucherVerificationPolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/all", "GET", typeof(VoucherVerificationPolicyController), "GetAll")]
        [InlineData("/api/policy/voucher-verification-policy/all", "GET", typeof(VoucherVerificationPolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/export", "GET", typeof(VoucherVerificationPolicyController), "Export")]
        [InlineData("/api/policy/voucher-verification-policy/export", "GET", typeof(VoucherVerificationPolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/1", "GET", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/policy/voucher-verification-policy/1", "GET", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/get?policyIds=1", "GET", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/policy/voucher-verification-policy/get?policyIds=1", "GET", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy", "GET", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/voucher-verification-policy", "GET", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/page/1", "GET", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/voucher-verification-policy/page/1", "GET", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/count-filtered/{filterName}", "GET", typeof(VoucherVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/policy/voucher-verification-policy/count-filtered/{filterName}", "GET", typeof(VoucherVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(VoucherVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/voucher-verification-policy/get-filtered/{pageNumber}/{filterName}", "GET", typeof(VoucherVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/voucher-verification-policy/first", "GET", typeof(VoucherVerificationPolicyController), "GetFirst")]
        [InlineData("/api/policy/voucher-verification-policy/previous/1", "GET", typeof(VoucherVerificationPolicyController), "GetPrevious")]
        [InlineData("/api/policy/voucher-verification-policy/next/1", "GET", typeof(VoucherVerificationPolicyController), "GetNext")]
        [InlineData("/api/policy/voucher-verification-policy/last", "GET", typeof(VoucherVerificationPolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/custom-fields", "GET", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/voucher-verification-policy/custom-fields", "GET", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/custom-fields/{resourceId}", "GET", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/voucher-verification-policy/custom-fields/{resourceId}", "GET", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/meta", "HEAD", typeof(VoucherVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/policy/voucher-verification-policy/meta", "HEAD", typeof(VoucherVerificationPolicyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/count", "HEAD", typeof(VoucherVerificationPolicyController), "Count")]
        [InlineData("/api/policy/voucher-verification-policy/count", "HEAD", typeof(VoucherVerificationPolicyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/all", "HEAD", typeof(VoucherVerificationPolicyController), "GetAll")]
        [InlineData("/api/policy/voucher-verification-policy/all", "HEAD", typeof(VoucherVerificationPolicyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/export", "HEAD", typeof(VoucherVerificationPolicyController), "Export")]
        [InlineData("/api/policy/voucher-verification-policy/export", "HEAD", typeof(VoucherVerificationPolicyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/1", "HEAD", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/policy/voucher-verification-policy/1", "HEAD", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/get?policyIds=1", "HEAD", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/policy/voucher-verification-policy/get?policyIds=1", "HEAD", typeof(VoucherVerificationPolicyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy", "HEAD", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/voucher-verification-policy", "HEAD", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/page/1", "HEAD", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/policy/voucher-verification-policy/page/1", "HEAD", typeof(VoucherVerificationPolicyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/count-filtered/{filterName}", "HEAD", typeof(VoucherVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/policy/voucher-verification-policy/count-filtered/{filterName}", "HEAD", typeof(VoucherVerificationPolicyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(VoucherVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/voucher-verification-policy/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(VoucherVerificationPolicyController), "GetFiltered")]
        [InlineData("/api/policy/voucher-verification-policy/first", "HEAD", typeof(VoucherVerificationPolicyController), "GetFirst")]
        [InlineData("/api/policy/voucher-verification-policy/previous/1", "HEAD", typeof(VoucherVerificationPolicyController), "GetPrevious")]
        [InlineData("/api/policy/voucher-verification-policy/next/1", "HEAD", typeof(VoucherVerificationPolicyController), "GetNext")]
        [InlineData("/api/policy/voucher-verification-policy/last", "HEAD", typeof(VoucherVerificationPolicyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/custom-fields", "HEAD", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/voucher-verification-policy/custom-fields", "HEAD", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/policy/voucher-verification-policy/custom-fields/{resourceId}", "HEAD", typeof(VoucherVerificationPolicyController), "GetCustomFields")]
        [InlineData("/api/policy/voucher-verification-policy/custom-fields/{resourceId}", "HEAD", typeof(VoucherVerificationPolicyController), "GetCustomFields")]

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

        public VoucherVerificationPolicyRouteTests()
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