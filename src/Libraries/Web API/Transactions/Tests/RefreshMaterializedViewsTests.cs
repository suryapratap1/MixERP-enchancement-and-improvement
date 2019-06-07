// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class RefreshMaterializedViewsTests
    {
        public static RefreshMaterializedViewsController Fixture()
        {
            RefreshMaterializedViewsController controller = new RefreshMaterializedViewsController(new RefreshMaterializedViewsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new RefreshMaterializedViewsController.Annotation());
        }
    }
}