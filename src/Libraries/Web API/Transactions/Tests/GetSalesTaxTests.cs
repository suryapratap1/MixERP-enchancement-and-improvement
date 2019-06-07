// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetSalesTaxTests
    {
        public static GetSalesTaxController Fixture()
        {
            GetSalesTaxController controller = new GetSalesTaxController(new GetSalesTaxRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalesTaxController.Annotation());
            Assert.NotNull(actual);
        }
    }
}