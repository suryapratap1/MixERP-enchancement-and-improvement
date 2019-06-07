// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetOrderedQuantityTests
    {
        public static GetOrderedQuantityController Fixture()
        {
            GetOrderedQuantityController controller = new GetOrderedQuantityController(new GetOrderedQuantityRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOrderedQuantityController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}