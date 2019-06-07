// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetEoyProfitSummaryTests
    {
        public static GetEoyProfitSummaryController Fixture()
        {
            GetEoyProfitSummaryController controller = new GetEoyProfitSummaryController(new GetEoyProfitSummaryRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetEoyProfitSummaryController.Annotation());
            Assert.NotNull(actual);
        }
    }
}