// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsCashEquivalentTests
    {
        public static IsCashEquivalentController Fixture()
        {
            IsCashEquivalentController controller = new IsCashEquivalentController(new IsCashEquivalentRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsCashEquivalentController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}