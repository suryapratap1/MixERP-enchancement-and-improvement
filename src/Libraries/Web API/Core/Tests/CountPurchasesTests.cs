// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class CountPurchasesTests
    {
        public static CountPurchasesController Fixture()
        {
            CountPurchasesController controller = new CountPurchasesController(new CountPurchasesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new CountPurchasesController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}