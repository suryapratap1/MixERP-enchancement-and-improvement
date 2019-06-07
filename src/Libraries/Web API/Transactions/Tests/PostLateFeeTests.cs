// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class PostLateFeeTests
    {
        public static PostLateFeeController Fixture()
        {
            PostLateFeeController controller = new PostLateFeeController(new PostLateFeeRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new PostLateFeeController.Annotation());
        }
    }
}