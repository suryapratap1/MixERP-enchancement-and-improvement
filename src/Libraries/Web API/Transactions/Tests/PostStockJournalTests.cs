// ReSharper disable All
using System;
using System.Diagnostics;
using System.Linq;
using MixERP.Net.Api.Transactions.Fakes;
using MixERP.Net.ApplicationState.Cache;
using Xunit;

namespace MixERP.Net.Api.Transactions.Tests
{
    public class PostStockJournalTests
    {
        public static PostStockJournalController Fixture()
        {
            PostStockJournalController controller = new PostStockJournalController(new PostStockJournalRepository(), "", new LoginView());
            return controller;
        }

        [Fact]
        [Conditional("Debug")]
        public void Execute()
        {
            var actual = Fixture().Execute(new PostStockJournalController.Annotation());
            Assert.Equal(1, actual);
        }
    }
}