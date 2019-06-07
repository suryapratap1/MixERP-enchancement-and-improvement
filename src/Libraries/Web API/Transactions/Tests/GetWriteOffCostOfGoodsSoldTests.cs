// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetWriteOffCostOfGoodsSoldTests
    {
        public static GetWriteOffCostOfGoodsSoldController Fixture()
        {
            GetWriteOffCostOfGoodsSoldController controller = new GetWriteOffCostOfGoodsSoldController(new GetWriteOffCostOfGoodsSoldRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetWriteOffCostOfGoodsSoldController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}