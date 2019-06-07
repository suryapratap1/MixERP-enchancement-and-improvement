// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetLastReceiptDateTests
    {
        public static GetLastReceiptDateController Fixture()
        {
            GetLastReceiptDateController controller = new GetLastReceiptDateController(new GetLastReceiptDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetLastReceiptDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}