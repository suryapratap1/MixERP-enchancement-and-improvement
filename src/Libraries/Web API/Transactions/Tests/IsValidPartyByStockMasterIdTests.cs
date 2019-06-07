// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class IsValidPartyByStockMasterIdTests
    {
        public static IsValidPartyByStockMasterIdController Fixture()
        {
            IsValidPartyByStockMasterIdController controller = new IsValidPartyByStockMasterIdController(new IsValidPartyByStockMasterIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidPartyByStockMasterIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}