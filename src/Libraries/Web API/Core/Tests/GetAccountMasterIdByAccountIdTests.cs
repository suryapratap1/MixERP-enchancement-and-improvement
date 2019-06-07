// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountMasterIdByAccountIdTests
    {
        public static GetAccountMasterIdByAccountIdController Fixture()
        {
            GetAccountMasterIdByAccountIdController controller = new GetAccountMasterIdByAccountIdController(new GetAccountMasterIdByAccountIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountMasterIdByAccountIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}