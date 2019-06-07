// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAssociatedUnitsTests
    {
        public static GetAssociatedUnitsController Fixture()
        {
            GetAssociatedUnitsController controller = new GetAssociatedUnitsController(new GetAssociatedUnitsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAssociatedUnitsController.Annotation());
            Assert.NotNull(actual);
        }
    }
}