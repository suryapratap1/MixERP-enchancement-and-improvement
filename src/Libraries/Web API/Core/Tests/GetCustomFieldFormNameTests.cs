// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCustomFieldFormNameTests
    {
        public static GetCustomFieldFormNameController Fixture()
        {
            GetCustomFieldFormNameController controller = new GetCustomFieldFormNameController(new GetCustomFieldFormNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCustomFieldFormNameController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}