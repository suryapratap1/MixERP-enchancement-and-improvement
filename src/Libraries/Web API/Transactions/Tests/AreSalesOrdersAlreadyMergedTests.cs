// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class AreSalesOrdersAlreadyMergedTests
    {
        public static AreSalesOrdersAlreadyMergedController Fixture()
        {
            AreSalesOrdersAlreadyMergedController controller = new AreSalesOrdersAlreadyMergedController(new AreSalesOrdersAlreadyMergedRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new AreSalesOrdersAlreadyMergedController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}