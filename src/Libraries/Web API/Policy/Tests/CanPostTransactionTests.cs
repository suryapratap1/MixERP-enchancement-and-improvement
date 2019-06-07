// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class CanPostTransactionTests
    {
        public static CanPostTransactionController Fixture()
        {
            CanPostTransactionController controller = new CanPostTransactionController(new CanPostTransactionRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new CanPostTransactionController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}