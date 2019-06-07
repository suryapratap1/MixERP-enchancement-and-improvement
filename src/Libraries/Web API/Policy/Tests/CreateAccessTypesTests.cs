// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Policy.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Policy.Tests
{
    public class CreateAccessTypesTests
    {
        public static CreateAccessTypesController Fixture()
        {
            CreateAccessTypesController controller = new CreateAccessTypesController(new CreateAccessTypesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new CreateAccessTypesController.Annotation());
        }
    }
}