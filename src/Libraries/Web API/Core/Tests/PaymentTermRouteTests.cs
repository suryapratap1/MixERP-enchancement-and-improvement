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
    public class PaymentTermRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/delete/{paymentTermId}", "DELETE", typeof(PaymentTermController), "Delete")]
        [InlineData("/api/core/payment-term/delete/{paymentTermId}", "DELETE", typeof(PaymentTermController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/edit/{paymentTermId}", "PUT", typeof(PaymentTermController), "Edit")]
        [InlineData("/api/core/payment-term/edit/{paymentTermId}", "PUT", typeof(PaymentTermController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/count-where", "POST", typeof(PaymentTermController), "CountWhere")]
        [InlineData("/api/core/payment-term/count-where", "POST", typeof(PaymentTermController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/get-where/{pageNumber}", "POST", typeof(PaymentTermController), "GetWhere")]
        [InlineData("/api/core/payment-term/get-where/{pageNumber}", "POST", typeof(PaymentTermController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/add-or-edit", "POST", typeof(PaymentTermController), "AddOrEdit")]
        [InlineData("/api/core/payment-term/add-or-edit", "POST", typeof(PaymentTermController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/add/{paymentTerm}", "POST", typeof(PaymentTermController), "Add")]
        [InlineData("/api/core/payment-term/add/{paymentTerm}", "POST", typeof(PaymentTermController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/bulk-import", "POST", typeof(PaymentTermController), "BulkImport")]
        [InlineData("/api/core/payment-term/bulk-import", "POST", typeof(PaymentTermController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/meta", "GET", typeof(PaymentTermController), "GetEntityView")]
        [InlineData("/api/core/payment-term/meta", "GET", typeof(PaymentTermController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/count", "GET", typeof(PaymentTermController), "Count")]
        [InlineData("/api/core/payment-term/count", "GET", typeof(PaymentTermController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/all", "GET", typeof(PaymentTermController), "GetAll")]
        [InlineData("/api/core/payment-term/all", "GET", typeof(PaymentTermController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/export", "GET", typeof(PaymentTermController), "Export")]
        [InlineData("/api/core/payment-term/export", "GET", typeof(PaymentTermController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/1", "GET", typeof(PaymentTermController), "Get")]
        [InlineData("/api/core/payment-term/1", "GET", typeof(PaymentTermController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/get?paymentTermIds=1", "GET", typeof(PaymentTermController), "Get")]
        [InlineData("/api/core/payment-term/get?paymentTermIds=1", "GET", typeof(PaymentTermController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term", "GET", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-term", "GET", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/page/1", "GET", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-term/page/1", "GET", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/count-filtered/{filterName}", "GET", typeof(PaymentTermController), "CountFiltered")]
        [InlineData("/api/core/payment-term/count-filtered/{filterName}", "GET", typeof(PaymentTermController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PaymentTermController), "GetFiltered")]
        [InlineData("/api/core/payment-term/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PaymentTermController), "GetFiltered")]
        [InlineData("/api/core/payment-term/first", "GET", typeof(PaymentTermController), "GetFirst")]
        [InlineData("/api/core/payment-term/previous/1", "GET", typeof(PaymentTermController), "GetPrevious")]
        [InlineData("/api/core/payment-term/next/1", "GET", typeof(PaymentTermController), "GetNext")]
        [InlineData("/api/core/payment-term/last", "GET", typeof(PaymentTermController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/payment-term/custom-fields", "GET", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/core/payment-term/custom-fields", "GET", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/custom-fields/{resourceId}", "GET", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/core/payment-term/custom-fields/{resourceId}", "GET", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/meta", "HEAD", typeof(PaymentTermController), "GetEntityView")]
        [InlineData("/api/core/payment-term/meta", "HEAD", typeof(PaymentTermController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/count", "HEAD", typeof(PaymentTermController), "Count")]
        [InlineData("/api/core/payment-term/count", "HEAD", typeof(PaymentTermController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/all", "HEAD", typeof(PaymentTermController), "GetAll")]
        [InlineData("/api/core/payment-term/all", "HEAD", typeof(PaymentTermController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/export", "HEAD", typeof(PaymentTermController), "Export")]
        [InlineData("/api/core/payment-term/export", "HEAD", typeof(PaymentTermController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/1", "HEAD", typeof(PaymentTermController), "Get")]
        [InlineData("/api/core/payment-term/1", "HEAD", typeof(PaymentTermController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/get?paymentTermIds=1", "HEAD", typeof(PaymentTermController), "Get")]
        [InlineData("/api/core/payment-term/get?paymentTermIds=1", "HEAD", typeof(PaymentTermController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term", "HEAD", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-term", "HEAD", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/page/1", "HEAD", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/core/payment-term/page/1", "HEAD", typeof(PaymentTermController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/count-filtered/{filterName}", "HEAD", typeof(PaymentTermController), "CountFiltered")]
        [InlineData("/api/core/payment-term/count-filtered/{filterName}", "HEAD", typeof(PaymentTermController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PaymentTermController), "GetFiltered")]
        [InlineData("/api/core/payment-term/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PaymentTermController), "GetFiltered")]
        [InlineData("/api/core/payment-term/first", "HEAD", typeof(PaymentTermController), "GetFirst")]
        [InlineData("/api/core/payment-term/previous/1", "HEAD", typeof(PaymentTermController), "GetPrevious")]
        [InlineData("/api/core/payment-term/next/1", "HEAD", typeof(PaymentTermController), "GetNext")]
        [InlineData("/api/core/payment-term/last", "HEAD", typeof(PaymentTermController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/payment-term/custom-fields", "HEAD", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/core/payment-term/custom-fields", "HEAD", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/payment-term/custom-fields/{resourceId}", "HEAD", typeof(PaymentTermController), "GetCustomFields")]
        [InlineData("/api/core/payment-term/custom-fields/{resourceId}", "HEAD", typeof(PaymentTermController), "GetCustomFields")]

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

        public PaymentTermRouteTests()
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