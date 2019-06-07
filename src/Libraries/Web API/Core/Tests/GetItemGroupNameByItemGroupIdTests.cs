// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemGroupNameByItemGroupIdTests
    {
        public static GetItemGroupNameByItemGroupIdController Fixture()
        {
            GetItemGroupNameByItemGroupIdController controller = new GetItemGroupNameByItemGroupIdController(new GetItemGroupNameByItemGroupIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemGroupNameByItemGroupIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}