// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetDueDateTests
    {
        public static GetDueDateController Fixture()
        {
            GetDueDateController controller = new GetDueDateController(new GetDueDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetDueDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}