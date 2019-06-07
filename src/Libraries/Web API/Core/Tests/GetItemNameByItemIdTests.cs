// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemNameByItemIdTests
    {
        public static GetItemNameByItemIdController Fixture()
        {
            GetItemNameByItemIdController controller = new GetItemNameByItemIdController(new GetItemNameByItemIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemNameByItemIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}