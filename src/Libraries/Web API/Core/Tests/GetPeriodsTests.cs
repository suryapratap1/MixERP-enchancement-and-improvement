// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetPeriodsTests
    {
        public static GetPeriodsController Fixture()
        {
            GetPeriodsController controller = new GetPeriodsController(new GetPeriodsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetPeriodsController.Annotation());
            Assert.NotNull(actual);
        }
    }
}