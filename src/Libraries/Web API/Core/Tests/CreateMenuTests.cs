// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class CreateMenuTests
    {
        public static CreateMenuController Fixture()
        {
            CreateMenuController controller = new CreateMenuController(new CreateMenuRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new CreateMenuController.Annotation());
        }
    }
}