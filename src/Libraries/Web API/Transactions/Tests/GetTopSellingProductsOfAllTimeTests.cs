// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetTopSellingProductsOfAllTimeTests
    {
        public static GetTopSellingProductsOfAllTimeController Fixture()
        {
            GetTopSellingProductsOfAllTimeController controller = new GetTopSellingProductsOfAllTimeController(new GetTopSellingProductsOfAllTimeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetTopSellingProductsOfAllTimeController.Annotation());
            Assert.NotNull(actual);
        }
    }
}