// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class IsValidOfficeIdTests
    {
        public static IsValidOfficeIdController Fixture()
        {
            IsValidOfficeIdController controller = new IsValidOfficeIdController(new IsValidOfficeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsValidOfficeIdController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}