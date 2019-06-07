// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class PostReceiptTests
    {
        public static PostReceiptController Fixture()
        {
            PostReceiptController controller = new PostReceiptController(new PostReceiptRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new PostReceiptController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}