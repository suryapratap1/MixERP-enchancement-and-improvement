// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetSalesTaxIdBySalesTaxCodeTests
    {
        public static GetSalesTaxIdBySalesTaxCodeController Fixture()
        {
            GetSalesTaxIdBySalesTaxCodeController controller = new GetSalesTaxIdBySalesTaxCodeController(new GetSalesTaxIdBySalesTaxCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalesTaxIdBySalesTaxCodeController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}