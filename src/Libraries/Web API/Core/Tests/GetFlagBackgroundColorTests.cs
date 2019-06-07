// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFlagBackgroundColorTests
    {
        public static GetFlagBackgroundColorController Fixture()
        {
            GetFlagBackgroundColorController controller = new GetFlagBackgroundColorController(new GetFlagBackgroundColorRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFlagBackgroundColorController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}