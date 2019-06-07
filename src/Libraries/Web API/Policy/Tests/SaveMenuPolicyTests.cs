// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class SaveMenuPolicyTests
    {
        public static SaveMenuPolicyController Fixture()
        {
            SaveMenuPolicyController controller = new SaveMenuPolicyController(new SaveMenuPolicyRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new SaveMenuPolicyController.Annotation());
        }
    }
}