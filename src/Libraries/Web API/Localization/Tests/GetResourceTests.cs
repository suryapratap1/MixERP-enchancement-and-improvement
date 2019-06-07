// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Localization.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Localization.Tests
{
    public class GetResourceTests
    {
        public static GetResourceController Fixture()
        {
            GetResourceController controller = new GetResourceController(new GetResourceRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetResourceController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}