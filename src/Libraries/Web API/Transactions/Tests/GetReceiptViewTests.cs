// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetReceiptViewTests
    {
        public static GetReceiptViewController Fixture()
        {
            GetReceiptViewController controller = new GetReceiptViewController(new GetReceiptViewRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetReceiptViewController.Annotation());
            Assert.NotNull(actual);
        }
    }
}