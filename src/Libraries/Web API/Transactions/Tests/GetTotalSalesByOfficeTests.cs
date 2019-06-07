// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetTotalSalesByOfficeTests
    {
        public static GetTotalSalesByOfficeController Fixture()
        {
            GetTotalSalesByOfficeController controller = new GetTotalSalesByOfficeController(new GetTotalSalesByOfficeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetTotalSalesByOfficeController.Annotation());
            Assert.NotNull(actual);
        }
    }
}