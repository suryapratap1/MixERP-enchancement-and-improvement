// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetValueDateTests
    {
        public static GetValueDateController Fixture()
        {
            GetValueDateController controller = new GetValueDateController(new GetValueDateRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetValueDateController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}