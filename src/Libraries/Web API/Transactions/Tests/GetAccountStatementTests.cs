// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetAccountStatementTests
    {
        public static GetAccountStatementController Fixture()
        {
            GetAccountStatementController controller = new GetAccountStatementController(new GetAccountStatementRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountStatementController.Annotation());
            Assert.NotNull(actual);
        }
    }
}