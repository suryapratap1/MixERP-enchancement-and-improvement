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
    public class TaxBaseAmountTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/delete/{taxBaseAmountTypeCode}", "DELETE", typeof(TaxBaseAmountTypeController), "Delete")]
        [InlineData("/api/core/tax-base-amount-type/delete/{taxBaseAmountTypeCode}", "DELETE", typeof(TaxBaseAmountTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/edit/{taxBaseAmountTypeCode}", "PUT", typeof(TaxBaseAmountTypeController), "Edit")]
        [InlineData("/api/core/tax-base-amount-type/edit/{taxBaseAmountTypeCode}", "PUT", typeof(TaxBaseAmountTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/count-where", "POST", typeof(TaxBaseAmountTypeController), "CountWhere")]
        [InlineData("/api/core/tax-base-amount-type/count-where", "POST", typeof(TaxBaseAmountTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/get-where/{pageNumber}", "POST", typeof(TaxBaseAmountTypeController), "GetWhere")]
        [InlineData("/api/core/tax-base-amount-type/get-where/{pageNumber}", "POST", typeof(TaxBaseAmountTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/add-or-edit", "POST", typeof(TaxBaseAmountTypeController), "AddOrEdit")]
        [InlineData("/api/core/tax-base-amount-type/add-or-edit", "POST", typeof(TaxBaseAmountTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/add/{taxBaseAmountType}", "POST", typeof(TaxBaseAmountTypeController), "Add")]
        [InlineData("/api/core/tax-base-amount-type/add/{taxBaseAmountType}", "POST", typeof(TaxBaseAmountTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/bulk-import", "POST", typeof(TaxBaseAmountTypeController), "BulkImport")]
        [InlineData("/api/core/tax-base-amount-type/bulk-import", "POST", typeof(TaxBaseAmountTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/meta", "GET", typeof(TaxBaseAmountTypeController), "GetEntityView")]
        [InlineData("/api/core/tax-base-amount-type/meta", "GET", typeof(TaxBaseAmountTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/count", "GET", typeof(TaxBaseAmountTypeController), "Count")]
        [InlineData("/api/core/tax-base-amount-type/count", "GET", typeof(TaxBaseAmountTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/all", "GET", typeof(TaxBaseAmountTypeController), "GetAll")]
        [InlineData("/api/core/tax-base-amount-type/all", "GET", typeof(TaxBaseAmountTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/export", "GET", typeof(TaxBaseAmountTypeController), "Export")]
        [InlineData("/api/core/tax-base-amount-type/export", "GET", typeof(TaxBaseAmountTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/1", "GET", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/core/tax-base-amount-type/1", "GET", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/get?taxBaseAmountTypeCodes=1", "GET", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/core/tax-base-amount-type/get?taxBaseAmountTypeCodes=1", "GET", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type", "GET", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-base-amount-type", "GET", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/page/1", "GET", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-base-amount-type/page/1", "GET", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/count-filtered/{filterName}", "GET", typeof(TaxBaseAmountTypeController), "CountFiltered")]
        [InlineData("/api/core/tax-base-amount-type/count-filtered/{filterName}", "GET", typeof(TaxBaseAmountTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxBaseAmountTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-base-amount-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxBaseAmountTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-base-amount-type/first", "GET", typeof(TaxBaseAmountTypeController), "GetFirst")]
        [InlineData("/api/core/tax-base-amount-type/previous/1", "GET", typeof(TaxBaseAmountTypeController), "GetPrevious")]
        [InlineData("/api/core/tax-base-amount-type/next/1", "GET", typeof(TaxBaseAmountTypeController), "GetNext")]
        [InlineData("/api/core/tax-base-amount-type/last", "GET", typeof(TaxBaseAmountTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/custom-fields", "GET", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-base-amount-type/custom-fields", "GET", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/custom-fields/{resourceId}", "GET", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-base-amount-type/custom-fields/{resourceId}", "GET", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/meta", "HEAD", typeof(TaxBaseAmountTypeController), "GetEntityView")]
        [InlineData("/api/core/tax-base-amount-type/meta", "HEAD", typeof(TaxBaseAmountTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/count", "HEAD", typeof(TaxBaseAmountTypeController), "Count")]
        [InlineData("/api/core/tax-base-amount-type/count", "HEAD", typeof(TaxBaseAmountTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/all", "HEAD", typeof(TaxBaseAmountTypeController), "GetAll")]
        [InlineData("/api/core/tax-base-amount-type/all", "HEAD", typeof(TaxBaseAmountTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/export", "HEAD", typeof(TaxBaseAmountTypeController), "Export")]
        [InlineData("/api/core/tax-base-amount-type/export", "HEAD", typeof(TaxBaseAmountTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/1", "HEAD", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/core/tax-base-amount-type/1", "HEAD", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/get?taxBaseAmountTypeCodes=1", "HEAD", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/core/tax-base-amount-type/get?taxBaseAmountTypeCodes=1", "HEAD", typeof(TaxBaseAmountTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type", "HEAD", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-base-amount-type", "HEAD", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/page/1", "HEAD", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-base-amount-type/page/1", "HEAD", typeof(TaxBaseAmountTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/count-filtered/{filterName}", "HEAD", typeof(TaxBaseAmountTypeController), "CountFiltered")]
        [InlineData("/api/core/tax-base-amount-type/count-filtered/{filterName}", "HEAD", typeof(TaxBaseAmountTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxBaseAmountTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-base-amount-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxBaseAmountTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-base-amount-type/first", "HEAD", typeof(TaxBaseAmountTypeController), "GetFirst")]
        [InlineData("/api/core/tax-base-amount-type/previous/1", "HEAD", typeof(TaxBaseAmountTypeController), "GetPrevious")]
        [InlineData("/api/core/tax-base-amount-type/next/1", "HEAD", typeof(TaxBaseAmountTypeController), "GetNext")]
        [InlineData("/api/core/tax-base-amount-type/last", "HEAD", typeof(TaxBaseAmountTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/custom-fields", "HEAD", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-base-amount-type/custom-fields", "HEAD", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-base-amount-type/custom-fields/{resourceId}", "HEAD", typeof(TaxBaseAmountTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-base-amount-type/custom-fields/{resourceId}", "HEAD", typeof(TaxBaseAmountTypeController), "GetCustomFields")]

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

        public TaxBaseAmountTypeRouteTests()
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