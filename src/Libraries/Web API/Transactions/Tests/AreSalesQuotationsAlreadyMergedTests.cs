// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class AreSalesQuotationsAlreadyMergedTests
    {
        public static AreSalesQuotationsAlreadyMergedController Fixture()
        {
            AreSalesQuotationsAlreadyMergedController controller = new AreSalesQuotationsAlreadyMergedController(new AreSalesQuotationsAlreadyMergedRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new AreSalesQuotationsAlreadyMergedController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}