// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Localization.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Localization.Tests
{
    public class GetMenuTableTests
    {
        public static GetMenuTableController Fixture()
        {
            GetMenuTableController controller = new GetMenuTableController(new GetMenuTableRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMenuTableController.Annotation());
            Assert.NotNull(actual);
        }
    }
}