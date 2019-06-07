// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class GetVerificationStatusNameByVerificationStatusIdTests
    {
        public static GetVerificationStatusNameByVerificationStatusIdController Fixture()
        {
            GetVerificationStatusNameByVerificationStatusIdController controller = new GetVerificationStatusNameByVerificationStatusIdController(new GetVerificationStatusNameByVerificationStatusIdRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetVerificationStatusNameByVerificationStatusIdController.Annotation());
            Assert.Equal("FizzBuzz", actual);
        }
    }
}