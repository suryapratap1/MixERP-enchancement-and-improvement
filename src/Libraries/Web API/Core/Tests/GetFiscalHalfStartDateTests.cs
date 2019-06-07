// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFiscalHalfStartDateTests
    {
        public static GetFiscalHalfStartDateController Fixture()
        {
            GetFiscalHalfStartDateController controller = new GetFiscalHalfStartDateController(new GetFiscalHalfStartDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFiscalHalfStartDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}