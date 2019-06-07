// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class CreatePaymentCardTests
    {
        public static CreatePaymentCardController Fixture()
        {
            CreatePaymentCardController controller = new CreatePaymentCardController(new CreatePaymentCardRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new CreatePaymentCardController.Annotation());
        }
    }
}