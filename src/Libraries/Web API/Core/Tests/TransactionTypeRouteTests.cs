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
    public class TransactionTypeRouteTests
    {
        [Theory]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/delete/{transactionTypeId}", "DELETE", typeof(TransactionTypeController), "Delete")]
        [InlineData("/api/core/transaction-type/delete/{transactionTypeId}", "DELETE", typeof(TransactionTypeController), "Delete")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/edit/{transactionTypeId}", "PUT", typeof(TransactionTypeController), "Edit")]
        [InlineData("/api/core/transaction-type/edit/{transactionTypeId}", "PUT", typeof(TransactionTypeController), "Edit")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/count-where", "POST", typeof(TransactionTypeController), "CountWhere")]
        [InlineData("/api/core/transaction-type/count-where", "POST", typeof(TransactionTypeController), "CountWhere")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/get-where/{pageNumber}", "POST", typeof(TransactionTypeController), "GetWhere")]
        [InlineData("/api/core/transaction-type/get-where/{pageNumber}", "POST", typeof(TransactionTypeController), "GetWhere")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/add-or-edit", "POST", typeof(TransactionTypeController), "AddOrEdit")]
        [InlineData("/api/core/transaction-type/add-or-edit", "POST", typeof(TransactionTypeController), "AddOrEdit")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/add/{transactionType}", "POST", typeof(TransactionTypeController), "Add")]
        [InlineData("/api/core/transaction-type/add/{transactionType}", "POST", typeof(TransactionTypeController), "Add")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/bulk-import", "POST", typeof(TransactionTypeController), "BulkImport")]
        [InlineData("/api/core/transaction-type/bulk-import", "POST", typeof(TransactionTypeController), "BulkImport")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/meta", "GET", typeof(TransactionTypeController), "GetEntityView")]
        [InlineData("/api/core/transaction-type/meta", "GET", typeof(TransactionTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/count", "GET", typeof(TransactionTypeController), "Count")]
        [InlineData("/api/core/transaction-type/count", "GET", typeof(TransactionTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/all", "GET", typeof(TransactionTypeController), "GetAll")]
        [InlineData("/api/core/transaction-type/all", "GET", typeof(TransactionTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/export", "GET", typeof(TransactionTypeController), "Export")]
        [InlineData("/api/core/transaction-type/export", "GET", typeof(TransactionTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/1", "GET", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/core/transaction-type/1", "GET", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/get?transactionTypeIds=1", "GET", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/core/transaction-type/get?transactionTypeIds=1", "GET", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type", "GET", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/transaction-type", "GET", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/page/1", "GET", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/transaction-type/page/1", "GET", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/count-filtered/{filterName}", "GET", typeof(TransactionTypeController), "CountFiltered")]
        [InlineData("/api/core/transaction-type/count-filtered/{filterName}", "GET", typeof(TransactionTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionTypeController), "GetFiltered")]
        [InlineData("/api/core/transaction-type/get-filtered/{pageNumber}/{filterName}", "GET", typeof(TransactionTypeController), "GetFiltered")]
        [InlineData("/api/core/transaction-type/first", "GET", typeof(TransactionTypeController), "GetFirst")]
        [InlineData("/api/core/transaction-type/previous/1", "GET", typeof(TransactionTypeController), "GetPrevious")]
        [InlineData("/api/core/transaction-type/next/1", "GET", typeof(TransactionTypeController), "GetNext")]
        [InlineData("/api/core/transaction-type/last", "GET", typeof(TransactionTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/transaction-type/custom-fields", "GET", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/core/transaction-type/custom-fields", "GET", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/custom-fields/{resourceId}", "GET", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/core/transaction-type/custom-fields/{resourceId}", "GET", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/meta", "HEAD", typeof(TransactionTypeController), "GetEntityView")]
        [InlineData("/api/core/transaction-type/meta", "HEAD", typeof(TransactionTypeController), "GetEntityView")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/count", "HEAD", typeof(TransactionTypeController), "Count")]
        [InlineData("/api/core/transaction-type/count", "HEAD", typeof(TransactionTypeController), "Count")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/all", "HEAD", typeof(TransactionTypeController), "GetAll")]
        [InlineData("/api/core/transaction-type/all", "HEAD", typeof(TransactionTypeController), "GetAll")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/export", "HEAD", typeof(TransactionTypeController), "Export")]
        [InlineData("/api/core/transaction-type/export", "HEAD", typeof(TransactionTypeController), "Export")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/1", "HEAD", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/core/transaction-type/1", "HEAD", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/get?transactionTypeIds=1", "HEAD", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/core/transaction-type/get?transactionTypeIds=1", "HEAD", typeof(TransactionTypeController), "Get")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type", "HEAD", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/transaction-type", "HEAD", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/page/1", "HEAD", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/core/transaction-type/page/1", "HEAD", typeof(TransactionTypeController), "GetPaginatedResult")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/count-filtered/{filterName}", "HEAD", typeof(TransactionTypeController), "CountFiltered")]
        [InlineData("/api/core/transaction-type/count-filtered/{filterName}", "HEAD", typeof(TransactionTypeController), "CountFiltered")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionTypeController), "GetFiltered")]
        [InlineData("/api/core/transaction-type/get-filtered/{pageNumber}/{filterName}", "HEAD", typeof(TransactionTypeController), "GetFiltered")]
        [InlineData("/api/core/transaction-type/first", "HEAD", typeof(TransactionTypeController), "GetFirst")]
        [InlineData("/api/core/transaction-type/previous/1", "HEAD", typeof(TransactionTypeController), "GetPrevious")]
        [InlineData("/api/core/transaction-type/next/1", "HEAD", typeof(TransactionTypeController), "GetNext")]
        [InlineData("/api/core/transaction-type/last", "HEAD", typeof(TransactionTypeController), "GetLast")]

        [InlineData("/api/{apiVersionNumber}/core/transaction-type/custom-fields", "HEAD", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/core/transaction-type/custom-fields", "HEAD", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/{apiVersionNumber}/core/transaction-type/custom-fields/{resourceId}", "HEAD", typeof(TransactionTypeController), "GetCustomFields")]
        [InlineData("/api/core/transaction-type/custom-fields/{resourceId}", "HEAD", typeof(TransactionTypeController), "GetCustomFields")]

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

        public TransactionTypeRouteTests()
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