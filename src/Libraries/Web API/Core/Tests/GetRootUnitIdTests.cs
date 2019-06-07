// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetRootUnitIdTests
    {
        public static GetRootUnitIdController Fixture()
        {
            GetRootUnitIdController controller = new GetRootUnitIdController(new GetRootUnitIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetRootUnitIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}