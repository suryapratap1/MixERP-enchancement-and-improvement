// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetQuarterEndDateTests
    {
        public static GetQuarterEndDateController Fixture()
        {
            GetQuarterEndDateController controller = new GetQuarterEndDateController(new GetQuarterEndDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetQuarterEndDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}