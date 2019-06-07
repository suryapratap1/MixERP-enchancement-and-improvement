// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class HasNexusTests
    {
        public static HasNexusController Fixture()
        {
            HasNexusController controller = new HasNexusController(new HasNexusRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new HasNexusController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}