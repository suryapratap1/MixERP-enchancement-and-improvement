// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetStockAccountStatementTests
    {
        public static GetStockAccountStatementController Fixture()
        {
            GetStockAccountStatementController controller = new GetStockAccountStatementController(new GetStockAccountStatementRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetStockAccountStatementController.Annotation());
            Assert.NotNull(actual);
        }
    }
}