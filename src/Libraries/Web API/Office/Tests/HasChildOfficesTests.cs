// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class HasChildOfficesTests
    {
        public static HasChildOfficesController Fixture()
        {
            HasChildOfficesController controller = new HasChildOfficesController(new HasChildOfficesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new HasChildOfficesController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}