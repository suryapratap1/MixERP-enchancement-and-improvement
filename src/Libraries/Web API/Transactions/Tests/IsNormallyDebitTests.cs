// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class IsNormallyDebitTests
    {
        public static IsNormallyDebitController Fixture()
        {
            IsNormallyDebitController controller = new IsNormallyDebitController(new IsNormallyDebitRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsNormallyDebitController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}