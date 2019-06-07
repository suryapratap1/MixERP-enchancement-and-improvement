// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Office.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Office.Tests
{
    public class IsSysUserTests
    {
        public static IsSysUserController Fixture()
        {
            IsSysUserController controller = new IsSysUserController(new IsSysUserRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new IsSysUserController.Annotation());
            Assert.Equal(new bool(), actual);
        }
    }
}