// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class IsValidStockTransactionByTransactionMasterIdTests
    {
        public static IsValidStockTransactionByTransactionMasterIdController Fixture()
        {
            IsValidStockTransactionByTransactionMasterIdController controller = new IsValidStockTransactionByTransactionMasterIdController(new IsValidStockTransactionByTransactionMasterIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidStockTransactionByTransactionMasterIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}