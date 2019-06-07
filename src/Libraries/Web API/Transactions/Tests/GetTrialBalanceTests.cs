// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetTrialBalanceTests
    {
        public static GetTrialBalanceController Fixture()
        {
            GetTrialBalanceController controller = new GetTrialBalanceController(new GetTrialBalanceRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetTrialBalanceController.Annotation());
            Assert.NotNull(actual);
        }
    }
}