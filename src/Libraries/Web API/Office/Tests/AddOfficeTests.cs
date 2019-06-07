// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class AddOfficeTests
    {
        public static AddOfficeController Fixture()
        {
            AddOfficeController controller = new AddOfficeController(new AddOfficeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new AddOfficeController.Annotation());
        }
    }
}