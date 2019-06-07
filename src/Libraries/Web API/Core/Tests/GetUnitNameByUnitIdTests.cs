// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetUnitNameByUnitIdTests
    {
        public static GetUnitNameByUnitIdController Fixture()
        {
            GetUnitNameByUnitIdController controller = new GetUnitNameByUnitIdController(new GetUnitNameByUnitIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetUnitNameByUnitIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}