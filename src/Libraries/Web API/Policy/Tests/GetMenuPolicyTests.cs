// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class GetMenuPolicyTests
    {
        public static GetMenuPolicyController Fixture()
        {
            GetMenuPolicyController controller = new GetMenuPolicyController(new GetMenuPolicyRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMenuPolicyController.Annotation());
            Assert.NotNull(actual);
        }
    }
}