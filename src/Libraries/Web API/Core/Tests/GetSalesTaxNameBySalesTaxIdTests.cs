// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetSalesTaxNameBySalesTaxIdTests
    {
        public static GetSalesTaxNameBySalesTaxIdController Fixture()
        {
            GetSalesTaxNameBySalesTaxIdController controller = new GetSalesTaxNameBySalesTaxIdController(new GetSalesTaxNameBySalesTaxIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalesTaxNameBySalesTaxIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}