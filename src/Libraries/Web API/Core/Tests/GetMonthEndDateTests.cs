// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetMonthEndDateTests
    {
        public static GetMonthEndDateController Fixture()
        {
            GetMonthEndDateController controller = new GetMonthEndDateController(new GetMonthEndDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMonthEndDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}