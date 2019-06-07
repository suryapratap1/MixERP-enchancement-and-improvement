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
    public class TaxMasterRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/delete/{taxMasterId}", "DELETE", typeof(TaxMasterController), "Delete")]
        [InlineData("/api/core/tax-master/delete/{taxMasterId}", "DELETE", typeof(TaxMasterController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/edit/{taxMasterId}", "PUT", typeof(TaxMasterController), "Edit")]
        [InlineData("/api/core/tax-master/edit/{taxMasterId}", "PUT", typeof(TaxMasterController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/count-where", "POST", typeof(TaxMasterController), "CountWhere")]
        [InlineData("/api/core/tax-master/count-where", "POST", typeof(TaxMasterController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/get-where/{pageNumber}", "POST", typeof(TaxMasterController), "GetWhere")]
        [InlineData("/api/core/tax-master/get-where/{pageNumber}", "POST", typeof(TaxMasterController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/add-or-edit", "POST", typeof(TaxMasterController), "AddOrEdit")]
        [InlineData("/api/core/tax-master/add-or-edit", "POST", typeof(TaxMasterController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/add/{taxMaster}", "POST", typeof(TaxMasterController), "Add")]
        [InlineData("/api/core/tax-master/add/{taxMaster}", "POST", typeof(TaxMasterController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/bulk-import", "POST", typeof(TaxMasterController), "BulkImport")]
        [InlineData("/api/core/tax-master/bulk-import", "POST", typeof(TaxMasterController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/meta", "GET", typeof(TaxMasterController), "GetEntityView")]
        [InlineData("/api/core/tax-master/meta", "GET", typeof(TaxMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/count", "GET", typeof(TaxMasterController), "Count")]
        [InlineData("/api/core/tax-master/count", "GET", typeof(TaxMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/all", "GET", typeof(TaxMasterController), "GetAll")]
        [InlineData("/api/core/tax-master/all", "GET", typeof(TaxMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/export", "GET", typeof(TaxMasterController), "Export")]
        [InlineData("/api/core/tax-master/export", "GET", typeof(TaxMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/1", "GET", typeof(TaxMasterController), "Get")]
        [InlineData("/api/core/tax-master/1", "GET", typeof(TaxMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/get?taxMasterIds=1", "GET", typeof(TaxMasterController), "Get")]
        [InlineData("/api/core/tax-master/get?taxMasterIds=1", "GET", typeof(TaxMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master", "GET", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-master", "GET", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/page/1", "GET", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-master/page/1", "GET", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/count-filtered/{filterName}", "GET", typeof(TaxMasterController), "CountFiltered")]
        [InlineData("/api/core/tax-master/count-filtered/{filterName}", "GET", typeof(TaxMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxMasterController), "GetFiltered")]
        [InlineData("/api/core/tax-master/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TaxMasterController), "GetFiltered")]
        [InlineData("/api/core/tax-master/first", "GET", typeof(TaxMasterController), "GetFirst")]
        [InlineData("/api/core/tax-master/previous/1", "GET", typeof(TaxMasterController), "GetPrevious")]
        [InlineData("/api/core/tax-master/next/1", "GET", typeof(TaxMasterController), "GetNext")]
        [InlineData("/api/core/tax-master/last", "GET", typeof(TaxMasterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-master/custom-fields", "GET", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/core/tax-master/custom-fields", "GET", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/custom-fields/{resourceId}", "GET", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/core/tax-master/custom-fields/{resourceId}", "GET", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/meta", "HEAD", typeof(TaxMasterController), "GetEntityView")]
        [InlineData("/api/core/tax-master/meta", "HEAD", typeof(TaxMasterController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/count", "HEAD", typeof(TaxMasterController), "Count")]
        [InlineData("/api/core/tax-master/count", "HEAD", typeof(TaxMasterController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/all", "HEAD", typeof(TaxMasterController), "GetAll")]
        [InlineData("/api/core/tax-master/all", "HEAD", typeof(TaxMasterController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/export", "HEAD", typeof(TaxMasterController), "Export")]
        [InlineData("/api/core/tax-master/export", "HEAD", typeof(TaxMasterController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/1", "HEAD", typeof(TaxMasterController), "Get")]
        [InlineData("/api/core/tax-master/1", "HEAD", typeof(TaxMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/get?taxMasterIds=1", "HEAD", typeof(TaxMasterController), "Get")]
        [InlineData("/api/core/tax-master/get?taxMasterIds=1", "HEAD", typeof(TaxMasterController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master", "HEAD", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-master", "HEAD", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/page/1", "HEAD", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/core/tax-master/page/1", "HEAD", typeof(TaxMasterController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/count-filtered/{filterName}", "HEAD", typeof(TaxMasterController), "CountFiltered")]
        [InlineData("/api/core/tax-master/count-filtered/{filterName}", "HEAD", typeof(TaxMasterController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxMasterController), "GetFiltered")]
        [InlineData("/api/core/tax-master/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TaxMasterController), "GetFiltered")]
        [InlineData("/api/core/tax-master/first", "HEAD", typeof(TaxMasterController), "GetFirst")]
        [InlineData("/api/core/tax-master/previous/1", "HEAD", typeof(TaxMasterController), "GetPrevious")]
        [InlineData("/api/core/tax-master/next/1", "HEAD", typeof(TaxMasterController), "GetNext")]
        [InlineData("/api/core/tax-master/last", "HEAD", typeof(TaxMasterController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/tax-master/custom-fields", "HEAD", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/core/tax-master/custom-fields", "HEAD", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/tax-master/custom-fields/{resourceId}", "HEAD", typeof(TaxMasterController), "GetCustomFields")]
        [InlineData("/api/core/tax-master/custom-fields/{resourceId}", "HEAD", typeof(TaxMasterController), "GetCustomFields")]

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

        public TaxMasterRouteTests()
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