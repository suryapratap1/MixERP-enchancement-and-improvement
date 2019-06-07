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
    public class PaymentCardRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/delete/{paymentCardId}", "DELETE", typeof(PaymentCardController), "Delete")]
        [InlineData("/api/core/payment-card/delete/{paymentCardId}", "DELETE", typeof(PaymentCardController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/edit/{paymentCardId}", "PUT", typeof(PaymentCardController), "Edit")]
        [InlineData("/api/core/payment-card/edit/{paymentCardId}", "PUT", typeof(PaymentCardController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/count-where", "POST", typeof(PaymentCardController), "CountWhere")]
        [InlineData("/api/core/payment-card/count-where", "POST", typeof(PaymentCardController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/get-where/{pageNumber}", "POST", typeof(PaymentCardController), "GetWhere")]
        [InlineData("/api/core/payment-card/get-where/{pageNumber}", "POST", typeof(PaymentCardController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/add-or-edit", "POST", typeof(PaymentCardController), "AddOrEdit")]
        [InlineData("/api/core/payment-card/add-or-edit", "POST", typeof(PaymentCardController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/add/{paymentCard}", "POST", typeof(PaymentCardController), "Add")]
        [InlineData("/api/core/payment-card/add/{paymentCard}", "POST", typeof(PaymentCardController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/bulk-import", "POST", typeof(PaymentCardController), "BulkImport")]
        [InlineData("/api/core/payment-card/bulk-import", "POST", typeof(PaymentCardController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/meta", "GET", typeof(PaymentCardController), "GetEntityView")]
        [InlineData("/api/core/payment-card/meta", "GET", typeof(PaymentCardController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/count", "GET", typeof(PaymentCardController), "Count")]
        [InlineData("/api/core/payment-card/count", "GET", typeof(PaymentCardController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/all", "GET", typeof(PaymentCardController), "GetAll")]
        [InlineData("/api/core/payment-card/all", "GET", typeof(PaymentCardController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/export", "GET", typeof(PaymentCardController), "Export")]
        [InlineData("/api/core/payment-card/export", "GET", typeof(PaymentCardController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/1", "GET", typeof(PaymentCardController), "Get")]
        [InlineData("/api/core/payment-card/1", "GET", typeof(PaymentCardController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/get?paymentCardIds=1", "GET", typeof(PaymentCardController), "Get")]
        [InlineData("/api/core/payment-card/get?paymentCardIds=1", "GET", typeof(PaymentCardController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card", "GET", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-card", "GET", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/page/1", "GET", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-card/page/1", "GET", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/count-filtered/{filterName}", "GET", typeof(PaymentCardController), "CountFiltered")]
        [InlineData("/api/core/payment-card/count-filtered/{filterName}", "GET", typeof(PaymentCardController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PaymentCardController), "GetFiltered")]
        [InlineData("/api/core/payment-card/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PaymentCardController), "GetFiltered")]
        [InlineData("/api/core/payment-card/first", "GET", typeof(PaymentCardController), "GetFirst")]
        [InlineData("/api/core/payment-card/previous/1", "GET", typeof(PaymentCardController), "GetPrevious")]
        [InlineData("/api/core/payment-card/next/1", "GET", typeof(PaymentCardController), "GetNext")]
        [InlineData("/api/core/payment-card/last", "GET", typeof(PaymentCardController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/payment-card/custom-fields", "GET", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/core/payment-card/custom-fields", "GET", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/custom-fields/{resourceId}", "GET", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/core/payment-card/custom-fields/{resourceId}", "GET", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/meta", "HEAD", typeof(PaymentCardController), "GetEntityView")]
        [InlineData("/api/core/payment-card/meta", "HEAD", typeof(PaymentCardController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/count", "HEAD", typeof(PaymentCardController), "Count")]
        [InlineData("/api/core/payment-card/count", "HEAD", typeof(PaymentCardController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/all", "HEAD", typeof(PaymentCardController), "GetAll")]
        [InlineData("/api/core/payment-card/all", "HEAD", typeof(PaymentCardController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/export", "HEAD", typeof(PaymentCardController), "Export")]
        [InlineData("/api/core/payment-card/export", "HEAD", typeof(PaymentCardController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/1", "HEAD", typeof(PaymentCardController), "Get")]
        [InlineData("/api/core/payment-card/1", "HEAD", typeof(PaymentCardController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/get?paymentCardIds=1", "HEAD", typeof(PaymentCardController), "Get")]
        [InlineData("/api/core/payment-card/get?paymentCardIds=1", "HEAD", typeof(PaymentCardController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card", "HEAD", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-card", "HEAD", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/page/1", "HEAD", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-card/page/1", "HEAD", typeof(PaymentCardController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/count-filtered/{filterName}", "HEAD", typeof(PaymentCardController), "CountFiltered")]
        [InlineData("/api/core/payment-card/count-filtered/{filterName}", "HEAD", typeof(PaymentCardController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PaymentCardController), "GetFiltered")]
        [InlineData("/api/core/payment-card/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PaymentCardController), "GetFiltered")]
        [InlineData("/api/core/payment-card/first", "HEAD", typeof(PaymentCardController), "GetFirst")]
        [InlineData("/api/core/payment-card/previous/1", "HEAD", typeof(PaymentCardController), "GetPrevious")]
        [InlineData("/api/core/payment-card/next/1", "HEAD", typeof(PaymentCardController), "GetNext")]
        [InlineData("/api/core/payment-card/last", "HEAD", typeof(PaymentCardController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/payment-card/custom-fields", "HEAD", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/core/payment-card/custom-fields", "HEAD", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/payment-card/custom-fields/{resourceId}", "HEAD", typeof(PaymentCardController), "GetCustomFields")]
        [InlineData("/api/core/payment-card/custom-fields/{resourceId}", "HEAD", typeof(PaymentCardController), "GetCustomFields")]

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

        public PaymentCardRouteTests()
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