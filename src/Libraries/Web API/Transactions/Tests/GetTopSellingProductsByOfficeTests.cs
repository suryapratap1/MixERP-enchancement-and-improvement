// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetTopSellingProductsByOfficeTests
    {
        public static GetTopSellingProductsByOfficeController Fixture()
        {
            GetTopSellingProductsByOfficeController controller = new GetTopSellingProductsByOfficeController(new GetTopSellingProductsByOfficeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetTopSellingProductsByOfficeController.Annotation());
            Assert.NotNull(actual);
        }
    }
}