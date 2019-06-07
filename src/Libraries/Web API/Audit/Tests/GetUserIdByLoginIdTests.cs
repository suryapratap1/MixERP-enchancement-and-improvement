// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Audit.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Audit.Tests
{
    public class GetUserIdByLoginIdTests
    {
        public static GetUserIdByLoginIdController Fixture()
        {
            GetUserIdByLoginIdController controller = new GetUserIdByLoginIdController(new GetUserIdByLoginIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetUserIdByLoginIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}