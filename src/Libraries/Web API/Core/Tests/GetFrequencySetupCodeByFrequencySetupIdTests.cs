// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFrequencySetupCodeByFrequencySetupIdTests
    {
        public static GetFrequencySetupCodeByFrequencySetupIdController Fixture()
        {
            GetFrequencySetupCodeByFrequencySetupIdController controller = new GetFrequencySetupCodeByFrequencySetupIdController(new GetFrequencySetupCodeByFrequencySetupIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFrequencySetupCodeByFrequencySetupIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}