// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCurrentYearTests
    {
        public static GetCurrentYearController Fixture()
        {
            GetCurrentYearController controller = new GetCurrentYearController(new GetCurrentYearRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCurrentYearController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}