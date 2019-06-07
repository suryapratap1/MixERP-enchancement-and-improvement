// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetExchangeRateTests
    {
        public static GetExchangeRateController Fixture()
        {
            GetExchangeRateController controller = new GetExchangeRateController(new GetExchangeRateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetExchangeRateController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}