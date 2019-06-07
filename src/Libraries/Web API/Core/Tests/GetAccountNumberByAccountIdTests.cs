// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountNumberByAccountIdTests
    {
        public static GetAccountNumberByAccountIdController Fixture()
        {
            GetAccountNumberByAccountIdController controller = new GetAccountNumberByAccountIdController(new GetAccountNumberByAccountIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountNumberByAccountIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}