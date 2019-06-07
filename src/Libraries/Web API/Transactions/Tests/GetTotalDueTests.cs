// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetTotalDueTests
    {
        public static GetTotalDueController Fixture()
        {
            GetTotalDueController controller = new GetTotalDueController(new GetTotalDueRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetTotalDueController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}