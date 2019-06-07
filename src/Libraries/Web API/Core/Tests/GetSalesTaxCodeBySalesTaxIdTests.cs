// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetSalesTaxCodeBySalesTaxIdTests
    {
        public static GetSalesTaxCodeBySalesTaxIdController Fixture()
        {
            GetSalesTaxCodeBySalesTaxIdController controller = new GetSalesTaxCodeBySalesTaxIdController(new GetSalesTaxCodeBySalesTaxIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalesTaxCodeBySalesTaxIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}