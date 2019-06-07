// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetShipperCodeTests
    {
        public static GetShipperCodeController Fixture()
        {
            GetShipperCodeController controller = new GetShipperCodeController(new GetShipperCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetShipperCodeController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}