// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetUnitIdByUnitNameTests
    {
        public static GetUnitIdByUnitNameController Fixture()
        {
            GetUnitIdByUnitNameController controller = new GetUnitIdByUnitNameController(new GetUnitIdByUnitNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetUnitIdByUnitNameController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}