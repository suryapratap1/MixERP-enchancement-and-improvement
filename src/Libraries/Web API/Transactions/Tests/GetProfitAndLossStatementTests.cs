// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetProfitAndLossStatementTests
    {
        public static GetProfitAndLossStatementController Fixture()
        {
            GetProfitAndLossStatementController controller = new GetProfitAndLossStatementController(new GetProfitAndLossStatementRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetProfitAndLossStatementController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}