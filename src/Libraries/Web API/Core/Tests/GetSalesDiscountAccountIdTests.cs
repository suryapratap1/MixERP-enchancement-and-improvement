// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetSalesDiscountAccountIdTests
    {
        public static GetSalesDiscountAccountIdController Fixture()
        {
            GetSalesDiscountAccountIdController controller = new GetSalesDiscountAccountIdController(new GetSalesDiscountAccountIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalesDiscountAccountIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}