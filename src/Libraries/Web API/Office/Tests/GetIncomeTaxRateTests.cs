// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetIncomeTaxRateTests
    {
        public static GetIncomeTaxRateController Fixture()
        {
            GetIncomeTaxRateController controller = new GetIncomeTaxRateController(new GetIncomeTaxRateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetIncomeTaxRateController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}