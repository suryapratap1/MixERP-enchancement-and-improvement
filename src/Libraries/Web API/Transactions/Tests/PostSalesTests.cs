// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class PostSalesTests
    {
        public static PostSalesController Fixture()
        {
            PostSalesController controller = new PostSalesController(new PostSalesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new PostSalesController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}