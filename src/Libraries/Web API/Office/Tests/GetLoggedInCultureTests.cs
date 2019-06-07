// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetLoggedInCultureTests
    {
        public static GetLoggedInCultureController Fixture()
        {
            GetLoggedInCultureController controller = new GetLoggedInCultureController(new GetLoggedInCultureRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetLoggedInCultureController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}