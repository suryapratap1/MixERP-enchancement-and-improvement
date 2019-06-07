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
    public class TaxAuthorityRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/delete/{taxAuthorityId}", "DELETE", typeof(TaxAuthorityController), "Delete")]
        [InlineData("/api/core/tax-authority/delete/{taxAuthorityId}", "DELETE", typeof(TaxAuthorityController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/edit/{taxAuthorityId}", "PUT", typeof(TaxAuthorityController), "Edit")]
        [InlineData("/api/core/tax-authority/edit/{taxAuthorityId}", "PUT", typeof(TaxAuthorityController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/count-where", "POST", typeof(TaxAuthorityController), "CountWhere")]
        [InlineData("/api/core/tax-authority/count-where", "POST", typeof(TaxAuthorityController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/get-where/{pageNumber}", "POST", typeof(TaxAuthorityController), "GetWhere")]
        [InlineData("/api/core/tax-authority/get-where/{pageNumber}", "POST", typeof(TaxAuthorityController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/add-or-edit", "POST", typeof(TaxAuthorityController), "AddOrEdit")]
        [InlineData("/api/core/tax-authority/add-or-edit", "POST", typeof(TaxAuthorityController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/add/{taxAuthority}", "POST", typeof(TaxAuthorityController), "Add")]
        [InlineData("/api/core/tax-authority/add/{taxAuthority}", "POST", typeof(TaxAuthorityController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/bulk-import", "POST", typeof(TaxAuthorityController), "BulkImport")]
        [InlineData("/api/core/tax-authority/bulk-import", "POST", typeof(TaxAuthorityController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/meta", "GET", typeof(TaxAuthorityController), "GetEntityView")]
        [InlineData("/api/core/tax-authority/meta", "GET", typeof(TaxAuthorityController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/count", "GET", typeof(TaxAuthorityController), "Count")]
        [InlineData("/api/core/tax-authority/count", "GET", typeof(TaxAuthorityController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/all", "GET", typeof(TaxAuthorityController), "GetAll")]
        [InlineData("/api/core/tax-authority/all", "GET", typeof(TaxAuthorityController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/export", "GET", typeof(TaxAuthorityController), "Export")]
        [InlineData("/api/core/tax-authority/export", "GET", typeof(TaxAuthorityController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/1", "GET", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/core/tax-authority/1", "GET", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/get?taxAuthorityIds=1", "GET", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/core/tax-authority/get?taxAuthorityIds=1", "GET", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority", "GET", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-authority", "GET", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/page/1", "GET", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-authority/page/1", "GET", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/count-filtered/{filterName}", "GET", typeof(TaxAuthorityController), "CountFiltered")]
        [InlineData("/api/core/tax-authority/count-filtered/{filterName}", "GET", typeof(TaxAuthorityController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxAuthorityController), "GetFiltered")]
        [InlineData("/api/core/tax-authority/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxAuthorityController), "GetFiltered")]
        [InlineData("/api/core/tax-authority/first", "GET", typeof(TaxAuthorityController), "GetFirst")]
        [InlineData("/api/core/tax-authority/previous/1", "GET", typeof(TaxAuthorityController), "GetPrevious")]
        [InlineData("/api/core/tax-authority/next/1", "GET", typeof(TaxAuthorityController), "GetNext")]
        [InlineData("/api/core/tax-authority/last", "GET", typeof(TaxAuthorityController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-authority/custom-fields", "GET", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/core/tax-authority/custom-fields", "GET", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/custom-fields/{resourceId}", "GET", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/core/tax-authority/custom-fields/{resourceId}", "GET", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/meta", "HEAD", typeof(TaxAuthorityController), "GetEntityView")]
        [InlineData("/api/core/tax-authority/meta", "HEAD", typeof(TaxAuthorityController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/count", "HEAD", typeof(TaxAuthorityController), "Count")]
        [InlineData("/api/core/tax-authority/count", "HEAD", typeof(TaxAuthorityController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/all", "HEAD", typeof(TaxAuthorityController), "GetAll")]
        [InlineData("/api/core/tax-authority/all", "HEAD", typeof(TaxAuthorityController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/export", "HEAD", typeof(TaxAuthorityController), "Export")]
        [InlineData("/api/core/tax-authority/export", "HEAD", typeof(TaxAuthorityController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/1", "HEAD", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/core/tax-authority/1", "HEAD", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/get?taxAuthorityIds=1", "HEAD", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/core/tax-authority/get?taxAuthorityIds=1", "HEAD", typeof(TaxAuthorityController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority", "HEAD", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-authority", "HEAD", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/page/1", "HEAD", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-authority/page/1", "HEAD", typeof(TaxAuthorityController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/count-filtered/{filterName}", "HEAD", typeof(TaxAuthorityController), "CountFiltered")]
        [InlineData("/api/core/tax-authority/count-filtered/{filterName}", "HEAD", typeof(TaxAuthorityController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxAuthorityController), "GetFiltered")]
        [InlineData("/api/core/tax-authority/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxAuthorityController), "GetFiltered")]
        [InlineData("/api/core/tax-authority/first", "HEAD", typeof(TaxAuthorityController), "GetFirst")]
        [InlineData("/api/core/tax-authority/previous/1", "HEAD", typeof(TaxAuthorityController), "GetPrevious")]
        [InlineData("/api/core/tax-authority/next/1", "HEAD", typeof(TaxAuthorityController), "GetNext")]
        [InlineData("/api/core/tax-authority/last", "HEAD", typeof(TaxAuthorityController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-authority/custom-fields", "HEAD", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/core/tax-authority/custom-fields", "HEAD", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-authority/custom-fields/{resourceId}", "HEAD", typeof(TaxAuthorityController), "GetCustomFields")]
        [InlineData("/api/core/tax-authority/custom-fields/{resourceId}", "HEAD", typeof(TaxAuthorityController), "GetCustomFields")]

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

        public TaxAuthorityRouteTests()
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