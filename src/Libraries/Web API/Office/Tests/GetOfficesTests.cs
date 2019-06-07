// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetOfficesTests
    {
        public static GetOfficesController Fixture()
        {
            GetOfficesController controller = new GetOfficesController(new GetOfficesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficesController.Annotation());
            Assert.NotNull(actual);
        }
    }
}