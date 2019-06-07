// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Localization.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Localization.Tests
{
    public class AddResourceTests
    {
        public static AddResourceController Fixture()
        {
            AddResourceController controller = new AddResourceController(new AddResourceRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new AddResourceController.Annotation());
        }
    }
}