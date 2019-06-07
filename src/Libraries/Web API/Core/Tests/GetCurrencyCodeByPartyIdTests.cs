// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCurrencyCodeByPartyIdTests
    {
        public static GetCurrencyCodeByPartyIdController Fixture()
        {
            GetCurrencyCodeByPartyIdController controller = new GetCurrencyCodeByPartyIdController(new GetCurrencyCodeByPartyIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCurrencyCodeByPartyIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}