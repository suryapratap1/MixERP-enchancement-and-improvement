// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class IsValidStockTransactionByStockMasterIdTests
    {
        public static IsValidStockTransactionByStockMasterIdController Fixture()
        {
            IsValidStockTransactionByStockMasterIdController controller = new IsValidStockTransactionByStockMasterIdController(new IsValidStockTransactionByStockMasterIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidStockTransactionByStockMasterIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}