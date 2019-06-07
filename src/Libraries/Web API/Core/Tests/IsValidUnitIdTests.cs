// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsValidUnitIdTests
    {
        public static IsValidUnitIdController Fixture()
        {
            IsValidUnitIdController controller = new IsValidUnitIdController(new IsValidUnitIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidUnitIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}