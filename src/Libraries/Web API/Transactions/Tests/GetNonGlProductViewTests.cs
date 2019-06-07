// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetNonGlProductViewTests
    {
        public static GetNonGlProductViewController Fixture()
        {
            GetNonGlProductViewController controller = new GetNonGlProductViewController(new GetNonGlProductViewRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetNonGlProductViewController.Annotation());
            Assert.NotNull(actual);
        }
    }
}