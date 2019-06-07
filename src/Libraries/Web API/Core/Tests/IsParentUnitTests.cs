// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsParentUnitTests
    {
        public static IsParentUnitController Fixture()
        {
            IsParentUnitController controller = new IsParentUnitController(new IsParentUnitRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsParentUnitController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}