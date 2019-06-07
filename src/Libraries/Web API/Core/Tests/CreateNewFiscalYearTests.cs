// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class CreateNewFiscalYearTests
    {
        public static CreateNewFiscalYearController Fixture()
        {
            CreateNewFiscalYearController controller = new CreateNewFiscalYearController(new CreateNewFiscalYearRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            Fixture().Execute(new CreateNewFiscalYearController.Annotation());
        }
    }
}