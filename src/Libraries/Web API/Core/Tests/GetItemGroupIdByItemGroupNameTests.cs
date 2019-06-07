// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemGroupIdByItemGroupNameTests
    {
        public static GetItemGroupIdByItemGroupNameController Fixture()
        {
            GetItemGroupIdByItemGroupNameController controller = new GetItemGroupIdByItemGroupNameController(new GetItemGroupIdByItemGroupNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemGroupIdByItemGroupNameController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}