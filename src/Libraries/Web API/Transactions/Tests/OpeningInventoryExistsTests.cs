// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class OpeningInventoryExistsTests
    {
        public static OpeningInventoryExistsController Fixture()
        {
            OpeningInventoryExistsController controller = new OpeningInventoryExistsController(new OpeningInventoryExistsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new OpeningInventoryExistsController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}