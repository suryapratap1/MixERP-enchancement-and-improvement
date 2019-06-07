// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetMonthStartDateTests
    {
        public static GetMonthStartDateController Fixture()
        {
            GetMonthStartDateController controller = new GetMonthStartDateController(new GetMonthStartDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMonthStartDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}