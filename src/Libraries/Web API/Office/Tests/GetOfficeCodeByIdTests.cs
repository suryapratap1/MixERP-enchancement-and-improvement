// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetOfficeCodeByIdTests
    {
        public static GetOfficeCodeByIdController Fixture()
        {
            GetOfficeCodeByIdController controller = new GetOfficeCodeByIdController(new GetOfficeCodeByIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficeCodeByIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}