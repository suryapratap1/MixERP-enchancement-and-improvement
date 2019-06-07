// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetUnitCodeByUnitIdTests
    {
        public static GetUnitCodeByUnitIdController Fixture()
        {
            GetUnitCodeByUnitIdController controller = new GetUnitCodeByUnitIdController(new GetUnitCodeByUnitIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetUnitCodeByUnitIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}