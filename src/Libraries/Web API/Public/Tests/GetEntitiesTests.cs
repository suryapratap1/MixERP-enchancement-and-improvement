// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Public.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Public.Tests
{
    public class GetEntitiesTests
    {
        public static GetEntitiesController Fixture()
        {
            GetEntitiesController controller = new GetEntitiesController(new GetEntitiesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetEntitiesController.Annotation());
            Assert.NotNull(actual);
        }
    }
}