// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetCashFlowStatementTests
    {
        public static GetCashFlowStatementController Fixture()
        {
            GetCashFlowStatementController controller = new GetCashFlowStatementController(new GetCashFlowStatementRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCashFlowStatementController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}