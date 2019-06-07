// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class ListClosingStockTests
    {
        public static ListClosingStockController Fixture()
        {
            ListClosingStockController controller = new ListClosingStockController(new ListClosingStockRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new ListClosingStockController.Annotation());
            Assert.NotNull(actual);
        }
    }
}