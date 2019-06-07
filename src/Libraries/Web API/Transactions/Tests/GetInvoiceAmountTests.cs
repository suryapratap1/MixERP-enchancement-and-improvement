// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetInvoiceAmountTests
    {
        public static GetInvoiceAmountController Fixture()
        {
            GetInvoiceAmountController controller = new GetInvoiceAmountController(new GetInvoiceAmountRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetInvoiceAmountController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}