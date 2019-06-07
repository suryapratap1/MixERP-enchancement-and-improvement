// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCompoundItemDetailsTests
    {
        public static GetCompoundItemDetailsController Fixture()
        {
            GetCompoundItemDetailsController controller = new GetCompoundItemDetailsController(new GetCompoundItemDetailsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCompoundItemDetailsController.Annotation());
            Assert.NotNull(actual);
        }
    }
}