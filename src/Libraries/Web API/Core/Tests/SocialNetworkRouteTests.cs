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
    public class SocialNetworkRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/social-network/delete/{socialNetworkName}", "DELETE", typeof(SocialNetworkController), "Delete")]
        [InlineData("/api/core/social-network/delete/{socialNetworkName}", "DELETE", typeof(SocialNetworkController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/edit/{socialNetworkName}", "PUT", typeof(SocialNetworkController), "Edit")]
        [InlineData("/api/core/social-network/edit/{socialNetworkName}", "PUT", typeof(SocialNetworkController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/count-where", "POST", typeof(SocialNetworkController), "CountWhere")]
        [InlineData("/api/core/social-network/count-where", "POST", typeof(SocialNetworkController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/get-where/{pageNumber}", "POST", typeof(SocialNetworkController), "GetWhere")]
        [InlineData("/api/core/social-network/get-where/{pageNumber}", "POST", typeof(SocialNetworkController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/add-or-edit", "POST", typeof(SocialNetworkController), "AddOrEdit")]
        [InlineData("/api/core/social-network/add-or-edit", "POST", typeof(SocialNetworkController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/add/{socialNetwork}", "POST", typeof(SocialNetworkController), "Add")]
        [InlineData("/api/core/social-network/add/{socialNetwork}", "POST", typeof(SocialNetworkController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/bulk-import", "POST", typeof(SocialNetworkController), "BulkImport")]
        [InlineData("/api/core/social-network/bulk-import", "POST", typeof(SocialNetworkController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/meta", "GET", typeof(SocialNetworkController), "GetEntityView")]
        [InlineData("/api/core/social-network/meta", "GET", typeof(SocialNetworkController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/count", "GET", typeof(SocialNetworkController), "Count")]
        [InlineData("/api/core/social-network/count", "GET", typeof(SocialNetworkController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/all", "GET", typeof(SocialNetworkController), "GetAll")]
        [InlineData("/api/core/social-network/all", "GET", typeof(SocialNetworkController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/export", "GET", typeof(SocialNetworkController), "Export")]
        [InlineData("/api/core/social-network/export", "GET", typeof(SocialNetworkController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/1", "GET", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/core/social-network/1", "GET", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/get?socialNetworkNames=1", "GET", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/core/social-network/get?socialNetworkNames=1", "GET", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/social-network", "GET", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/core/social-network", "GET", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/page/1", "GET", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/core/social-network/page/1", "GET", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/count-filtered/{filterName}", "GET", typeof(SocialNetworkController), "CountFiltered")]
        [InlineData("/api/core/social-network/count-filtered/{filterName}", "GET", typeof(SocialNetworkController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SocialNetworkController), "GetFiltered")]
        [InlineData("/api/core/social-network/get-filtered/{pageNumber}/{filterName}", "GET", typeof(SocialNetworkController), "GetFiltered")]
        [InlineData("/api/core/social-network/first", "GET", typeof(SocialNetworkController), "GetFirst")]
        [InlineData("/api/core/social-network/previous/1", "GET", typeof(SocialNetworkController), "GetPrevious")]
        [InlineData("/api/core/social-network/next/1", "GET", typeof(SocialNetworkController), "GetNext")]
        [InlineData("/api/core/social-network/last", "GET", typeof(SocialNetworkController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/social-network/custom-fields", "GET", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/core/social-network/custom-fields", "GET", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/custom-fields/{resourceId}", "GET", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/core/social-network/custom-fields/{resourceId}", "GET", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/meta", "HEAD", typeof(SocialNetworkController), "GetEntityView")]
        [InlineData("/api/core/social-network/meta", "HEAD", typeof(SocialNetworkController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/count", "HEAD", typeof(SocialNetworkController), "Count")]
        [InlineData("/api/core/social-network/count", "HEAD", typeof(SocialNetworkController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/all", "HEAD", typeof(SocialNetworkController), "GetAll")]
        [InlineData("/api/core/social-network/all", "HEAD", typeof(SocialNetworkController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/export", "HEAD", typeof(SocialNetworkController), "Export")]
        [InlineData("/api/core/social-network/export", "HEAD", typeof(SocialNetworkController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/1", "HEAD", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/core/social-network/1", "HEAD", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/get?socialNetworkNames=1", "HEAD", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/core/social-network/get?socialNetworkNames=1", "HEAD", typeof(SocialNetworkController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/social-network", "HEAD", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/core/social-network", "HEAD", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/page/1", "HEAD", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/core/social-network/page/1", "HEAD", typeof(SocialNetworkController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/count-filtered/{filterName}", "HEAD", typeof(SocialNetworkController), "CountFiltered")]
        [InlineData("/api/core/social-network/count-filtered/{filterName}", "HEAD", typeof(SocialNetworkController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SocialNetworkController), "GetFiltered")]
        [InlineData("/api/core/social-network/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(SocialNetworkController), "GetFiltered")]
        [InlineData("/api/core/social-network/first", "HEAD", typeof(SocialNetworkController), "GetFirst")]
        [InlineData("/api/core/social-network/previous/1", "HEAD", typeof(SocialNetworkController), "GetPrevious")]
        [InlineData("/api/core/social-network/next/1", "HEAD", typeof(SocialNetworkController), "GetNext")]
        [InlineData("/api/core/social-network/last", "HEAD", typeof(SocialNetworkController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/social-network/custom-fields", "HEAD", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/core/social-network/custom-fields", "HEAD", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/social-network/custom-fields/{resourceId}", "HEAD", typeof(SocialNetworkController), "GetCustomFields")]
        [InlineData("/api/core/social-network/custom-fields/{resourceId}", "HEAD", typeof(SocialNetworkController), "GetCustomFields")]

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

        public SocialNetworkRouteTests()
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