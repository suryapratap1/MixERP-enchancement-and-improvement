// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetTransactionCodeTests
    {
        public static GetTransactionCodeController Fixture()
        {
            GetTransactionCodeController controller = new GetTransactionCodeController(new GetTransactionCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetTransactionCodeController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}