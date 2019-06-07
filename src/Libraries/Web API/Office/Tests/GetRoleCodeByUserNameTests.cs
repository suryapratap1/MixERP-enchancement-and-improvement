// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetRoleCodeByUserNameTests
    {
        public static GetRoleCodeByUserNameController Fixture()
        {
            GetRoleCodeByUserNameController controller = new GetRoleCodeByUserNameController(new GetRoleCodeByUserNameRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetRoleCodeByUserNameController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}