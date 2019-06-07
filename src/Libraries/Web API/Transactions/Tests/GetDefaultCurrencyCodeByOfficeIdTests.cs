// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetDefaultCurrencyCodeByOfficeIdTests
    {
        public static GetDefaultCurrencyCodeByOfficeIdController Fixture()
        {
            GetDefaultCurrencyCodeByOfficeIdController controller = new GetDefaultCurrencyCodeByOfficeIdController(new GetDefaultCurrencyCodeByOfficeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetDefaultCurrencyCodeByOfficeIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}