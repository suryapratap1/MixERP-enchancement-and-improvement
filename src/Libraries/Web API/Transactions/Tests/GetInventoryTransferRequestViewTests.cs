// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetInventoryTransferRequestViewTests
    {
        public static GetInventoryTransferRequestViewController Fixture()
        {
            GetInventoryTransferRequestViewController controller = new GetInventoryTransferRequestViewController(new GetInventoryTransferRequestViewRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetInventoryTransferRequestViewController.Annotation());
            Assert.NotNull(actual);
        }
    }
}