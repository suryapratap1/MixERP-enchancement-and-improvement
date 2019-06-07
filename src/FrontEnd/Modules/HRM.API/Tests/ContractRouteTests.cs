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

namespace MixERP.Net.Api.HRM.Tests
{
    public class ContractRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/delete/{contractId}", "DELETE", typeof(ContractController), "Delete")]
        [InlineData("/api/hrm/contract/delete/{contractId}", "DELETE", typeof(ContractController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/edit/{contractId}", "PUT", typeof(ContractController), "Edit")]
        [InlineData("/api/hrm/contract/edit/{contractId}", "PUT", typeof(ContractController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/verify/{contractId}/{verificationStatusId}/{reason}", "PUT", typeof(ContractController), "Verifiy")]
        [InlineData("/api/hrm/contract/verify/{contractId}/{verificationStatusId}/{reason}", "PUT", typeof(ContractController), "Verifiy")]

        [InlineData("/api/{apiVersionNumber}/hrm/contract/count-where", "POST", typeof(ContractController), "CountWhere")]
        [InlineData("/api/hrm/contract/count-where", "POST", typeof(ContractController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/get-where/{pageNumber}", "POST", typeof(ContractController), "GetWhere")]
        [InlineData("/api/hrm/contract/get-where/{pageNumber}", "POST", typeof(ContractController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/add-or-edit", "POST", typeof(ContractController), "AddOrEdit")]
        [InlineData("/api/hrm/contract/add-or-edit", "POST", typeof(ContractController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/add/{contract}", "POST", typeof(ContractController), "Add")]
        [InlineData("/api/hrm/contract/add/{contract}", "POST", typeof(ContractController), "Add")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/bulk-import", "POST", typeof(ContractController), "BulkImport")]
        [InlineData("/api/hrm/contract/bulk-import", "POST", typeof(ContractController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/meta", "GET", typeof(ContractController), "GetEntityView")]
        [InlineData("/api/hrm/contract/meta", "GET", typeof(ContractController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/count", "GET", typeof(ContractController), "Count")]
        [InlineData("/api/hrm/contract/count", "GET", typeof(ContractController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/all", "GET", typeof(ContractController), "GetAll")]
        [InlineData("/api/hrm/contract/all", "GET", typeof(ContractController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/export", "GET", typeof(ContractController), "Export")]
        [InlineData("/api/hrm/contract/export", "GET", typeof(ContractController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/1", "GET", typeof(ContractController), "Get")]
        [InlineData("/api/hrm/contract/1", "GET", typeof(ContractController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/get?contractIds=1", "GET", typeof(ContractController), "Get")]
        [InlineData("/api/hrm/contract/get?contractIds=1", "GET", typeof(ContractController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract", "GET", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/hrm/contract", "GET", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/page/1", "GET", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/hrm/contract/page/1", "GET", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/count-filtered/{filterName}", "GET", typeof(ContractController), "CountFiltered")]
        [InlineData("/api/hrm/contract/count-filtered/{filterName}", "GET", typeof(ContractController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ContractController), "GetFiltered")]
        [InlineData("/api/hrm/contract/get-filtered/{pageNumber}/{filterName}", "GET", typeof(ContractController), "GetFiltered")]
        [InlineData("/api/hrm/contract/first", "GET", typeof(ContractController), "GetFirst")]
        [InlineData("/api/hrm/contract/previous/1", "GET", typeof(ContractController), "GetPrevious")]
        [InlineData("/api/hrm/contract/next/1", "GET", typeof(ContractController), "GetNext")]
        [InlineData("/api/hrm/contract/last", "GET", typeof(ContractController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/contract/custom-fields", "GET", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/hrm/contract/custom-fields", "GET", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/custom-fields/{resourceId}", "GET", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/hrm/contract/custom-fields/{resourceId}", "GET", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/meta", "HEAD", typeof(ContractController), "GetEntityView")]
        [InlineData("/api/hrm/contract/meta", "HEAD", typeof(ContractController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/count", "HEAD", typeof(ContractController), "Count")]
        [InlineData("/api/hrm/contract/count", "HEAD", typeof(ContractController), "Count")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/all", "HEAD", typeof(ContractController), "GetAll")]
        [InlineData("/api/hrm/contract/all", "HEAD", typeof(ContractController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/export", "HEAD", typeof(ContractController), "Export")]
        [InlineData("/api/hrm/contract/export", "HEAD", typeof(ContractController), "Export")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/1", "HEAD", typeof(ContractController), "Get")]
        [InlineData("/api/hrm/contract/1", "HEAD", typeof(ContractController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/get?contractIds=1", "HEAD", typeof(ContractController), "Get")]
        [InlineData("/api/hrm/contract/get?contractIds=1", "HEAD", typeof(ContractController), "Get")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract", "HEAD", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/hrm/contract", "HEAD", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/page/1", "HEAD", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/hrm/contract/page/1", "HEAD", typeof(ContractController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/count-filtered/{filterName}", "HEAD", typeof(ContractController), "CountFiltered")]
        [InlineData("/api/hrm/contract/count-filtered/{filterName}", "HEAD", typeof(ContractController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ContractController), "GetFiltered")]
        [InlineData("/api/hrm/contract/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(ContractController), "GetFiltered")]
        [InlineData("/api/hrm/contract/first", "HEAD", typeof(ContractController), "GetFirst")]
        [InlineData("/api/hrm/contract/previous/1", "HEAD", typeof(ContractController), "GetPrevious")]
        [InlineData("/api/hrm/contract/next/1", "HEAD", typeof(ContractController), "GetNext")]
        [InlineData("/api/hrm/contract/last", "HEAD", typeof(ContractController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/hrm/contract/custom-fields", "HEAD", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/hrm/contract/custom-fields", "HEAD", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/hrm/contract/custom-fields/{resourceId}", "HEAD", typeof(ContractController), "GetCustomFields")]
        [InlineData("/api/hrm/contract/custom-fields/{resourceId}", "HEAD", typeof(ContractController), "GetCustomFields")]

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

        public ContractRouteTests()
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