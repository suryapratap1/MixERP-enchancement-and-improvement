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
    public class PartyRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/party/delete/{partyId}", "DELETE", typeof(PartyController), "Delete")]
        [InlineData("/api/core/party/delete/{partyId}", "DELETE", typeof(PartyController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/party/edit/{partyId}", "PUT", typeof(PartyController), "Edit")]
        [InlineData("/api/core/party/edit/{partyId}", "PUT", typeof(PartyController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/party/count-where", "POST", typeof(PartyController), "CountWhere")]
        [InlineData("/api/core/party/count-where", "POST", typeof(PartyController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/party/get-where/{pageNumber}", "POST", typeof(PartyController), "GetWhere")]
        [InlineData("/api/core/party/get-where/{pageNumber}", "POST", typeof(PartyController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/party/add-or-edit", "POST", typeof(PartyController), "AddOrEdit")]
        [InlineData("/api/core/party/add-or-edit", "POST", typeof(PartyController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/party/add/{party}", "POST", typeof(PartyController), "Add")]
        [InlineData("/api/core/party/add/{party}", "POST", typeof(PartyController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/party/bulk-import", "POST", typeof(PartyController), "BulkImport")]
        [InlineData("/api/core/party/bulk-import", "POST", typeof(PartyController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/party/meta", "GET", typeof(PartyController), "GetEntityView")]
        [InlineData("/api/core/party/meta", "GET", typeof(PartyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/party/count", "GET", typeof(PartyController), "Count")]
        [InlineData("/api/core/party/count", "GET", typeof(PartyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/party/all", "GET", typeof(PartyController), "GetAll")]
        [InlineData("/api/core/party/all", "GET", typeof(PartyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/party/export", "GET", typeof(PartyController), "Export")]
        [InlineData("/api/core/party/export", "GET", typeof(PartyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/party/1", "GET", typeof(PartyController), "Get")]
        [InlineData("/api/core/party/1", "GET", typeof(PartyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party/get?partyIds=1", "GET", typeof(PartyController), "Get")]
        [InlineData("/api/core/party/get?partyIds=1", "GET", typeof(PartyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party", "GET", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/core/party", "GET", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party/page/1", "GET", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/core/party/page/1", "GET", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party/count-filtered/{filterName}", "GET", typeof(PartyController), "CountFiltered")]
        [InlineData("/api/core/party/count-filtered/{filterName}", "GET", typeof(PartyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyController), "GetFiltered")]
        [InlineData("/api/core/party/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyController), "GetFiltered")]
        [InlineData("/api/core/party/first", "GET", typeof(PartyController), "GetFirst")]
        [InlineData("/api/core/party/previous/1", "GET", typeof(PartyController), "GetPrevious")]
        [InlineData("/api/core/party/next/1", "GET", typeof(PartyController), "GetNext")]
        [InlineData("/api/core/party/last", "GET", typeof(PartyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/party/custom-fields", "GET", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/core/party/custom-fields", "GET", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/party/custom-fields/{resourceId}", "GET", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/core/party/custom-fields/{resourceId}", "GET", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/party/meta", "HEAD", typeof(PartyController), "GetEntityView")]
        [InlineData("/api/core/party/meta", "HEAD", typeof(PartyController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/party/count", "HEAD", typeof(PartyController), "Count")]
        [InlineData("/api/core/party/count", "HEAD", typeof(PartyController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/party/all", "HEAD", typeof(PartyController), "GetAll")]
        [InlineData("/api/core/party/all", "HEAD", typeof(PartyController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/party/export", "HEAD", typeof(PartyController), "Export")]
        [InlineData("/api/core/party/export", "HEAD", typeof(PartyController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/party/1", "HEAD", typeof(PartyController), "Get")]
        [InlineData("/api/core/party/1", "HEAD", typeof(PartyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party/get?partyIds=1", "HEAD", typeof(PartyController), "Get")]
        [InlineData("/api/core/party/get?partyIds=1", "HEAD", typeof(PartyController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party", "HEAD", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/core/party", "HEAD", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party/page/1", "HEAD", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/core/party/page/1", "HEAD", typeof(PartyController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party/count-filtered/{filterName}", "HEAD", typeof(PartyController), "CountFiltered")]
        [InlineData("/api/core/party/count-filtered/{filterName}", "HEAD", typeof(PartyController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyController), "GetFiltered")]
        [InlineData("/api/core/party/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyController), "GetFiltered")]
        [InlineData("/api/core/party/first", "HEAD", typeof(PartyController), "GetFirst")]
        [InlineData("/api/core/party/previous/1", "HEAD", typeof(PartyController), "GetPrevious")]
        [InlineData("/api/core/party/next/1", "HEAD", typeof(PartyController), "GetNext")]
        [InlineData("/api/core/party/last", "HEAD", typeof(PartyController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/party/custom-fields", "HEAD", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/core/party/custom-fields", "HEAD", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/party/custom-fields/{resourceId}", "HEAD", typeof(PartyController), "GetCustomFields")]
        [InlineData("/api/core/party/custom-fields/{resourceId}", "HEAD", typeof(PartyController), "GetCustomFields")]

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

        public PartyRouteTests()
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