// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetIncomeExpenditureStatementTests
    {
        public static GetIncomeExpenditureStatementController Fixture()
        {
            GetIncomeExpenditureStatementController controller = new GetIncomeExpenditureStatementController(new GetIncomeExpenditureStatementRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetIncomeExpenditureStatementController.Annotation());
            Assert.NotNull(actual);
        }
    }
}