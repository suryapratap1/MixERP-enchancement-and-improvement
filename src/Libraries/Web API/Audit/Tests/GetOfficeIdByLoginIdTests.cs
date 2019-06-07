// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Audit.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Audit.Tests
{
    public class GetOfficeIdByLoginIdTests
    {
        public static GetOfficeIdByLoginIdController Fixture()
        {
            GetOfficeIdByLoginIdController controller = new GetOfficeIdByLoginIdController(new GetOfficeIdByLoginIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficeIdByLoginIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}