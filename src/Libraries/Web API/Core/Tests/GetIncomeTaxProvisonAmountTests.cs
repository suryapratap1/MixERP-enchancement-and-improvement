// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetIncomeTaxProvisonAmountTests
    {
        public static GetIncomeTaxProvisonAmountController Fixture()
        {
            GetIncomeTaxProvisonAmountController controller = new GetIncomeTaxProvisonAmountController(new GetIncomeTaxProvisonAmountRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetIncomeTaxProvisonAmountController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}