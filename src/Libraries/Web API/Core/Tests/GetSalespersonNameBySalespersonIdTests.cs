// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetSalespersonNameBySalespersonIdTests
    {
        public static GetSalespersonNameBySalespersonIdController Fixture()
        {
            GetSalespersonNameBySalespersonIdController controller = new GetSalespersonNameBySalespersonIdController(new GetSalespersonNameBySalespersonIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetSalespersonNameBySalespersonIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}