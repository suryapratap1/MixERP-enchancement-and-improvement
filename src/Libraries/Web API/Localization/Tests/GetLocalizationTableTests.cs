// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Localization.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Localization.Tests
{
    public class GetLocalizationTableTests
    {
        public static GetLocalizationTableController Fixture()
        {
            GetLocalizationTableController controller = new GetLocalizationTableController(new GetLocalizationTableRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetLocalizationTableController.Annotation());
            Assert.NotNull(actual);
        }
    }
}