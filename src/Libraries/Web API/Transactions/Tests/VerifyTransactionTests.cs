// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class VerifyTransactionTests
    {
        public static VerifyTransactionController Fixture()
        {
            VerifyTransactionController controller = new VerifyTransactionController(new VerifyTransactionRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new VerifyTransactionController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}