// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class IsElevatedUserTests
    {
        public static IsElevatedUserController Fixture()
        {
            IsElevatedUserController controller = new IsElevatedUserController(new IsElevatedUserRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsElevatedUserController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}