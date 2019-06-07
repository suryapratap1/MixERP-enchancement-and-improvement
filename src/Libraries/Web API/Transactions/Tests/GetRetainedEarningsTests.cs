// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetRetainedEarningsTests
    {
        public static GetRetainedEarningsController Fixture()
        {
            GetRetainedEarningsController controller = new GetRetainedEarningsController(new GetRetainedEarningsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetRetainedEarningsController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}