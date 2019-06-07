// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class CastFrequencyTests
    {
        public static CastFrequencyController Fixture()
        {
            CastFrequencyController controller = new CastFrequencyController(new CastFrequencyRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new CastFrequencyController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}