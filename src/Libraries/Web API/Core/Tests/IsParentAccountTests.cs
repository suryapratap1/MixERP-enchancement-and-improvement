// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Core.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Core.Tests
{
    public class IsParentAccountTests
    {
        public static IsParentAccountController Fixture()
        {
            IsParentAccountController controller = new IsParentAccountController(new IsParentAccountRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsParentAccountController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}