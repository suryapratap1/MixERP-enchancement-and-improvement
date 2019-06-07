// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetBrandIdByBrandCodeTests
    {
        public static GetBrandIdByBrandCodeController Fixture()
        {
            GetBrandIdByBrandCodeController controller = new GetBrandIdByBrandCodeController(new GetBrandIdByBrandCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetBrandIdByBrandCodeController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}