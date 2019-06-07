// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetQuarterStartDateTests
    {
        public static GetQuarterStartDateController Fixture()
        {
            GetQuarterStartDateController controller = new GetQuarterStartDateController(new GetQuarterStartDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetQuarterStartDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}