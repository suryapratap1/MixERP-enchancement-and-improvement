// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class IsAdminTests
    {
        public static IsAdminController Fixture()
        {
            IsAdminController controller = new IsAdminController(new IsAdminRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsAdminController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}