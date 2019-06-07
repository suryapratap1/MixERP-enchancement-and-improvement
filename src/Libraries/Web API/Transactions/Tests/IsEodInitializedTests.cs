// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class IsEodInitializedTests
    {
        public static IsEodInitializedController Fixture()
        {
            IsEodInitializedController controller = new IsEodInitializedController(new IsEodInitializedRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsEodInitializedController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}