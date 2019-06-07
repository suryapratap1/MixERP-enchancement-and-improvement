// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetFieldTests
    {
        public static GetFieldController Fixture()
        {
            GetFieldController controller = new GetFieldController(new GetFieldRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetFieldController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}