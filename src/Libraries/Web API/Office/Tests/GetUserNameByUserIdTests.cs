// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetUserNameByUserIdTests
    {
        public static GetUserNameByUserIdController Fixture()
        {
            GetUserNameByUserIdController controller = new GetUserNameByUserIdController(new GetUserNameByUserIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetUserNameByUserIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}