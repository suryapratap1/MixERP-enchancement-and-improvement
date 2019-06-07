// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCurrentFiscalYearCodeTests
    {
        public static GetCurrentFiscalYearCodeController Fixture()
        {
            GetCurrentFiscalYearCodeController controller = new GetCurrentFiscalYearCodeController(new GetCurrentFiscalYearCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCurrentFiscalYearCodeController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}