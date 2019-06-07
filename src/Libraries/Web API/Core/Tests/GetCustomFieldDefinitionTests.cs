// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetCustomFieldDefinitionTests
    {
        public static GetCustomFieldDefinitionController Fixture()
        {
            GetCustomFieldDefinitionController controller = new GetCustomFieldDefinitionController(new GetCustomFieldDefinitionRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCustomFieldDefinitionController.Annotation());
            Assert.NotNull(actual);
        }
    }
}