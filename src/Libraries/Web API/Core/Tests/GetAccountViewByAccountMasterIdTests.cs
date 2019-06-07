// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountViewByAccountMasterIdTests
    {
        public static GetAccountViewByAccountMasterIdController Fixture()
        {
            GetAccountViewByAccountMasterIdController controller = new GetAccountViewByAccountMasterIdController(new GetAccountViewByAccountMasterIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountViewByAccountMasterIdController.Annotation());
            Assert.NotNull(actual);
        }
    }
}