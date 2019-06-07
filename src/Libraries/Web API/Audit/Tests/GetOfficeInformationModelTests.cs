// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Audit.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Audit.Tests
{
    public class GetOfficeInformationModelTests
    {
        public static GetOfficeInformationModelController Fixture()
        {
            GetOfficeInformationModelController controller = new GetOfficeInformationModelController(new GetOfficeInformationModelRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficeInformationModelController.Annotation());
            Assert.NotNull(actual);
        }
    }
}