// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetBrandCodeByBrandIdTests
    {
        public static GetBrandCodeByBrandIdController Fixture()
        {
            GetBrandCodeByBrandIdController controller = new GetBrandCodeByBrandIdController(new GetBrandCodeByBrandIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetBrandCodeByBrandIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}