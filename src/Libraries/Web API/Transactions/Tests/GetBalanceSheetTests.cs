// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetBalanceSheetTests
    {
        public static GetBalanceSheetController Fixture()
        {
            GetBalanceSheetController controller = new GetBalanceSheetController(new GetBalanceSheetRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetBalanceSheetController.Annotation());
            Assert.NotNull(actual);
        }
    }
}