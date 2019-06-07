// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetAccountIdsTests
    {
        public static GetAccountIdsController Fixture()
        {
            GetAccountIdsController controller = new GetAccountIdsController(new GetAccountIdsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetAccountIdsController.Annotation());
            Assert.NotNull(actual);
        }
    }
}