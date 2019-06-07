// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetEntityIdByPartyIdTests
    {
        public static GetEntityIdByPartyIdController Fixture()
        {
            GetEntityIdByPartyIdController controller = new GetEntityIdByPartyIdController(new GetEntityIdByPartyIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetEntityIdByPartyIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}