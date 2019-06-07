// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Localization.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Localization.Tests
{
    public class GetOutputForTests
    {
        public static GetOutputForController Fixture()
        {
            GetOutputForController controller = new GetOutputForController(new GetOutputForRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOutputForController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}