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
    public class PartyTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/party-type/delete/{partyTypeId}", "DELETE", typeof(PartyTypeController), "Delete")]
        [InlineData("/api/core/party-type/delete/{partyTypeId}", "DELETE", typeof(PartyTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/edit/{partyTypeId}", "PUT", typeof(PartyTypeController), "Edit")]
        [InlineData("/api/core/party-type/edit/{partyTypeId}", "PUT", typeof(PartyTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/count-where", "POST", typeof(PartyTypeController), "CountWhere")]
        [InlineData("/api/core/party-type/count-where", "POST", typeof(PartyTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/get-where/{pageNumber}", "POST", typeof(PartyTypeController), "GetWhere")]
        [InlineData("/api/core/party-type/get-where/{pageNumber}", "POST", typeof(PartyTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/add-or-edit", "POST", typeof(PartyTypeController), "AddOrEdit")]
        [InlineData("/api/core/party-type/add-or-edit", "POST", typeof(PartyTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/add/{partyType}", "POST", typeof(PartyTypeController), "Add")]
        [InlineData("/api/core/party-type/add/{partyType}", "POST", typeof(PartyTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/bulk-import", "POST", typeof(PartyTypeController), "BulkImport")]
        [InlineData("/api/core/party-type/bulk-import", "POST", typeof(PartyTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/meta", "GET", typeof(PartyTypeController), "GetEntityView")]
        [InlineData("/api/core/party-type/meta", "GET", typeof(PartyTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/count", "GET", typeof(PartyTypeController), "Count")]
        [InlineData("/api/core/party-type/count", "GET", typeof(PartyTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/all", "GET", typeof(PartyTypeController), "GetAll")]
        [InlineData("/api/core/party-type/all", "GET", typeof(PartyTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/export", "GET", typeof(PartyTypeController), "Export")]
        [InlineData("/api/core/party-type/export", "GET", typeof(PartyTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/1", "GET", typeof(PartyTypeController), "Get")]
        [InlineData("/api/core/party-type/1", "GET", typeof(PartyTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/get?partyTypeIds=1", "GET", typeof(PartyTypeController), "Get")]
        [InlineData("/api/core/party-type/get?partyTypeIds=1", "GET", typeof(PartyTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-type", "GET", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/party-type", "GET", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/page/1", "GET", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/party-type/page/1", "GET", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/count-filtered/{filterName}", "GET", typeof(PartyTypeController), "CountFiltered")]
        [InlineData("/api/core/party-type/count-filtered/{filterName}", "GET", typeof(PartyTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyTypeController), "GetFiltered")]
        [InlineData("/api/core/party-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(PartyTypeController), "GetFiltered")]
        [InlineData("/api/core/party-type/first", "GET", typeof(PartyTypeController), "GetFirst")]
        [InlineData("/api/core/party-type/previous/1", "GET", typeof(PartyTypeController), "GetPrevious")]
        [InlineData("/api/core/party-type/next/1", "GET", typeof(PartyTypeController), "GetNext")]
        [InlineData("/api/core/party-type/last", "GET", typeof(PartyTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/party-type/custom-fields", "GET", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/core/party-type/custom-fields", "GET", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/custom-fields/{resourceId}", "GET", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/core/party-type/custom-fields/{resourceId}", "GET", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/meta", "HEAD", typeof(PartyTypeController), "GetEntityView")]
        [InlineData("/api/core/party-type/meta", "HEAD", typeof(PartyTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/count", "HEAD", typeof(PartyTypeController), "Count")]
        [InlineData("/api/core/party-type/count", "HEAD", typeof(PartyTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/all", "HEAD", typeof(PartyTypeController), "GetAll")]
        [InlineData("/api/core/party-type/all", "HEAD", typeof(PartyTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/export", "HEAD", typeof(PartyTypeController), "Export")]
        [InlineData("/api/core/party-type/export", "HEAD", typeof(PartyTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/1", "HEAD", typeof(PartyTypeController), "Get")]
        [InlineData("/api/core/party-type/1", "HEAD", typeof(PartyTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/get?partyTypeIds=1", "HEAD", typeof(PartyTypeController), "Get")]
        [InlineData("/api/core/party-type/get?partyTypeIds=1", "HEAD", typeof(PartyTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/party-type", "HEAD", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/party-type", "HEAD", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/page/1", "HEAD", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/party-type/page/1", "HEAD", typeof(PartyTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/count-filtered/{filterName}", "HEAD", typeof(PartyTypeController), "CountFiltered")]
        [InlineData("/api/core/party-type/count-filtered/{filterName}", "HEAD", typeof(PartyTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyTypeController), "GetFiltered")]
        [InlineData("/api/core/party-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(PartyTypeController), "GetFiltered")]
        [InlineData("/api/core/party-type/first", "HEAD", typeof(PartyTypeController), "GetFirst")]
        [InlineData("/api/core/party-type/previous/1", "HEAD", typeof(PartyTypeController), "GetPrevious")]
        [InlineData("/api/core/party-type/next/1", "HEAD", typeof(PartyTypeController), "GetNext")]
        [InlineData("/api/core/party-type/last", "HEAD", typeof(PartyTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/party-type/custom-fields", "HEAD", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/core/party-type/custom-fields", "HEAD", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/party-type/custom-fields/{resourceId}", "HEAD", typeof(PartyTypeController), "GetCustomFields")]
        [InlineData("/api/core/party-type/custom-fields/{resourceId}", "HEAD", typeof(PartyTypeController), "GetCustomFields")]

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

        public PartyTypeRouteTests()
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