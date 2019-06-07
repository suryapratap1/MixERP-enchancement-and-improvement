// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class ChangePasswordTests
    {
        public static ChangePasswordController Fixture()
        {
            ChangePasswordController controller = new ChangePasswordController(new ChangePasswordRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new ChangePasswordController.Annotation());
        }
    }
}