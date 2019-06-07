// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAssociatedUnitsFromItemIdTests
    {
        public static GetAssociatedUnitsFromItemIdController Fixture()
        {
            GetAssociatedUnitsFromItemIdController controller = new GetAssociatedUnitsFromItemIdController(new GetAssociatedUnitsFromItemIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAssociatedUnitsFromItemIdController.Annotation());
            Assert.NotNull(actual);
        }
    }
}