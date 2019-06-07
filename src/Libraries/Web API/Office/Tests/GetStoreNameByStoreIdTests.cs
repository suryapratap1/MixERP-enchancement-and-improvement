// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetStoreNameByStoreIdTests
    {
        public static GetStoreNameByStoreIdController Fixture()
        {
            GetStoreNameByStoreIdController controller = new GetStoreNameByStoreIdController(new GetStoreNameByStoreIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetStoreNameByStoreIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}