// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class PostErFluctuationTests
    {
        public static PostErFluctuationController Fixture()
        {
            PostErFluctuationController controller = new PostErFluctuationController(new PostErFluctuationRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new PostErFluctuationController.Annotation());
        }
    }
}