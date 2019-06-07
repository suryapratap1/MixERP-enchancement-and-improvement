// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class ValidateLoginTests
    {
        public static ValidateLoginController Fixture()
        {
            ValidateLoginController controller = new ValidateLoginController(new ValidateLoginRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new ValidateLoginController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}