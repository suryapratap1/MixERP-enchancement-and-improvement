// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetDefaultCurrencyCodeTests
    {
        public static GetDefaultCurrencyCodeController Fixture()
        {
            GetDefaultCurrencyCodeController controller = new GetDefaultCurrencyCodeController(new GetDefaultCurrencyCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetDefaultCurrencyCodeController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}