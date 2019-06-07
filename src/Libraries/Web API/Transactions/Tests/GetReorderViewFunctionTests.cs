// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetReorderViewFunctionTests
    {
        public static GetReorderViewFunctionController Fixture()
        {
            GetReorderViewFunctionController controller = new GetReorderViewFunctionController(new GetReorderViewFunctionRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetReorderViewFunctionController.Annotation());
            Assert.NotNull(actual);
        }
    }
}