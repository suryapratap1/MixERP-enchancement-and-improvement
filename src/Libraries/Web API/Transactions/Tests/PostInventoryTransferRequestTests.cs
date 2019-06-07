// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class PostInventoryTransferRequestTests
    {
        public static PostInventoryTransferRequestController Fixture()
        {
            PostInventoryTransferRequestController controller = new PostInventoryTransferRequestController(new PostInventoryTransferRequestRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new PostInventoryTransferRequestController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}