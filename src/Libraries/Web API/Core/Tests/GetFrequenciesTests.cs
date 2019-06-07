// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFrequenciesTests
    {
        public static GetFrequenciesController Fixture()
        {
            GetFrequenciesController controller = new GetFrequenciesController(new GetFrequenciesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFrequenciesController.Annotation());
            Assert.NotNull(actual);
        }
    }
}