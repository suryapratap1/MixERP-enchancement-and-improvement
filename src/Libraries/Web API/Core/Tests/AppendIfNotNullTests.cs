// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class AppendIfNotNullTests
    {
        public static AppendIfNotNullController Fixture()
        {
            AppendIfNotNullController controller = new AppendIfNotNullController(new AppendIfNotNullRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new AppendIfNotNullController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}