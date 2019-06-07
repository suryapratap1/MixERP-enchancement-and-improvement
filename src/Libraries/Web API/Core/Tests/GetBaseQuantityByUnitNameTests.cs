// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetBaseQuantityByUnitNameTests
    {
        public static GetBaseQuantityByUnitNameController Fixture()
        {
            GetBaseQuantityByUnitNameController controller = new GetBaseQuantityByUnitNameController(new GetBaseQuantityByUnitNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetBaseQuantityByUnitNameController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}