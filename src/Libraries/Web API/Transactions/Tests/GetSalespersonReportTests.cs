// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetSalespersonReportTests
    {
        public static GetSalespersonReportController Fixture()
        {
            GetSalespersonReportController controller = new GetSalespersonReportController(new GetSalespersonReportRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalespersonReportController.Annotation());
            Assert.NotNull(actual);
        }
    }
}