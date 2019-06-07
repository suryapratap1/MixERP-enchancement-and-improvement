// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class ContainsIncompatibleTaxesTests
    {
        public static ContainsIncompatibleTaxesController Fixture()
        {
            ContainsIncompatibleTaxesController controller = new ContainsIncompatibleTaxesController(new ContainsIncompatibleTaxesRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new ContainsIncompatibleTaxesController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}