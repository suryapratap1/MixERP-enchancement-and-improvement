// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemCodeByItemIdTests
    {
        public static GetItemCodeByItemIdController Fixture()
        {
            GetItemCodeByItemIdController controller = new GetItemCodeByItemIdController(new GetItemCodeByItemIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemCodeByItemIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}