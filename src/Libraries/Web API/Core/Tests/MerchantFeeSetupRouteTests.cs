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
    public class MerchantFeeSetupRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/delete/{merchantFeeSetupId}", "DELETE", typeof(MerchantFeeSetupController), "Delete")]
        [InlineData("/api/core/merchant-fee-setup/delete/{merchantFeeSetupId}", "DELETE", typeof(MerchantFeeSetupController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/edit/{merchantFeeSetupId}", "PUT", typeof(MerchantFeeSetupController), "Edit")]
        [InlineData("/api/core/merchant-fee-setup/edit/{merchantFeeSetupId}", "PUT", typeof(MerchantFeeSetupController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/count-where", "POST", typeof(MerchantFeeSetupController), "CountWhere")]
        [InlineData("/api/core/merchant-fee-setup/count-where", "POST", typeof(MerchantFeeSetupController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/get-where/{pageNumber}", "POST", typeof(MerchantFeeSetupController), "GetWhere")]
        [InlineData("/api/core/merchant-fee-setup/get-where/{pageNumber}", "POST", typeof(MerchantFeeSetupController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/add-or-edit", "POST", typeof(MerchantFeeSetupController), "AddOrEdit")]
        [InlineData("/api/core/merchant-fee-setup/add-or-edit", "POST", typeof(MerchantFeeSetupController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/add/{merchantFeeSetup}", "POST", typeof(MerchantFeeSetupController), "Add")]
        [InlineData("/api/core/merchant-fee-setup/add/{merchantFeeSetup}", "POST", typeof(MerchantFeeSetupController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/bulk-import", "POST", typeof(MerchantFeeSetupController), "BulkImport")]
        [InlineData("/api/core/merchant-fee-setup/bulk-import", "POST", typeof(MerchantFeeSetupController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/meta", "GET", typeof(MerchantFeeSetupController), "GetEntityView")]
        [InlineData("/api/core/merchant-fee-setup/meta", "GET", typeof(MerchantFeeSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/count", "GET", typeof(MerchantFeeSetupController), "Count")]
        [InlineData("/api/core/merchant-fee-setup/count", "GET", typeof(MerchantFeeSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/all", "GET", typeof(MerchantFeeSetupController), "GetAll")]
        [InlineData("/api/core/merchant-fee-setup/all", "GET", typeof(MerchantFeeSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/export", "GET", typeof(MerchantFeeSetupController), "Export")]
        [InlineData("/api/core/merchant-fee-setup/export", "GET", typeof(MerchantFeeSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/1", "GET", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/core/merchant-fee-setup/1", "GET", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/get?merchantFeeSetupIds=1", "GET", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/core/merchant-fee-setup/get?merchantFeeSetupIds=1", "GET", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup", "GET", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/merchant-fee-setup", "GET", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/page/1", "GET", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/merchant-fee-setup/page/1", "GET", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/count-filtered/{filterName}", "GET", typeof(MerchantFeeSetupController), "CountFiltered")]
        [InlineData("/api/core/merchant-fee-setup/count-filtered/{filterName}", "GET", typeof(MerchantFeeSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MerchantFeeSetupController), "GetFiltered")]
        [InlineData("/api/core/merchant-fee-setup/get-filtered/{pageNumber}/{filterName}", "GET", typeof(MerchantFeeSetupController), "GetFiltered")]
        [InlineData("/api/core/merchant-fee-setup/first", "GET", typeof(MerchantFeeSetupController), "GetFirst")]
        [InlineData("/api/core/merchant-fee-setup/previous/1", "GET", typeof(MerchantFeeSetupController), "GetPrevious")]
        [InlineData("/api/core/merchant-fee-setup/next/1", "GET", typeof(MerchantFeeSetupController), "GetNext")]
        [InlineData("/api/core/merchant-fee-setup/last", "GET", typeof(MerchantFeeSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/custom-fields", "GET", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/core/merchant-fee-setup/custom-fields", "GET", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/custom-fields/{resourceId}", "GET", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/core/merchant-fee-setup/custom-fields/{resourceId}", "GET", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/meta", "HEAD", typeof(MerchantFeeSetupController), "GetEntityView")]
        [InlineData("/api/core/merchant-fee-setup/meta", "HEAD", typeof(MerchantFeeSetupController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/count", "HEAD", typeof(MerchantFeeSetupController), "Count")]
        [InlineData("/api/core/merchant-fee-setup/count", "HEAD", typeof(MerchantFeeSetupController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/all", "HEAD", typeof(MerchantFeeSetupController), "GetAll")]
        [InlineData("/api/core/merchant-fee-setup/all", "HEAD", typeof(MerchantFeeSetupController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/export", "HEAD", typeof(MerchantFeeSetupController), "Export")]
        [InlineData("/api/core/merchant-fee-setup/export", "HEAD", typeof(MerchantFeeSetupController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/1", "HEAD", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/core/merchant-fee-setup/1", "HEAD", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/get?merchantFeeSetupIds=1", "HEAD", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/core/merchant-fee-setup/get?merchantFeeSetupIds=1", "HEAD", typeof(MerchantFeeSetupController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup", "HEAD", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/merchant-fee-setup", "HEAD", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/page/1", "HEAD", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/core/merchant-fee-setup/page/1", "HEAD", typeof(MerchantFeeSetupController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/count-filtered/{filterName}", "HEAD", typeof(MerchantFeeSetupController), "CountFiltered")]
        [InlineData("/api/core/merchant-fee-setup/count-filtered/{filterName}", "HEAD", typeof(MerchantFeeSetupController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MerchantFeeSetupController), "GetFiltered")]
        [InlineData("/api/core/merchant-fee-setup/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(MerchantFeeSetupController), "GetFiltered")]
        [InlineData("/api/core/merchant-fee-setup/first", "HEAD", typeof(MerchantFeeSetupController), "GetFirst")]
        [InlineData("/api/core/merchant-fee-setup/previous/1", "HEAD", typeof(MerchantFeeSetupController), "GetPrevious")]
        [InlineData("/api/core/merchant-fee-setup/next/1", "HEAD", typeof(MerchantFeeSetupController), "GetNext")]
        [InlineData("/api/core/merchant-fee-setup/last", "HEAD", typeof(MerchantFeeSetupController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/custom-fields", "HEAD", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/core/merchant-fee-setup/custom-fields", "HEAD", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/merchant-fee-setup/custom-fields/{resourceId}", "HEAD", typeof(MerchantFeeSetupController), "GetCustomFields")]
        [InlineData("/api/core/merchant-fee-setup/custom-fields/{resourceId}", "HEAD", typeof(MerchantFeeSetupController), "GetCustomFields")]

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

        public MerchantFeeSetupRouteTests()
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