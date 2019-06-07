// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.HRM.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.HRM.Tests
{
    public class GetEmployeeByEmployeeIdTests
    {
        public static GetEmployeeByEmployeeIdController Fixture()
        {
            GetEmployeeByEmployeeIdController controller = new GetEmployeeByEmployeeIdController(new GetEmployeeByEmployeeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetEmployeeByEmployeeIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}