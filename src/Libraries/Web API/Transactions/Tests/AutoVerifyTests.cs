// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class AutoVerifyTests
    {
        public static AutoVerifyController Fixture()
        {
            AutoVerifyController controller = new AutoVerifyController(new AutoVerifyRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new AutoVerifyController.Annotation());
        }
    }
}