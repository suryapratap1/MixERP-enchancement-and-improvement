// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class CountItemInStockTests
    {
        public static CountItemInStockController Fixture()
        {
            CountItemInStockController controller = new CountItemInStockController(new CountItemInStockRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new CountItemInStockController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}