// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetShippingAddressByShippingAddressIdTests
    {
        public static GetShippingAddressByShippingAddressIdController Fixture()
        {
            GetShippingAddressByShippingAddressIdController controller = new GetShippingAddressByShippingAddressIdController(new GetShippingAddressByShippingAddressIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetShippingAddressByShippingAddressIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}