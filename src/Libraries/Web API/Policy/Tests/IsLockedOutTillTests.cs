// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class IsLockedOutTillTests
    {
        public static IsLockedOutTillController Fixture()
        {
            IsLockedOutTillController controller = new IsLockedOutTillController(new IsLockedOutTillRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsLockedOutTillController.Annotation());
            Assert.Equal(new DateTime(), actual);
        }
    }
}