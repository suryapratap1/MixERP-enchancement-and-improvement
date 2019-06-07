// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetMenuIdByMenuCodeTests
    {
        public static GetMenuIdByMenuCodeController Fixture()
        {
            GetMenuIdByMenuCodeController controller = new GetMenuIdByMenuCodeController(new GetMenuIdByMenuCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMenuIdByMenuCodeController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}