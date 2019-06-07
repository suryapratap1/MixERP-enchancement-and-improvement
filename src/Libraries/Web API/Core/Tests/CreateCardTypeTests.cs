// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class CreateCardTypeTests
    {
        public static CreateCardTypeController Fixture()
        {
            CreateCardTypeController controller = new CreateCardTypeController(new CreateCardTypeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new CreateCardTypeController.Annotation());
        }
    }
}