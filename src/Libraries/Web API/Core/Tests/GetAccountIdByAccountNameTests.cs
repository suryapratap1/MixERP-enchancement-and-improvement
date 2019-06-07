// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountIdByAccountNameTests
    {
        public static GetAccountIdByAccountNameController Fixture()
        {
            GetAccountIdByAccountNameController controller = new GetAccountIdByAccountNameController(new GetAccountIdByAccountNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountIdByAccountNameController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}