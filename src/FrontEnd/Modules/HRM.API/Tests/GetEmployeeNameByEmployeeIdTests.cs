// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.HRM.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.HRM.Tests
{
    public class GetEmployeeNameByEmployeeIdTests
    {
        public static GetEmployeeNameByEmployeeIdController Fixture()
        {
            GetEmployeeNameByEmployeeIdController controller = new GetEmployeeNameByEmployeeIdController(new GetEmployeeNameByEmployeeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetEmployeeNameByEmployeeIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}