// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class IsTransactionRestrictedTests
    {
        public static IsTransactionRestrictedController Fixture()
        {
            IsTransactionRestrictedController controller = new IsTransactionRestrictedController(new IsTransactionRestrictedRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsTransactionRestrictedController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}