// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class HasAccessTests
    {
        public static HasAccessController Fixture()
        {
            HasAccessController controller = new HasAccessController(new HasAccessRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new HasAccessController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}