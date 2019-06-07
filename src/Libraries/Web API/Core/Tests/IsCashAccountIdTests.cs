// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsCashAccountIdTests
    {
        public static IsCashAccountIdController Fixture()
        {
            IsCashAccountIdController controller = new IsCashAccountIdController(new IsCashAccountIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsCashAccountIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}