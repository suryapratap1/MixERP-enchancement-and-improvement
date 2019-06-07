// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class GetOfficeIdsTests
    {
        public static GetOfficeIdsController Fixture()
        {
            GetOfficeIdsController controller = new GetOfficeIdsController(new GetOfficeIdsRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetOfficeIdsController.Annotation());
            Assert.NotNull(actual);
        }
    }
}