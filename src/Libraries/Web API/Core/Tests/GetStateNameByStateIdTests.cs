// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetStateNameByStateIdTests
    {
        public static GetStateNameByStateIdController Fixture()
        {
            GetStateNameByStateIdController controller = new GetStateNameByStateIdController(new GetStateNameByStateIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetStateNameByStateIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}