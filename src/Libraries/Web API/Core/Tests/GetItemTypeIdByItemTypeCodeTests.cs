// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetItemTypeIdByItemTypeCodeTests
    {
        public static GetItemTypeIdByItemTypeCodeController Fixture()
        {
            GetItemTypeIdByItemTypeCodeController controller = new GetItemTypeIdByItemTypeCodeController(new GetItemTypeIdByItemTypeCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetItemTypeIdByItemTypeCodeController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}