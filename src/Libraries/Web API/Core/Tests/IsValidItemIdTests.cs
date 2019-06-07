// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsValidItemIdTests
    {
        public static IsValidItemIdController Fixture()
        {
            IsValidItemIdController controller = new IsValidItemIdController(new IsValidItemIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidItemIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}