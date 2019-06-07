// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetCostCenterIdByCostCenterCodeTests
    {
        public static GetCostCenterIdByCostCenterCodeController Fixture()
        {
            GetCostCenterIdByCostCenterCodeController controller = new GetCostCenterIdByCostCenterCodeController(new GetCostCenterIdByCostCenterCodeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetCostCenterIdByCostCenterCodeController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}