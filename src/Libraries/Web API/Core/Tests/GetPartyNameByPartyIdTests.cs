// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetPartyNameByPartyIdTests
    {
        public static GetPartyNameByPartyIdController Fixture()
        {
            GetPartyNameByPartyIdController controller = new GetPartyNameByPartyIdController(new GetPartyNameByPartyIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetPartyNameByPartyIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}