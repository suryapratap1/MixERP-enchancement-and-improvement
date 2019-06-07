// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetOfficeIdByStoreIdTests
    {
        public static GetOfficeIdByStoreIdController Fixture()
        {
            GetOfficeIdByStoreIdController controller = new GetOfficeIdByStoreIdController(new GetOfficeIdByStoreIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficeIdByStoreIdController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}