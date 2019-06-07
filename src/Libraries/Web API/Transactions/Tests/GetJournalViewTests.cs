// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class GetJournalViewTests
    {
        public static GetJournalViewController Fixture()
        {
            GetJournalViewController controller = new GetJournalViewController(new GetJournalViewRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new GetJournalViewController.Annotation());
            Assert.NotNull(actual);
        }
    }
}