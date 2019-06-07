// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemGroupCodeByItemGroupIdTests
    {
        public static GetItemGroupCodeByItemGroupIdController Fixture()
        {
            GetItemGroupCodeByItemGroupIdController controller = new GetItemGroupCodeByItemGroupIdController(new GetItemGroupCodeByItemGroupIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemGroupCodeByItemGroupIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}