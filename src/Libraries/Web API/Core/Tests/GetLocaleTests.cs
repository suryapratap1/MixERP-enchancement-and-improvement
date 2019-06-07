// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetLocaleTests
    {
        public static GetLocaleController Fixture()
        {
            GetLocaleController controller = new GetLocaleController(new GetLocaleRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetLocaleController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}