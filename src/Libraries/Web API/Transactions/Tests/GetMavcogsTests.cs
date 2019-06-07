// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetMavcogsTests
    {
        public static GetMavcogsController Fixture()
        {
            GetMavcogsController controller = new GetMavcogsController(new GetMavcogsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMavcogsController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}