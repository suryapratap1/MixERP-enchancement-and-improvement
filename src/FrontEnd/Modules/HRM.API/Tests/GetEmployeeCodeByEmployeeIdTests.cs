// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.HRM.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.HRM.Tests
{
    public class GetEmployeeCodeByEmployeeIdTests
    {
        public static GetEmployeeCodeByEmployeeIdController Fixture()
        {
            GetEmployeeCodeByEmployeeIdController controller = new GetEmployeeCodeByEmployeeIdController(new GetEmployeeCodeByEmployeeIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetEmployeeCodeByEmployeeIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}