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
    public class CardTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/card-type/delete/{cardTypeId}", "DELETE", typeof(CardTypeController), "Delete")]
        [InlineData("/api/core/card-type/delete/{cardTypeId}", "DELETE", typeof(CardTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/edit/{cardTypeId}", "PUT", typeof(CardTypeController), "Edit")]
        [InlineData("/api/core/card-type/edit/{cardTypeId}", "PUT", typeof(CardTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/count-where", "POST", typeof(CardTypeController), "CountWhere")]
        [InlineData("/api/core/card-type/count-where", "POST", typeof(CardTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/get-where/{pageNumber}", "POST", typeof(CardTypeController), "GetWhere")]
        [InlineData("/api/core/card-type/get-where/{pageNumber}", "POST", typeof(CardTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/add-or-edit", "POST", typeof(CardTypeController), "AddOrEdit")]
        [InlineData("/api/core/card-type/add-or-edit", "POST", typeof(CardTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/add/{cardType}", "POST", typeof(CardTypeController), "Add")]
        [InlineData("/api/core/card-type/add/{cardType}", "POST", typeof(CardTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/bulk-import", "POST", typeof(CardTypeController), "BulkImport")]
        [InlineData("/api/core/card-type/bulk-import", "POST", typeof(CardTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/meta", "GET", typeof(CardTypeController), "GetEntityView")]
        [InlineData("/api/core/card-type/meta", "GET", typeof(CardTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/count", "GET", typeof(CardTypeController), "Count")]
        [InlineData("/api/core/card-type/count", "GET", typeof(CardTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/all", "GET", typeof(CardTypeController), "GetAll")]
        [InlineData("/api/core/card-type/all", "GET", typeof(CardTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/export", "GET", typeof(CardTypeController), "Export")]
        [InlineData("/api/core/card-type/export", "GET", typeof(CardTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/1", "GET", typeof(CardTypeController), "Get")]
        [InlineData("/api/core/card-type/1", "GET", typeof(CardTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/get?cardTypeIds=1", "GET", typeof(CardTypeController), "Get")]
        [InlineData("/api/core/card-type/get?cardTypeIds=1", "GET", typeof(CardTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/card-type", "GET", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/card-type", "GET", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/page/1", "GET", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/card-type/page/1", "GET", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/count-filtered/{filterName}", "GET", typeof(CardTypeController), "CountFiltered")]
        [InlineData("/api/core/card-type/count-filtered/{filterName}", "GET", typeof(CardTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CardTypeController), "GetFiltered")]
        [InlineData("/api/core/card-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(CardTypeController), "GetFiltered")]
        [InlineData("/api/core/card-type/first", "GET", typeof(CardTypeController), "GetFirst")]
        [InlineData("/api/core/card-type/previous/1", "GET", typeof(CardTypeController), "GetPrevious")]
        [InlineData("/api/core/card-type/next/1", "GET", typeof(CardTypeController), "GetNext")]
        [InlineData("/api/core/card-type/last", "GET", typeof(CardTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/card-type/custom-fields", "GET", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/core/card-type/custom-fields", "GET", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/custom-fields/{resourceId}", "GET", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/core/card-type/custom-fields/{resourceId}", "GET", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/meta", "HEAD", typeof(CardTypeController), "GetEntityView")]
        [InlineData("/api/core/card-type/meta", "HEAD", typeof(CardTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/count", "HEAD", typeof(CardTypeController), "Count")]
        [InlineData("/api/core/card-type/count", "HEAD", typeof(CardTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/all", "HEAD", typeof(CardTypeController), "GetAll")]
        [InlineData("/api/core/card-type/all", "HEAD", typeof(CardTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/export", "HEAD", typeof(CardTypeController), "Export")]
        [InlineData("/api/core/card-type/export", "HEAD", typeof(CardTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/1", "HEAD", typeof(CardTypeController), "Get")]
        [InlineData("/api/core/card-type/1", "HEAD", typeof(CardTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/get?cardTypeIds=1", "HEAD", typeof(CardTypeController), "Get")]
        [InlineData("/api/core/card-type/get?cardTypeIds=1", "HEAD", typeof(CardTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/card-type", "HEAD", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/card-type", "HEAD", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/page/1", "HEAD", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/card-type/page/1", "HEAD", typeof(CardTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/count-filtered/{filterName}", "HEAD", typeof(CardTypeController), "CountFiltered")]
        [InlineData("/api/core/card-type/count-filtered/{filterName}", "HEAD", typeof(CardTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CardTypeController), "GetFiltered")]
        [InlineData("/api/core/card-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(CardTypeController), "GetFiltered")]
        [InlineData("/api/core/card-type/first", "HEAD", typeof(CardTypeController), "GetFirst")]
        [InlineData("/api/core/card-type/previous/1", "HEAD", typeof(CardTypeController), "GetPrevious")]
        [InlineData("/api/core/card-type/next/1", "HEAD", typeof(CardTypeController), "GetNext")]
        [InlineData("/api/core/card-type/last", "HEAD", typeof(CardTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/card-type/custom-fields", "HEAD", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/core/card-type/custom-fields", "HEAD", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/card-type/custom-fields/{resourceId}", "HEAD", typeof(CardTypeController), "GetCustomFields")]
        [InlineData("/api/core/card-type/custom-fields/{resourceId}", "HEAD", typeof(CardTypeController), "GetCustomFields")]

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

        public CardTypeRouteTests()
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