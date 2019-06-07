// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetPartyCodeByPartyIdTests
    {
        public static GetPartyCodeByPartyIdController Fixture()
        {
            GetPartyCodeByPartyIdController controller = new GetPartyCodeByPartyIdController(new GetPartyCodeByPartyIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetPartyCodeByPartyIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}