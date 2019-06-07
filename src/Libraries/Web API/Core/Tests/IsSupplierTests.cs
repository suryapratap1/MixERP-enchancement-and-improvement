// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsSupplierTests
    {
        public static IsSupplierController Fixture()
        {
            IsSupplierController controller = new IsSupplierController(new IsSupplierRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsSupplierController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}