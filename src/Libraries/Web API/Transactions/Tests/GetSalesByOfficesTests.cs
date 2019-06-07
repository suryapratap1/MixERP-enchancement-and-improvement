// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetSalesByOfficesTests
    {
        public static GetSalesByOfficesController Fixture()
        {
            GetSalesByOfficesController controller = new GetSalesByOfficesController(new GetSalesByOfficesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalesByOfficesController.Annotation());
            Assert.NotNull(actual);
        }
    }
}