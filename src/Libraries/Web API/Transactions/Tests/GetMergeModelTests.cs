// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetMergeModelTests
    {
        public static GetMergeModelController Fixture()
        {
            GetMergeModelController controller = new GetMergeModelController(new GetMergeModelRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetMergeModelController.Annotation());
            Assert.NotNull(actual);
        }
    }
}