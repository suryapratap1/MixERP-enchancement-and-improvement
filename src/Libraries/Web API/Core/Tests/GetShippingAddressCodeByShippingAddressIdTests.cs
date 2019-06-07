// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetShippingAddressCodeByShippingAddressIdTests
    {
        public static GetShippingAddressCodeByShippingAddressIdController Fixture()
        {
            GetShippingAddressCodeByShippingAddressIdController controller = new GetShippingAddressCodeByShippingAddressIdController(new GetShippingAddressCodeByShippingAddressIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetShippingAddressCodeByShippingAddressIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}