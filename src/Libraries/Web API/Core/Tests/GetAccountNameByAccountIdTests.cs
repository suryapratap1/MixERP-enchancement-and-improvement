// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountNameByAccountIdTests
    {
        public static GetAccountNameByAccountIdController Fixture()
        {
            GetAccountNameByAccountIdController controller = new GetAccountNameByAccountIdController(new GetAccountNameByAccountIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountNameByAccountIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}