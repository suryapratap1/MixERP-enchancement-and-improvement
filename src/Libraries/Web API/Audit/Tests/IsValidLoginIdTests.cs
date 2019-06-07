// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Audit.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Audit.Tests
{
    public class IsValidLoginIdTests
    {
        public static IsValidLoginIdController Fixture()
        {
            IsValidLoginIdController controller = new IsValidLoginIdController(new IsValidLoginIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidLoginIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}