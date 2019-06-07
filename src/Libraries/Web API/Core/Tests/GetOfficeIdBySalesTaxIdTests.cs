// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetOfficeIdBySalesTaxIdTests
    {
        public static GetOfficeIdBySalesTaxIdController Fixture()
        {
            GetOfficeIdBySalesTaxIdController controller = new GetOfficeIdBySalesTaxIdController(new GetOfficeIdBySalesTaxIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficeIdBySalesTaxIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}