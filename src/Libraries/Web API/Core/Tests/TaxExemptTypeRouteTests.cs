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
    public class TaxExemptTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/delete/{taxExemptTypeId}", "DELETE", typeof(TaxExemptTypeController), "Delete")]
        [InlineData("/api/core/tax-exempt-type/delete/{taxExemptTypeId}", "DELETE", typeof(TaxExemptTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/edit/{taxExemptTypeId}", "PUT", typeof(TaxExemptTypeController), "Edit")]
        [InlineData("/api/core/tax-exempt-type/edit/{taxExemptTypeId}", "PUT", typeof(TaxExemptTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/count-where", "POST", typeof(TaxExemptTypeController), "CountWhere")]
        [InlineData("/api/core/tax-exempt-type/count-where", "POST", typeof(TaxExemptTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/get-where/{pageNumber}", "POST", typeof(TaxExemptTypeController), "GetWhere")]
        [InlineData("/api/core/tax-exempt-type/get-where/{pageNumber}", "POST", typeof(TaxExemptTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/add-or-edit", "POST", typeof(TaxExemptTypeController), "AddOrEdit")]
        [InlineData("/api/core/tax-exempt-type/add-or-edit", "POST", typeof(TaxExemptTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/add/{taxExemptType}", "POST", typeof(TaxExemptTypeController), "Add")]
        [InlineData("/api/core/tax-exempt-type/add/{taxExemptType}", "POST", typeof(TaxExemptTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/bulk-import", "POST", typeof(TaxExemptTypeController), "BulkImport")]
        [InlineData("/api/core/tax-exempt-type/bulk-import", "POST", typeof(TaxExemptTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/meta", "GET", typeof(TaxExemptTypeController), "GetEntityView")]
        [InlineData("/api/core/tax-exempt-type/meta", "GET", typeof(TaxExemptTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/count", "GET", typeof(TaxExemptTypeController), "Count")]
        [InlineData("/api/core/tax-exempt-type/count", "GET", typeof(TaxExemptTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/all", "GET", typeof(TaxExemptTypeController), "GetAll")]
        [InlineData("/api/core/tax-exempt-type/all", "GET", typeof(TaxExemptTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/export", "GET", typeof(TaxExemptTypeController), "Export")]
        [InlineData("/api/core/tax-exempt-type/export", "GET", typeof(TaxExemptTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/1", "GET", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/core/tax-exempt-type/1", "GET", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/get?taxExemptTypeIds=1", "GET", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/core/tax-exempt-type/get?taxExemptTypeIds=1", "GET", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type", "GET", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-exempt-type", "GET", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/page/1", "GET", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-exempt-type/page/1", "GET", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/count-filtered/{filterName}", "GET", typeof(TaxExemptTypeController), "CountFiltered")]
        [InlineData("/api/core/tax-exempt-type/count-filtered/{filterName}", "GET", typeof(TaxExemptTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxExemptTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-exempt-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxExemptTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-exempt-type/first", "GET", typeof(TaxExemptTypeController), "GetFirst")]
        [InlineData("/api/core/tax-exempt-type/previous/1", "GET", typeof(TaxExemptTypeController), "GetPrevious")]
        [InlineData("/api/core/tax-exempt-type/next/1", "GET", typeof(TaxExemptTypeController), "GetNext")]
        [InlineData("/api/core/tax-exempt-type/last", "GET", typeof(TaxExemptTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/custom-fields", "GET", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-exempt-type/custom-fields", "GET", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/custom-fields/{resourceId}", "GET", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-exempt-type/custom-fields/{resourceId}", "GET", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/meta", "HEAD", typeof(TaxExemptTypeController), "GetEntityView")]
        [InlineData("/api/core/tax-exempt-type/meta", "HEAD", typeof(TaxExemptTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/count", "HEAD", typeof(TaxExemptTypeController), "Count")]
        [InlineData("/api/core/tax-exempt-type/count", "HEAD", typeof(TaxExemptTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/all", "HEAD", typeof(TaxExemptTypeController), "GetAll")]
        [InlineData("/api/core/tax-exempt-type/all", "HEAD", typeof(TaxExemptTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/export", "HEAD", typeof(TaxExemptTypeController), "Export")]
        [InlineData("/api/core/tax-exempt-type/export", "HEAD", typeof(TaxExemptTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/1", "HEAD", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/core/tax-exempt-type/1", "HEAD", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/get?taxExemptTypeIds=1", "HEAD", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/core/tax-exempt-type/get?taxExemptTypeIds=1", "HEAD", typeof(TaxExemptTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type", "HEAD", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-exempt-type", "HEAD", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/page/1", "HEAD", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-exempt-type/page/1", "HEAD", typeof(TaxExemptTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/count-filtered/{filterName}", "HEAD", typeof(TaxExemptTypeController), "CountFiltered")]
        [InlineData("/api/core/tax-exempt-type/count-filtered/{filterName}", "HEAD", typeof(TaxExemptTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxExemptTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-exempt-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxExemptTypeController), "GetFiltered")]
        [InlineData("/api/core/tax-exempt-type/first", "HEAD", typeof(TaxExemptTypeController), "GetFirst")]
        [InlineData("/api/core/tax-exempt-type/previous/1", "HEAD", typeof(TaxExemptTypeController), "GetPrevious")]
        [InlineData("/api/core/tax-exempt-type/next/1", "HEAD", typeof(TaxExemptTypeController), "GetNext")]
        [InlineData("/api/core/tax-exempt-type/last", "HEAD", typeof(TaxExemptTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/custom-fields", "HEAD", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-exempt-type/custom-fields", "HEAD", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-exempt-type/custom-fields/{resourceId}", "HEAD", typeof(TaxExemptTypeController), "GetCustomFields")]
        [InlineData("/api/core/tax-exempt-type/custom-fields/{resourceId}", "HEAD", typeof(TaxExemptTypeController), "GetCustomFields")]

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

        public TaxExemptTypeRouteTests()
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