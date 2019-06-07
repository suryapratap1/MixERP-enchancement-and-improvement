// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsStockItemTests
    {
        public static IsStockItemController Fixture()
        {
            IsStockItemController controller = new IsStockItemController(new IsStockItemRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsStockItemController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}