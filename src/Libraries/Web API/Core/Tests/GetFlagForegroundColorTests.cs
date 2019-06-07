// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFlagForegroundColorTests
    {
        public static GetFlagForegroundColorController Fixture()
        {
            GetFlagForegroundColorController controller = new GetFlagForegroundColorController(new GetFlagForegroundColorRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFlagForegroundColorController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}