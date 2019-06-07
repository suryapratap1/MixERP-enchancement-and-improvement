// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFrequencySetupStartDateByFrequencySetupIdTests
    {
        public static GetFrequencySetupStartDateByFrequencySetupIdController Fixture()
        {
            GetFrequencySetupStartDateByFrequencySetupIdController controller = new GetFrequencySetupStartDateByFrequencySetupIdController(new GetFrequencySetupStartDateByFrequencySetupIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFrequencySetupStartDateByFrequencySetupIdController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}